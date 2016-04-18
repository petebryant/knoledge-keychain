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
        ExtPubKey _ceoPubkey;

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
                    listViewAddress.Items.Add(lvi);
                }
            }
        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (contextMenuStrip.SourceControl == listViewAddress)
            {
                var address = listViewAddress.SelectedItems[0].Tag;

                if (address != null)
                {
                    using (FormAddressDetails form = new FormAddressDetails())
                    {
                        form.Address = address;
                        form.ShowDialog();
                    }
                }
            }
            else if (contextMenuStrip.SourceControl == listViewKey)
            {
                var key = listViewKey.SelectedItems[0].Tag;

                if (key != null)
                {
                    using (FormKeyDetails form = new FormKeyDetails())
                    {
                        form.Key = key;
                        form.ShowDialog();
                    }
                }
            }
            else if (contextMenuStrip.SourceControl == treeViewDrived)
            {
                var key = treeViewDrived.SelectedNode.Tag;

                if (key != null)
                {
                    using (FormKeyDetails form = new FormKeyDetails())
                    {
                        form.Key = key;
                        form.ShowDialog();
                    }
                }
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
            ContextMenuStrip menu = sender as ContextMenuStrip;

            if (menu != null)
            {
                if (menu.SourceControl == listViewAddress && listViewAddress.SelectedItems.Count <= 0)
                {
                    e.Cancel = true;
                }
                else if (menu.SourceControl == listViewKey && listViewKey.SelectedItems.Count <= 0)
                {
                    e.Cancel = true;
                }
                else if (menu.SourceControl == treeViewDrived) 
                {
                    if (treeViewDrived.SelectedNode == null)
                        e.Cancel = true;

                    recoverParentToolStripMenuItem.Enabled = (treeViewDrived.SelectedNode.Nodes.Count <= 0);
                }
            }
        }

        private void newAddressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KeyPair keyPair = new KeyPair();
            ListViewItem lvi = new ListViewItem();
            lvi.Text = keyPair.Address.ToString();
            lvi.Tag = keyPair.Address;
            listViewAddress.Items.Add(lvi);
        }

        private void newKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KeyPair keyPair = new KeyPair();

            string[] subItems = { keyPair.PubKey.ToString(), keyPair.Address.ToString() };
            
            ListViewItem lvi = new ListViewItem();
            lvi.Text = keyPair.PrivateKey.ToString();
            lvi.Tag = keyPair;
            lvi.SubItems.AddRange(subItems);
            listViewKey.Items.Add(lvi);
        }

        private void addKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormAddKey form = new FormAddKey())
            {
                if (form.ShowDialog() == DialogResult.OK && form.Result != null)
                {
                    KeyPair keyPair = null;
                    Type type = form.Result.GetType();
                    ListViewItem lvi = new ListViewItem();

                    switch (type.ToString())
                    {
                        case "NBitcoin.ExtPubKey":
                            ExtPubKey pubKey = form.Result as ExtPubKey;
                            keyPair = new KeyPair(pubKey);
                            lvi.Text = keyPair.PrivateKeyString;
                            lvi.Tag = keyPair;
                            lvi.SubItems.AddRange( new []{ keyPair.PubKey.ToString(), keyPair.Address.ToString() });
                            listViewKey.Items.Add(lvi);
                            break;
                        case "NBitcoin.BitcoinSecret":
                            BitcoinSecret secret = form.Result as BitcoinSecret;
                            lvi.Text = secret.ToWif();
                            lvi.Tag = secret;
                            lvi.SubItems.AddRange(new[] { "unknown", secret.GetAddress().ToString() });
                            listViewKey.Items.Add(lvi);
                            break;
                        case "NBitcoin.BitcoinExtKey":
                            BitcoinExtKey extKey = form.Result as BitcoinExtKey;
                            keyPair = new KeyPair(extKey);
                            lvi.Text = keyPair.PrivateKeyString;
                            lvi.Tag = keyPair;
                            lvi.SubItems.AddRange( new []{ keyPair.PubKey.ToString(), keyPair.Address.ToString() });
                            listViewKey.Items.Add(lvi);
                            break;
                    }
                }
            }
        }

        private void clearAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listViewAddress.Items.Clear();
        }

        private void clearAllToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            listViewKey.Items.Clear();
        }

        private void fromScriptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormAddressFromScript form = new FormAddressFromScript())
            {
                if (form.ShowDialog() == DialogResult.OK && form.Result != null)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = form.Result.ToString();
                    lvi.Tag = form.Result;
                    listViewAddress.Items.Add(lvi);
                }
            }
            
        }

        private void proofOfOwnershipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormProof form = new FormProof())
            {
                form.ShowDialog();
            }
        }

        private void findVanityAddressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormVanityAddress form = new FormVanityAddress())
            {
                form.ShowDialog();
            }
        }

        private void derivedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //unsecure key hierarchy
            ExtKey ceoKey = new ExtKey();
            _ceoPubkey = ceoKey.Neuter();
            TreeNode ceoNode = new TreeNode();
            ceoNode.Text = "CEO: " + ceoKey.ToString(Network.TestNet);
            ceoNode.Tag = ceoKey;

            ExtKey cfoKey = ceoKey.Derive(0, hardened: false);
            TreeNode cfoNode = new TreeNode();
            cfoNode.Text = "CFO: " + cfoKey.ToString(Network.TestNet);
            cfoNode.Tag = cfoKey;
            ceoNode.Nodes.Add(cfoNode);

            ExtKey ctoKey = ceoKey.Derive(1, hardened: false);
            TreeNode ctoNode = new TreeNode();
            ctoNode.Text = "CTO: " + ctoKey.ToString(Network.TestNet);
            ctoNode.Tag = ctoKey;
            ceoNode.Nodes.Add(ctoNode);

            treeViewDrived.Nodes.Add(ceoNode);
        }

        private void treeViewDrived_MouseClick(object sender, MouseEventArgs e)
        {
            TreeView treeView = sender as TreeView;
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                TreeNode item = treeView.GetNodeAt(e.X, e.Y);
                if (item != null)
                {
                    treeView.SelectedNode = item;
                    contextMenuStrip.Show(treeView, e.Location);
                }
            }
        }

        private void recoverParentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExtKey key = treeViewDrived.SelectedNode.Tag as ExtKey;

            if (key == null) return;

            //Recover ceo key with accounting private key and ceo public key 
            ExtKey recovered = key.GetParentExtKey(_ceoPubkey);

            MessageBox.Show("CEO: " + recovered.ToString(Network.TestNet));
        }
    }
}
