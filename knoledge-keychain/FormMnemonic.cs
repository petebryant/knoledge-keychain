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
    public partial class FormMnemonic : Form
    {
        public FormMnemonic()
        {
            InitializeComponent();
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            Wordlist wordlist = (Wordlist)comboBoxMnemonic.SelectedItem;
            WordCount wordcount = (WordCount)comboBoxWordcount.SelectedItem;

            Mnemonic mnemo = new Mnemonic(wordlist, wordcount); 

            ExtKey hdRoot = mnemo.DeriveExtKey(textBoxPassword.Text);
            textBoxWordlist.Text = mnemo.ToString();
            textBoxHDRoot.Text = hdRoot.PrivateKey.GetWif(Network.TestNet).ToString();
        }

        private void FormMnemonic_Load(object sender, EventArgs e)
        {
            comboBoxMnemonic.Items.Add(Wordlist.English);
            comboBoxMnemonic.Items.Add(Wordlist.French);
            comboBoxMnemonic.Items.Add(Wordlist.Spanish);

            comboBoxMnemonic.SelectedItem = Wordlist.English;

            comboBoxWordcount.Items.Add(WordCount.Twelve);
            comboBoxWordcount.Items.Add(WordCount.Fifteen);
            comboBoxWordcount.Items.Add(WordCount.Eighteen);
            comboBoxWordcount.Items.Add(WordCount.TwentyOne);
            comboBoxWordcount.Items.Add(WordCount.TwentyFour);

            comboBoxWordcount.SelectedItem = WordCount.Twelve;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            comboBoxMnemonic.SelectedItem = Wordlist.English;
            comboBoxWordcount.SelectedItem = WordCount.Twelve;

            textBoxWordlist.Text = "";
            textBoxHDRoot.Text = "";
            textBoxPassword.Text = "";
        }

        private void buttonRecover_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxWordlist.Text)) return;

            Wordlist wordlist = (Wordlist)comboBoxMnemonic.SelectedItem;
            Mnemonic mnemo = new Mnemonic(textBoxWordlist.Text, wordlist);
            ExtKey hdRoot = mnemo.DeriveExtKey(textBoxPassword.Text);
            textBoxHDRoot.Text = hdRoot.PrivateKey.GetWif(Network.TestNet).ToString();
        }
    }
}
