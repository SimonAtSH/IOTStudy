namespace PMS5003TReader
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CloseButton = new System.Windows.Forms.Button();
            this.OpenButton = new System.Windows.Forms.Button();
            this.BaundRateComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PortComboBox = new System.Windows.Forms.ComboBox();
            this.端口 = new System.Windows.Forms.Label();
            this.LogTextBox = new System.Windows.Forms.TextBox();
            this.PmLabel = new System.Windows.Forms.Label();
            this.GbPMLabel = new System.Windows.Forms.Label();
            this.cfpm01Label = new System.Windows.Forms.Label();
            this.cfpm25Label = new System.Windows.Forms.Label();
            this.cfpm10Label = new System.Windows.Forms.Label();
            this.PM01Label = new System.Windows.Forms.Label();
            this.PM25Label = new System.Windows.Forms.Label();
            this.PM10Label = new System.Windows.Forms.Label();
            this.Count03umLabel = new System.Windows.Forms.Label();
            this.Count05umLabel = new System.Windows.Forms.Label();
            this.Count10umLabel = new System.Windows.Forms.Label();
            this.Count25umLabel = new System.Windows.Forms.Label();
            this.TempLabel = new System.Windows.Forms.Label();
            this.HumLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.ReadTimeout = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.CloseButton);
            this.groupBox1.Controls.Add(this.OpenButton);
            this.groupBox1.Controls.Add(this.BaundRateComboBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.PortComboBox);
            this.groupBox1.Controls.Add(this.端口);
            this.groupBox1.Location = new System.Drawing.Point(12, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(679, 59);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "设置";
            // 
            // CloseButton
            // 
            this.CloseButton.Enabled = false;
            this.CloseButton.Location = new System.Drawing.Point(586, 18);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(74, 25);
            this.CloseButton.TabIndex = 11;
            this.CloseButton.Text = "关闭端口";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.ClosePortButton_Click);
            // 
            // OpenButton
            // 
            this.OpenButton.Location = new System.Drawing.Point(499, 18);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(74, 25);
            this.OpenButton.TabIndex = 4;
            this.OpenButton.Text = "打开端口";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenBbutton_Click);
            // 
            // BaundRateComboBox
            // 
            this.BaundRateComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "115200"});
            this.BaundRateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BaundRateComboBox.FormattingEnabled = true;
            this.BaundRateComboBox.Items.AddRange(new object[] {
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "115200"});
            this.BaundRateComboBox.Location = new System.Drawing.Point(291, 21);
            this.BaundRateComboBox.Name = "BaundRateComboBox";
            this.BaundRateComboBox.Size = new System.Drawing.Size(144, 21);
            this.BaundRateComboBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(244, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "波特率";
            // 
            // PortComboBox
            // 
            this.PortComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PortComboBox.FormattingEnabled = true;
            this.PortComboBox.Location = new System.Drawing.Point(44, 20);
            this.PortComboBox.Name = "PortComboBox";
            this.PortComboBox.Size = new System.Drawing.Size(120, 21);
            this.PortComboBox.TabIndex = 1;
            // 
            // 端口
            // 
            this.端口.AutoSize = true;
            this.端口.Location = new System.Drawing.Point(6, 24);
            this.端口.Name = "端口";
            this.端口.Size = new System.Drawing.Size(31, 13);
            this.端口.TabIndex = 0;
            this.端口.Text = "端口";
            // 
            // LogTextBox
            // 
            this.LogTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.LogTextBox.Location = new System.Drawing.Point(12, 252);
            this.LogTextBox.Multiline = true;
            this.LogTextBox.Name = "LogTextBox";
            this.LogTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LogTextBox.Size = new System.Drawing.Size(679, 227);
            this.LogTextBox.TabIndex = 2;
            // 
            // PmLabel
            // 
            this.PmLabel.AutoSize = true;
            this.PmLabel.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PmLabel.Location = new System.Drawing.Point(15, 81);
            this.PmLabel.Name = "PmLabel";
            this.PmLabel.Size = new System.Drawing.Size(104, 19);
            this.PmLabel.TabIndex = 6;
            this.PmLabel.Text = "美国标准：";
            // 
            // GbPMLabel
            // 
            this.GbPMLabel.AutoSize = true;
            this.GbPMLabel.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GbPMLabel.Location = new System.Drawing.Point(256, 81);
            this.GbPMLabel.Name = "GbPMLabel";
            this.GbPMLabel.Size = new System.Drawing.Size(104, 19);
            this.GbPMLabel.TabIndex = 7;
            this.GbPMLabel.Text = "中国标准：";
            // 
            // cfpm01Label
            // 
            this.cfpm01Label.AutoSize = true;
            this.cfpm01Label.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cfpm01Label.Location = new System.Drawing.Point(18, 108);
            this.cfpm01Label.Name = "cfpm01Label";
            this.cfpm01Label.Size = new System.Drawing.Size(64, 16);
            this.cfpm01Label.TabIndex = 8;
            this.cfpm01Label.Text = "PM1.0：";
            // 
            // cfpm25Label
            // 
            this.cfpm25Label.AutoSize = true;
            this.cfpm25Label.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cfpm25Label.Location = new System.Drawing.Point(18, 145);
            this.cfpm25Label.Name = "cfpm25Label";
            this.cfpm25Label.Size = new System.Drawing.Size(64, 16);
            this.cfpm25Label.TabIndex = 9;
            this.cfpm25Label.Text = "PM2.5：";
            // 
            // cfpm10Label
            // 
            this.cfpm10Label.AutoSize = true;
            this.cfpm10Label.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cfpm10Label.Location = new System.Drawing.Point(18, 182);
            this.cfpm10Label.Name = "cfpm10Label";
            this.cfpm10Label.Size = new System.Drawing.Size(64, 16);
            this.cfpm10Label.TabIndex = 10;
            this.cfpm10Label.Text = "PM 10：";
            // 
            // PM01Label
            // 
            this.PM01Label.AutoSize = true;
            this.PM01Label.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PM01Label.Location = new System.Drawing.Point(260, 108);
            this.PM01Label.Name = "PM01Label";
            this.PM01Label.Size = new System.Drawing.Size(64, 16);
            this.PM01Label.TabIndex = 11;
            this.PM01Label.Text = "PM1.0：";
            // 
            // PM25Label
            // 
            this.PM25Label.AutoSize = true;
            this.PM25Label.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PM25Label.Location = new System.Drawing.Point(260, 145);
            this.PM25Label.Name = "PM25Label";
            this.PM25Label.Size = new System.Drawing.Size(64, 16);
            this.PM25Label.TabIndex = 12;
            this.PM25Label.Text = "PM2.5：";
            // 
            // PM10Label
            // 
            this.PM10Label.AutoSize = true;
            this.PM10Label.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PM10Label.Location = new System.Drawing.Point(260, 182);
            this.PM10Label.Name = "PM10Label";
            this.PM10Label.Size = new System.Drawing.Size(64, 16);
            this.PM10Label.TabIndex = 13;
            this.PM10Label.Text = "PM 10：";
            // 
            // Count03umLabel
            // 
            this.Count03umLabel.AutoSize = true;
            this.Count03umLabel.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Count03umLabel.Location = new System.Drawing.Point(459, 108);
            this.Count03umLabel.Name = "Count03umLabel";
            this.Count03umLabel.Size = new System.Drawing.Size(112, 16);
            this.Count03umLabel.TabIndex = 15;
            this.Count03umLabel.Text = "0.3 um 计数：";
            // 
            // Count05umLabel
            // 
            this.Count05umLabel.AutoSize = true;
            this.Count05umLabel.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Count05umLabel.Location = new System.Drawing.Point(458, 145);
            this.Count05umLabel.Name = "Count05umLabel";
            this.Count05umLabel.Size = new System.Drawing.Size(112, 16);
            this.Count05umLabel.TabIndex = 17;
            this.Count05umLabel.Text = "0.5 um 计数：";
            // 
            // Count10umLabel
            // 
            this.Count10umLabel.AutoSize = true;
            this.Count10umLabel.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Count10umLabel.Location = new System.Drawing.Point(459, 182);
            this.Count10umLabel.Name = "Count10umLabel";
            this.Count10umLabel.Size = new System.Drawing.Size(112, 16);
            this.Count10umLabel.TabIndex = 18;
            this.Count10umLabel.Text = "1.0 um 计数：";
            // 
            // Count25umLabel
            // 
            this.Count25umLabel.AutoSize = true;
            this.Count25umLabel.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Count25umLabel.Location = new System.Drawing.Point(459, 219);
            this.Count25umLabel.Name = "Count25umLabel";
            this.Count25umLabel.Size = new System.Drawing.Size(112, 16);
            this.Count25umLabel.TabIndex = 19;
            this.Count25umLabel.Text = "2.5 um 计数：";
            // 
            // TempLabel
            // 
            this.TempLabel.AutoSize = true;
            this.TempLabel.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TempLabel.Location = new System.Drawing.Point(18, 219);
            this.TempLabel.Name = "TempLabel";
            this.TempLabel.Size = new System.Drawing.Size(64, 16);
            this.TempLabel.TabIndex = 20;
            this.TempLabel.Text = "温 度：";
            // 
            // HumLabel
            // 
            this.HumLabel.AutoSize = true;
            this.HumLabel.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.HumLabel.Location = new System.Drawing.Point(260, 219);
            this.HumLabel.Name = "HumLabel";
            this.HumLabel.Size = new System.Drawing.Size(64, 16);
            this.HumLabel.TabIndex = 21;
            this.HumLabel.Text = "湿 度：";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(703, 491);
            this.Controls.Add(this.HumLabel);
            this.Controls.Add(this.TempLabel);
            this.Controls.Add(this.Count25umLabel);
            this.Controls.Add(this.Count10umLabel);
            this.Controls.Add(this.Count05umLabel);
            this.Controls.Add(this.Count03umLabel);
            this.Controls.Add(this.PM10Label);
            this.Controls.Add(this.PM25Label);
            this.Controls.Add(this.PM01Label);
            this.Controls.Add(this.cfpm10Label);
            this.Controls.Add(this.cfpm25Label);
            this.Controls.Add(this.cfpm01Label);
            this.Controls.Add(this.GbPMLabel);
            this.Controls.Add(this.PmLabel);
            this.Controls.Add(this.LogTextBox);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "PM2.5检测";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label 端口;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.ComboBox BaundRateComboBox;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox PortComboBox;
        private System.Windows.Forms.TextBox LogTextBox;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label PmLabel;
        private System.Windows.Forms.Label GbPMLabel;
        private System.Windows.Forms.Label cfpm01Label;
        private System.Windows.Forms.Label cfpm25Label;
        private System.Windows.Forms.Label cfpm10Label;
        private System.Windows.Forms.Label PM01Label;
        private System.Windows.Forms.Label PM25Label;
        private System.Windows.Forms.Label PM10Label;
        private System.Windows.Forms.Label Count03umLabel;
        private System.Windows.Forms.Label Count05umLabel;
        private System.Windows.Forms.Label Count10umLabel;
        private System.Windows.Forms.Label Count25umLabel;
        private System.Windows.Forms.Label TempLabel;
        private System.Windows.Forms.Label HumLabel;
    }
}

