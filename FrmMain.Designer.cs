namespace WinVolumnCalculator
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.headerPanel = new System.Windows.Forms.Panel();
            this.headerLable = new System.Windows.Forms.Label();
            this.bodyPanel = new System.Windows.Forms.Panel();
            this.labelSelectProduct = new System.Windows.Forms.Label();
            this.productComboBox = new System.Windows.Forms.ComboBox();
            this.labelSelectArm = new System.Windows.Forms.Label();
            this.armComboBox = new System.Windows.Forms.ComboBox();
            this.labelStep1 = new System.Windows.Forms.Label();
            this.footerPanel = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.lableVolume = new System.Windows.Forms.Label();
            this.volumeEntry = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.meter1VolDisplay = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.meter2VolDisplay = new System.Windows.Forms.TextBox();
            this.meter1Panel = new System.Windows.Forms.Panel();
            this.meter2Panel = new System.Windows.Forms.Panel();
            this.additivePanel = new System.Windows.Forms.Panel();
            this.meter1RatioLabel = new System.Windows.Forms.Label();
            this.meter2RatioLabel = new System.Windows.Forms.Label();
            this.additiveEntry = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.meter1Vcf30Entry = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.meter2Vcf30Entry = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCal = new System.Windows.Forms.Button();
            this.additiveLabel = new System.Windows.Forms.Label();
            this.totalRawVolDisplay = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.totalVol1Display = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.totalVol2Display = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.totalAllDisplay = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.headerPanel.SuspendLayout();
            this.bodyPanel.SuspendLayout();
            this.footerPanel.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.meter1Panel.SuspendLayout();
            this.meter2Panel.SuspendLayout();
            this.additivePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.headerPanel.Controls.Add(this.headerLable);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.ForeColor = System.Drawing.Color.White;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(935, 61);
            this.headerPanel.TabIndex = 0;
            // 
            // headerLable
            // 
            this.headerLable.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.headerLable.AutoSize = true;
            this.headerLable.Font = new System.Drawing.Font("Sarabun", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.headerLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.headerLable.Location = new System.Drawing.Point(236, 3);
            this.headerLable.Name = "headerLable";
            this.headerLable.Size = new System.Drawing.Size(471, 50);
            this.headerLable.TabIndex = 0;
            this.headerLable.Text = "⛽ โปรแกรมคำนวณปริมาตรสูตรน้ำมัน";
            // 
            // bodyPanel
            // 
            this.bodyPanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bodyPanel.Controls.Add(this.groupBox3);
            this.bodyPanel.Controls.Add(this.splitContainer1);
            this.bodyPanel.Controls.Add(this.additivePanel);
            this.bodyPanel.Controls.Add(this.groupBox2);
            this.bodyPanel.Controls.Add(this.groupBox1);
            this.bodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bodyPanel.Location = new System.Drawing.Point(0, 61);
            this.bodyPanel.Name = "bodyPanel";
            this.bodyPanel.Size = new System.Drawing.Size(935, 878);
            this.bodyPanel.TabIndex = 1;
            // 
            // labelSelectProduct
            // 
            this.labelSelectProduct.AutoSize = true;
            this.labelSelectProduct.Font = new System.Drawing.Font("Sarabun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelSelectProduct.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelSelectProduct.Location = new System.Drawing.Point(426, 81);
            this.labelSelectProduct.Name = "labelSelectProduct";
            this.labelSelectProduct.Size = new System.Drawing.Size(151, 30);
            this.labelSelectProduct.TabIndex = 4;
            this.labelSelectProduct.Text = "🧪 เลือกผลิตภัณฑ์:";
            // 
            // productComboBox
            // 
            this.productComboBox.Font = new System.Drawing.Font("Sarabun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.productComboBox.FormattingEnabled = true;
            this.productComboBox.Location = new System.Drawing.Point(584, 79);
            this.productComboBox.Name = "productComboBox";
            this.productComboBox.Size = new System.Drawing.Size(303, 38);
            this.productComboBox.TabIndex = 3;
            this.productComboBox.SelectedIndexChanged += new System.EventHandler(this.ProductComboBox_SelectedIndexChanged);
            // 
            // labelSelectArm
            // 
            this.labelSelectArm.AutoSize = true;
            this.labelSelectArm.Font = new System.Drawing.Font("Sarabun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelSelectArm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelSelectArm.Location = new System.Drawing.Point(12, 81);
            this.labelSelectArm.Name = "labelSelectArm";
            this.labelSelectArm.Size = new System.Drawing.Size(152, 30);
            this.labelSelectArm.TabIndex = 2;
            this.labelSelectArm.Text = "🔧 เลือก Arm No. :";
            // 
            // armComboBox
            // 
            this.armComboBox.Font = new System.Drawing.Font("Sarabun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.armComboBox.FormattingEnabled = true;
            this.armComboBox.Location = new System.Drawing.Point(170, 79);
            this.armComboBox.Name = "armComboBox";
            this.armComboBox.Size = new System.Drawing.Size(238, 38);
            this.armComboBox.TabIndex = 1;
            this.armComboBox.SelectedIndexChanged += new System.EventHandler(this.ArmComboBox_SelectedIndexChanged);
            // 
            // labelStep1
            // 
            this.labelStep1.AutoSize = true;
            this.labelStep1.Font = new System.Drawing.Font("Sarabun", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelStep1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelStep1.Location = new System.Drawing.Point(253, 16);
            this.labelStep1.Name = "labelStep1";
            this.labelStep1.Size = new System.Drawing.Size(387, 39);
            this.labelStep1.TabIndex = 0;
            this.labelStep1.Text = "📋 ขั้นตอนที่ 1: เลือก Arm และผลิตภัณฑ์";
            // 
            // footerPanel
            // 
            this.footerPanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.footerPanel.Controls.Add(this.toolStrip1);
            this.footerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footerPanel.Location = new System.Drawing.Point(0, 903);
            this.footerPanel.Name = "footerPanel";
            this.footerPanel.Size = new System.Drawing.Size(935, 36);
            this.footerPanel.TabIndex = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 11);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(935, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(86, 22);
            this.toolStripLabel1.Text = "toolStripLabel1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sarabun", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(253, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "📋 ขั้นตอนที่ 2 : ป้อนปริมาณที่ต้องการเติม";
            // 
            // lableVolume
            // 
            this.lableVolume.AutoSize = true;
            this.lableVolume.Font = new System.Drawing.Font("Sarabun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lableVolume.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lableVolume.Location = new System.Drawing.Point(202, 68);
            this.lableVolume.Name = "lableVolume";
            this.lableVolume.Size = new System.Drawing.Size(145, 30);
            this.lableVolume.TabIndex = 7;
            this.lableVolume.Text = "📊  ป้อนปริมาณ. :";
            // 
            // volumeEntry
            // 
            this.volumeEntry.Font = new System.Drawing.Font("Sarabun", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.volumeEntry.Location = new System.Drawing.Point(361, 68);
            this.volumeEntry.Name = "volumeEntry";
            this.volumeEntry.Size = new System.Drawing.Size(201, 35);
            this.volumeEntry.TabIndex = 8;
            this.volumeEntry.TextChanged += new System.EventHandler(this.VolumeEntry_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelStep1);
            this.groupBox1.Controls.Add(this.armComboBox);
            this.groupBox1.Controls.Add(this.labelSelectArm);
            this.groupBox1.Controls.Add(this.productComboBox);
            this.groupBox1.Controls.Add(this.labelSelectProduct);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(935, 132);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lableVolume);
            this.groupBox2.Controls.Add(this.volumeEntry);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 132);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(935, 132);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // meter1VolDisplay
            // 
            this.meter1VolDisplay.Font = new System.Drawing.Font("Sarabun", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.meter1VolDisplay.Location = new System.Drawing.Point(167, 21);
            this.meter1VolDisplay.Name = "meter1VolDisplay";
            this.meter1VolDisplay.Size = new System.Drawing.Size(238, 35);
            this.meter1VolDisplay.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sarabun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(64, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 30);
            this.label3.TabIndex = 10;
            this.label3.Text = "Meter 1. :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sarabun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(26, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 30);
            this.label4.TabIndex = 11;
            this.label4.Text = "Meter 2. :";
            // 
            // meter2VolDisplay
            // 
            this.meter2VolDisplay.Font = new System.Drawing.Font("Sarabun", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.meter2VolDisplay.Location = new System.Drawing.Point(117, 22);
            this.meter2VolDisplay.Name = "meter2VolDisplay";
            this.meter2VolDisplay.Size = new System.Drawing.Size(303, 35);
            this.meter2VolDisplay.TabIndex = 12;
            // 
            // meter1Panel
            // 
            this.meter1Panel.BackColor = System.Drawing.Color.ForestGreen;
            this.meter1Panel.Controls.Add(this.meter1Vcf30Entry);
            this.meter1Panel.Controls.Add(this.label5);
            this.meter1Panel.Controls.Add(this.meter1RatioLabel);
            this.meter1Panel.Controls.Add(this.meter1VolDisplay);
            this.meter1Panel.Controls.Add(this.label3);
            this.meter1Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.meter1Panel.Location = new System.Drawing.Point(0, 0);
            this.meter1Panel.Name = "meter1Panel";
            this.meter1Panel.Size = new System.Drawing.Size(460, 183);
            this.meter1Panel.TabIndex = 13;
            // 
            // meter2Panel
            // 
            this.meter2Panel.BackColor = System.Drawing.Color.Orange;
            this.meter2Panel.Controls.Add(this.meter2Vcf30Entry);
            this.meter2Panel.Controls.Add(this.label6);
            this.meter2Panel.Controls.Add(this.meter2RatioLabel);
            this.meter2Panel.Controls.Add(this.meter2VolDisplay);
            this.meter2Panel.Controls.Add(this.label4);
            this.meter2Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.meter2Panel.Location = new System.Drawing.Point(0, 0);
            this.meter2Panel.Name = "meter2Panel";
            this.meter2Panel.Size = new System.Drawing.Size(471, 183);
            this.meter2Panel.TabIndex = 14;
            // 
            // additivePanel
            // 
            this.additivePanel.BackColor = System.Drawing.Color.Blue;
            this.additivePanel.Controls.Add(this.additiveLabel);
            this.additivePanel.Controls.Add(this.label2);
            this.additivePanel.Controls.Add(this.additiveEntry);
            this.additivePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.additivePanel.Location = new System.Drawing.Point(0, 264);
            this.additivePanel.Name = "additivePanel";
            this.additivePanel.Size = new System.Drawing.Size(935, 60);
            this.additivePanel.TabIndex = 15;
            // 
            // meter1RatioLabel
            // 
            this.meter1RatioLabel.AutoSize = true;
            this.meter1RatioLabel.Font = new System.Drawing.Font("Sarabun", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.meter1RatioLabel.ForeColor = System.Drawing.Color.White;
            this.meter1RatioLabel.Location = new System.Drawing.Point(165, 64);
            this.meter1RatioLabel.Name = "meter1RatioLabel";
            this.meter1RatioLabel.Size = new System.Drawing.Size(96, 20);
            this.meter1RatioLabel.TabIndex = 11;
            this.meter1RatioLabel.Text = "meter1RatioLabel";
            // 
            // meter2RatioLabel
            // 
            this.meter2RatioLabel.AutoSize = true;
            this.meter2RatioLabel.Font = new System.Drawing.Font("Sarabun", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.meter2RatioLabel.ForeColor = System.Drawing.Color.White;
            this.meter2RatioLabel.Location = new System.Drawing.Point(113, 65);
            this.meter2RatioLabel.Name = "meter2RatioLabel";
            this.meter2RatioLabel.Size = new System.Drawing.Size(39, 20);
            this.meter2RatioLabel.TabIndex = 13;
            this.meter2RatioLabel.Text = "label2";
            // 
            // additiveEntry
            // 
            this.additiveEntry.Font = new System.Drawing.Font("Sarabun", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.additiveEntry.Location = new System.Drawing.Point(167, 11);
            this.additiveEntry.Name = "additiveEntry";
            this.additiveEntry.Size = new System.Drawing.Size(238, 35);
            this.additiveEntry.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sarabun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(50, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 30);
            this.label2.TabIndex = 12;
            this.label2.Text = "Additive. :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sarabun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(64, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 30);
            this.label5.TabIndex = 12;
            this.label5.Text = "VCF30. :";
            // 
            // meter1Vcf30Entry
            // 
            this.meter1Vcf30Entry.Font = new System.Drawing.Font("Sarabun", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.meter1Vcf30Entry.Location = new System.Drawing.Point(167, 98);
            this.meter1Vcf30Entry.Name = "meter1Vcf30Entry";
            this.meter1Vcf30Entry.Size = new System.Drawing.Size(238, 35);
            this.meter1Vcf30Entry.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sarabun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(37, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 30);
            this.label6.TabIndex = 14;
            this.label6.Text = "VCF30. :";
            // 
            // meter2Vcf30Entry
            // 
            this.meter2Vcf30Entry.Font = new System.Drawing.Font("Sarabun", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.meter2Vcf30Entry.Location = new System.Drawing.Point(117, 93);
            this.meter2Vcf30Entry.Name = "meter2Vcf30Entry";
            this.meter2Vcf30Entry.Size = new System.Drawing.Size(303, 35);
            this.meter2Vcf30Entry.TabIndex = 15;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainer1.Location = new System.Drawing.Point(0, 324);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.meter1Panel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.meter2Panel);
            this.splitContainer1.Size = new System.Drawing.Size(935, 183);
            this.splitContainer1.SplitterDistance = 460;
            this.splitContainer1.TabIndex = 16;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.totalAllDisplay);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.totalVol2Display);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.totalVol1Display);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.totalRawVolDisplay);
            this.groupBox3.Controls.Add(this.btnCal);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 507);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(935, 371);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            // 
            // btnCal
            // 
            this.btnCal.BackColor = System.Drawing.Color.Teal;
            this.btnCal.Font = new System.Drawing.Font("Sarabun", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnCal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCal.Location = new System.Drawing.Point(361, 29);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(201, 41);
            this.btnCal.TabIndex = 10;
            this.btnCal.Text = "คำนวณ";
            this.btnCal.UseVisualStyleBackColor = false;
            this.btnCal.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // additiveLabel
            // 
            this.additiveLabel.AutoSize = true;
            this.additiveLabel.Font = new System.Drawing.Font("Sarabun", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.additiveLabel.ForeColor = System.Drawing.Color.White;
            this.additiveLabel.Location = new System.Drawing.Point(421, 19);
            this.additiveLabel.Name = "additiveLabel";
            this.additiveLabel.Size = new System.Drawing.Size(75, 20);
            this.additiveLabel.TabIndex = 13;
            this.additiveLabel.Text = "additiveLabel";
            // 
            // totalRawVolDisplay
            // 
            this.totalRawVolDisplay.BackColor = System.Drawing.Color.Silver;
            this.totalRawVolDisplay.Font = new System.Drawing.Font("Sarabun", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.totalRawVolDisplay.Location = new System.Drawing.Point(347, 131);
            this.totalRawVolDisplay.Name = "totalRawVolDisplay";
            this.totalRawVolDisplay.Size = new System.Drawing.Size(537, 35);
            this.totalRawVolDisplay.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sarabun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(50, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(275, 30);
            this.label7.TabIndex = 15;
            this.label7.Text = "ปริมาณจากมิเตอร์ (ที่ยังไม่ได้ปรับแก้). :";
            // 
            // totalVol1Display
            // 
            this.totalVol1Display.BackColor = System.Drawing.Color.Turquoise;
            this.totalVol1Display.Font = new System.Drawing.Font("Sarabun", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.totalVol1Display.Location = new System.Drawing.Point(167, 185);
            this.totalVol1Display.Name = "totalVol1Display";
            this.totalVol1Display.Size = new System.Drawing.Size(238, 35);
            this.totalVol1Display.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Sarabun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(64, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 30);
            this.label8.TabIndex = 17;
            this.label8.Text = "Meter 1. :";
            // 
            // totalVol2Display
            // 
            this.totalVol2Display.BackColor = System.Drawing.Color.MediumTurquoise;
            this.totalVol2Display.Font = new System.Drawing.Font("Sarabun", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.totalVol2Display.Location = new System.Drawing.Point(584, 185);
            this.totalVol2Display.Name = "totalVol2Display";
            this.totalVol2Display.Size = new System.Drawing.Size(300, 35);
            this.totalVol2Display.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Sarabun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(478, 190);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 30);
            this.label9.TabIndex = 19;
            this.label9.Text = "Meter 2. :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Sarabun", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(363, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(186, 39);
            this.label10.TabIndex = 20;
            this.label10.Text = "📈 ผลการคำนวณ";
            // 
            // totalAllDisplay
            // 
            this.totalAllDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.totalAllDisplay.Font = new System.Drawing.Font("Sarabun", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.totalAllDisplay.Location = new System.Drawing.Point(347, 247);
            this.totalAllDisplay.Name = "totalAllDisplay";
            this.totalAllDisplay.Size = new System.Drawing.Size(540, 35);
            this.totalAllDisplay.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Sarabun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(101, 250);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(224, 30);
            this.label11.TabIndex = 22;
            this.label11.Text = "🏆 รวมปริมาตรสุดท้ายทั้งหมด";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 939);
            this.Controls.Add(this.footerPanel);
            this.Controls.Add(this.bodyPanel);
            this.Controls.Add(this.headerPanel);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.bodyPanel.ResumeLayout(false);
            this.footerPanel.ResumeLayout(false);
            this.footerPanel.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.meter1Panel.ResumeLayout(false);
            this.meter1Panel.PerformLayout();
            this.meter2Panel.ResumeLayout(false);
            this.meter2Panel.PerformLayout();
            this.additivePanel.ResumeLayout(false);
            this.additivePanel.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label headerLable;
        private System.Windows.Forms.Panel bodyPanel;
        private System.Windows.Forms.Panel footerPanel;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Label labelStep1;
        private System.Windows.Forms.Label labelSelectArm;
        private System.Windows.Forms.ComboBox armComboBox;
        private System.Windows.Forms.Label labelSelectProduct;
        private System.Windows.Forms.ComboBox productComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox volumeEntry;
        private System.Windows.Forms.Label lableVolume;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox meter1VolDisplay;
        private System.Windows.Forms.TextBox meter2VolDisplay;
        private System.Windows.Forms.Panel meter2Panel;
        private System.Windows.Forms.Panel meter1Panel;
        private System.Windows.Forms.Panel additivePanel;
        private System.Windows.Forms.Label meter2RatioLabel;
        private System.Windows.Forms.Label meter1RatioLabel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox meter1Vcf30Entry;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox meter2Vcf30Entry;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox additiveEntry;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.Label additiveLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox totalAllDisplay;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox totalVol2Display;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox totalVol1Display;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox totalRawVolDisplay;
    }
}