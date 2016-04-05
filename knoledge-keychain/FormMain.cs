using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace knoledge_keychain
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addAddressKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormAddAddress form = new FormAddAddress())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("an address"); 
                }
            }
        }
    }
}
