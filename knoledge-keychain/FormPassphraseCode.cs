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
    public partial class FormPassphraseCode : Form
    {
        public FormPassphraseCode()
        {
            InitializeComponent();
        }

        private void FormPassphraseCode_Load(object sender, EventArgs e)
        {

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxPassword.Text = "";
            textBoxPhrase.Text = "";
            textBoxEncKey.Text = "";
            textBoxAddress.Text = "";
            textBoxConfirmation.Text = "";
        }

        private void buttonPassphrase_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxPassword.Text))
            {
                MessageBox.Show(this, "A password is required.", "knoledge-keychain", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (new HourGlass())
            {
                BitcoinPassphraseCode phrase = new BitcoinPassphraseCode(textBoxPassword.Text, Network.TestNet, null);
                textBoxPhrase.Text = phrase.ToWif();
            }
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxPhrase.Text))
            {
                MessageBox.Show(this, "You need to create or enter a [Passphrase] first.", "knoledge-keychain", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (new HourGlass())
            {
                BitcoinPassphraseCode phrase = new BitcoinPassphraseCode(textBoxPhrase.Text, Network.TestNet);
                EncryptedKeyResult encryptedKey = phrase.GenerateEncryptedSecret();
                textBoxEncKey.Text = encryptedKey.EncryptedKey.ToWif();
                textBoxAddress.Text = encryptedKey.GeneratedAddress.ToWif();
                textBoxConfirmation.Text = encryptedKey.ConfirmationCode.ToWif();
            }
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxConfirmation.Text) ||
                string.IsNullOrEmpty(textBoxEncKey.Text) ||
                string.IsNullOrEmpty(textBoxPassword.Text) ||
                string.IsNullOrEmpty(textBoxAddress.Text))
            {
                MessageBox.Show(this, "You need to [Generate Key] first.", "knoledge-keychain", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (new HourGlass())
            {
                try
                {
                    BitcoinConfirmationCode confirmationCode = new BitcoinConfirmationCode(textBoxConfirmation.Text, Network.TestNet);
                    BitcoinEncryptedSecretEC encKey = new BitcoinEncryptedSecretEC(textBoxEncKey.Text, Network.TestNet);
                    BitcoinSecret secret = encKey.GetSecret(textBoxPassword.Text);
                    BitcoinAddress address = new BitcoinAddress(textBoxAddress.Text);

                    if (confirmationCode.Check(textBoxPassword.Text, address))
                    {
                        if (secret.GetAddress() == address)
                        {
                            MessageBox.Show(this, "Confirmation that this Address depends on the Passphrase", "knoledge-keychain", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "knoledge-keychain", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
