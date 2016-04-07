using NBitcoin;
using NBitcoin.OpenAsset;
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

namespace knoledge_keychain
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void validateBase58ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormValidateBase58 form = new FormValidateBase58())
            {
                if (form.ShowDialog() == DialogResult.OK && form.Result != null)
                {
                    MessageBox.Show(form.Result.ToString()); 
                }
            }
        }

        private void addAddressKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormAddAddress form = new FormAddAddress())
            {
                if (form.ShowDialog() == DialogResult.OK && form.Result != null)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = form.Result.ToString();
                    lvi.Tag = form.Result;
                    listView.Items.Add(lvi);
                }
            }
        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var address = listView.SelectedItems[0].Tag;

            if (address != null)
            {
                MessageBox.Show(address.ToString());
            }
        }

        private void listView_MouseClick(object sender, MouseEventArgs e)
        {
            ListView listView = sender as ListView;
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                ListViewItem item = listView.GetItemAt(e.X, e.Y);
                if (item != null)
                {
                    item.Selected = true;
                    contextMenuStrip.Show(listView, e.Location);
                }
            }
        }

        private void contextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            if (listView.SelectedItems.Count <= 0)
            {
                e.Cancel = true;
            }
        }
    }
}
