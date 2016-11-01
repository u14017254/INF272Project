namespace PharmPlus
{
    partial class frmAddClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddClient));
            this.txBxID = new System.Windows.Forms.TextBox();
            this.txBxName = new System.Windows.Forms.TextBox();
            this.txBxSurname = new System.Windows.Forms.TextBox();
            this.txBxMedAidNum = new System.Windows.Forms.TextBox();
            this.txBxAddress = new System.Windows.Forms.RichTextBox();
            this.txBxMedCondition = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txBxID
            // 
            this.txBxID.Location = new System.Drawing.Point(136, 72);
            this.txBxID.Name = "txBxID";
            this.txBxID.Size = new System.Drawing.Size(199, 20);
            this.txBxID.TabIndex = 0;
            this.txBxID.TextChanged += new System.EventHandler(this.txBxID_TextChanged);
            // 
            // txBxName
            // 
            this.txBxName.Location = new System.Drawing.Point(136, 112);
            this.txBxName.Name = "txBxName";
            this.txBxName.Size = new System.Drawing.Size(199, 20);
            this.txBxName.TabIndex = 1;
            this.txBxName.TextChanged += new System.EventHandler(this.txBxName_TextChanged);
            // 
            // txBxSurname
            // 
            this.txBxSurname.Location = new System.Drawing.Point(136, 152);
            this.txBxSurname.Name = "txBxSurname";
            this.txBxSurname.Size = new System.Drawing.Size(199, 20);
            this.txBxSurname.TabIndex = 2;
            this.txBxSurname.TextChanged += new System.EventHandler(this.txBxSurname_TextChanged);
            // 
            // txBxMedAidNum
            // 
            this.txBxMedAidNum.Location = new System.Drawing.Point(136, 260);
            this.txBxMedAidNum.Name = "txBxMedAidNum";
            this.txBxMedAidNum.Size = new System.Drawing.Size(199, 20);
            this.txBxMedAidNum.TabIndex = 3;
            this.txBxMedAidNum.TextChanged += new System.EventHandler(this.txBxMedAidNum_TextChanged);
            // 
            // txBxAddress
            // 
            this.txBxAddress.Location = new System.Drawing.Point(136, 190);
            this.txBxAddress.Name = "txBxAddress";
            this.txBxAddress.Size = new System.Drawing.Size(199, 59);
            this.txBxAddress.TabIndex = 4;
            this.txBxAddress.Text = "";
            this.txBxAddress.TextChanged += new System.EventHandler(this.txBxAddress_TextChanged);
            // 
            // txBxMedCondition
            // 
            this.txBxMedCondition.Location = new System.Drawing.Point(136, 299);
            this.txBxMedCondition.Name = "txBxMedCondition";
            this.txBxMedCondition.Size = new System.Drawing.Size(199, 20);
            this.txBxMedCondition.TabIndex = 5;
            this.txBxMedCondition.TextChanged += new System.EventHandler(this.txBxMedCondition_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID Number";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Surname";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Address";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Medical Aid Number";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Medical Condition";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(367, 60);
            this.panel1.TabIndex = 12;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(346, 44);
            this.label7.TabIndex = 0;
            this.label7.Text = "Enter Client Details";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(136, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 30);
            this.button1.TabIndex = 13;
            this.button1.Text = "Add Client";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmAddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 364);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txBxMedCondition);
            this.Controls.Add(this.txBxAddress);
            this.Controls.Add(this.txBxMedAidNum);
            this.Controls.Add(this.txBxSurname);
            this.Controls.Add(this.txBxName);
            this.Controls.Add(this.txBxID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddClient";
            this.Text = "Add Client";
            this.Load += new System.EventHandler(this.frmAddClient_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txBxID;
        private System.Windows.Forms.TextBox txBxName;
        private System.Windows.Forms.TextBox txBxSurname;
        private System.Windows.Forms.TextBox txBxMedAidNum;
        private System.Windows.Forms.RichTextBox txBxAddress;
        private System.Windows.Forms.TextBox txBxMedCondition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
    }
}