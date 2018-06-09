using System;
using System.Windows.Forms;

namespace Holbor.MySelfSSL.Forms
{
    public partial class Status : Form
    {
        public Status()
        {
            InitializeComponent();
        }

        private void Init(object sender, EventArgs e)
        {
            
        }

        public void ChangeLoadingText(string text)
        {
            textBoxLoading.Text = text;
        }
    }
}
