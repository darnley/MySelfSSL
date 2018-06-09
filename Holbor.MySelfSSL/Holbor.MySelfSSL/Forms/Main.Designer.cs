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
            this.tabIssue = new System.Windows.Forms.TabPage();
            this.groupBoxCertificateAuthority = new System.Windows.Forms.GroupBox();
            this.comboBoxCertificateAuthorities = new System.Windows.Forms.ComboBox();
            this.groupBoxSelfSignedCertificate = new System.Windows.Forms.GroupBox();
            this.groupBoxSAN = new System.Windows.Forms.GroupBox();
            this.textBoxSAN = new System.Windows.Forms.TextBox();
            this.buttonAddSAN = new System.Windows.Forms.Button();
            this.buttonRemoveSAN = new System.Windows.Forms.Button();
            this.listBoxSAN = new System.Windows.Forms.ListBox();
            this.buttonCreateCertificate = new System.Windows.Forms.Button();
            this.textBoxCommonName = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.headMenu = new System.Windows.Forms.MenuStrip();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.headMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tabCertificateAuthority = new System.Windows.Forms.TabPage();
            this.groupBoxCreateCertificateAuthority = new System.Windows.Forms.GroupBox();
            this.textBoxCommonNameCA = new System.Windows.Forms.TextBox();
            this.labelCommonNameCA = new System.Windows.Forms.Label();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.headMenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxSubjectAlternativeNamesCA = new System.Windows.Forms.GroupBox();
            this.textBoxSANCA = new System.Windows.Forms.TextBox();
            this.buttonAddSANCA = new System.Windows.Forms.Button();
            this.buttonRemoveSANCA = new System.Windows.Forms.Button();
            this.listBoxSANCA = new System.Windows.Forms.ListBox();
            this.buttonCreateCertificateCA = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.defaultExportPasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.buttonRefreshCA = new System.Windows.Forms.Button();
            this.checkBoxWildcardToCommonName = new System.Windows.Forms.CheckBox();
            this.groupBoxCommonName = new System.Windows.Forms.GroupBox();
            this.tabIssue.SuspendLayout();
            this.groupBoxCertificateAuthority.SuspendLayout();
            this.groupBoxSelfSignedCertificate.SuspendLayout();
            this.groupBoxSAN.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.headMenu.SuspendLayout();
            this.tabCertificateAuthority.SuspendLayout();
            this.groupBoxCreateCertificateAuthority.SuspendLayout();
            this.groupBoxSubjectAlternativeNamesCA.SuspendLayout();
            this.groupBoxCommonName.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabIssue
            // 
            this.tabIssue.Controls.Add(this.groupBoxCertificateAuthority);
            this.tabIssue.Controls.Add(this.groupBoxSelfSignedCertificate);
            this.tabIssue.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabIssue.Location = new System.Drawing.Point(4, 25);
            this.tabIssue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabIssue.Name = "tabIssue";
            this.tabIssue.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabIssue.Size = new System.Drawing.Size(577, 427);
            this.tabIssue.TabIndex = 0;
            this.tabIssue.Text = "Issue Certificate";
            this.tabIssue.UseVisualStyleBackColor = true;
            // 
            // groupBoxCertificateAuthority
            // 
            this.groupBoxCertificateAuthority.AccessibleName = "Certificate Authority";
            this.groupBoxCertificateAuthority.Controls.Add(this.buttonRefreshCA);
            this.groupBoxCertificateAuthority.Controls.Add(this.comboBoxCertificateAuthorities);
            this.groupBoxCertificateAuthority.Location = new System.Drawing.Point(8, 8);
            this.groupBoxCertificateAuthority.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxCertificateAuthority.Name = "groupBoxCertificateAuthority";
            this.groupBoxCertificateAuthority.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxCertificateAuthority.Size = new System.Drawing.Size(559, 60);
            this.groupBoxCertificateAuthority.TabIndex = 0;
            this.groupBoxCertificateAuthority.TabStop = false;
            this.groupBoxCertificateAuthority.Text = "Certificate Authority (CA)";
            // 
            // comboBoxCertificateAuthorities
            // 
            this.comboBoxCertificateAuthorities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCertificateAuthorities.FormattingEnabled = true;
            this.comboBoxCertificateAuthorities.IntegralHeight = false;
            this.comboBoxCertificateAuthorities.Location = new System.Drawing.Point(8, 23);
            this.comboBoxCertificateAuthorities.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxCertificateAuthorities.Name = "comboBoxCertificateAuthorities";
            this.comboBoxCertificateAuthorities.Size = new System.Drawing.Size(454, 24);
            this.comboBoxCertificateAuthorities.TabIndex = 0;
            this.comboBoxCertificateAuthorities.SelectedIndexChanged += new System.EventHandler(this.CertificateAuthoritySizeChanged);
            this.comboBoxCertificateAuthorities.SizeChanged += new System.EventHandler(this.CertificateAuthoritySizeChanged);
            // 
            // groupBoxSelfSignedCertificate
            // 
            this.groupBoxSelfSignedCertificate.AccessibleName = "Self-Signed Certificate";
            this.groupBoxSelfSignedCertificate.Controls.Add(this.groupBoxCommonName);
            this.groupBoxSelfSignedCertificate.Controls.Add(this.groupBoxSAN);
            this.groupBoxSelfSignedCertificate.Controls.Add(this.buttonCreateCertificate);
            this.groupBoxSelfSignedCertificate.Location = new System.Drawing.Point(8, 76);
            this.groupBoxSelfSignedCertificate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxSelfSignedCertificate.Name = "groupBoxSelfSignedCertificate";
            this.groupBoxSelfSignedCertificate.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxSelfSignedCertificate.Size = new System.Drawing.Size(559, 343);
            this.groupBoxSelfSignedCertificate.TabIndex = 1;
            this.groupBoxSelfSignedCertificate.TabStop = false;
            // 
            // groupBoxSAN
            // 
            this.groupBoxSAN.Controls.Add(this.textBoxSAN);
            this.groupBoxSAN.Controls.Add(this.buttonAddSAN);
            this.groupBoxSAN.Controls.Add(this.buttonRemoveSAN);
            this.groupBoxSAN.Controls.Add(this.listBoxSAN);
            this.groupBoxSAN.Location = new System.Drawing.Point(7, 118);
            this.groupBoxSAN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxSAN.Name = "groupBoxSAN";
            this.groupBoxSAN.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxSAN.Size = new System.Drawing.Size(545, 159);
            this.groupBoxSAN.TabIndex = 8;
            this.groupBoxSAN.TabStop = false;
            this.groupBoxSAN.Text = "Subject Alternative Names (SAN)";
            // 
            // textBoxSAN
            // 
            this.textBoxSAN.Location = new System.Drawing.Point(9, 23);
            this.textBoxSAN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSAN.Name = "textBoxSAN";
            this.textBoxSAN.Size = new System.Drawing.Size(448, 22);
            this.textBoxSAN.TabIndex = 2;
            // 
            // buttonAddSAN
            // 
            this.buttonAddSAN.Location = new System.Drawing.Point(463, 21);
            this.buttonAddSAN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddSAN.Name = "buttonAddSAN";
            this.buttonAddSAN.Size = new System.Drawing.Size(75, 26);
            this.buttonAddSAN.TabIndex = 3;
            this.buttonAddSAN.Text = "Add";
            this.buttonAddSAN.UseVisualStyleBackColor = true;
            this.buttonAddSAN.Click += new System.EventHandler(this.AddSAN);
            // 
            // buttonRemoveSAN
            // 
            this.buttonRemoveSAN.Location = new System.Drawing.Point(463, 53);
            this.buttonRemoveSAN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRemoveSAN.Name = "buttonRemoveSAN";
            this.buttonRemoveSAN.Size = new System.Drawing.Size(75, 100);
            this.buttonRemoveSAN.TabIndex = 5;
            this.buttonRemoveSAN.Text = "Remove";
            this.buttonRemoveSAN.UseVisualStyleBackColor = true;
            this.buttonRemoveSAN.Click += new System.EventHandler(this.RemoveSAN);
            // 
            // listBoxSAN
            // 
            this.listBoxSAN.FormattingEnabled = true;
            this.listBoxSAN.ItemHeight = 16;
            this.listBoxSAN.Location = new System.Drawing.Point(9, 53);
            this.listBoxSAN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxSAN.Name = "listBoxSAN";
            this.listBoxSAN.Size = new System.Drawing.Size(448, 100);
            this.listBoxSAN.TabIndex = 4;
            // 
            // buttonCreateCertificate
            // 
            this.buttonCreateCertificate.Location = new System.Drawing.Point(7, 283);
            this.buttonCreateCertificate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCreateCertificate.Name = "buttonCreateCertificate";
            this.buttonCreateCertificate.Size = new System.Drawing.Size(545, 54);
            this.buttonCreateCertificate.TabIndex = 6;
            this.buttonCreateCertificate.Text = "Create certificate";
            this.buttonCreateCertificate.UseVisualStyleBackColor = true;
            this.buttonCreateCertificate.Click += new System.EventHandler(this.CreateCertificate);
            // 
            // textBoxCommonName
            // 
            this.textBoxCommonName.Location = new System.Drawing.Point(9, 20);
            this.textBoxCommonName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCommonName.Name = "textBoxCommonName";
            this.textBoxCommonName.Size = new System.Drawing.Size(529, 22);
            this.textBoxCommonName.TabIndex = 1;
            this.textBoxCommonName.Text = "MySelfSSL Local Development";
            this.textBoxCommonName.Click += new System.EventHandler(this.OnClickInCommonName);
            this.textBoxCommonName.TextChanged += new System.EventHandler(this.OnTypeInCommonName);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabIssue);
            this.tabControl1.Controls.Add(this.tabCertificateAuthority);
            this.tabControl1.Location = new System.Drawing.Point(13, 32);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(585, 456);
            this.tabControl1.TabIndex = 2;
            // 
            // headMenu
            // 
            this.headMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.headMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.headMenu.Location = new System.Drawing.Point(0, 0);
            this.headMenu.Name = "headMenu";
            this.headMenu.Size = new System.Drawing.Size(609, 28);
            this.headMenu.TabIndex = 3;
            this.headMenu.Text = "menuStrip1";
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.headMenuItemExit});
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.programToolStripMenuItem.Text = "Program";
            // 
            // headMenuItemExit
            // 
            this.headMenuItemExit.Name = "headMenuItemExit";
            this.headMenuItemExit.Size = new System.Drawing.Size(216, 26);
            this.headMenuItemExit.Text = "Exit";
            this.headMenuItemExit.Click += new System.EventHandler(this.Exit);
            // 
            // tabCertificateAuthority
            // 
            this.tabCertificateAuthority.Controls.Add(this.label1);
            this.tabCertificateAuthority.Controls.Add(this.groupBoxCreateCertificateAuthority);
            this.tabCertificateAuthority.Location = new System.Drawing.Point(4, 25);
            this.tabCertificateAuthority.Name = "tabCertificateAuthority";
            this.tabCertificateAuthority.Size = new System.Drawing.Size(577, 427);
            this.tabCertificateAuthority.TabIndex = 1;
            this.tabCertificateAuthority.Text = "Certificate Authorities (CA)";
            this.tabCertificateAuthority.UseVisualStyleBackColor = true;
            // 
            // groupBoxCreateCertificateAuthority
            // 
            this.groupBoxCreateCertificateAuthority.AccessibleName = "Certificate Authority";
            this.groupBoxCreateCertificateAuthority.Controls.Add(this.buttonCreateCertificateCA);
            this.groupBoxCreateCertificateAuthority.Controls.Add(this.groupBoxSubjectAlternativeNamesCA);
            this.groupBoxCreateCertificateAuthority.Controls.Add(this.labelCommonNameCA);
            this.groupBoxCreateCertificateAuthority.Controls.Add(this.textBoxCommonNameCA);
            this.groupBoxCreateCertificateAuthority.Location = new System.Drawing.Point(4, 121);
            this.groupBoxCreateCertificateAuthority.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxCreateCertificateAuthority.Name = "groupBoxCreateCertificateAuthority";
            this.groupBoxCreateCertificateAuthority.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxCreateCertificateAuthority.Size = new System.Drawing.Size(569, 298);
            this.groupBoxCreateCertificateAuthority.TabIndex = 1;
            this.groupBoxCreateCertificateAuthority.TabStop = false;
            this.groupBoxCreateCertificateAuthority.Text = "Create";
            // 
            // textBoxCommonNameCA
            // 
            this.textBoxCommonNameCA.Location = new System.Drawing.Point(8, 41);
            this.textBoxCommonNameCA.Name = "textBoxCommonNameCA";
            this.textBoxCommonNameCA.Size = new System.Drawing.Size(553, 22);
            this.textBoxCommonNameCA.TabIndex = 0;
            this.textBoxCommonNameCA.Text = "Root Development CA";
            this.textBoxCommonNameCA.TextChanged += new System.EventHandler(this.OnTypeInCommonNameCA);
            // 
            // labelCommonNameCA
            // 
            this.labelCommonNameCA.AutoSize = true;
            this.labelCommonNameCA.Location = new System.Drawing.Point(12, 21);
            this.labelCommonNameCA.Name = "labelCommonNameCA";
            this.labelCommonNameCA.Size = new System.Drawing.Size(137, 17);
            this.labelCommonNameCA.TabIndex = 1;
            this.labelCommonNameCA.Text = "Common Name (CN)";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.defaultExportPasswordToolStripMenuItem,
            this.toolStripSeparator1,
            this.headMenuItemAbout});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // headMenuItemAbout
            // 
            this.headMenuItemAbout.Name = "headMenuItemAbout";
            this.headMenuItemAbout.Size = new System.Drawing.Size(247, 26);
            this.headMenuItemAbout.Text = "About";
            this.headMenuItemAbout.Click += new System.EventHandler(this.OpenAboutWindow);
            // 
            // groupBoxSubjectAlternativeNamesCA
            // 
            this.groupBoxSubjectAlternativeNamesCA.Controls.Add(this.textBoxSANCA);
            this.groupBoxSubjectAlternativeNamesCA.Controls.Add(this.buttonAddSANCA);
            this.groupBoxSubjectAlternativeNamesCA.Controls.Add(this.buttonRemoveSANCA);
            this.groupBoxSubjectAlternativeNamesCA.Controls.Add(this.listBoxSANCA);
            this.groupBoxSubjectAlternativeNamesCA.Location = new System.Drawing.Point(8, 70);
            this.groupBoxSubjectAlternativeNamesCA.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxSubjectAlternativeNamesCA.Name = "groupBoxSubjectAlternativeNamesCA";
            this.groupBoxSubjectAlternativeNamesCA.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxSubjectAlternativeNamesCA.Size = new System.Drawing.Size(553, 159);
            this.groupBoxSubjectAlternativeNamesCA.TabIndex = 9;
            this.groupBoxSubjectAlternativeNamesCA.TabStop = false;
            this.groupBoxSubjectAlternativeNamesCA.Text = "Subject Alternative Names (SAN)";
            // 
            // textBoxSANCA
            // 
            this.textBoxSANCA.Location = new System.Drawing.Point(7, 22);
            this.textBoxSANCA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSANCA.Name = "textBoxSANCA";
            this.textBoxSANCA.Size = new System.Drawing.Size(460, 22);
            this.textBoxSANCA.TabIndex = 1;
            // 
            // buttonAddSANCA
            // 
            this.buttonAddSANCA.Location = new System.Drawing.Point(473, 22);
            this.buttonAddSANCA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddSANCA.Name = "buttonAddSANCA";
            this.buttonAddSANCA.Size = new System.Drawing.Size(75, 26);
            this.buttonAddSANCA.TabIndex = 2;
            this.buttonAddSANCA.Text = "Add";
            this.buttonAddSANCA.UseVisualStyleBackColor = true;
            this.buttonAddSANCA.Click += new System.EventHandler(this.AddSANCertificateAuthority);
            // 
            // buttonRemoveSANCA
            // 
            this.buttonRemoveSANCA.Location = new System.Drawing.Point(473, 55);
            this.buttonRemoveSANCA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRemoveSANCA.Name = "buttonRemoveSANCA";
            this.buttonRemoveSANCA.Size = new System.Drawing.Size(75, 98);
            this.buttonRemoveSANCA.TabIndex = 4;
            this.buttonRemoveSANCA.Text = "Remove";
            this.buttonRemoveSANCA.UseVisualStyleBackColor = true;
            this.buttonRemoveSANCA.Click += new System.EventHandler(this.RemoveSANCertificateAuthority);
            // 
            // listBoxSANCA
            // 
            this.listBoxSANCA.FormattingEnabled = true;
            this.listBoxSANCA.ItemHeight = 16;
            this.listBoxSANCA.Location = new System.Drawing.Point(7, 53);
            this.listBoxSANCA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxSANCA.Name = "listBoxSANCA";
            this.listBoxSANCA.Size = new System.Drawing.Size(460, 100);
            this.listBoxSANCA.TabIndex = 3;
            // 
            // buttonCreateCertificateCA
            // 
            this.buttonCreateCertificateCA.Location = new System.Drawing.Point(8, 235);
            this.buttonCreateCertificateCA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCreateCertificateCA.Name = "buttonCreateCertificateCA";
            this.buttonCreateCertificateCA.Size = new System.Drawing.Size(553, 54);
            this.buttonCreateCertificateCA.TabIndex = 10;
            this.buttonCreateCertificateCA.Text = "Create certificate";
            this.buttonCreateCertificateCA.UseVisualStyleBackColor = true;
            this.buttonCreateCertificateCA.Click += new System.EventHandler(this.CreateCertificateAuthority);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(5, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(568, 106);
            this.label1.TabIndex = 2;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // defaultExportPasswordToolStripMenuItem
            // 
            this.defaultExportPasswordToolStripMenuItem.Name = "defaultExportPasswordToolStripMenuItem";
            this.defaultExportPasswordToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.defaultExportPasswordToolStripMenuItem.Text = "Default Export password";
            this.defaultExportPasswordToolStripMenuItem.Click += new System.EventHandler(this.ShowDefaultPasswordInMessageBox);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(244, 6);
            // 
            // buttonRefreshCA
            // 
            this.buttonRefreshCA.Location = new System.Drawing.Point(468, 23);
            this.buttonRefreshCA.Name = "buttonRefreshCA";
            this.buttonRefreshCA.Size = new System.Drawing.Size(84, 24);
            this.buttonRefreshCA.TabIndex = 1;
            this.buttonRefreshCA.Text = "Refresh";
            this.buttonRefreshCA.UseVisualStyleBackColor = true;
            this.buttonRefreshCA.Click += new System.EventHandler(this.RefreshCertificateAuthorities);
            // 
            // checkBoxWildcardToCommonName
            // 
            this.checkBoxWildcardToCommonName.AutoSize = true;
            this.checkBoxWildcardToCommonName.Checked = true;
            this.checkBoxWildcardToCommonName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxWildcardToCommonName.Location = new System.Drawing.Point(9, 47);
            this.checkBoxWildcardToCommonName.Name = "checkBoxWildcardToCommonName";
            this.checkBoxWildcardToCommonName.Size = new System.Drawing.Size(333, 21);
            this.checkBoxWildcardToCommonName.TabIndex = 10;
            this.checkBoxWildcardToCommonName.Text = "Add wildcard to Common Name (required for IIS)";
            this.checkBoxWildcardToCommonName.UseVisualStyleBackColor = true;
            // 
            // groupBoxCommonName
            // 
            this.groupBoxCommonName.Controls.Add(this.textBoxCommonName);
            this.groupBoxCommonName.Controls.Add(this.checkBoxWildcardToCommonName);
            this.groupBoxCommonName.Location = new System.Drawing.Point(7, 22);
            this.groupBoxCommonName.Name = "groupBoxCommonName";
            this.groupBoxCommonName.Size = new System.Drawing.Size(545, 89);
            this.groupBoxCommonName.TabIndex = 11;
            this.groupBoxCommonName.TabStop = false;
            this.groupBoxCommonName.Text = "Common Name (CA)";
            // 
            // Main
            // 
            this.AccessibleDescription = "Create Self-Signed Certificates";
            this.AccessibleName = "MySelfSSL";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 492);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.headMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MySelfSSL";
            this.Load += new System.EventHandler(this.Init);
            this.tabIssue.ResumeLayout(false);
            this.groupBoxCertificateAuthority.ResumeLayout(false);
            this.groupBoxSelfSignedCertificate.ResumeLayout(false);
            this.groupBoxSAN.ResumeLayout(false);
            this.groupBoxSAN.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.headMenu.ResumeLayout(false);
            this.headMenu.PerformLayout();
            this.tabCertificateAuthority.ResumeLayout(false);
            this.groupBoxCreateCertificateAuthority.ResumeLayout(false);
            this.groupBoxCreateCertificateAuthority.PerformLayout();
            this.groupBoxSubjectAlternativeNamesCA.ResumeLayout(false);
            this.groupBoxSubjectAlternativeNamesCA.PerformLayout();
            this.groupBoxCommonName.ResumeLayout(false);
            this.groupBoxCommonName.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabPage tabIssue;
        private System.Windows.Forms.GroupBox groupBoxCertificateAuthority;
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
        private System.Windows.Forms.MenuStrip headMenu;
        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem headMenuItemExit;
        private System.Windows.Forms.TabPage tabCertificateAuthority;
        private System.Windows.Forms.GroupBox groupBoxCreateCertificateAuthority;
        private System.Windows.Forms.Label labelCommonNameCA;
        private System.Windows.Forms.TextBox textBoxCommonNameCA;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem headMenuItemAbout;
        private System.Windows.Forms.GroupBox groupBoxSubjectAlternativeNamesCA;
        private System.Windows.Forms.TextBox textBoxSANCA;
        private System.Windows.Forms.Button buttonAddSANCA;
        private System.Windows.Forms.Button buttonRemoveSANCA;
        private System.Windows.Forms.ListBox listBoxSANCA;
        private System.Windows.Forms.Button buttonCreateCertificateCA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem defaultExportPasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Button buttonRefreshCA;
        private System.Windows.Forms.GroupBox groupBoxCommonName;
        private System.Windows.Forms.CheckBox checkBoxWildcardToCommonName;
    }
}