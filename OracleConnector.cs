using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;

namespace WinVolumnCalculator
{
    /// <summary>
    /// Handles all database interactions using Oracle.ManagedDataAccess.
    /// This class now manages its own connections for each method call.
    /// </summary>
    public class OracleConnector : IDisposable
    {
        private readonly string _connectionString;

        /// <summary>
        /// Initializes a new instance of the OracleConnector class.
        /// Reads the connection string from the application configuration file.
        /// </summary>
        public OracleConnector()
        {
            // IMPORTANT: The connection string must be defined in the App.config file.
            _connectionString = ConfigurationManager.ConnectionStrings["OracleDb"].ConnectionString;
        }

        /// <summary>
        /// Fetches a list of all arms from the database.
        /// A new connection is opened for this operation and disposed of automatically.
        /// </summary>
        /// <returns>A List of ArmData objects.</returns>
        public List<ArmData> FetchArms()
        {
            List<ArmData> arms = new List<ArmData>();
            string query = "SELECT arm_no, arm_name FROM METER_ARM WHERE arm_no > 100 ORDER BY arm_no ASC";

            try
            {
                // Using statement ensures the connection is closed and disposed of.
                using (OracleConnection connection = new OracleConnection(_connectionString))
                {
                    connection.Open();
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        using (OracleDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                arms.Add(new ArmData
                                {
                                    ArmNo = reader.GetString(0),
                                    Name = reader.IsDBNull(1) ? "N/A" : reader.GetString(1)
                                });
                            }
                        }
                    }
                }
            }
            catch (OracleException ex)
            {
                throw new ApplicationException($"Error fetching arms from database: {ex.Message}", ex);
            }

            return arms;
        }

        /// <summary>
        /// Fetches products associated with a specific arm from the database.
        /// A new connection is opened for this operation and disposed of automatically.
        /// </summary>
        /// <param name="armNo">The arm number to filter products by.</param>
        /// <returns>A List of ProductData objects.</returns>
        public List<ProductData> FetchProductsByArm(int armNo)
        {
            Dictionary<string, ProductData> products = new Dictionary<string, ProductData>();

            // The query needs to join the product table and the formula detail table
            string query = @"
                  SELECT
                        ap.SALE_PRODUCT_ID,
                        UPPER(sp.SALE_PRODUCT_NAME) AS PRODUCT_NAME,
                        mf.FORMULA_NO,
                        mf.METER_NO,
                        mf.BLEND_PERCENT
                    FROM
                        METER_PRODUCT ap
                    JOIN
                        METER_FORMULA mf ON ap.ARM_NO = mf.ARM_NO AND ap.FORMULA_NO = mf.FORMULA_NO
                    LEFT JOIN
                        tas.sale_product sp ON ap.SALE_PRODUCT_ID = sp.SALE_PRODUCT_ID
                    WHERE
                        ap.ARM_NO = :p_arm_no
                    AND sp.sale_product_name IS NOT NULL
                    ORDER BY
                        mf.formula_no, mf.meter_no";

            try
            {
                // Using statement ensures the connection is closed and disposed of.
                using (OracleConnection connection = new OracleConnection(_connectionString))
                {
                    connection.Open();
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.Parameters.Add("p_arm_no", armNo);

                        using (OracleDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string productId = reader.GetString(0);
                                string productName = reader.GetString(1);
                                int formulaNo = reader.GetInt32(2);
                                int meterNo = reader.GetInt32(3);
                                double blendPercent = reader.GetDouble(4);

                                if (!products.ContainsKey(productId))
                                {
                                    // Fetch additives separately for each unique product
                                    var additives = FetchAdditivesByFormula(armNo, formulaNo);
                                    products[productId] = new ProductData
                                    {
                                        Id = productId,
                                        Name = productName,
                                        FormulaNo = formulaNo,
                                        Meters = new List<int>(),
                                        Ratios = new List<double>(),
                                        Additives = additives,

                                    };
                                }

                                products[productId].Meters.Add(meterNo);
                                products[productId].Ratios.Add(blendPercent / 100.0);
                            }
                        }
                    }
                }
            }
            catch (OracleException ex)
            {
                throw new ApplicationException($"Error fetching products for arm {armNo}: {ex.Message}", ex);
            }

            return products.Values.ToList();
        }

        /// <summary>
        /// Placeholder method for fetching additive data.
        /// </summary>
        /// <param name="formulaNo">The formula number to fetch additives for.</param>
        /// <returns>A list of Additive objects.</returns>
        private List<Additive> FetchAdditivesByFormula(int armNo, int formulaNo)
        {
            var additives = new List<Additive>();
            string query = @"
                SELECT
                    ADDITIVE_NAME,
                    K_MEASURE_ADDITIVE
                FROM
                    METER_ADDITIVE
                WHERE
                    ARM_NO = :armNo
                AND
                    FORMULA_NO = :formulaNo
                ORDER BY
                    ADDITIVE_NO";

            using (var conn = new OracleConnection(_connectionString))
            {
                conn.Open();
                using (var cmd = new OracleCommand(query, conn))
                {
                    cmd.Parameters.Add(new OracleParameter("armNo", armNo));
                    cmd.Parameters.Add(new OracleParameter("formulaNo", formulaNo));

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            additives.Add(new Additive
                            {
                                Name = reader.GetString(0),
                                KMeasureAdditive = reader.GetDouble(1)
                            });
                        }
                    }
                }
            }
            return additives;
        }
    

        /// <summary>
        /// The Dispose method is still here to satisfy the IDisposable interface,
        /// but it no longer needs to explicitly close a connection as 'using' blocks handle it.
        /// </summary>
        public void Dispose()
        {
            // No action needed as 'using' blocks manage connections.
        }
    }
}
