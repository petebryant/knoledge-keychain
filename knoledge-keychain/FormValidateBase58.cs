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

    // see keys.txt for examples of Base58 strings.
    public partial class FormValidateBase58 : Form
    {
        public object Result { get; internal set; }

        public FormValidateBase58()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxAddress.Text))
            {
                MessageBox.Show("Enter an address or key.");
                return;
            }

            Result = Util.GetBase58Type(textBoxAddress.Text);

            if (Result == null)
            {
                MessageBox.Show("Unrecognized or invalid address/key");
            }
            else
            {
                Close();
            }
        }
    }
}
