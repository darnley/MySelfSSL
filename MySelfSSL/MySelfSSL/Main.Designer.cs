namespace MySelfSSL
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
            this.panelContents = new System.Windows.Forms.Panel();
            this.groupBoxCA = new System.Windows.Forms.GroupBox();
            this.textBoxAuthorityCommonName = new System.Windows.Forms.TextBox();
            this.textBoxCN = new System.Windows.Forms.TextBox();
            this.groupBoxCertificate = new System.Windows.Forms.GroupBox();
            this.labelCertName = new System.Windows.Forms.Label();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.panelContents.SuspendLayout();
            this.groupBoxCA.SuspendLayout();
            this.groupBoxCertificate.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContents
            // 
            this.panelContents.Controls.Add(this.buttonCreate);
            this.panelContents.Controls.Add(this.groupBoxCertificate);
            this.panelContents.Controls.Add(this.groupBoxCA);
            this.panelContents.Location = new System.Drawing.Point(12, 12);
            this.panelContents.Name = "panelContents";
            this.panelContents.Size = new System.Drawing.Size(277, 426);
            this.panelContents.TabIndex = 0;
            // 
            // groupBoxCA
            // 
            this.groupBoxCA.Controls.Add(this.textBoxAuthorityCommonName);
            this.groupBoxCA.Location = new System.Drawing.Point(3, 3);
            this.groupBoxCA.Name = "groupBoxCA";
            this.groupBoxCA.Size = new System.Drawing.Size(271, 52);
            this.groupBoxCA.TabIndex = 0;
            this.groupBoxCA.TabStop = false;
            this.groupBoxCA.Text = "Certificate Authority (CA)";
            // 
            // textBoxAuthorityCommonName
            // 
            this.textBoxAuthorityCommonName.Location = new System.Drawing.Point(6, 19);
            this.textBoxAuthorityCommonName.Name = "textBoxAuthorityCommonName";
            this.textBoxAuthorityCommonName.ReadOnly = true;
            this.textBoxAuthorityCommonName.Size = new System.Drawing.Size(259, 20);
            this.textBoxAuthorityCommonName.TabIndex = 0;
            this.textBoxAuthorityCommonName.Text = "Root Development CA";
            // 
            // textBoxCN
            // 
            this.textBoxCN.Location = new System.Drawing.Point(6, 32);
            this.textBoxCN.Name = "textBoxCN";
            this.textBoxCN.Size = new System.Drawing.Size(259, 20);
            this.textBoxCN.TabIndex = 1;
            // 
            // groupBoxCertificate
            // 
            this.groupBoxCertificate.Controls.Add(this.labelCertName);
            this.groupBoxCertificate.Controls.Add(this.textBoxCN);
            this.groupBoxCertificate.Location = new System.Drawing.Point(3, 61);
            this.groupBoxCertificate.Name = "groupBoxCertificate";
            this.groupBoxCertificate.Size = new System.Drawing.Size(271, 100);
            this.groupBoxCertificate.TabIndex = 2;
            this.groupBoxCertificate.TabStop = false;
            this.groupBoxCertificate.Text = "Certificate";
            // 
            // labelCertName
            // 
            this.labelCertName.AutoSize = true;
            this.labelCertName.Location = new System.Drawing.Point(6, 16);
            this.labelCertName.Name = "labelCertName";
            this.labelCertName.Size = new System.Drawing.Size(79, 13);
            this.labelCertName.TabIndex = 2;
            this.labelCertName.Text = "Common Name";
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(3, 400);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(271, 23);
            this.buttonCreate.TabIndex = 3;
            this.buttonCreate.Text = "Create";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.CreateCertificate);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 450);
            this.Controls.Add(this.panelContents);
            this.Name = "Main";
            this.Text = "MySelfSSL";
            this.panelContents.ResumeLayout(false);
            this.groupBoxCA.ResumeLayout(false);
            this.groupBoxCA.PerformLayout();
            this.groupBoxCertificate.ResumeLayout(false);
            this.groupBoxCertificate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContents;
        private System.Windows.Forms.GroupBox groupBoxCA;
        private System.Windows.Forms.TextBox textBoxAuthorityCommonName;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.GroupBox groupBoxCertificate;
        private System.Windows.Forms.Label labelCertName;
        private System.Windows.Forms.TextBox textBoxCN;
    }
}