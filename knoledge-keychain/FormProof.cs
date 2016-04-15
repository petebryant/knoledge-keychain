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
    //TODO accept input for Proof of Ownership and validate Base58
    public partial class FormProof : Form
    {
        public FormProof()
        {
            InitializeComponent();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            string msg = "A sample message to sign";
            Key key = new Key();
            BitcoinSecret secret = key.GetBitcoinSecret(Network.TestNet);
            string sig = secret.PrivateKey.SignMessage(msg);

            textBoxSecret.Text = secret.ToWif();
            textBoxAddress.Text = secret.GetAddress().ToString();
            textBoxMessage.Text = msg;
            textBoxSig.Text = sig;
        }

        private void buttonVerify_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxSecret.Text) ||
                string.IsNullOrEmpty(textBoxMessage.Text) ||
                string.IsNullOrEmpty(textBoxSig.Text)) return;

            try
            {
                BitcoinSecret secret = new BitcoinSecret(textBoxSecret.Text, Network.TestNet);
                string valid = secret.GetAddress().VerifyMessage(textBoxMessage.Text, textBoxSig.Text).ToString();
                MessageBox.Show(this, valid, "Knoledge-keychain", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Knoledge-keychain", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
