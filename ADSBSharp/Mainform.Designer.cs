namespace ADSBSharp
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.deviceComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tunerGainTrackBar = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.tunerAgcCheckBox = new System.Windows.Forms.CheckBox();
            this.gainLabel = new System.Windows.Forms.Label();
            this.frequencyCorrectionNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.tunerTypeLabel = new System.Windows.Forms.Label();
            this.rtlAgcCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.startBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.timeoutNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.confidenceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.framesPerSecLbl = new System.Windows.Forms.Label();
            this.fpsLabel = new System.Windows.Forms.Label();
            this.fpsTimer = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mainFormBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tunerGainTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequencyCorrectionNumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeoutNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.confidenceNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainFormBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // deviceComboBox
            // 
            this.deviceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deviceComboBox.FormattingEnabled = true;
            this.deviceComboBox.Location = new System.Drawing.Point(15, 33);
            this.deviceComboBox.Name = "deviceComboBox";
            this.deviceComboBox.Size = new System.Drawing.Size(240, 21);
            this.deviceComboBox.TabIndex = 0;
            this.deviceComboBox.SelectedIndexChanged += new System.EventHandler(this.deviceComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Device";
            // 
            // tunerGainTrackBar
            // 
            this.tunerGainTrackBar.Enabled = false;
            this.tunerGainTrackBar.Location = new System.Drawing.Point(6, 119);
            this.tunerGainTrackBar.Maximum = 10000;
            this.tunerGainTrackBar.Name = "tunerGainTrackBar";
            this.tunerGainTrackBar.Size = new System.Drawing.Size(258, 45);
            this.tunerGainTrackBar.TabIndex = 3;
            this.tunerGainTrackBar.Scroll += new System.EventHandler(this.tunerGainTrackBar_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "RF Gain";
            // 
            // tunerAgcCheckBox
            // 
            this.tunerAgcCheckBox.AutoSize = true;
            this.tunerAgcCheckBox.Checked = true;
            this.tunerAgcCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tunerAgcCheckBox.Location = new System.Drawing.Point(15, 83);
            this.tunerAgcCheckBox.Name = "tunerAgcCheckBox";
            this.tunerAgcCheckBox.Size = new System.Drawing.Size(79, 17);
            this.tunerAgcCheckBox.TabIndex = 2;
            this.tunerAgcCheckBox.Text = "Tuner AGC";
            this.tunerAgcCheckBox.UseVisualStyleBackColor = true;
            this.tunerAgcCheckBox.CheckedChanged += new System.EventHandler(this.tunerAgcCheckBox_CheckedChanged);
            // 
            // gainLabel
            // 
            this.gainLabel.Location = new System.Drawing.Point(194, 103);
            this.gainLabel.Name = "gainLabel";
            this.gainLabel.Size = new System.Drawing.Size(68, 13);
            this.gainLabel.TabIndex = 26;
            this.gainLabel.Text = "1000dB";
            this.gainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.gainLabel.Visible = false;
            // 
            // frequencyCorrectionNumericUpDown
            // 
            this.frequencyCorrectionNumericUpDown.Location = new System.Drawing.Point(172, 169);
            this.frequencyCorrectionNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.frequencyCorrectionNumericUpDown.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.frequencyCorrectionNumericUpDown.Name = "frequencyCorrectionNumericUpDown";
            this.frequencyCorrectionNumericUpDown.Size = new System.Drawing.Size(83, 20);
            this.frequencyCorrectionNumericUpDown.TabIndex = 4;
            this.frequencyCorrectionNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.frequencyCorrectionNumericUpDown.ValueChanged += new System.EventHandler(this.frequencyCorrectionNumericUpDown_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Frequency correction (ppm)";
            // 
            // tunerTypeLabel
            // 
            this.tunerTypeLabel.Location = new System.Drawing.Point(169, 16);
            this.tunerTypeLabel.Name = "tunerTypeLabel";
            this.tunerTypeLabel.Size = new System.Drawing.Size(93, 13);
            this.tunerTypeLabel.TabIndex = 29;
            this.tunerTypeLabel.Text = "E4000";
            this.tunerTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rtlAgcCheckBox
            // 
            this.rtlAgcCheckBox.AutoSize = true;
            this.rtlAgcCheckBox.Location = new System.Drawing.Point(15, 60);
            this.rtlAgcCheckBox.Name = "rtlAgcCheckBox";
            this.rtlAgcCheckBox.Size = new System.Drawing.Size(72, 17);
            this.rtlAgcCheckBox.TabIndex = 1;
            this.rtlAgcCheckBox.Text = "RTL AGC";
            this.rtlAgcCheckBox.UseVisualStyleBackColor = true;
            this.rtlAgcCheckBox.CheckedChanged += new System.EventHandler(this.rtlAgcCheckBox_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rtlAgcCheckBox);
            this.groupBox1.Controls.Add(this.deviceComboBox);
            this.groupBox1.Controls.Add(this.tunerTypeLabel);
            this.groupBox1.Controls.Add(this.tunerGainTrackBar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.frequencyCorrectionNumericUpDown);
            this.groupBox1.Controls.Add(this.tunerAgcCheckBox);
            this.groupBox1.Controls.Add(this.gainLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 202);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RTL-SDR Control";
            // 
            // startBtn
            // 
            this.startBtn.Enabled = false;
            this.startBtn.Location = new System.Drawing.Point(209, 23);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(75, 23);
            this.startBtn.TabIndex = 0;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.timeoutNumericUpDown);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.confidenceNumericUpDown);
            this.groupBox2.Controls.Add(this.framesPerSecLbl);
            this.groupBox2.Controls.Add(this.fpsLabel);
            this.groupBox2.Location = new System.Drawing.Point(12, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(270, 69);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Decoder";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(104, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "Timeout (sec)";
            // 
            // timeoutNumericUpDown
            // 
            this.timeoutNumericUpDown.Location = new System.Drawing.Point(104, 34);
            this.timeoutNumericUpDown.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.timeoutNumericUpDown.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.timeoutNumericUpDown.Name = "timeoutNumericUpDown";
            this.timeoutNumericUpDown.Size = new System.Drawing.Size(71, 20);
            this.timeoutNumericUpDown.TabIndex = 40;
            this.timeoutNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.timeoutNumericUpDown.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.timeoutNumericUpDown.ValueChanged += new System.EventHandler(this.timeoutNumericUpDown_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Confidence";
            // 
            // confidenceNumericUpDown
            // 
            this.confidenceNumericUpDown.Location = new System.Drawing.Point(15, 34);
            this.confidenceNumericUpDown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.confidenceNumericUpDown.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.confidenceNumericUpDown.Name = "confidenceNumericUpDown";
            this.confidenceNumericUpDown.Size = new System.Drawing.Size(71, 20);
            this.confidenceNumericUpDown.TabIndex = 0;
            this.confidenceNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.confidenceNumericUpDown.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.confidenceNumericUpDown.ValueChanged += new System.EventHandler(this.confidenceNumericUpDown_ValueChanged);
            // 
            // framesPerSecLbl
            // 
            this.framesPerSecLbl.AutoSize = true;
            this.framesPerSecLbl.Location = new System.Drawing.Point(192, 16);
            this.framesPerSecLbl.Name = "framesPerSecLbl";
            this.framesPerSecLbl.Size = new System.Drawing.Size(63, 13);
            this.framesPerSecLbl.TabIndex = 33;
            this.framesPerSecLbl.Text = "Frames/sec";
            // 
            // fpsLabel
            // 
            this.fpsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fpsLabel.Location = new System.Drawing.Point(195, 34);
            this.fpsLabel.Name = "fpsLabel";
            this.fpsLabel.Size = new System.Drawing.Size(60, 20);
            this.fpsLabel.TabIndex = 34;
            this.fpsLabel.Text = "FPS";
            this.fpsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fpsTimer
            // 
            this.fpsTimer.Enabled = true;
            this.fpsTimer.Interval = 500;
            this.fpsTimer.Tick += new System.EventHandler(this.fpsTimer_Tick);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "ADSB#";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(97, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(90, 20);
            this.textBox1.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Aircraft ICAO";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(303, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(671, 325);
            this.dataGridView1.TabIndex = 49;
            // 
            // mainFormBindingSource
            // 
            this.mainFormBindingSource.DataSource = typeof(ADSBSharp.MainForm);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 358);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ADSB#";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.tunerGainTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequencyCorrectionNumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeoutNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.confidenceNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainFormBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox deviceComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar tunerGainTrackBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox tunerAgcCheckBox;
        private System.Windows.Forms.Label gainLabel;
        private System.Windows.Forms.NumericUpDown frequencyCorrectionNumericUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label tunerTypeLabel;
        private System.Windows.Forms.CheckBox rtlAgcCheckBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label framesPerSecLbl;
        private System.Windows.Forms.Label fpsLabel;
        private System.Windows.Forms.Timer fpsTimer;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown confidenceNumericUpDown;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown timeoutNumericUpDown;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.BindingSource mainFormBindingSource;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

