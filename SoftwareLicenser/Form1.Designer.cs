namespace SoftwareLicenser
{
    partial class Licenser
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbLicensetype = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValidity = new System.Windows.Forms.TextBox();
            this.txtproductKey = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.HostUrl = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.MacAddress = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.TextBox();
            this.Stat = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Brown;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(4, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(907, 76);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Licenser";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "License Type";
            // 
            // cbLicensetype
            // 
            this.cbLicensetype.FormattingEnabled = true;
            this.cbLicensetype.Items.AddRange(new object[] {
            "Custom",
            "Full"});
            this.cbLicensetype.Location = new System.Drawing.Point(176, 281);
            this.cbLicensetype.Name = "cbLicensetype";
            this.cbLicensetype.Size = new System.Drawing.Size(358, 24);
            this.cbLicensetype.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Valid Date";
            // 
            // txtValidity
            // 
            this.txtValidity.Location = new System.Drawing.Point(176, 327);
            this.txtValidity.Multiline = true;
            this.txtValidity.Name = "txtValidity";
            this.txtValidity.Size = new System.Drawing.Size(358, 30);
            this.txtValidity.TabIndex = 4;
            // 
            // txtproductKey
            // 
            this.txtproductKey.Location = new System.Drawing.Point(176, 373);
            this.txtproductKey.Multiline = true;
            this.txtproductKey.Name = "txtproductKey";
            this.txtproductKey.Size = new System.Drawing.Size(462, 30);
            this.txtproductKey.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 387);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Product Key";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(176, 498);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(462, 66);
            this.txtStatus.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 501);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Status";
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGenerate.Location = new System.Drawing.Point(696, 366);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(108, 37);
            this.btnGenerate.TabIndex = 9;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.Silver;
            this.btnCheck.Location = new System.Drawing.Point(686, 513);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(142, 37);
            this.btnCheck.TabIndex = 10;
            this.btnCheck.Text = "Check Status";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Email";
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(176, 136);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(358, 22);
            this.Email.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Host URL";
            // 
            // HostUrl
            // 
            this.HostUrl.Location = new System.Drawing.Point(176, 188);
            this.HostUrl.Name = "HostUrl";
            this.HostUrl.Size = new System.Drawing.Size(358, 22);
            this.HostUrl.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Mac Address";
            // 
            // MacAddress
            // 
            this.MacAddress.Location = new System.Drawing.Point(176, 235);
            this.MacAddress.Name = "MacAddress";
            this.MacAddress.Size = new System.Drawing.Size(358, 22);
            this.MacAddress.TabIndex = 16;
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(176, 418);
            this.Result.Multiline = true;
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(462, 56);
            this.Result.TabIndex = 17;
            // 
            // Stat
            // 
            this.Stat.Location = new System.Drawing.Point(176, 577);
            this.Stat.Multiline = true;
            this.Stat.Name = "Stat";
            this.Stat.Size = new System.Drawing.Size(462, 66);
            this.Stat.TabIndex = 18;
            // 
            // Licenser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 655);
            this.Controls.Add(this.Stat);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.MacAddress);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.HostUrl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtproductKey);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtValidity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbLicensetype);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Licenser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Licenser_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbLicensetype;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValidity;
        private System.Windows.Forms.TextBox txtproductKey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox HostUrl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox MacAddress;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.TextBox Stat;
    }
}

