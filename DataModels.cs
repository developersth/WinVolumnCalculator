using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinVolumnCalculator
{
    public class ArmData
    {
        public string ArmNo { get; set; }
        public string Name { get; set; }
    }

    /// <summary>
    /// Represents data for a Product, including its blend formula.
    /// </summary>
    public class ProductData
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int FormulaNo { get; set; }
        public List<int> Meters { get; set; } = new List<int>();
        public List<double> Ratios { get; set; } = new List<double>();
        public List<Additive> Additives { get; set; } = new List<Additive>();
    }

    /// <summary>
    /// Represents data for an additive.
    /// </summary>
    public class Additive
    {
        public string Name { get; set; }
        public double KMeasureAdditive { get; set; }
    }
}
