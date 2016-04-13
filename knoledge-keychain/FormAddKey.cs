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
    public partial class FormAddKey: Form
    {
        public object Result { get; internal set; }

        public FormAddKey()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxKey.Text))
            {
                MessageBox.Show("Enter a key.");
                return;
            }

            Result = Util.InterpretKey(textBoxKey.Text);

            if (Result == null)
            {
                MessageBox.Show("Unrecognized or invalid key.");
            }
            else
            {
                Close();
            }
        }

        private void FormAddKey_Load(object sender, EventArgs e)
        {
            textBoxKey.Focus();
        }
    }
}
