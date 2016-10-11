﻿namespace PharmPlus
{
    partial class frmAddMedication
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txBxSchedule = new System.Windows.Forms.TextBox();
            this.txBxSupplier = new System.Windows.Forms.TextBox();
            this.txBxBrand = new System.Windows.Forms.TextBox();
            this.txBxName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 60);
            this.panel1.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(433, 44);
            this.label7.TabIndex = 0;
            this.label7.Text = "Enter Medication Details";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Schedule";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Supplier";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Brand";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Name";
            // 
            // txBxSchedule
            // 
            this.txBxSchedule.Location = new System.Drawing.Point(131, 201);
            this.txBxSchedule.Name = "txBxSchedule";
            this.txBxSchedule.Size = new System.Drawing.Size(199, 20);
            this.txBxSchedule.TabIndex = 19;
            // 
            // txBxSupplier
            // 
            this.txBxSupplier.Location = new System.Drawing.Point(131, 162);
            this.txBxSupplier.Name = "txBxSupplier";
            this.txBxSupplier.Size = new System.Drawing.Size(199, 20);
            this.txBxSupplier.TabIndex = 17;
            // 
            // txBxBrand
            // 
            this.txBxBrand.Location = new System.Drawing.Point(131, 124);
            this.txBxBrand.Name = "txBxBrand";
            this.txBxBrand.Size = new System.Drawing.Size(199, 20);
            this.txBxBrand.TabIndex = 16;
            // 
            // txBxName
            // 
            this.txBxName.Location = new System.Drawing.Point(131, 84);
            this.txBxName.Name = "txBxName";
            this.txBxName.Size = new System.Drawing.Size(199, 20);
            this.txBxName.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(131, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 30);
            this.button1.TabIndex = 27;
            this.button1.Text = "Add Medication";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmAddMedication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 295);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txBxSchedule);
            this.Controls.Add(this.txBxSupplier);
            this.Controls.Add(this.txBxBrand);
            this.Controls.Add(this.txBxName);
            this.Controls.Add(this.button1);
            this.Name = "frmAddMedication";
            this.Text = "frmAddMedication";
            this.Load += new System.EventHandler(this.frmAddMedication_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txBxSchedule;
        private System.Windows.Forms.TextBox txBxSupplier;
        private System.Windows.Forms.TextBox txBxBrand;
        private System.Windows.Forms.TextBox txBxName;
        private System.Windows.Forms.Button button1;
    }
}