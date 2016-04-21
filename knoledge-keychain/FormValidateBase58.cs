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
                MessageBox.Show(this, "Enter an Address or Key.", "Knoledge-keychain", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (new HourGlass())
            {
                Result = Util.GetBase58Type(textBoxAddress.Text);
            }

            if (Result == null)
            {
                MessageBox.Show(this, "Unrecognized or invalid address/key.", "Knoledge-keychain", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Close();
            }
        }

        private void FormValidateBase58_Load(object sender, EventArgs e)
        {
            textBoxAddress.Focus();
        }
    }
}
