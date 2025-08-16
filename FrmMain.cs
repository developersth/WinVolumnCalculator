using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinVolumnCalculator
{
    public partial class FrmMain : Form
    {
        private OracleConnector _oracleConnector;
        // Data fields
        private List<ArmData> _armData = new List<ArmData>();
        private List<ProductData> _productsForArm = new List<ProductData>();
        private PrivateFontCollection privateFonts = new PrivateFontCollection();
        private Dictionary<string, Font> customFonts = new Dictionary<string, Font>();
        public FrmMain()
        {
            InitializeComponent();
            LoadCustomFonts();
            ApplyCustomFonts();
        }

        private async void FrmMain_Load(object sender, EventArgs e)
        {
            _oracleConnector = new OracleConnector();
            LoadingDialog loadingDialog = new LoadingDialog();
            try
            {
                loadingDialog.Show(this);
                loadingDialog.UpdateStatus("กำลังเชื่อมต่อฐานข้อมูล...", 0.1);
                _armData = await Task.Run(() => _oracleConnector.FetchArms());
                loadingDialog.UpdateStatus("เชื่อมต่อสำเร็จ!", 1.0);
                toolStripLabel1.Text = "Database connection success";
            }
            catch (Exception ex)
            {
                loadingDialog.UpdateStatus("เกิดข้อผิดพลาด!", 0.0, ex.Message);
                MessageBox.Show($"ข้อผิดพลาดในการเชื่อมต่อ:\n{ex.Message}", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                toolStripLabel1.Text = "Database connection failed";
                _armData = new List<ArmData>();
            }
            finally
            {
                loadingDialog.Close();
                UpdateArmComboBox();
            }
        }

        private void UpdateArmComboBox()
        {
            var armValues = new List<string> { "---เลือก Arm---" };
            if (_armData.Any())
            {
                armValues.AddRange(_armData.Select(a => $"{a.ArmNo} ({a.Name})"));
            }
            else
            {
                armValues.Add("---ไม่พบข้อมูล Arm---");
            }
            armComboBox.DataSource = armValues;
            armComboBox.SelectedIndex = 0;
        }
        private async void ArmComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var choice = armComboBox.SelectedItem as string;
            // Prevent execution if a placeholder or no item is selected
            if (string.IsNullOrEmpty(choice) || choice.StartsWith("---") || _oracleConnector == null)
            {
                productComboBox.DataSource = new List<string> { "---เลือกผลิตภัณฑ์---" };
                OnProductSelect(null); // Pass null to reset everything
                return;
            }

            LoadingDialog loadingDialog = new LoadingDialog();

            try
            {
                loadingDialog.Show(this);
                loadingDialog.UpdateStatus("กำลังดึงข้อมูลผลิตภัณฑ์...", 0.1);

                var armNo = int.Parse(choice.Split(' ')[0]);

                // Fetch product data on a background thread to prevent the UI from freezing.
                _productsForArm = await Task.Run(() =>
                {
                    return _oracleConnector.FetchProductsByArm(armNo);
                });

                loadingDialog.UpdateStatus("เสร็จสิ้น!", 1.0);
                loadingDialog.Close();

                var productNames = new List<string> { "---เลือกผลิตภัณฑ์---" };
                if (_productsForArm.Any())
                {
                    productNames.AddRange(_productsForArm.Select(p => $"{p.Id} ({p.Name}) [สูตร {p.FormulaNo}]"));
                }
                else
                {
                    productNames.Add("---ไม่พบผลิตภัณฑ์---");
                }

                productComboBox.DataSource = productNames;
                productComboBox.SelectedIndex = 0;
                OnProductSelect(productNames[0]);
            }
            catch (Exception ex)
            {
                loadingDialog.UpdateStatus("เกิดข้อผิดพลาด!", 0, ex.Message);
                MessageBox.Show($"เกิดข้อผิดพลาดในการดึงข้อมูลผลิตภัณฑ์:\n{ex.Message}", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                loadingDialog.Close();
            }
        }
        private void ProductComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var choice = productComboBox.SelectedItem as string;
            if (string.IsNullOrEmpty(choice) || choice.StartsWith("---"))
            {
                OnProductSelect(null); // Pass null to reset everything
                return;
            }
            OnProductSelect(choice);
        }

        private void OnProductSelect(string choice)
        {
            // Reset all displays and hide panels
            meter1Panel.Visible = false;
            meter2Panel.Visible = false;
            additivePanel.Visible = false;
            ClearDisplays();

            if (choice == null || choice.StartsWith("---"))
            {
                return;
            }

            try
            {
                var productId = choice.Split(' ')[0];
                var config = GetProductConfig(productId);

                if (config == null) return;

                var meters = config.Meters;
                var ratios = config.Ratios;

                if (meters.Contains(1))
                {
                  meter1Panel.Visible = true;
                    var ratio = ratios[meters.IndexOf(1)] * 100;
                   meter1RatioLabel.Text = $"📊 สัดส่วนการผสม: {ratio:F2}%";
                }

                if (meters.Contains(2))
                {
                    meter2Panel.Visible = true;
                    var ratio = ratios[meters.IndexOf(2)] * 100;
                   meter2RatioLabel.Text = $"📊 สัดส่วนการผสม: {ratio:F2}%";
                }

                if (config.Additives != null && config.Additives.Any())
                {
                    additivePanel.Visible = true;
                    var additive = config.Additives.First();
                    additiveLabel.Text = $"🧪 Additive: {additive.Name} ({additive.KMeasureAdditive} ppm)";
                    //additiveEntry.WatermarkText = "ค่า Additive (อัตโนมัติ)";
                }

               // UpdateMeterVolumes();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"เกิดข้อผิดพลาดในการเลือกผลิตภัณฑ์:\n{ex.Message}", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void VolumeEntry_TextChanged(object sender, EventArgs e)
        {
            UpdateMeterVolumes();
        }

        /// <summary>
        /// Performs the calculation for meter volumes and additive based on the input volume.
        /// </summary>
        private void UpdateMeterVolumes()
        {
            try
            {
                // Clean the input string by removing thousand separators and check if it's a valid number.
                var totalVolInput = volumeEntry.Text.Replace(",", "");
                if (!double.TryParse(totalVolInput, out double totalVol))
                {
                    // If not a valid number, or if the input is empty, clear the displays.
                    // This handles the watermark text and invalid characters gracefully.
                    ClearDisplays();
                    return;
                }

                var productChoice = productComboBox.SelectedItem as string;
                if (string.IsNullOrEmpty(productChoice) || productChoice.StartsWith("---"))
                {
                    return;
                }
                var productId = productChoice.Split(' ')[0];
                var config = GetProductConfig(productId);
                if (config == null) return;

                // Calculate additive volume if applicable
                double additiveVol = 0;
                if (config.Additives != null && config.Additives.Any())
                {
                    var additive = config.Additives.First();
                    var kAdd = additive.KMeasureAdditive;
                    additiveVol = totalVol * kAdd / 1_000_000;
                    additiveEntry.Text = $"{additiveVol:F4}";
                }

                // Calculate total volume to be split between meters
                double totalVolWithAdditive = totalVol ;

                // Calculate and display meter 1 volume
                if (config.Meters.Contains(1))
                {
                    var ratio = config.Ratios[config.Meters.IndexOf(1)];
                    var volMeasured = totalVol * ratio;
                    meter1VolDisplay.Text = $"{volMeasured:N2}";
                }
                else
                {
                    meter1VolDisplay.Text = string.Empty;
                }

                // Calculate and display meter 2 volume
                if (config.Meters.Contains(2))
                {
                    var ratio = config.Ratios[config.Meters.IndexOf(2)];
                    var volMeasured = totalVol * ratio;
                    volMeasured = Math.Round(volMeasured, 2); // Ensure two decimal places for the display
                    meter2VolDisplay.Text = $"{volMeasured:N2}";
                }
                else
                {
                    meter2VolDisplay.Text = string.Empty;
                }

                // Clear final results to prompt recalculation
                totalRawVolDisplay.Text = string.Empty;
                totalVol1Display.Text = string.Empty;
                totalVol2Display.Text = string.Empty;
                totalAllDisplay.Text = string.Empty;
            }
            catch (Exception ex)
            {
                // In case of an error during live update, show a message box.
                MessageBox.Show($"เกิดข้อผิดพลาดในการอัปเดตปริมาตร:\n{ex.Message}", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                // --- Validation Checks ---
                var productChoice = productComboBox.SelectedItem as string;
                if (productChoice == null || productChoice.StartsWith("---"))
                {
                    MessageBox.Show("❌ กรุณาเลือกผลิตภัณฑ์ก่อน", "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var totalVolInput = volumeEntry.Text.Replace(",", "");
                if (!double.TryParse(totalVolInput, out double totalVol))
                {
                    MessageBox.Show("❌ กรุณาป้อนปริมาตรรวมเป็นตัวเลขที่ถูกต้อง", "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Get measured volumes from display fields (they were calculated in UpdateMeterVolumes)
                var vol1MeasuredStr = meter1VolDisplay.Text.Replace(",", "");
                var vol2MeasuredStr = meter2VolDisplay.Text.Replace(",", "");

                double vol1Measured = 0;
                double vol2Measured = 0;

                // Parse measured volumes only if the meters are visible
                if (meter1Panel.Visible && !double.TryParse(vol1MeasuredStr, out vol1Measured))
                {
                    MessageBox.Show("❌ ปริมาตร Meter 1 ไม่ถูกต้อง", "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (meter2Panel.Visible && !double.TryParse(vol2MeasuredStr, out vol2Measured))
                {
                    MessageBox.Show("❌ ปริมาตร Meter 2 ไม่ถูกต้อง", "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // --- VCF30 Validation and Parsing ---
                double vcf1 = 1.0;
                if (meter1Panel.Visible)
                {
                    if (string.IsNullOrEmpty(meter1Vcf30Entry.Text))
                    {
                        MessageBox.Show("❌ กรุณาป้อนค่า VCF30 สำหรับ Meter 1", "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (!double.TryParse(meter1Vcf30Entry.Text, out vcf1))
                    {
                        MessageBox.Show("❌ ค่า VCF30 สำหรับ Meter 1 ไม่ถูกต้อง", "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                double vcf2 = 1.0;
                if (meter2Panel.Visible)
                {
                    if (string.IsNullOrEmpty(meter2Vcf30Entry.Text))
                    {
                        MessageBox.Show("❌ กรุณาป้อนค่า VCF30 สำหรับ Meter 2", "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (!double.TryParse(meter2Vcf30Entry.Text, out vcf2))
                    {
                        MessageBox.Show("❌ ค่า VCF30 สำหรับ Meter 2 ไม่ถูกต้อง", "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // --- Calculations and Display ---
                // Total raw volume (sum of measured volumes)
                double totalRawVol = vol1Measured + vol2Measured;
                totalRawVolDisplay.Text = $"{totalRawVol:N2} ลิตร";

                // Final volumes after VCF correction
                double vol1Final = vol1Measured * vcf1;
                double vol2Final = vol2Measured * vcf2;
                totalVol1Display.Text = $"{vol1Final:N2} ลิตร";
                totalVol2Display.Text = $"{vol2Final:N2} ลิตร";

                // Total final volume
                double totalFinalVol = vol1Final + vol2Final;
                totalAllDisplay.Text = $"{totalFinalVol:N2} ลิตร";

                MessageBox.Show("✅ คำนวณเสร็จสิ้น!", "สำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ เกิดข้อผิดพลาดในการคำนวณ:\n{ex.Message}", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearDisplays()
        {
            totalRawVolDisplay.Text = string.Empty;
            totalVol1Display.Text = string.Empty;
            totalVol2Display.Text = string.Empty;
            totalAllDisplay.Text = string.Empty;
            meter1VolDisplay.Text = string.Empty;
            meter2VolDisplay.Text = string.Empty;
            additiveEntry.Text = string.Empty;
            meter1Vcf30Entry.Text = string.Empty;
            meter2Vcf30Entry.Text = string.Empty;

            // Don't clear ratio labels, they are tied to the selected product
        }

        private ProductData GetProductConfig(string productId)
        {
            return _productsForArm.FirstOrDefault(p => p.Id == productId);
        }
        private void LoadCustomFonts()
        {
            try
            {
                // List of font file names to load
                string[] fontFiles = new string[]
                {
                "Sarabun-Regular.ttf",
                "Sarabun-Bold.ttf",
                "Sarabun-Italic.ttf",
                "Sarabun-BoldItalic.ttf"
                    // Add any other font files you want to use here
                };

                foreach (string fontFile in fontFiles)
                {
                    string fontPath = System.IO.Path.Combine(Application.StartupPath,"fonts", fontFile);
                    if (System.IO.File.Exists(fontPath))
                    {
                        privateFonts.AddFontFile(fontPath);
                    }
                    else
                    {
                        // You can log an error or show a message if a font file is not found
                        Console.WriteLine($"Font file not found: {fontPath}");
                    }
                }

                // Store the loaded fonts in a dictionary for easy access
                foreach (FontFamily family in privateFonts.Families)
                {
                    // You can add different styles of the same font family here as needed
                    customFonts[family.Name + "-Regular"] = new Font(family, 12, FontStyle.Regular);
                    customFonts[family.Name + "-Bold"] = new Font(family, 12, FontStyle.Bold);
                    customFonts[family.Name + "-Italic"] = new Font(family, 12, FontStyle.Italic);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading custom fonts: {ex.Message}");
            }
        }

        /// <summary>
        /// Applies the loaded custom fonts to the application's controls.
        /// </summary>
        private void ApplyCustomFonts()
        {
            // Example of applying a specific font to a control.
            // You need to replace "myLabel" with the actual name of your control.
            if (customFonts.ContainsKey("Sarabun-Regular") && this.Controls.ContainsKey("myLabel"))
            {
                this.Controls["myLabel"].Font = customFonts["Sarabun-Regular"];
            }

            if (customFonts.ContainsKey("Sarabun-Bold") && this.Controls.ContainsKey("myButton"))
            {
                this.Controls["myButton"].Font = customFonts["Sarabun-Bold"];
            }

            // You can also iterate through all controls and apply the font
            // ApplyFontToControls(this.Controls);
        }

        // Recursive method to apply the font to all controls on the form
        private void ApplyFontToControls(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (customFonts.ContainsKey("Sarabun-Regular"))
                {
                    control.Font = customFonts["Sarabun-Regular"];
                }
                // If the control has child controls, call the method recursively
                if (control.Controls.Count > 0)
                {
                    ApplyFontToControls(control.Controls);
                }
            }
        }
    }
}
