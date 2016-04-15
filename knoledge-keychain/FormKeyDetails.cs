using NBitcoin;
using NBitcoin.Stealth;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThoughtWorks.QRCode.Codec;

namespace knoledge_keychain
{
    public partial class FormKeyDetails : Form
    {
        public object Key { get; set; }
        public FormKeyDetails()
        {
            InitializeComponent();
        }

        private void FormDetails_Load(object sender, EventArgs e)
        {
            if (Key == null) return;

            string privateKey = "";
            string pubKey = "";
            string address = "";
            string hash = "";
            string script = "";
            string base58Type = "";

            Type type = Key.GetType();

            switch (type.ToString())
            {
                case "knoledge_keychain.KeyPair":
                    KeyPair keyPair = Key as KeyPair;
                    privateKey = keyPair.PrivateKeyString;
                    pubKey = keyPair.PubKey.ToString();
                    address = keyPair.Address.ToString();
                    hash = keyPair.PubKey.ExtPubKey.PubKey.Hash.ToString();
                    script = keyPair.PubKey.ScriptPubKey.ToString();

                    if (keyPair.PrivateKey != null)
                        base58Type = keyPair.PrivateKey.Type.ToString();
                    else
                        base58Type = keyPair.PubKey.Type.ToString();
                    break;
                case "NBitcoin.BitcoinSecret":
                    BitcoinSecret secret = Key as BitcoinSecret;
                    privateKey = secret.ToWif();
                    BitcoinAddress bitcoinAddress = secret.GetAddress();
                    address = bitcoinAddress.ToString();
                    hash = secret.PubKey.Hash.ToString();
                    script = bitcoinAddress.ScriptPubKey.ToString();
                    base58Type = secret.Type.ToString();
                    break;

            }

            textBoxType.Text = base58Type;
            textBoxPrivateKey.Text = privateKey;
            textBoxBitcoinAddress.Text = address;
            textBoxPubHash.Text = hash;
            textBoxPubKey.Text = pubKey;
            textBoxScriptPubKey.Text = script;

            textBoxPrivateKey.Focus();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void createQRCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxBitcoinAddress.Text)) return;

            using (FormQRCode form = new FormQRCode())
            {
                form.Address = textBoxBitcoinAddress.Text;
                form.ShowDialog();
            }
        }


    }
}
