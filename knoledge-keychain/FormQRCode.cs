using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThoughtWorks.QRCode.Codec;

namespace knoledge_keychain
{
    public partial class FormQRCode : Form
    {
        Image _image = null;

        public string Address { get; set; }
        public FormQRCode()
        {
            InitializeComponent();
        }

        private void FormQRCode_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Address)) return;

            QRCodeEncoder qr = new QRCodeEncoder();
            qr.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.ALPHA_NUMERIC;
            qr.QRCodeScale = 4;
            qr.QRCodeVersion = 7;
            qr.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.M;

            string data = Address;
            _image = qr.Encode(data);

            pictureBox.Image = _image;
            labelAddress.Text = Address;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAddress_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Address)) return;

            Clipboard.SetData(DataFormats.Text, Address);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (_image == null) return;

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.CheckPathExists = true;
                sfd.Filter = "Image files (*.png) | *.png";
                sfd.OverwritePrompt = true;

                if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    _image.Save(sfd.FileName, ImageFormat.Png);
            }
        }
    }
}
