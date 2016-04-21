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
    public partial class FormAddressDetails : Form
    {
        public object Address { get; set; }
        public FormAddressDetails()
        {
            InitializeComponent();
        }

        private void FormDetails_Load(object sender, EventArgs e)
        {
            string address = "";
            string bitcoinAddress = "";
            string hash = "";
            string script = "";
            string base58Type = "";
            Type type = Address.GetType();

            using (new HourGlass())
            {
                switch (type.ToString())
                {
                    case "NBitcoin.BitcoinScriptAddress":
                        BitcoinScriptAddress bsa = Address as BitcoinScriptAddress;
                        bitcoinAddress = bsa.ToString();
                        hash = bsa.Hash.ToString();
                        script = bsa.ScriptPubKey.ToString();
                        base58Type = bsa.Type.ToString();
                        break;
                    case "NBitcoin.BitcoinAddress":
                        BitcoinAddress ba = Address as BitcoinAddress;
                        bitcoinAddress = ba.ToString();
                        hash = ba.Hash.ToString();
                        script = ba.ScriptPubKey.ToString();
                        base58Type = ba.Type.ToString();
                        break;
                    case "NBitcoin.Stealth.BitcoinStealthAddress":
                        BitcoinStealthAddress stealth = Address as BitcoinStealthAddress;
                        bitcoinAddress = stealth.ToString();
                        hash = stealth.ScanPubKey.Hash.ToString();
                        script = stealth.ScanPubKey.ScriptPubKey.ToString();
                        base58Type = stealth.Type.ToString();
                        break;
                    case "NBitcoin.BitcoinColoredAddress":
                        BitcoinColoredAddress colored = Address as BitcoinColoredAddress;
                        address = colored.ToString();
                        bitcoinAddress = colored.Address.ToString();
                        hash = colored.Address.Hash.ToString();
                        script = colored.ScriptPubKey.ToString();
                        base58Type = colored.Type.ToString();
                        break;
                    default:
                        textBoxType.Text = type.ToString();
                        break;
                }
            }

            textBoxAddress.Text = address;
            textBoxBitcoinAddress.Text = bitcoinAddress;
            textBoxPubHash.Text = hash;
            textBoxScriptPubKey.Text = script;
            textBoxType.Text = base58Type;

            textBoxBitcoinAddress.Focus();
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
