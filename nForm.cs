using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.C_app.Lab01.FirstTask
{
    public partial class nForm : Form
    {
        private bool nclose = false;
        public nForm()
        {
            InitializeComponent();
        }
        public new void Close() 
        { 
            nclose = true; 
            base.Close(); 
        }
        private void nForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (nclose) return;
            e.Cancel = true; 
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void nForm_Load(object sender, EventArgs e)
        {

        }
    }
}
