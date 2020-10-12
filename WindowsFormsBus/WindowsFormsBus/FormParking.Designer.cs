﻿namespace WindowsFormsBus
{
    partial class FormParking
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
            this.pictureBoxParking = new System.Windows.Forms.PictureBox();
            this.buttonSetBus = new System.Windows.Forms.Button();
            this.buttonSetGarmBus = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBoxNumber = new System.Windows.Forms.MaskedTextBox();
            this.buttonTakeBus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxParking
            // 
            this.pictureBoxParking.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxParking.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxParking.Name = "pictureBoxParking";
            this.pictureBoxParking.Size = new System.Drawing.Size(1369, 601);
            this.pictureBoxParking.TabIndex = 0;
            this.pictureBoxParking.TabStop = false;
            // 
            // buttonSetBus
            // 
            this.buttonSetBus.Location = new System.Drawing.Point(1383, 39);
            this.buttonSetBus.Name = "buttonSetBus";
            this.buttonSetBus.Size = new System.Drawing.Size(120, 51);
            this.buttonSetBus.TabIndex = 1;
            this.buttonSetBus.Text = "Припарковать автобус";
            this.buttonSetBus.UseVisualStyleBackColor = true;
            this.buttonSetBus.Click += new System.EventHandler(this.buttonSetBus_Click);
            // 
            // buttonSetGarmBus
            // 
            this.buttonSetGarmBus.Location = new System.Drawing.Point(1383, 96);
            this.buttonSetGarmBus.Name = "buttonSetGarmBus";
            this.buttonSetGarmBus.Size = new System.Drawing.Size(120, 64);
            this.buttonSetGarmBus.TabIndex = 2;
            this.buttonSetGarmBus.Text = "Припарковать автобус с гармошкой";
            this.buttonSetGarmBus.UseVisualStyleBackColor = true;
            this.buttonSetGarmBus.Click += new System.EventHandler(this.buttonSetGarmBus_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonTakeBus);
            this.groupBox1.Controls.Add(this.maskedTextBoxNumber);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(1383, 166);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 109);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Забрать автобус";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Место:";
            // 
            // maskedTextBoxNumber
            // 
            this.maskedTextBoxNumber.Location = new System.Drawing.Point(73, 36);
            this.maskedTextBoxNumber.Name = "maskedTextBoxNumber";
            this.maskedTextBoxNumber.Size = new System.Drawing.Size(47, 22);
            this.maskedTextBoxNumber.TabIndex = 1;
            // 
            // buttonTakeBus
            // 
            this.buttonTakeBus.Location = new System.Drawing.Point(17, 64);
            this.buttonTakeBus.Name = "buttonTakeBus";
            this.buttonTakeBus.Size = new System.Drawing.Size(103, 30);
            this.buttonTakeBus.TabIndex = 2;
            this.buttonTakeBus.Text = "Забрать";
            this.buttonTakeBus.UseVisualStyleBackColor = true;
            this.buttonTakeBus.Click += new System.EventHandler(this.buttonTakeBus_Click_1);
            // 
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1575, 601);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonSetGarmBus);
            this.Controls.Add(this.buttonSetBus);
            this.Controls.Add(this.pictureBoxParking);
            this.Name = "FormParking";
            this.Text = "Автовокзал";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxParking;
        private System.Windows.Forms.Button buttonSetBus;
        private System.Windows.Forms.Button buttonSetGarmBus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonTakeBus;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxNumber;
        private System.Windows.Forms.Label label1;
    }
}