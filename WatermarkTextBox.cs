using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinVolumnCalculator
{
    public class WatermarkTextBox : TextBox
    {
        private string _watermarkText;
        private bool _isWatermarkActive;

        public string WatermarkText
        {
            get => _watermarkText;
            set
            {
                _watermarkText = value;
                if (string.IsNullOrEmpty(this.Text))
                {
                    ShowWatermark();
                }
            }
        }

        public WatermarkTextBox()
        {
            this.ForeColor = SystemColors.WindowText;
            this.Text = "";
            this.GotFocus += OnFocus;
            this.LostFocus += OnLostFocus;
            _isWatermarkActive = false;
        }

        private void ShowWatermark()
        {
            if (!_isWatermarkActive)
            {
                this.Text = _watermarkText;
                this.ForeColor = Color.Gray;
                _isWatermarkActive = true;
            }
        }

        private void HideWatermark()
        {
            if (_isWatermarkActive)
            {
                this.Text = "";
                this.ForeColor = SystemColors.WindowText;
                _isWatermarkActive = false;
            }
        }

        private void OnFocus(object sender, EventArgs e)
        {
            HideWatermark();
        }

        private void OnLostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.Text))
            {
                ShowWatermark();
            }
        }
    }
}
