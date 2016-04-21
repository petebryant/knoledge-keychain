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
    public partial class FormProof : Form
    {
        string msg;
        string sig;
        Key key;
        BitcoinSecret secret;
        BitcoinAddress address;

        public FormProof()
        {
            InitializeComponent();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            try
            {
                using (new HourGlass())
                {
                    key = new Key();
                    secret = key.GetBitcoinSecret(Network.TestNet);
                    address = secret.GetAddress();
                    string base58String = secret.ToWif();
                    msg = "A sample message to sign";
                    sig = secret.PrivateKey.SignMessage(msg);

                    textBoxBase58.Text = base58String;
                    textBoxMessage.Text = msg;
                    textBoxSig.Text = sig;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Knoledge-keychain", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonVerify_Click(object sender, EventArgs e)
        {
            try
            {
                using (new HourGlass())
                {
                    var fromBase58 = Util.Interpret(textBoxBase58.Text);

                    if (fromBase58 is BitcoinSecret)
                    {
                        secret = new BitcoinSecret(textBoxBase58.Text, Network.TestNet);
                        address = secret.GetAddress();
                    }
                    else
                    {
                        address = new BitcoinAddress(textBoxBase58.Text);
                    }

                    sig = textBoxSig.Text;
                    msg = textBoxMessage.Text;
                }

                string valid = address.VerifyMessage(msg, sig).ToString();
                MessageBox.Show(this, valid, "Knoledge-keychain", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Knoledge-keychain", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormProof_Load(object sender, EventArgs e)
        {
            textBoxBase58.Focus();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxBase58.Text = "";
            textBoxMessage.Text = "";
            textBoxSig.Text = "";

            key = null;
            secret = null;
            address = null;
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
