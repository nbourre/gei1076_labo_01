namespace labo_01_convertisseur
{
    partial class Form1
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
            this.nudDecimal = new System.Windows.Forms.NumericUpDown();
            this.nudBin03 = new System.Windows.Forms.NumericUpDown();
            this.nudBin02 = new System.Windows.Forms.NumericUpDown();
            this.nudBin00 = new System.Windows.Forms.NumericUpDown();
            this.nudBin01 = new System.Windows.Forms.NumericUpDown();
            this.nudHex = new System.Windows.Forms.NumericUpDown();
            this.chkCounter = new System.Windows.Forms.CheckBox();
            this.radDec = new System.Windows.Forms.RadioButton();
            this.radBinaire = new System.Windows.Forms.RadioButton();
            this.radHex = new System.Windows.Forms.RadioButton();
            this.lblSeg_A = new System.Windows.Forms.Label();
            this.lblSeg_G = new System.Windows.Forms.Label();
            this.lblSeg_D = new System.Windows.Forms.Label();
            this.lblSeg_B = new System.Windows.Forms.Label();
            this.lblSeg_C = new System.Windows.Forms.Label();
            this.lblSeg_E = new System.Windows.Forms.Label();
            this.lblSeg_F = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.pnl_serialPort = new System.Windows.Forms.Panel();
            this.btnSerialPortClose = new System.Windows.Forms.Button();
            this.btnSerialPortOpen = new System.Windows.Forms.Button();
            this.cboSerialPortList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkSerialPortSync = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudDecimal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBin03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBin02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBin00)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBin01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHex)).BeginInit();
            this.pnl_serialPort.SuspendLayout();
            this.SuspendLayout();
            // 
            // nudDecimal
            // 
            this.nudDecimal.Location = new System.Drawing.Point(12, 38);
            this.nudDecimal.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nudDecimal.Name = "nudDecimal";
            this.nudDecimal.Size = new System.Drawing.Size(41, 20);
            this.nudDecimal.TabIndex = 0;
            this.nudDecimal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudDecimal.ValueChanged += new System.EventHandler(this.nudDecimal_ValueChanged);
            // 
            // nudBin03
            // 
            this.nudBin03.Location = new System.Drawing.Point(119, 38);
            this.nudBin03.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudBin03.Name = "nudBin03";
            this.nudBin03.Size = new System.Drawing.Size(41, 20);
            this.nudBin03.TabIndex = 1;
            this.nudBin03.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudBin03.ValueChanged += new System.EventHandler(this.nudBin_ValueChanged);
            // 
            // nudBin02
            // 
            this.nudBin02.Location = new System.Drawing.Point(166, 38);
            this.nudBin02.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudBin02.Name = "nudBin02";
            this.nudBin02.Size = new System.Drawing.Size(41, 20);
            this.nudBin02.TabIndex = 2;
            this.nudBin02.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudBin02.ValueChanged += new System.EventHandler(this.nudBin_ValueChanged);
            // 
            // nudBin00
            // 
            this.nudBin00.Location = new System.Drawing.Point(260, 38);
            this.nudBin00.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudBin00.Name = "nudBin00";
            this.nudBin00.Size = new System.Drawing.Size(41, 20);
            this.nudBin00.TabIndex = 4;
            this.nudBin00.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudBin00.ValueChanged += new System.EventHandler(this.nudBin_ValueChanged);
            // 
            // nudBin01
            // 
            this.nudBin01.Location = new System.Drawing.Point(213, 38);
            this.nudBin01.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudBin01.Name = "nudBin01";
            this.nudBin01.Size = new System.Drawing.Size(41, 20);
            this.nudBin01.TabIndex = 3;
            this.nudBin01.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudBin01.ValueChanged += new System.EventHandler(this.nudBin_ValueChanged);
            // 
            // nudHex
            // 
            this.nudHex.Hexadecimal = true;
            this.nudHex.Location = new System.Drawing.Point(372, 38);
            this.nudHex.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nudHex.Name = "nudHex";
            this.nudHex.Size = new System.Drawing.Size(41, 20);
            this.nudHex.TabIndex = 5;
            this.nudHex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudHex.ValueChanged += new System.EventHandler(this.nudHex_ValueChanged);
            // 
            // chkCounter
            // 
            this.chkCounter.AutoSize = true;
            this.chkCounter.Location = new System.Drawing.Point(166, 76);
            this.chkCounter.Name = "chkCounter";
            this.chkCounter.Size = new System.Drawing.Size(71, 17);
            this.chkCounter.TabIndex = 6;
            this.chkCounter.Text = "Compteur";
            this.chkCounter.UseVisualStyleBackColor = true;
            this.chkCounter.CheckedChanged += new System.EventHandler(this.chkCounter_CheckedChanged);
            // 
            // radDec
            // 
            this.radDec.AutoSize = true;
            this.radDec.Location = new System.Drawing.Point(12, 15);
            this.radDec.Name = "radDec";
            this.radDec.Size = new System.Drawing.Size(63, 17);
            this.radDec.TabIndex = 7;
            this.radDec.TabStop = true;
            this.radDec.Text = "Décimal";
            this.radDec.UseVisualStyleBackColor = true;
            this.radDec.CheckedChanged += new System.EventHandler(this.radDec_CheckedChanged);
            // 
            // radBinaire
            // 
            this.radBinaire.AutoSize = true;
            this.radBinaire.Location = new System.Drawing.Point(119, 12);
            this.radBinaire.Name = "radBinaire";
            this.radBinaire.Size = new System.Drawing.Size(57, 17);
            this.radBinaire.TabIndex = 8;
            this.radBinaire.TabStop = true;
            this.radBinaire.Text = "Binaire";
            this.radBinaire.UseVisualStyleBackColor = true;
            this.radBinaire.CheckedChanged += new System.EventHandler(this.radBinaire_CheckedChanged);
            // 
            // radHex
            // 
            this.radHex.AutoSize = true;
            this.radHex.Location = new System.Drawing.Point(372, 12);
            this.radHex.Name = "radHex";
            this.radHex.Size = new System.Drawing.Size(44, 17);
            this.radHex.TabIndex = 9;
            this.radHex.TabStop = true;
            this.radHex.Text = "Hex";
            this.radHex.UseVisualStyleBackColor = true;
            this.radHex.CheckedChanged += new System.EventHandler(this.radHex_CheckedChanged);
            // 
            // lblSeg_A
            // 
            this.lblSeg_A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSeg_A.Location = new System.Drawing.Point(154, 118);
            this.lblSeg_A.Name = "lblSeg_A";
            this.lblSeg_A.Size = new System.Drawing.Size(100, 25);
            this.lblSeg_A.TabIndex = 10;
            // 
            // lblSeg_G
            // 
            this.lblSeg_G.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSeg_G.Location = new System.Drawing.Point(154, 197);
            this.lblSeg_G.Name = "lblSeg_G";
            this.lblSeg_G.Size = new System.Drawing.Size(100, 25);
            this.lblSeg_G.TabIndex = 11;
            // 
            // lblSeg_D
            // 
            this.lblSeg_D.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSeg_D.Location = new System.Drawing.Point(154, 276);
            this.lblSeg_D.Name = "lblSeg_D";
            this.lblSeg_D.Size = new System.Drawing.Size(100, 25);
            this.lblSeg_D.TabIndex = 12;
            // 
            // lblSeg_B
            // 
            this.lblSeg_B.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSeg_B.Location = new System.Drawing.Point(260, 128);
            this.lblSeg_B.Name = "lblSeg_B";
            this.lblSeg_B.Size = new System.Drawing.Size(25, 75);
            this.lblSeg_B.TabIndex = 13;
            // 
            // lblSeg_C
            // 
            this.lblSeg_C.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSeg_C.Location = new System.Drawing.Point(260, 216);
            this.lblSeg_C.Name = "lblSeg_C";
            this.lblSeg_C.Size = new System.Drawing.Size(25, 75);
            this.lblSeg_C.TabIndex = 14;
            // 
            // lblSeg_E
            // 
            this.lblSeg_E.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSeg_E.Location = new System.Drawing.Point(123, 216);
            this.lblSeg_E.Name = "lblSeg_E";
            this.lblSeg_E.Size = new System.Drawing.Size(25, 75);
            this.lblSeg_E.TabIndex = 16;
            // 
            // lblSeg_F
            // 
            this.lblSeg_F.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSeg_F.Location = new System.Drawing.Point(123, 128);
            this.lblSeg_F.Name = "lblSeg_F";
            this.lblSeg_F.Size = new System.Drawing.Size(25, 75);
            this.lblSeg_F.TabIndex = 15;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnl_serialPort
            // 
            this.pnl_serialPort.Controls.Add(this.chkSerialPortSync);
            this.pnl_serialPort.Controls.Add(this.label2);
            this.pnl_serialPort.Controls.Add(this.label1);
            this.pnl_serialPort.Controls.Add(this.cboSerialPortList);
            this.pnl_serialPort.Controls.Add(this.btnSerialPortClose);
            this.pnl_serialPort.Controls.Add(this.btnSerialPortOpen);
            this.pnl_serialPort.Location = new System.Drawing.Point(12, 322);
            this.pnl_serialPort.Name = "pnl_serialPort";
            this.pnl_serialPort.Size = new System.Drawing.Size(404, 92);
            this.pnl_serialPort.TabIndex = 17;
            // 
            // btnSerialPortClose
            // 
            this.btnSerialPortClose.Location = new System.Drawing.Point(318, 29);
            this.btnSerialPortClose.Name = "btnSerialPortClose";
            this.btnSerialPortClose.Size = new System.Drawing.Size(75, 23);
            this.btnSerialPortClose.TabIndex = 1;
            this.btnSerialPortClose.Text = "Fermer";
            this.btnSerialPortClose.UseVisualStyleBackColor = true;
            this.btnSerialPortClose.Click += new System.EventHandler(this.btnSerialPortClose_Click);
            // 
            // btnSerialPortOpen
            // 
            this.btnSerialPortOpen.Location = new System.Drawing.Point(237, 29);
            this.btnSerialPortOpen.Name = "btnSerialPortOpen";
            this.btnSerialPortOpen.Size = new System.Drawing.Size(75, 23);
            this.btnSerialPortOpen.TabIndex = 0;
            this.btnSerialPortOpen.Text = "Ouvrir";
            this.btnSerialPortOpen.UseVisualStyleBackColor = true;
            this.btnSerialPortOpen.Click += new System.EventHandler(this.btnSerialPortOpen_Click);
            // 
            // cboSerialPortList
            // 
            this.cboSerialPortList.FormattingEnabled = true;
            this.cboSerialPortList.Location = new System.Drawing.Point(104, 30);
            this.cboSerialPortList.Name = "cboSerialPortList";
            this.cboSerialPortList.Size = new System.Drawing.Size(121, 21);
            this.cboSerialPortList.TabIndex = 2;
            this.cboSerialPortList.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Configuration du port série";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ports reconnus";
            // 
            // chkSerialPortSync
            // 
            this.chkSerialPortSync.AutoSize = true;
            this.chkSerialPortSync.Checked = true;
            this.chkSerialPortSync.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSerialPortSync.Location = new System.Drawing.Point(23, 57);
            this.chkSerialPortSync.Name = "chkSerialPortSync";
            this.chkSerialPortSync.Size = new System.Drawing.Size(87, 17);
            this.chkSerialPortSync.TabIndex = 5;
            this.chkSerialPortSync.Text = "Synchroniser";
            this.chkSerialPortSync.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 426);
            this.Controls.Add(this.pnl_serialPort);
            this.Controls.Add(this.lblSeg_E);
            this.Controls.Add(this.lblSeg_F);
            this.Controls.Add(this.lblSeg_C);
            this.Controls.Add(this.lblSeg_B);
            this.Controls.Add(this.lblSeg_D);
            this.Controls.Add(this.lblSeg_G);
            this.Controls.Add(this.lblSeg_A);
            this.Controls.Add(this.radHex);
            this.Controls.Add(this.radBinaire);
            this.Controls.Add(this.radDec);
            this.Controls.Add(this.chkCounter);
            this.Controls.Add(this.nudHex);
            this.Controls.Add(this.nudBin00);
            this.Controls.Add(this.nudBin01);
            this.Controls.Add(this.nudBin02);
            this.Controls.Add(this.nudBin03);
            this.Controls.Add(this.nudDecimal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Convertisseur visuel";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudDecimal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBin03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBin02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBin00)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBin01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHex)).EndInit();
            this.pnl_serialPort.ResumeLayout(false);
            this.pnl_serialPort.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudDecimal;
        private System.Windows.Forms.NumericUpDown nudBin03;
        private System.Windows.Forms.NumericUpDown nudBin02;
        private System.Windows.Forms.NumericUpDown nudBin00;
        private System.Windows.Forms.NumericUpDown nudBin01;
        private System.Windows.Forms.NumericUpDown nudHex;
        private System.Windows.Forms.CheckBox chkCounter;
        private System.Windows.Forms.RadioButton radDec;
        private System.Windows.Forms.RadioButton radBinaire;
        private System.Windows.Forms.RadioButton radHex;
        private System.Windows.Forms.Label lblSeg_A;
        private System.Windows.Forms.Label lblSeg_G;
        private System.Windows.Forms.Label lblSeg_D;
        private System.Windows.Forms.Label lblSeg_B;
        private System.Windows.Forms.Label lblSeg_C;
        private System.Windows.Forms.Label lblSeg_E;
        private System.Windows.Forms.Label lblSeg_F;
        private System.Windows.Forms.Timer timer1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Panel pnl_serialPort;
        private System.Windows.Forms.Button btnSerialPortOpen;
        private System.Windows.Forms.Button btnSerialPortClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboSerialPortList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkSerialPortSync;
    }
}

