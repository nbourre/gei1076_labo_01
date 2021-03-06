﻿namespace labo_01_convertisseur
{
    partial class SerialPortConfigurator
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblState = new System.Windows.Forms.Label();
            this.lblEtat = new System.Windows.Forms.Label();
            this.chkSerialPortSync = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboSerialPortList = new System.Windows.Forms.ComboBox();
            this.btnSerialPortClose = new System.Windows.Forms.Button();
            this.btnSerialPortOpen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblState.Location = new System.Drawing.Point(377, 59);
            this.lblState.MinimumSize = new System.Drawing.Size(30, 2);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(30, 15);
            this.lblState.TabIndex = 15;
            // 
            // lblEtat
            // 
            this.lblEtat.AutoSize = true;
            this.lblEtat.Location = new System.Drawing.Point(331, 59);
            this.lblEtat.Name = "lblEtat";
            this.lblEtat.Size = new System.Drawing.Size(32, 13);
            this.lblEtat.TabIndex = 14;
            this.lblEtat.Text = "État :";
            // 
            // chkSerialPortSync
            // 
            this.chkSerialPortSync.AutoSize = true;
            this.chkSerialPortSync.Checked = true;
            this.chkSerialPortSync.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSerialPortSync.Location = new System.Drawing.Point(37, 58);
            this.chkSerialPortSync.Name = "chkSerialPortSync";
            this.chkSerialPortSync.Size = new System.Drawing.Size(87, 17);
            this.chkSerialPortSync.TabIndex = 13;
            this.chkSerialPortSync.Text = "Synchroniser";
            this.chkSerialPortSync.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ports reconnus";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Configuration du port série";
            // 
            // cboSerialPortList
            // 
            this.cboSerialPortList.FormattingEnabled = true;
            this.cboSerialPortList.Location = new System.Drawing.Point(118, 31);
            this.cboSerialPortList.Name = "cboSerialPortList";
            this.cboSerialPortList.Size = new System.Drawing.Size(121, 21);
            this.cboSerialPortList.TabIndex = 10;
            // 
            // btnSerialPortClose
            // 
            this.btnSerialPortClose.Location = new System.Drawing.Point(332, 30);
            this.btnSerialPortClose.Name = "btnSerialPortClose";
            this.btnSerialPortClose.Size = new System.Drawing.Size(75, 23);
            this.btnSerialPortClose.TabIndex = 9;
            this.btnSerialPortClose.Text = "Fermer";
            this.btnSerialPortClose.UseVisualStyleBackColor = true;
            // 
            // btnSerialPortOpen
            // 
            this.btnSerialPortOpen.Location = new System.Drawing.Point(251, 30);
            this.btnSerialPortOpen.Name = "btnSerialPortOpen";
            this.btnSerialPortOpen.Size = new System.Drawing.Size(75, 23);
            this.btnSerialPortOpen.TabIndex = 8;
            this.btnSerialPortOpen.Text = "Ouvrir";
            this.btnSerialPortOpen.UseVisualStyleBackColor = true;
            // 
            // SerialPortConfigurator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblEtat);
            this.Controls.Add(this.chkSerialPortSync);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboSerialPortList);
            this.Controls.Add(this.btnSerialPortClose);
            this.Controls.Add(this.btnSerialPortOpen);
            this.Name = "SerialPortConfigurator";
            this.Size = new System.Drawing.Size(431, 90);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblEtat;
        private System.Windows.Forms.CheckBox chkSerialPortSync;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboSerialPortList;
        private System.Windows.Forms.Button btnSerialPortClose;
        private System.Windows.Forms.Button btnSerialPortOpen;
    }
}
