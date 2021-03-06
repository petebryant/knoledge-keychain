﻿using System;
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

    public partial class FormAddressFromScript: Form
    {
        public object Result { get; internal set; }

        public FormAddressFromScript()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxScript.Text))
            {
                MessageBox.Show(this, "Enter an script.", "Knoledge-keychain", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            using (new HourGlass())
            {
                Result = Util.BitcoinAddressFomScriptPubKey(textBoxScript.Text);
            }

            if (Result == null)
            {
                MessageBox.Show(this, "Unrecognized or invalid script.", "Knoledge-keychain", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Close();
            }
        }

        private void FormAddressFromScript_Load(object sender, EventArgs e)
        {
            textBoxScript.Focus();
        }
    }
}
