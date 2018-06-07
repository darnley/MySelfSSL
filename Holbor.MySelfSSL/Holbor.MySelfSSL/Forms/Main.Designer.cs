namespace Holbor.MySelfSSL.Forms
{
    partial class Main
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
            this.groupBoxCertificateAuthority = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxCertificateAuthorities = new System.Windows.Forms.ComboBox();
            this.groupBoxSelfSignedCertificate = new System.Windows.Forms.GroupBox();
            this.textBoxCommonName = new System.Windows.Forms.TextBox();
            this.listBoxSAN = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonAddSAN = new System.Windows.Forms.Button();
            this.buttonRemoveSAN = new System.Windows.Forms.Button();
            this.buttonCreateCertificate = new System.Windows.Forms.Button();
            this.groupBoxCertificateAuthority.SuspendLayout();
            this.groupBoxSelfSignedCertificate.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCertificateAuthority
            // 
            this.groupBoxCertificateAuthority.AccessibleName = "Certificate Authority";
            this.groupBoxCertificateAuthority.Controls.Add(this.button1);
            this.groupBoxCertificateAuthority.Controls.Add(this.comboBoxCertificateAuthorities);
            this.groupBoxCertificateAuthority.Location = new System.Drawing.Point(16, 15);
            this.groupBoxCertificateAuthority.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxCertificateAuthority.Name = "groupBoxCertificateAuthority";
            this.groupBoxCertificateAuthority.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxCertificateAuthority.Size = new System.Drawing.Size(437, 96);
            this.groupBoxCertificateAuthority.TabIndex = 0;
            this.groupBoxCertificateAuthority.TabStop = false;
            this.groupBoxCertificateAuthority.Text = "Certificate Authority (CA)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 57);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(421, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.CreateCertificateAuthority);
            // 
            // comboBoxCertificateAuthorities
            // 
            this.comboBoxCertificateAuthorities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCertificateAuthorities.FormattingEnabled = true;
            this.comboBoxCertificateAuthorities.IntegralHeight = false;
            this.comboBoxCertificateAuthorities.Location = new System.Drawing.Point(8, 23);
            this.comboBoxCertificateAuthorities.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxCertificateAuthorities.Name = "comboBoxCertificateAuthorities";
            this.comboBoxCertificateAuthorities.Size = new System.Drawing.Size(420, 24);
            this.comboBoxCertificateAuthorities.TabIndex = 0;
            // 
            // groupBoxSelfSignedCertificate
            // 
            this.groupBoxSelfSignedCertificate.AccessibleName = "Self-Signed Certificate";
            this.groupBoxSelfSignedCertificate.Controls.Add(this.buttonCreateCertificate);
            this.groupBoxSelfSignedCertificate.Controls.Add(this.buttonRemoveSAN);
            this.groupBoxSelfSignedCertificate.Controls.Add(this.buttonAddSAN);
            this.groupBoxSelfSignedCertificate.Controls.Add(this.textBox1);
            this.groupBoxSelfSignedCertificate.Controls.Add(this.listBoxSAN);
            this.groupBoxSelfSignedCertificate.Controls.Add(this.textBoxCommonName);
            this.groupBoxSelfSignedCertificate.Location = new System.Drawing.Point(16, 118);
            this.groupBoxSelfSignedCertificate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxSelfSignedCertificate.Name = "groupBoxSelfSignedCertificate";
            this.groupBoxSelfSignedCertificate.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxSelfSignedCertificate.Size = new System.Drawing.Size(437, 268);
            this.groupBoxSelfSignedCertificate.TabIndex = 1;
            this.groupBoxSelfSignedCertificate.TabStop = false;
            this.groupBoxSelfSignedCertificate.Text = "Self-Signed Certificate";
            // 
            // textBoxCommonName
            // 
            this.textBoxCommonName.Location = new System.Drawing.Point(8, 22);
            this.textBoxCommonName.Name = "textBoxCommonName";
            this.textBoxCommonName.Size = new System.Drawing.Size(420, 22);
            this.textBoxCommonName.TabIndex = 2;
            // 
            // listBoxSAN
            // 
            this.listBoxSAN.FormattingEnabled = true;
            this.listBoxSAN.ItemHeight = 16;
            this.listBoxSAN.Location = new System.Drawing.Point(8, 99);
            this.listBoxSAN.Name = "listBoxSAN";
            this.listBoxSAN.Size = new System.Drawing.Size(338, 84);
            this.listBoxSAN.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(8, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(338, 22);
            this.textBox1.TabIndex = 3;
            // 
            // buttonAddSAN
            // 
            this.buttonAddSAN.Location = new System.Drawing.Point(352, 70);
            this.buttonAddSAN.Name = "buttonAddSAN";
            this.buttonAddSAN.Size = new System.Drawing.Size(75, 23);
            this.buttonAddSAN.TabIndex = 4;
            this.buttonAddSAN.Text = "Add";
            this.buttonAddSAN.UseVisualStyleBackColor = true;
            // 
            // buttonRemoveSAN
            // 
            this.buttonRemoveSAN.Location = new System.Drawing.Point(352, 99);
            this.buttonRemoveSAN.Name = "buttonRemoveSAN";
            this.buttonRemoveSAN.Size = new System.Drawing.Size(75, 84);
            this.buttonRemoveSAN.TabIndex = 6;
            this.buttonRemoveSAN.Text = "Remove";
            this.buttonRemoveSAN.UseVisualStyleBackColor = true;
            // 
            // buttonCreateCertificate
            // 
            this.buttonCreateCertificate.Location = new System.Drawing.Point(8, 210);
            this.buttonCreateCertificate.Name = "buttonCreateCertificate";
            this.buttonCreateCertificate.Size = new System.Drawing.Size(419, 43);
            this.buttonCreateCertificate.TabIndex = 7;
            this.buttonCreateCertificate.Text = "Create certificate";
            this.buttonCreateCertificate.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AccessibleDescription = "Create Self-Signed Certificates";
            this.AccessibleName = "MySelfSSL";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 403);
            this.Controls.Add(this.groupBoxSelfSignedCertificate);
            this.Controls.Add(this.groupBoxCertificateAuthority);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MySelfSSL";
            this.Load += new System.EventHandler(this.Init);
            this.groupBoxCertificateAuthority.ResumeLayout(false);
            this.groupBoxSelfSignedCertificate.ResumeLayout(false);
            this.groupBoxSelfSignedCertificate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCertificateAuthority;
        private System.Windows.Forms.GroupBox groupBoxSelfSignedCertificate;
        private System.Windows.Forms.ComboBox comboBoxCertificateAuthorities;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonAddSAN;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBoxSAN;
        private System.Windows.Forms.TextBox textBoxCommonName;
        private System.Windows.Forms.Button buttonRemoveSAN;
        private System.Windows.Forms.Button buttonCreateCertificate;
    }
}