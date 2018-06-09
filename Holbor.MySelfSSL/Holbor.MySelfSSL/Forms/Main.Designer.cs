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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tabPage = new System.Windows.Forms.TabPage();
            this.groupBoxSelfSignedCertificate = new System.Windows.Forms.GroupBox();
            this.textBoxCommonName = new System.Windows.Forms.TextBox();
            this.listBoxSAN = new System.Windows.Forms.ListBox();
            this.textBoxSAN = new System.Windows.Forms.TextBox();
            this.buttonAddSAN = new System.Windows.Forms.Button();
            this.buttonRemoveSAN = new System.Windows.Forms.Button();
            this.buttonCreateCertificate = new System.Windows.Forms.Button();
            this.groupBoxCertificateAuthority = new System.Windows.Forms.GroupBox();
            this.comboBoxCertificateAuthorities = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonRefreshCertificateAuthorities = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.groupBoxSAN = new System.Windows.Forms.GroupBox();
            this.labelCommonName = new System.Windows.Forms.Label();
            this.tabPage.SuspendLayout();
            this.groupBoxSelfSignedCertificate.SuspendLayout();
            this.groupBoxCertificateAuthority.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.groupBoxSAN.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage
            // 
            this.tabPage.Controls.Add(this.groupBoxCertificateAuthority);
            this.tabPage.Controls.Add(this.groupBoxSelfSignedCertificate);
            this.tabPage.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabPage.Location = new System.Drawing.Point(4, 22);
            this.tabPage.Name = "tabPage";
            this.tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage.Size = new System.Drawing.Size(431, 355);
            this.tabPage.TabIndex = 0;
            this.tabPage.Text = "Main";
            this.tabPage.UseVisualStyleBackColor = true;
            // 
            // groupBoxSelfSignedCertificate
            // 
            this.groupBoxSelfSignedCertificate.AccessibleName = "Self-Signed Certificate";
            this.groupBoxSelfSignedCertificate.Controls.Add(this.labelCommonName);
            this.groupBoxSelfSignedCertificate.Controls.Add(this.groupBoxSAN);
            this.groupBoxSelfSignedCertificate.Controls.Add(this.buttonCreateCertificate);
            this.groupBoxSelfSignedCertificate.Controls.Add(this.textBoxCommonName);
            this.groupBoxSelfSignedCertificate.Location = new System.Drawing.Point(6, 99);
            this.groupBoxSelfSignedCertificate.Name = "groupBoxSelfSignedCertificate";
            this.groupBoxSelfSignedCertificate.Size = new System.Drawing.Size(419, 250);
            this.groupBoxSelfSignedCertificate.TabIndex = 1;
            this.groupBoxSelfSignedCertificate.TabStop = false;
            // 
            // textBoxCommonName
            // 
            this.textBoxCommonName.Location = new System.Drawing.Point(5, 33);
            this.textBoxCommonName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCommonName.Name = "textBoxCommonName";
            this.textBoxCommonName.Size = new System.Drawing.Size(407, 20);
            this.textBoxCommonName.TabIndex = 2;
            // 
            // listBoxSAN
            // 
            this.listBoxSAN.FormattingEnabled = true;
            this.listBoxSAN.Location = new System.Drawing.Point(5, 43);
            this.listBoxSAN.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxSAN.Name = "listBoxSAN";
            this.listBoxSAN.Size = new System.Drawing.Size(337, 82);
            this.listBoxSAN.TabIndex = 5;
            // 
            // textBoxSAN
            // 
            this.textBoxSAN.Location = new System.Drawing.Point(5, 18);
            this.textBoxSAN.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSAN.Name = "textBoxSAN";
            this.textBoxSAN.Size = new System.Drawing.Size(337, 20);
            this.textBoxSAN.TabIndex = 3;
            // 
            // buttonAddSAN
            // 
            this.buttonAddSAN.Location = new System.Drawing.Point(346, 18);
            this.buttonAddSAN.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddSAN.Name = "buttonAddSAN";
            this.buttonAddSAN.Size = new System.Drawing.Size(56, 21);
            this.buttonAddSAN.TabIndex = 4;
            this.buttonAddSAN.Text = "Add";
            this.buttonAddSAN.UseVisualStyleBackColor = true;
            this.buttonAddSAN.Click += new System.EventHandler(this.AddSAN);
            // 
            // buttonRemoveSAN
            // 
            this.buttonRemoveSAN.Location = new System.Drawing.Point(346, 44);
            this.buttonRemoveSAN.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRemoveSAN.Name = "buttonRemoveSAN";
            this.buttonRemoveSAN.Size = new System.Drawing.Size(56, 80);
            this.buttonRemoveSAN.TabIndex = 6;
            this.buttonRemoveSAN.Text = "Remove";
            this.buttonRemoveSAN.UseVisualStyleBackColor = true;
            this.buttonRemoveSAN.Click += new System.EventHandler(this.RemoveSAN);
            // 
            // buttonCreateCertificate
            // 
            this.buttonCreateCertificate.Location = new System.Drawing.Point(5, 200);
            this.buttonCreateCertificate.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCreateCertificate.Name = "buttonCreateCertificate";
            this.buttonCreateCertificate.Size = new System.Drawing.Size(409, 44);
            this.buttonCreateCertificate.TabIndex = 7;
            this.buttonCreateCertificate.Text = "Create certificate";
            this.buttonCreateCertificate.UseVisualStyleBackColor = true;
            this.buttonCreateCertificate.Click += new System.EventHandler(this.AttemptCertificateCreation);
            // 
            // groupBoxCertificateAuthority
            // 
            this.groupBoxCertificateAuthority.AccessibleName = "Certificate Authority";
            this.groupBoxCertificateAuthority.Controls.Add(this.buttonRefreshCertificateAuthorities);
            this.groupBoxCertificateAuthority.Controls.Add(this.button1);
            this.groupBoxCertificateAuthority.Controls.Add(this.comboBoxCertificateAuthorities);
            this.groupBoxCertificateAuthority.Location = new System.Drawing.Point(6, 6);
            this.groupBoxCertificateAuthority.Name = "groupBoxCertificateAuthority";
            this.groupBoxCertificateAuthority.Size = new System.Drawing.Size(419, 77);
            this.groupBoxCertificateAuthority.TabIndex = 0;
            this.groupBoxCertificateAuthority.TabStop = false;
            this.groupBoxCertificateAuthority.Text = "Certificate Authority (CA)";
            // 
            // comboBoxCertificateAuthorities
            // 
            this.comboBoxCertificateAuthorities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCertificateAuthorities.FormattingEnabled = true;
            this.comboBoxCertificateAuthorities.IntegralHeight = false;
            this.comboBoxCertificateAuthorities.Location = new System.Drawing.Point(6, 19);
            this.comboBoxCertificateAuthorities.Name = "comboBoxCertificateAuthorities";
            this.comboBoxCertificateAuthorities.Size = new System.Drawing.Size(407, 21);
            this.comboBoxCertificateAuthorities.TabIndex = 0;
            this.comboBoxCertificateAuthorities.SelectedIndexChanged += new System.EventHandler(this.CertificateAuthoritySizeChanged);
            this.comboBoxCertificateAuthorities.SizeChanged += new System.EventHandler(this.CertificateAuthoritySizeChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(68, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(345, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.CreateCertificateAuthority);
            // 
            // buttonRefreshCertificateAuthorities
            // 
            this.buttonRefreshCertificateAuthorities.Location = new System.Drawing.Point(6, 46);
            this.buttonRefreshCertificateAuthorities.Name = "buttonRefreshCertificateAuthorities";
            this.buttonRefreshCertificateAuthorities.Size = new System.Drawing.Size(56, 23);
            this.buttonRefreshCertificateAuthorities.TabIndex = 2;
            this.buttonRefreshCertificateAuthorities.Text = "Refresh";
            this.buttonRefreshCertificateAuthorities.UseVisualStyleBackColor = true;
            this.buttonRefreshCertificateAuthorities.Click += new System.EventHandler(this.RefreshCertificateAuthorities);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(439, 381);
            this.tabControl1.TabIndex = 2;
            // 
            // groupBoxSAN
            // 
            this.groupBoxSAN.Controls.Add(this.textBoxSAN);
            this.groupBoxSAN.Controls.Add(this.buttonAddSAN);
            this.groupBoxSAN.Controls.Add(this.buttonRemoveSAN);
            this.groupBoxSAN.Controls.Add(this.listBoxSAN);
            this.groupBoxSAN.Location = new System.Drawing.Point(5, 66);
            this.groupBoxSAN.Name = "groupBoxSAN";
            this.groupBoxSAN.Size = new System.Drawing.Size(407, 129);
            this.groupBoxSAN.TabIndex = 8;
            this.groupBoxSAN.TabStop = false;
            this.groupBoxSAN.Text = "Subject Alternative Names (SAN)";
            // 
            // labelCommonName
            // 
            this.labelCommonName.AutoSize = true;
            this.labelCommonName.Location = new System.Drawing.Point(8, 16);
            this.labelCommonName.Name = "labelCommonName";
            this.labelCommonName.Size = new System.Drawing.Size(79, 13);
            this.labelCommonName.TabIndex = 9;
            this.labelCommonName.Text = "Common Name";
            // 
            // Main
            // 
            this.AccessibleDescription = "Create Self-Signed Certificates";
            this.AccessibleName = "MySelfSSL";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 406);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MySelfSSL";
            this.Load += new System.EventHandler(this.Init);
            this.tabPage.ResumeLayout(false);
            this.groupBoxSelfSignedCertificate.ResumeLayout(false);
            this.groupBoxSelfSignedCertificate.PerformLayout();
            this.groupBoxCertificateAuthority.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.groupBoxSAN.ResumeLayout(false);
            this.groupBoxSAN.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage;
        private System.Windows.Forms.GroupBox groupBoxCertificateAuthority;
        private System.Windows.Forms.Button buttonRefreshCertificateAuthorities;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxCertificateAuthorities;
        private System.Windows.Forms.GroupBox groupBoxSelfSignedCertificate;
        private System.Windows.Forms.Button buttonCreateCertificate;
        private System.Windows.Forms.Button buttonRemoveSAN;
        private System.Windows.Forms.Button buttonAddSAN;
        private System.Windows.Forms.TextBox textBoxSAN;
        private System.Windows.Forms.ListBox listBoxSAN;
        private System.Windows.Forms.TextBox textBoxCommonName;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.GroupBox groupBoxSAN;
        private System.Windows.Forms.Label labelCommonName;
    }
}