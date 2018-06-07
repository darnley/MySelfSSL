using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
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
