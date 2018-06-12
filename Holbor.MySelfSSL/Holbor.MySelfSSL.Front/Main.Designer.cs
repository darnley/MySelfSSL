namespace Holbor.MySelfSSL.Front
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tabIssue = new System.Windows.Forms.TabPage();
            this.groupBoxCertificateAuthority = new System.Windows.Forms.GroupBox();
            this.buttonDeleteCA = new System.Windows.Forms.Button();
            this.buttonShowInformationCA = new System.Windows.Forms.Button();
            this.buttonRefreshCA = new System.Windows.Forms.Button();
            this.comboBoxCertificateAuthorities = new System.Windows.Forms.ComboBox();
            this.groupBoxSelfSignedCertificate = new System.Windows.Forms.GroupBox();
            this.groupBoxCommonName = new System.Windows.Forms.GroupBox();
            this.textBoxCommonName = new System.Windows.Forms.TextBox();
            this.checkBoxWildcardToCommonName = new System.Windows.Forms.CheckBox();
            this.groupBoxSAN = new System.Windows.Forms.GroupBox();
            this.textBoxSAN = new System.Windows.Forms.TextBox();
            this.buttonAddSAN = new System.Windows.Forms.Button();
            this.buttonRemoveSAN = new System.Windows.Forms.Button();
            this.listBoxSAN = new System.Windows.Forms.ListBox();
            this.buttonCreateCertificate = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCertificateAuthority = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxCreateCertificateAuthority = new System.Windows.Forms.GroupBox();
            this.buttonCreateCertificateCA = new System.Windows.Forms.Button();
            this.groupBoxSubjectAlternativeNamesCA = new System.Windows.Forms.GroupBox();
            this.textBoxSANCA = new System.Windows.Forms.TextBox();
            this.buttonAddSANCA = new System.Windows.Forms.Button();
            this.buttonRemoveSANCA = new System.Windows.Forms.Button();
            this.listBoxSANCA = new System.Windows.Forms.ListBox();
            this.labelCommonNameCA = new System.Windows.Forms.Label();
            this.textBoxCommonNameCA = new System.Windows.Forms.TextBox();
            this.headMenu = new System.Windows.Forms.MenuStrip();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.headMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultExportPasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.headMenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTipHelp = new System.Windows.Forms.ToolTip(this.components);
            this.tabCertificate = new System.Windows.Forms.TabPage();
            this.tabIssue.SuspendLayout();
            this.groupBoxCertificateAuthority.SuspendLayout();
            this.groupBoxSelfSignedCertificate.SuspendLayout();
            this.groupBoxCommonName.SuspendLayout();
            this.groupBoxSAN.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabCertificateAuthority.SuspendLayout();
            this.groupBoxCreateCertificateAuthority.SuspendLayout();
            this.groupBoxSubjectAlternativeNamesCA.SuspendLayout();
            this.headMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabIssue
            // 
            this.tabIssue.Controls.Add(this.groupBoxCertificateAuthority);
            this.tabIssue.Controls.Add(this.groupBoxSelfSignedCertificate);
            this.tabIssue.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabIssue.Location = new System.Drawing.Point(4, 22);
            this.tabIssue.Name = "tabIssue";
            this.tabIssue.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabIssue.Size = new System.Drawing.Size(431, 344);
            this.tabIssue.TabIndex = 0;
            this.tabIssue.Text = "Issue Certificate";
            this.tabIssue.UseVisualStyleBackColor = true;
            // 
            // groupBoxCertificateAuthority
            // 
            this.groupBoxCertificateAuthority.AccessibleName = "Certificate Authority";
            this.groupBoxCertificateAuthority.Controls.Add(this.buttonDeleteCA);
            this.groupBoxCertificateAuthority.Controls.Add(this.buttonShowInformationCA);
            this.groupBoxCertificateAuthority.Controls.Add(this.buttonRefreshCA);
            this.groupBoxCertificateAuthority.Controls.Add(this.comboBoxCertificateAuthorities);
            this.groupBoxCertificateAuthority.Location = new System.Drawing.Point(6, 6);
            this.groupBoxCertificateAuthority.Name = "groupBoxCertificateAuthority";
            this.groupBoxCertificateAuthority.Size = new System.Drawing.Size(419, 49);
            this.groupBoxCertificateAuthority.TabIndex = 0;
            this.groupBoxCertificateAuthority.TabStop = false;
            this.groupBoxCertificateAuthority.Text = "Certificate Authority (CA)";
            // 
            // buttonDeleteCA
            // 
            this.buttonDeleteCA.ForeColor = System.Drawing.Color.Red;
            this.buttonDeleteCA.Location = new System.Drawing.Point(358, 18);
            this.buttonDeleteCA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDeleteCA.Name = "buttonDeleteCA";
            this.buttonDeleteCA.Size = new System.Drawing.Size(56, 20);
            this.buttonDeleteCA.TabIndex = 3;
            this.buttonDeleteCA.Text = "Delete";
            this.buttonDeleteCA.UseVisualStyleBackColor = true;
            this.buttonDeleteCA.Click += new System.EventHandler(this.DeleteSelectedCA);
            // 
            // buttonShowInformationCA
            // 
            this.buttonShowInformationCA.Location = new System.Drawing.Point(237, 18);
            this.buttonShowInformationCA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonShowInformationCA.Name = "buttonShowInformationCA";
            this.buttonShowInformationCA.Size = new System.Drawing.Size(56, 20);
            this.buttonShowInformationCA.TabIndex = 2;
            this.buttonShowInformationCA.Text = "Info";
            this.buttonShowInformationCA.UseVisualStyleBackColor = true;
            this.buttonShowInformationCA.Click += new System.EventHandler(this.ShowInformationAboutSelectedCA);
            // 
            // buttonRefreshCA
            // 
            this.buttonRefreshCA.Location = new System.Drawing.Point(298, 18);
            this.buttonRefreshCA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonRefreshCA.Name = "buttonRefreshCA";
            this.buttonRefreshCA.Size = new System.Drawing.Size(56, 20);
            this.buttonRefreshCA.TabIndex = 1;
            this.buttonRefreshCA.Text = "Refresh";
            this.toolTipHelp.SetToolTip(this.buttonRefreshCA, "Update the list of Certificate Authorities.");
            this.buttonRefreshCA.UseVisualStyleBackColor = true;
            this.buttonRefreshCA.Click += new System.EventHandler(this.RefreshCertificateAuthorities);
            // 
            // comboBoxCertificateAuthorities
            // 
            this.comboBoxCertificateAuthorities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCertificateAuthorities.FormattingEnabled = true;
            this.comboBoxCertificateAuthorities.IntegralHeight = false;
            this.comboBoxCertificateAuthorities.Location = new System.Drawing.Point(6, 19);
            this.comboBoxCertificateAuthorities.Name = "comboBoxCertificateAuthorities";
            this.comboBoxCertificateAuthorities.Size = new System.Drawing.Size(227, 21);
            this.comboBoxCertificateAuthorities.TabIndex = 0;
            this.comboBoxCertificateAuthorities.SizeChanged += new System.EventHandler(this.CertificateAuthoritySizeChanged);
            // 
            // groupBoxSelfSignedCertificate
            // 
            this.groupBoxSelfSignedCertificate.AccessibleName = "Self-Signed Certificate";
            this.groupBoxSelfSignedCertificate.Controls.Add(this.groupBoxCommonName);
            this.groupBoxSelfSignedCertificate.Controls.Add(this.groupBoxSAN);
            this.groupBoxSelfSignedCertificate.Controls.Add(this.buttonCreateCertificate);
            this.groupBoxSelfSignedCertificate.Location = new System.Drawing.Point(6, 62);
            this.groupBoxSelfSignedCertificate.Name = "groupBoxSelfSignedCertificate";
            this.groupBoxSelfSignedCertificate.Size = new System.Drawing.Size(419, 279);
            this.groupBoxSelfSignedCertificate.TabIndex = 1;
            this.groupBoxSelfSignedCertificate.TabStop = false;
            // 
            // groupBoxCommonName
            // 
            this.groupBoxCommonName.Controls.Add(this.textBoxCommonName);
            this.groupBoxCommonName.Controls.Add(this.checkBoxWildcardToCommonName);
            this.groupBoxCommonName.Location = new System.Drawing.Point(5, 18);
            this.groupBoxCommonName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxCommonName.Name = "groupBoxCommonName";
            this.groupBoxCommonName.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxCommonName.Size = new System.Drawing.Size(409, 72);
            this.groupBoxCommonName.TabIndex = 11;
            this.groupBoxCommonName.TabStop = false;
            this.groupBoxCommonName.Text = "Common Name (CA)";
            // 
            // textBoxCommonName
            // 
            this.textBoxCommonName.Location = new System.Drawing.Point(7, 16);
            this.textBoxCommonName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxCommonName.Name = "textBoxCommonName";
            this.textBoxCommonName.Size = new System.Drawing.Size(398, 20);
            this.textBoxCommonName.TabIndex = 1;
            this.textBoxCommonName.Text = "MySelfSSL Local Development";
            this.textBoxCommonName.Click += new System.EventHandler(this.OnClickInCommonName);
            this.textBoxCommonName.TextChanged += new System.EventHandler(this.OnTypeInCommonName);
            // 
            // checkBoxWildcardToCommonName
            // 
            this.checkBoxWildcardToCommonName.AutoSize = true;
            this.checkBoxWildcardToCommonName.Checked = true;
            this.checkBoxWildcardToCommonName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxWildcardToCommonName.Location = new System.Drawing.Point(7, 38);
            this.checkBoxWildcardToCommonName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxWildcardToCommonName.Name = "checkBoxWildcardToCommonName";
            this.checkBoxWildcardToCommonName.Size = new System.Drawing.Size(252, 17);
            this.checkBoxWildcardToCommonName.TabIndex = 10;
            this.checkBoxWildcardToCommonName.Text = "Add wildcard to Common Name (required for IIS)";
            this.toolTipHelp.SetToolTip(this.checkBoxWildcardToCommonName, "This will add an asterisk in front of the Common Name (CN). This is recommended w" +
        "hen you are using IIS.");
            this.checkBoxWildcardToCommonName.UseVisualStyleBackColor = true;
            // 
            // groupBoxSAN
            // 
            this.groupBoxSAN.Controls.Add(this.textBoxSAN);
            this.groupBoxSAN.Controls.Add(this.buttonAddSAN);
            this.groupBoxSAN.Controls.Add(this.buttonRemoveSAN);
            this.groupBoxSAN.Controls.Add(this.listBoxSAN);
            this.groupBoxSAN.Location = new System.Drawing.Point(5, 96);
            this.groupBoxSAN.Name = "groupBoxSAN";
            this.groupBoxSAN.Size = new System.Drawing.Size(409, 129);
            this.groupBoxSAN.TabIndex = 8;
            this.groupBoxSAN.TabStop = false;
            this.groupBoxSAN.Text = "Subject Alternative Names (SAN)";
            // 
            // textBoxSAN
            // 
            this.textBoxSAN.Location = new System.Drawing.Point(7, 19);
            this.textBoxSAN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxSAN.Name = "textBoxSAN";
            this.textBoxSAN.Size = new System.Drawing.Size(337, 20);
            this.textBoxSAN.TabIndex = 2;
            this.textBoxSAN.TextChanged += new System.EventHandler(this.OnTypeInSAN);
            // 
            // buttonAddSAN
            // 
            this.buttonAddSAN.Enabled = false;
            this.buttonAddSAN.Location = new System.Drawing.Point(347, 17);
            this.buttonAddSAN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAddSAN.Name = "buttonAddSAN";
            this.buttonAddSAN.Size = new System.Drawing.Size(56, 21);
            this.buttonAddSAN.TabIndex = 3;
            this.buttonAddSAN.Text = "Add";
            this.toolTipHelp.SetToolTip(this.buttonAddSAN, "Add a new Subject Alternative Name (SAN) to the certificate to be created.");
            this.buttonAddSAN.UseVisualStyleBackColor = true;
            this.buttonAddSAN.Click += new System.EventHandler(this.AddSAN);
            // 
            // buttonRemoveSAN
            // 
            this.buttonRemoveSAN.Enabled = false;
            this.buttonRemoveSAN.Location = new System.Drawing.Point(347, 43);
            this.buttonRemoveSAN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonRemoveSAN.Name = "buttonRemoveSAN";
            this.buttonRemoveSAN.Size = new System.Drawing.Size(56, 81);
            this.buttonRemoveSAN.TabIndex = 5;
            this.buttonRemoveSAN.Text = "Remove";
            this.toolTipHelp.SetToolTip(this.buttonRemoveSAN, "Remove the selected Subject Alternative Name (SAN) from the list on the left side" +
        ".");
            this.buttonRemoveSAN.UseVisualStyleBackColor = true;
            this.buttonRemoveSAN.Click += new System.EventHandler(this.RemoveSAN);
            // 
            // listBoxSAN
            // 
            this.listBoxSAN.FormattingEnabled = true;
            this.listBoxSAN.Location = new System.Drawing.Point(7, 43);
            this.listBoxSAN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxSAN.Name = "listBoxSAN";
            this.listBoxSAN.Size = new System.Drawing.Size(337, 82);
            this.listBoxSAN.TabIndex = 4;
            this.listBoxSAN.Click += new System.EventHandler(this.OnClickInASAN);
            // 
            // buttonCreateCertificate
            // 
            this.buttonCreateCertificate.Location = new System.Drawing.Point(5, 230);
            this.buttonCreateCertificate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCreateCertificate.Name = "buttonCreateCertificate";
            this.buttonCreateCertificate.Size = new System.Drawing.Size(409, 44);
            this.buttonCreateCertificate.TabIndex = 6;
            this.buttonCreateCertificate.Text = "Create certificate";
            this.buttonCreateCertificate.UseVisualStyleBackColor = true;
            this.buttonCreateCertificate.Click += new System.EventHandler(this.CreateCertificate);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabIssue);
            this.tabControl1.Controls.Add(this.tabCertificate);
            this.tabControl1.Controls.Add(this.tabCertificateAuthority);
            this.tabControl1.Location = new System.Drawing.Point(10, 26);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(439, 370);
            this.tabControl1.TabIndex = 2;
            // 
            // tabCertificateAuthority
            // 
            this.tabCertificateAuthority.Controls.Add(this.label1);
            this.tabCertificateAuthority.Controls.Add(this.groupBoxCreateCertificateAuthority);
            this.tabCertificateAuthority.Location = new System.Drawing.Point(4, 22);
            this.tabCertificateAuthority.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabCertificateAuthority.Name = "tabCertificateAuthority";
            this.tabCertificateAuthority.Size = new System.Drawing.Size(431, 344);
            this.tabCertificateAuthority.TabIndex = 1;
            this.tabCertificateAuthority.Text = "Certificate Authorities (CA)";
            this.tabCertificateAuthority.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(426, 86);
            this.label1.TabIndex = 2;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // groupBoxCreateCertificateAuthority
            // 
            this.groupBoxCreateCertificateAuthority.AccessibleName = "Certificate Authority";
            this.groupBoxCreateCertificateAuthority.Controls.Add(this.buttonCreateCertificateCA);
            this.groupBoxCreateCertificateAuthority.Controls.Add(this.groupBoxSubjectAlternativeNamesCA);
            this.groupBoxCreateCertificateAuthority.Controls.Add(this.labelCommonNameCA);
            this.groupBoxCreateCertificateAuthority.Controls.Add(this.textBoxCommonNameCA);
            this.groupBoxCreateCertificateAuthority.Location = new System.Drawing.Point(3, 98);
            this.groupBoxCreateCertificateAuthority.Name = "groupBoxCreateCertificateAuthority";
            this.groupBoxCreateCertificateAuthority.Size = new System.Drawing.Size(427, 242);
            this.groupBoxCreateCertificateAuthority.TabIndex = 1;
            this.groupBoxCreateCertificateAuthority.TabStop = false;
            this.groupBoxCreateCertificateAuthority.Text = "Create";
            // 
            // buttonCreateCertificateCA
            // 
            this.buttonCreateCertificateCA.Location = new System.Drawing.Point(6, 191);
            this.buttonCreateCertificateCA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCreateCertificateCA.Name = "buttonCreateCertificateCA";
            this.buttonCreateCertificateCA.Size = new System.Drawing.Size(415, 44);
            this.buttonCreateCertificateCA.TabIndex = 10;
            this.buttonCreateCertificateCA.Text = "Create certificate";
            this.buttonCreateCertificateCA.UseVisualStyleBackColor = true;
            this.buttonCreateCertificateCA.Click += new System.EventHandler(this.CreateCertificateAuthority);
            // 
            // groupBoxSubjectAlternativeNamesCA
            // 
            this.groupBoxSubjectAlternativeNamesCA.Controls.Add(this.textBoxSANCA);
            this.groupBoxSubjectAlternativeNamesCA.Controls.Add(this.buttonAddSANCA);
            this.groupBoxSubjectAlternativeNamesCA.Controls.Add(this.buttonRemoveSANCA);
            this.groupBoxSubjectAlternativeNamesCA.Controls.Add(this.listBoxSANCA);
            this.groupBoxSubjectAlternativeNamesCA.Location = new System.Drawing.Point(6, 57);
            this.groupBoxSubjectAlternativeNamesCA.Name = "groupBoxSubjectAlternativeNamesCA";
            this.groupBoxSubjectAlternativeNamesCA.Size = new System.Drawing.Size(415, 129);
            this.groupBoxSubjectAlternativeNamesCA.TabIndex = 9;
            this.groupBoxSubjectAlternativeNamesCA.TabStop = false;
            this.groupBoxSubjectAlternativeNamesCA.Text = "Subject Alternative Names (SAN)";
            // 
            // textBoxSANCA
            // 
            this.textBoxSANCA.Location = new System.Drawing.Point(5, 18);
            this.textBoxSANCA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxSANCA.Name = "textBoxSANCA";
            this.textBoxSANCA.Size = new System.Drawing.Size(346, 20);
            this.textBoxSANCA.TabIndex = 1;
            this.textBoxSANCA.TextChanged += new System.EventHandler(this.OnTypeInSANCA);
            // 
            // buttonAddSANCA
            // 
            this.buttonAddSANCA.Enabled = false;
            this.buttonAddSANCA.Location = new System.Drawing.Point(355, 18);
            this.buttonAddSANCA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAddSANCA.Name = "buttonAddSANCA";
            this.buttonAddSANCA.Size = new System.Drawing.Size(56, 21);
            this.buttonAddSANCA.TabIndex = 2;
            this.buttonAddSANCA.Text = "Add";
            this.buttonAddSANCA.UseVisualStyleBackColor = true;
            this.buttonAddSANCA.Click += new System.EventHandler(this.AddSANCertificateAuthority);
            // 
            // buttonRemoveSANCA
            // 
            this.buttonRemoveSANCA.Enabled = false;
            this.buttonRemoveSANCA.Location = new System.Drawing.Point(355, 45);
            this.buttonRemoveSANCA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonRemoveSANCA.Name = "buttonRemoveSANCA";
            this.buttonRemoveSANCA.Size = new System.Drawing.Size(56, 80);
            this.buttonRemoveSANCA.TabIndex = 4;
            this.buttonRemoveSANCA.Text = "Remove";
            this.buttonRemoveSANCA.UseVisualStyleBackColor = true;
            this.buttonRemoveSANCA.Click += new System.EventHandler(this.RemoveSANCertificateAuthority);
            // 
            // listBoxSANCA
            // 
            this.listBoxSANCA.FormattingEnabled = true;
            this.listBoxSANCA.Location = new System.Drawing.Point(5, 43);
            this.listBoxSANCA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxSANCA.Name = "listBoxSANCA";
            this.listBoxSANCA.Size = new System.Drawing.Size(346, 82);
            this.listBoxSANCA.TabIndex = 3;
            this.listBoxSANCA.Click += new System.EventHandler(this.OnClickInASANCA);
            // 
            // labelCommonNameCA
            // 
            this.labelCommonNameCA.AutoSize = true;
            this.labelCommonNameCA.Location = new System.Drawing.Point(9, 17);
            this.labelCommonNameCA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCommonNameCA.Name = "labelCommonNameCA";
            this.labelCommonNameCA.Size = new System.Drawing.Size(103, 13);
            this.labelCommonNameCA.TabIndex = 1;
            this.labelCommonNameCA.Text = "Common Name (CN)";
            // 
            // textBoxCommonNameCA
            // 
            this.textBoxCommonNameCA.Location = new System.Drawing.Point(6, 33);
            this.textBoxCommonNameCA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxCommonNameCA.Name = "textBoxCommonNameCA";
            this.textBoxCommonNameCA.Size = new System.Drawing.Size(416, 20);
            this.textBoxCommonNameCA.TabIndex = 0;
            this.textBoxCommonNameCA.Text = "Root Development CA";
            this.textBoxCommonNameCA.TextChanged += new System.EventHandler(this.OnTypeInCommonNameCA);
            // 
            // headMenu
            // 
            this.headMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.headMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.headMenu.Location = new System.Drawing.Point(0, 0);
            this.headMenu.Name = "headMenu";
            this.headMenu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.headMenu.Size = new System.Drawing.Size(457, 24);
            this.headMenu.TabIndex = 3;
            this.headMenu.Text = "menuStrip1";
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.headMenuItemExit});
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.programToolStripMenuItem.Text = "Program";
            // 
            // headMenuItemExit
            // 
            this.headMenuItemExit.Name = "headMenuItemExit";
            this.headMenuItemExit.Size = new System.Drawing.Size(92, 22);
            this.headMenuItemExit.Text = "Exit";
            this.headMenuItemExit.Click += new System.EventHandler(this.Exit);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.defaultExportPasswordToolStripMenuItem,
            this.toolStripSeparator1,
            this.headMenuItemAbout});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // defaultExportPasswordToolStripMenuItem
            // 
            this.defaultExportPasswordToolStripMenuItem.Name = "defaultExportPasswordToolStripMenuItem";
            this.defaultExportPasswordToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.defaultExportPasswordToolStripMenuItem.Text = "Default Export password";
            this.defaultExportPasswordToolStripMenuItem.Click += new System.EventHandler(this.ShowDefaultPasswordInMessageBox);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(190, 6);
            // 
            // headMenuItemAbout
            // 
            this.headMenuItemAbout.Name = "headMenuItemAbout";
            this.headMenuItemAbout.Size = new System.Drawing.Size(193, 22);
            this.headMenuItemAbout.Text = "About";
            this.headMenuItemAbout.Click += new System.EventHandler(this.OpenAboutWindow);
            // 
            // toolTipHelp
            // 
            this.toolTipHelp.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipHelp.ToolTipTitle = "Field help";
            // 
            // tabCertificate
            // 
            this.tabCertificate.Location = new System.Drawing.Point(4, 22);
            this.tabCertificate.Name = "tabCertificate";
            this.tabCertificate.Padding = new System.Windows.Forms.Padding(3);
            this.tabCertificate.Size = new System.Drawing.Size(431, 344);
            this.tabCertificate.TabIndex = 2;
            this.tabCertificate.Text = "Certificates";
            this.tabCertificate.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AccessibleDescription = "Create Self-Signed Certificates";
            this.AccessibleName = "MySelfSSL";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 400);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.headMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MySelfSSL";
            this.Load += new System.EventHandler(this.Init);
            this.tabIssue.ResumeLayout(false);
            this.groupBoxCertificateAuthority.ResumeLayout(false);
            this.groupBoxSelfSignedCertificate.ResumeLayout(false);
            this.groupBoxCommonName.ResumeLayout(false);
            this.groupBoxCommonName.PerformLayout();
            this.groupBoxSAN.ResumeLayout(false);
            this.groupBoxSAN.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabCertificateAuthority.ResumeLayout(false);
            this.groupBoxCreateCertificateAuthority.ResumeLayout(false);
            this.groupBoxCreateCertificateAuthority.PerformLayout();
            this.groupBoxSubjectAlternativeNamesCA.ResumeLayout(false);
            this.groupBoxSubjectAlternativeNamesCA.PerformLayout();
            this.headMenu.ResumeLayout(false);
            this.headMenu.PerformLayout();
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
        private System.Windows.Forms.ToolTip toolTipHelp;
        private System.Windows.Forms.Button buttonShowInformationCA;
        private System.Windows.Forms.Button buttonDeleteCA;
        private System.Windows.Forms.TabPage tabCertificate;
    }
}