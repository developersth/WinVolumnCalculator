using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinVolumnCalculator
{
    public partial class LoadingDialog : Form
    {
        public LoadingDialog()
        {
            InitializeComponent();
        }

        public void UpdateStatus(string message, double progress, string error = null)
        {
            // Use Invoke to ensure UI updates are on the main thread.
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => UpdateStatus(message, progress, error)));
                return;
            }

            statusLabel.Text = message;
            progressBar.Value = (int)(progress * 100);

            if (!string.IsNullOrEmpty(error))
            {
                errorLabel.Text = $"ข้อผิดพลาด: {error}";
                errorLabel.Visible = true;
            }
            else
            {
                errorLabel.Visible = false;
            }
        }
    }
}
