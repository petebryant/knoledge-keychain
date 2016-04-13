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
        public KeyPair Key { get; set; }
        public FormKeyDetails()
        {
            InitializeComponent();
        }

        private void FormDetails_Load(object sender, EventArgs e)
        {
            if (Key == null) return;

            textBoxPrivateKey.Text = Key.PrivateKeyString;
            textBoxBitcoinAddress.Text = Key.Address.ToString();
            textBoxPubHash.Text = Key.PubKey.ExtPubKey.PubKey.Hash.ToString();
            textBoxPubKey.Text = Key.PubKey.ToString();
            textBoxScriptPubKey.Text = Key.PubKey.ScriptPubKey.ToString();

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
