using NBitcoin;
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
                Type type = Result.GetType();
                switch (type.ToString())
                {
                    case "NBitcoin.BitcoinEncryptedSecretEC":
                        if (string.IsNullOrEmpty(textBoxPassword.Text))
                        {
                            textBoxPassword.Enabled = true;
                            MessageBox.Show(this, "This is an encrypted BitcoinSecret, please provide the password.", "Knoledge-keychain", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                            return;
                        }
                        else
                        {
                            try
                            {
                                BitcoinEncryptedSecretEC encEC = Result as BitcoinEncryptedSecretEC;
                                Result = encEC.GetKey(textBoxPassword.Text).GetBitcoinSecret(Network.TestNet);
                                DialogResult = System.Windows.Forms.DialogResult.OK;
                            }
                            catch 
                            { 
                                MessageBox.Show(this, "The pasword you entered is incorrect.", "Knoledge-keychain", MessageBoxButtons.OK,MessageBoxIcon.Error);
                            }
                        }
                        break;
                    case "NBitcoin.BitcoinEncryptedSecretNoEC":
                        if (string.IsNullOrEmpty(textBoxPassword.Text))
                        {
                            textBoxPassword.Enabled = true;
                            MessageBox.Show(this, "This is an encrypted BitcoinSecret, please provide the password.", "Knoledge-keychain", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                        else
                        {
                            try
                            {
                                BitcoinEncryptedSecretNoEC encEC = Result as BitcoinEncryptedSecretNoEC;
                                Result = encEC.GetKey(textBoxPassword.Text).GetBitcoinSecret(Network.TestNet);
                                DialogResult = System.Windows.Forms.DialogResult.OK;
                            }
                            catch
                            {
                                MessageBox.Show(this, "The pasword you entered is incorrect.", "Knoledge-keychain", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        break;
                    default:
                        DialogResult = System.Windows.Forms.DialogResult.OK;
                        break;
                }
            }
        }

        private void FormAddKey_Load(object sender, EventArgs e)
        {
            textBoxKey.Focus();
        }
    }
}
