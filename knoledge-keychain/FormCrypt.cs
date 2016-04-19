﻿using NBitcoin;
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
    public partial class FormCrypt : Form
    {
        object _result = null;
        public FormCrypt()
        {
            InitializeComponent();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxEncrypted.Text = "";
            textBoxPassword.Text = "";
            textBoxSecret.Text = "";

            _result = null;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxPassword.Text)) return;

            if (string.IsNullOrEmpty(textBoxEncrypted.Text))
            {
                _result = Util.Interpret(textBoxSecret.Text);

                if (_result == null || !(_result is BitcoinSecret))
                {
                    MessageBox.Show("Unrecognized or invalid key.");
                    return;
                }

                BitcoinSecret secret = _result as BitcoinSecret;
                BitcoinEncryptedSecret encrypted = secret.Encrypt(textBoxPassword.Text);
                textBoxEncrypted.Text = encrypted.ToString();
            }
            else if (string.IsNullOrEmpty(textBoxSecret.Text))
            {
                _result = Util.Interpret(textBoxEncrypted.Text);

                if (_result == null || !(_result is BitcoinEncryptedSecretNoEC))
                {
                    MessageBox.Show("Unrecognized or invalid key.");
                    return;
                }

                BitcoinEncryptedSecretNoEC encEC = _result as BitcoinEncryptedSecretNoEC;
                textBoxSecret.Text = encEC.GetKey(textBoxPassword.Text).GetBitcoinSecret(Network.TestNet).ToString();
            }
        }
    }
}
