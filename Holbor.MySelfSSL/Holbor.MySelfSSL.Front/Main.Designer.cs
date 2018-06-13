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
            this.buttonShowInformationCA = new System.Windows.Forms.Button();
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
            this.tabClientCertificate = new System.Windows.Forms.TabPage();
            this.groupBoxManageCertificateAuthorities = new System.Windows.Forms.GroupBox();
            this.listBoxExistentCertificateAuthorities = new System.Windows.Forms.ListBox();
            this.buttonExistentCertificateAuthoritiesInfo = new System.Windows.Forms.Button();
            this.buttonExistentCertificateAuthoritiesDelete = new System.Windows.Forms.Button();
            this.buttonExistentCertificateAuthoritiesRefresh = new System.Windows.Forms.Button();
            this.groupBoxManageClientCertificate = new System.Windows.Forms.GroupBox();
            this.listBoxExistentClientCertificates = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonExistentClientCertificateInfo = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonExistentClientCertificateRefresh = new System.Windows.Forms.Button();
            this.buttonExistentClientCertificateDelete = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
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
            this.tabClientCertificate.SuspendLayout();
            this.groupBoxManageCertificateAuthorities.SuspendLayout();
            this.groupBoxManageClientCertificate.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabIssue
            // 
            this.tabIssue.Controls.Add(this.tableLayoutPanel5);
            this.tabIssue.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabIssue.Location = new System.Drawing.Point(4, 22);
            this.tabIssue.Name = "tabIssue";
            this.tabIssue.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabIssue.Size = new System.Drawing.Size(431, 361);
            this.tabIssue.TabIndex = 0;
            this.tabIssue.Text = "Issue Certificate";
            this.tabIssue.UseVisualStyleBackColor = true;
            // 
            // groupBoxCertificateAuthority
            // 
            this.groupBoxCertificateAuthority.AccessibleName = "Certificate Authority";
            this.groupBoxCertificateAuthority.Controls.Add(this.tableLayoutPanel3);
            this.groupBoxCertificateAuthority.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxCertificateAuthority.Location = new System.Drawing.Point(3, 3);
            this.groupBoxCertificateAuthority.Name = "groupBoxCertificateAuthority";
            this.groupBoxCertificateAuthority.Size = new System.Drawing.Size(413, 57);
            this.groupBoxCertificateAuthority.TabIndex = 0;
            this.groupBoxCertificateAuthority.TabStop = false;
            this.groupBoxCertificateAuthority.Text = "Certificate Authority (CA)";
            // 
            // buttonShowInformationCA
            // 
            this.buttonShowInformationCA.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonShowInformationCA.Location = new System.Drawing.Point(322, 2);
            this.buttonShowInformationCA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonShowInformationCA.Name = "buttonShowInformationCA";
            this.buttonShowInformationCA.Size = new System.Drawing.Size(77, 22);
            this.buttonShowInformationCA.TabIndex = 2;
            this.buttonShowInformationCA.Text = "Info";
            this.buttonShowInformationCA.UseVisualStyleBackColor = true;
            this.buttonShowInformationCA.Click += new System.EventHandler(this.ShowInformationAboutSelectedCA);
            // 
            // comboBoxCertificateAuthorities
            // 
            this.comboBoxCertificateAuthorities.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBoxCertificateAuthorities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCertificateAuthorities.FormattingEnabled = true;
            this.comboBoxCertificateAuthorities.IntegralHeight = false;
            this.comboBoxCertificateAuthorities.Location = new System.Drawing.Point(3, 3);
            this.comboBoxCertificateAuthorities.Name = "comboBoxCertificateAuthorities";
            this.comboBoxCertificateAuthorities.Size = new System.Drawing.Size(314, 21);
            this.comboBoxCertificateAuthorities.TabIndex = 0;
            this.comboBoxCertificateAuthorities.SizeChanged += new System.EventHandler(this.CertificateAuthoritySizeChanged);
            // 
            // groupBoxSelfSignedCertificate
            // 
            this.groupBoxSelfSignedCertificate.AccessibleName = "Self-Signed Certificate";
            this.groupBoxSelfSignedCertificate.Controls.Add(this.tableLayoutPanel6);
            this.groupBoxSelfSignedCertificate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxSelfSignedCertificate.Location = new System.Drawing.Point(3, 66);
            this.groupBoxSelfSignedCertificate.Name = "groupBoxSelfSignedCertificate";
            this.groupBoxSelfSignedCertificate.Size = new System.Drawing.Size(413, 280);
            this.groupBoxSelfSignedCertificate.TabIndex = 1;
            this.groupBoxSelfSignedCertificate.TabStop = false;
            // 
            // groupBoxCommonName
            // 
            this.groupBoxCommonName.Controls.Add(this.tableLayoutPanel4);
            this.groupBoxCommonName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxCommonName.Location = new System.Drawing.Point(2, 2);
            this.groupBoxCommonName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxCommonName.Name = "groupBoxCommonName";
            this.groupBoxCommonName.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxCommonName.Size = new System.Drawing.Size(397, 74);
            this.groupBoxCommonName.TabIndex = 11;
            this.groupBoxCommonName.TabStop = false;
            this.groupBoxCommonName.Text = "Common Name (CA)";
            // 
            // textBoxCommonName
            // 
            this.textBoxCommonName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCommonName.Location = new System.Drawing.Point(2, 2);
            this.textBoxCommonName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxCommonName.Name = "textBoxCommonName";
            this.textBoxCommonName.Size = new System.Drawing.Size(383, 20);
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
            this.checkBoxWildcardToCommonName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxWildcardToCommonName.Location = new System.Drawing.Point(2, 26);
            this.checkBoxWildcardToCommonName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxWildcardToCommonName.Name = "checkBoxWildcardToCommonName";
            this.checkBoxWildcardToCommonName.Size = new System.Drawing.Size(383, 21);
            this.checkBoxWildcardToCommonName.TabIndex = 10;
            this.checkBoxWildcardToCommonName.Text = "Add wildcard to Common Name (required for IIS)";
            this.toolTipHelp.SetToolTip(this.checkBoxWildcardToCommonName, "This will add an asterisk in front of the Common Name (CN). This is recommended w" +
        "hen you are using IIS.");
            this.checkBoxWildcardToCommonName.UseVisualStyleBackColor = true;
            // 
            // groupBoxSAN
            // 
            this.groupBoxSAN.Controls.Add(this.tableLayoutPanel7);
            this.groupBoxSAN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxSAN.Location = new System.Drawing.Point(3, 81);
            this.groupBoxSAN.Name = "groupBoxSAN";
            this.groupBoxSAN.Size = new System.Drawing.Size(395, 114);
            this.groupBoxSAN.TabIndex = 8;
            this.groupBoxSAN.TabStop = false;
            this.groupBoxSAN.Text = "Subject Alternative Names (SAN)";
            // 
            // textBoxSAN
            // 
            this.textBoxSAN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSAN.Location = new System.Drawing.Point(2, 2);
            this.textBoxSAN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxSAN.Name = "textBoxSAN";
            this.textBoxSAN.Size = new System.Drawing.Size(302, 20);
            this.textBoxSAN.TabIndex = 2;
            this.textBoxSAN.TextChanged += new System.EventHandler(this.OnTypeInSAN);
            // 
            // buttonAddSAN
            // 
            this.buttonAddSAN.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAddSAN.Enabled = false;
            this.buttonAddSAN.Location = new System.Drawing.Point(308, 2);
            this.buttonAddSAN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAddSAN.Name = "buttonAddSAN";
            this.buttonAddSAN.Size = new System.Drawing.Size(73, 20);
            this.buttonAddSAN.TabIndex = 3;
            this.buttonAddSAN.Text = "Add";
            this.toolTipHelp.SetToolTip(this.buttonAddSAN, "Add a new Subject Alternative Name (SAN) to the certificate to be created.");
            this.buttonAddSAN.UseVisualStyleBackColor = true;
            this.buttonAddSAN.Click += new System.EventHandler(this.AddSAN);
            // 
            // buttonRemoveSAN
            // 
            this.buttonRemoveSAN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonRemoveSAN.Enabled = false;
            this.buttonRemoveSAN.Location = new System.Drawing.Point(308, 26);
            this.buttonRemoveSAN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonRemoveSAN.Name = "buttonRemoveSAN";
            this.buttonRemoveSAN.Size = new System.Drawing.Size(73, 61);
            this.buttonRemoveSAN.TabIndex = 5;
            this.buttonRemoveSAN.Text = "Remove";
            this.toolTipHelp.SetToolTip(this.buttonRemoveSAN, "Remove the selected Subject Alternative Name (SAN) from the list on the left side" +
        ".");
            this.buttonRemoveSAN.UseVisualStyleBackColor = true;
            this.buttonRemoveSAN.Click += new System.EventHandler(this.RemoveSAN);
            // 
            // listBoxSAN
            // 
            this.listBoxSAN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxSAN.FormattingEnabled = true;
            this.listBoxSAN.Location = new System.Drawing.Point(2, 26);
            this.listBoxSAN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxSAN.Name = "listBoxSAN";
            this.listBoxSAN.Size = new System.Drawing.Size(302, 61);
            this.listBoxSAN.TabIndex = 4;
            this.listBoxSAN.Click += new System.EventHandler(this.OnClickInASAN);
            // 
            // buttonCreateCertificate
            // 
            this.buttonCreateCertificate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCreateCertificate.Location = new System.Drawing.Point(2, 200);
            this.buttonCreateCertificate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCreateCertificate.Name = "buttonCreateCertificate";
            this.buttonCreateCertificate.Size = new System.Drawing.Size(397, 53);
            this.buttonCreateCertificate.TabIndex = 6;
            this.buttonCreateCertificate.Text = "Create certificate";
            this.buttonCreateCertificate.UseVisualStyleBackColor = true;
            this.buttonCreateCertificate.Click += new System.EventHandler(this.CreateCertificate);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabIssue);
            this.tabControl1.Controls.Add(this.tabCertificateAuthority);
            this.tabControl1.Controls.Add(this.tabClientCertificate);
            this.tabControl1.Location = new System.Drawing.Point(10, 26);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(439, 387);
            this.tabControl1.TabIndex = 2;
            // 
            // tabCertificateAuthority
            // 
            this.tabCertificateAuthority.Controls.Add(this.groupBoxManageCertificateAuthorities);
            this.tabCertificateAuthority.Controls.Add(this.groupBoxCreateCertificateAuthority);
            this.tabCertificateAuthority.Location = new System.Drawing.Point(4, 22);
            this.tabCertificateAuthority.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabCertificateAuthority.Name = "tabCertificateAuthority";
            this.tabCertificateAuthority.Size = new System.Drawing.Size(431, 361);
            this.tabCertificateAuthority.TabIndex = 1;
            this.tabCertificateAuthority.Text = "Certificate Authorities";
            this.tabCertificateAuthority.UseVisualStyleBackColor = true;
            // 
            // groupBoxCreateCertificateAuthority
            // 
            this.groupBoxCreateCertificateAuthority.AccessibleName = "Certificate Authority";
            this.groupBoxCreateCertificateAuthority.Controls.Add(this.buttonCreateCertificateCA);
            this.groupBoxCreateCertificateAuthority.Controls.Add(this.groupBoxSubjectAlternativeNamesCA);
            this.groupBoxCreateCertificateAuthority.Controls.Add(this.labelCommonNameCA);
            this.groupBoxCreateCertificateAuthority.Controls.Add(this.textBoxCommonNameCA);
            this.groupBoxCreateCertificateAuthority.Location = new System.Drawing.Point(3, 3);
            this.groupBoxCreateCertificateAuthority.Name = "groupBoxCreateCertificateAuthority";
            this.groupBoxCreateCertificateAuthority.Size = new System.Drawing.Size(425, 229);
            this.groupBoxCreateCertificateAuthority.TabIndex = 1;
            this.groupBoxCreateCertificateAuthority.TabStop = false;
            this.groupBoxCreateCertificateAuthority.Text = "Create";
            // 
            // buttonCreateCertificateCA
            // 
            this.buttonCreateCertificateCA.Location = new System.Drawing.Point(6, 191);
            this.buttonCreateCertificateCA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCreateCertificateCA.Name = "buttonCreateCertificateCA";
            this.buttonCreateCertificateCA.Size = new System.Drawing.Size(415, 29);
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
            // tabClientCertificate
            // 
            this.tabClientCertificate.Controls.Add(this.groupBoxManageClientCertificate);
            this.tabClientCertificate.Location = new System.Drawing.Point(4, 22);
            this.tabClientCertificate.Name = "tabClientCertificate";
            this.tabClientCertificate.Size = new System.Drawing.Size(431, 361);
            this.tabClientCertificate.TabIndex = 2;
            this.tabClientCertificate.Text = "Client Certificates";
            this.tabClientCertificate.UseVisualStyleBackColor = true;
            // 
            // groupBoxManageCertificateAuthorities
            // 
            this.groupBoxManageCertificateAuthorities.Controls.Add(this.tableLayoutPanel8);
            this.groupBoxManageCertificateAuthorities.Location = new System.Drawing.Point(3, 238);
            this.groupBoxManageCertificateAuthorities.Name = "groupBoxManageCertificateAuthorities";
            this.groupBoxManageCertificateAuthorities.Size = new System.Drawing.Size(425, 120);
            this.groupBoxManageCertificateAuthorities.TabIndex = 2;
            this.groupBoxManageCertificateAuthorities.TabStop = false;
            this.groupBoxManageCertificateAuthorities.Text = "Manage";
            // 
            // listBoxExistentCertificateAuthorities
            // 
            this.listBoxExistentCertificateAuthorities.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxExistentCertificateAuthorities.FormattingEnabled = true;
            this.listBoxExistentCertificateAuthorities.Location = new System.Drawing.Point(3, 3);
            this.listBoxExistentCertificateAuthorities.Name = "listBoxExistentCertificateAuthorities";
            this.listBoxExistentCertificateAuthorities.Size = new System.Drawing.Size(322, 89);
            this.listBoxExistentCertificateAuthorities.TabIndex = 0;
            // 
            // buttonExistentCertificateAuthoritiesInfo
            // 
            this.buttonExistentCertificateAuthoritiesInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonExistentCertificateAuthoritiesInfo.Location = new System.Drawing.Point(3, 3);
            this.buttonExistentCertificateAuthoritiesInfo.Name = "buttonExistentCertificateAuthoritiesInfo";
            this.buttonExistentCertificateAuthoritiesInfo.Size = new System.Drawing.Size(71, 23);
            this.buttonExistentCertificateAuthoritiesInfo.TabIndex = 1;
            this.buttonExistentCertificateAuthoritiesInfo.Text = "Info";
            this.buttonExistentCertificateAuthoritiesInfo.UseVisualStyleBackColor = true;
            this.buttonExistentCertificateAuthoritiesInfo.Click += new System.EventHandler(this.ShowInformationAboutSelectedCA);
            // 
            // buttonExistentCertificateAuthoritiesDelete
            // 
            this.buttonExistentCertificateAuthoritiesDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonExistentCertificateAuthoritiesDelete.ForeColor = System.Drawing.Color.Red;
            this.buttonExistentCertificateAuthoritiesDelete.Location = new System.Drawing.Point(3, 61);
            this.buttonExistentCertificateAuthoritiesDelete.Name = "buttonExistentCertificateAuthoritiesDelete";
            this.buttonExistentCertificateAuthoritiesDelete.Size = new System.Drawing.Size(71, 25);
            this.buttonExistentCertificateAuthoritiesDelete.TabIndex = 2;
            this.buttonExistentCertificateAuthoritiesDelete.Text = "Delete";
            this.buttonExistentCertificateAuthoritiesDelete.UseVisualStyleBackColor = true;
            this.buttonExistentCertificateAuthoritiesDelete.Click += new System.EventHandler(this.DeleteSelectedCA);
            // 
            // buttonExistentCertificateAuthoritiesRefresh
            // 
            this.buttonExistentCertificateAuthoritiesRefresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonExistentCertificateAuthoritiesRefresh.Location = new System.Drawing.Point(3, 32);
            this.buttonExistentCertificateAuthoritiesRefresh.Name = "buttonExistentCertificateAuthoritiesRefresh";
            this.buttonExistentCertificateAuthoritiesRefresh.Size = new System.Drawing.Size(71, 23);
            this.buttonExistentCertificateAuthoritiesRefresh.TabIndex = 3;
            this.buttonExistentCertificateAuthoritiesRefresh.Text = "Refresh";
            this.buttonExistentCertificateAuthoritiesRefresh.UseVisualStyleBackColor = true;
            this.buttonExistentCertificateAuthoritiesRefresh.Click += new System.EventHandler(this.RefreshCertificateAuthorities);
            // 
            // groupBoxManageClientCertificate
            // 
            this.groupBoxManageClientCertificate.Controls.Add(this.tableLayoutPanel1);
            this.groupBoxManageClientCertificate.Location = new System.Drawing.Point(3, 3);
            this.groupBoxManageClientCertificate.Name = "groupBoxManageClientCertificate";
            this.groupBoxManageClientCertificate.Size = new System.Drawing.Size(425, 355);
            this.groupBoxManageClientCertificate.TabIndex = 0;
            this.groupBoxManageClientCertificate.TabStop = false;
            this.groupBoxManageClientCertificate.Text = "Manage";
            // 
            // listBoxExistentClientCertificates
            // 
            this.listBoxExistentClientCertificates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxExistentClientCertificates.FormattingEnabled = true;
            this.listBoxExistentClientCertificates.Location = new System.Drawing.Point(3, 3);
            this.listBoxExistentClientCertificates.Name = "listBoxExistentClientCertificates";
            this.listBoxExistentClientCertificates.Size = new System.Drawing.Size(329, 330);
            this.listBoxExistentClientCertificates.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.listBoxExistentClientCertificates, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(419, 336);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // buttonExistentClientCertificateInfo
            // 
            this.buttonExistentClientCertificateInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonExistentClientCertificateInfo.Location = new System.Drawing.Point(3, 3);
            this.buttonExistentClientCertificateInfo.Name = "buttonExistentClientCertificateInfo";
            this.buttonExistentClientCertificateInfo.Size = new System.Drawing.Size(72, 27);
            this.buttonExistentClientCertificateInfo.TabIndex = 1;
            this.buttonExistentClientCertificateInfo.Text = "Info";
            this.buttonExistentClientCertificateInfo.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.buttonExistentClientCertificateInfo, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonExistentClientCertificateDelete, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.buttonExistentClientCertificateRefresh, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(338, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(78, 100);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // buttonExistentClientCertificateRefresh
            // 
            this.buttonExistentClientCertificateRefresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonExistentClientCertificateRefresh.Location = new System.Drawing.Point(3, 36);
            this.buttonExistentClientCertificateRefresh.Name = "buttonExistentClientCertificateRefresh";
            this.buttonExistentClientCertificateRefresh.Size = new System.Drawing.Size(72, 27);
            this.buttonExistentClientCertificateRefresh.TabIndex = 2;
            this.buttonExistentClientCertificateRefresh.Text = "Refresh";
            this.buttonExistentClientCertificateRefresh.UseVisualStyleBackColor = true;
            // 
            // buttonExistentClientCertificateDelete
            // 
            this.buttonExistentClientCertificateDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonExistentClientCertificateDelete.ForeColor = System.Drawing.Color.Red;
            this.buttonExistentClientCertificateDelete.Location = new System.Drawing.Point(3, 69);
            this.buttonExistentClientCertificateDelete.Name = "buttonExistentClientCertificateDelete";
            this.buttonExistentClientCertificateDelete.Size = new System.Drawing.Size(72, 28);
            this.buttonExistentClientCertificateDelete.TabIndex = 3;
            this.buttonExistentClientCertificateDelete.Text = "Delete";
            this.buttonExistentClientCertificateDelete.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Controls.Add(this.buttonShowInformationCA, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.comboBoxCertificateAuthorities, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(401, 31);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Controls.Add(this.checkBoxWildcardToCommonName, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.textBoxCommonName, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(5, 18);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(387, 49);
            this.tableLayoutPanel4.TabIndex = 11;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.groupBoxCertificateAuthority, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.groupBoxSelfSignedCertificate, 0, 1);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.33811F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.66189F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(419, 349);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.groupBoxCommonName, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.buttonCreateCertificate, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.groupBoxSAN, 0, 1);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 3;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.58824F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.05882F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.96078F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(401, 255);
            this.tableLayoutPanel6.TabIndex = 12;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel7.Controls.Add(this.textBoxSAN, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.buttonRemoveSAN, 1, 1);
            this.tableLayoutPanel7.Controls.Add(this.buttonAddSAN, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.listBoxSAN, 0, 1);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.08989F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.91011F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(383, 89);
            this.tableLayoutPanel7.TabIndex = 6;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel9, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.listBoxExistentCertificateAuthorities, 0, 0);
            this.tableLayoutPanel8.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(411, 95);
            this.tableLayoutPanel8.TabIndex = 4;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 1;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Controls.Add(this.buttonExistentCertificateAuthoritiesInfo, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.buttonExistentCertificateAuthoritiesDelete, 0, 2);
            this.tableLayoutPanel9.Controls.Add(this.buttonExistentCertificateAuthoritiesRefresh, 0, 1);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(331, 3);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 3;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(77, 89);
            this.tableLayoutPanel9.TabIndex = 0;
            // 
            // Main
            // 
            this.AccessibleDescription = "Create Self-Signed Certificates";
            this.AccessibleName = "MySelfSSL";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 425);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.headMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
            this.groupBoxSAN.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabCertificateAuthority.ResumeLayout(false);
            this.groupBoxCreateCertificateAuthority.ResumeLayout(false);
            this.groupBoxCreateCertificateAuthority.PerformLayout();
            this.groupBoxSubjectAlternativeNamesCA.ResumeLayout(false);
            this.groupBoxSubjectAlternativeNamesCA.PerformLayout();
            this.headMenu.ResumeLayout(false);
            this.headMenu.PerformLayout();
            this.tabClientCertificate.ResumeLayout(false);
            this.groupBoxManageCertificateAuthorities.ResumeLayout(false);
            this.groupBoxManageClientCertificate.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripMenuItem defaultExportPasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.GroupBox groupBoxCommonName;
        private System.Windows.Forms.CheckBox checkBoxWildcardToCommonName;
        private System.Windows.Forms.ToolTip toolTipHelp;
        private System.Windows.Forms.Button buttonShowInformationCA;
        private System.Windows.Forms.TabPage tabClientCertificate;
        private System.Windows.Forms.GroupBox groupBoxManageCertificateAuthorities;
        private System.Windows.Forms.Button buttonExistentCertificateAuthoritiesDelete;
        private System.Windows.Forms.Button buttonExistentCertificateAuthoritiesInfo;
        private System.Windows.Forms.ListBox listBoxExistentCertificateAuthorities;
        private System.Windows.Forms.Button buttonExistentCertificateAuthoritiesRefresh;
        private System.Windows.Forms.GroupBox groupBoxManageClientCertificate;
        private System.Windows.Forms.ListBox listBoxExistentClientCertificates;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button buttonExistentClientCertificateInfo;
        private System.Windows.Forms.Button buttonExistentClientCertificateDelete;
        private System.Windows.Forms.Button buttonExistentClientCertificateRefresh;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
    }
}