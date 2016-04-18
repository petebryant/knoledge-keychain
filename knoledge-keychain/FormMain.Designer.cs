namespace knoledge_keychain
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.validateBase58ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proofOfOwnershipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAddressKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newAddressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromScriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.clearAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.clearAllToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listViewAddress = new System.Windows.Forms.ListView();
            this.columnAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.detailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageAddress = new System.Windows.Forms.TabPage();
            this.tabPageKeys = new System.Windows.Forms.TabPage();
            this.listViewKey = new System.Windows.Forms.ListView();
            this.columnPrivateKey = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPublicKey = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnKeyAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.findVanityAddressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.derivedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPageDrived = new System.Windows.Forms.TabPage();
            this.treeViewDrived = new System.Windows.Forms.TreeView();
            this.recoverParentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageAddress.SuspendLayout();
            this.tabPageKeys.SuspendLayout();
            this.tabPageDrived.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.utilitiesToolStripMenuItem,
            this.addressToolStripMenuItem,
            this.keysToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(960, 33);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(189, 30);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // utilitiesToolStripMenuItem
            // 
            this.utilitiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.validateBase58ToolStripMenuItem,
            this.proofOfOwnershipToolStripMenuItem});
            this.utilitiesToolStripMenuItem.Name = "utilitiesToolStripMenuItem";
            this.utilitiesToolStripMenuItem.Size = new System.Drawing.Size(81, 29);
            this.utilitiesToolStripMenuItem.Text = "&Utilities";
            // 
            // validateBase58ToolStripMenuItem
            // 
            this.validateBase58ToolStripMenuItem.Name = "validateBase58ToolStripMenuItem";
            this.validateBase58ToolStripMenuItem.Size = new System.Drawing.Size(253, 30);
            this.validateBase58ToolStripMenuItem.Text = "&Validate Base58";
            this.validateBase58ToolStripMenuItem.Click += new System.EventHandler(this.validateBase58ToolStripMenuItem_Click);
            // 
            // proofOfOwnershipToolStripMenuItem
            // 
            this.proofOfOwnershipToolStripMenuItem.Name = "proofOfOwnershipToolStripMenuItem";
            this.proofOfOwnershipToolStripMenuItem.Size = new System.Drawing.Size(253, 30);
            this.proofOfOwnershipToolStripMenuItem.Text = "&Proof of Ownership";
            this.proofOfOwnershipToolStripMenuItem.Click += new System.EventHandler(this.proofOfOwnershipToolStripMenuItem_Click);
            // 
            // addressToolStripMenuItem
            // 
            this.addressToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAddressKeyToolStripMenuItem,
            this.newAddressToolStripMenuItem,
            this.fromScriptToolStripMenuItem,
            this.findVanityAddressToolStripMenuItem,
            this.toolStripSeparator1,
            this.clearAllToolStripMenuItem});
            this.addressToolStripMenuItem.Name = "addressToolStripMenuItem";
            this.addressToolStripMenuItem.Size = new System.Drawing.Size(89, 29);
            this.addressToolStripMenuItem.Text = "&Address";
            // 
            // addAddressKeyToolStripMenuItem
            // 
            this.addAddressKeyToolStripMenuItem.Name = "addAddressKeyToolStripMenuItem";
            this.addAddressKeyToolStripMenuItem.Size = new System.Drawing.Size(254, 30);
            this.addAddressKeyToolStripMenuItem.Text = "&Add Address";
            this.addAddressKeyToolStripMenuItem.Click += new System.EventHandler(this.addAddressKeyToolStripMenuItem_Click);
            // 
            // newAddressToolStripMenuItem
            // 
            this.newAddressToolStripMenuItem.Name = "newAddressToolStripMenuItem";
            this.newAddressToolStripMenuItem.Size = new System.Drawing.Size(254, 30);
            this.newAddressToolStripMenuItem.Text = "&New Address";
            this.newAddressToolStripMenuItem.Click += new System.EventHandler(this.newAddressToolStripMenuItem_Click);
            // 
            // fromScriptToolStripMenuItem
            // 
            this.fromScriptToolStripMenuItem.Name = "fromScriptToolStripMenuItem";
            this.fromScriptToolStripMenuItem.Size = new System.Drawing.Size(254, 30);
            this.fromScriptToolStripMenuItem.Text = "From &Script";
            this.fromScriptToolStripMenuItem.Click += new System.EventHandler(this.fromScriptToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(251, 6);
            // 
            // clearAllToolStripMenuItem
            // 
            this.clearAllToolStripMenuItem.Name = "clearAllToolStripMenuItem";
            this.clearAllToolStripMenuItem.Size = new System.Drawing.Size(254, 30);
            this.clearAllToolStripMenuItem.Text = "&Clear All";
            this.clearAllToolStripMenuItem.Click += new System.EventHandler(this.clearAllToolStripMenuItem_Click);
            // 
            // keysToolStripMenuItem
            // 
            this.keysToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addKeyToolStripMenuItem,
            this.newKeyToolStripMenuItem,
            this.derivedToolStripMenuItem,
            this.toolStripSeparator2,
            this.clearAllToolStripMenuItem1});
            this.keysToolStripMenuItem.Name = "keysToolStripMenuItem";
            this.keysToolStripMenuItem.Size = new System.Drawing.Size(60, 29);
            this.keysToolStripMenuItem.Text = "&Keys";
            // 
            // addKeyToolStripMenuItem
            // 
            this.addKeyToolStripMenuItem.Name = "addKeyToolStripMenuItem";
            this.addKeyToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.addKeyToolStripMenuItem.Text = "&Add Key";
            this.addKeyToolStripMenuItem.Click += new System.EventHandler(this.addKeyToolStripMenuItem_Click);
            // 
            // newKeyToolStripMenuItem
            // 
            this.newKeyToolStripMenuItem.Name = "newKeyToolStripMenuItem";
            this.newKeyToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.newKeyToolStripMenuItem.Text = "&New Key";
            this.newKeyToolStripMenuItem.Click += new System.EventHandler(this.newKeyToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(208, 6);
            // 
            // clearAllToolStripMenuItem1
            // 
            this.clearAllToolStripMenuItem1.Name = "clearAllToolStripMenuItem1";
            this.clearAllToolStripMenuItem1.Size = new System.Drawing.Size(211, 30);
            this.clearAllToolStripMenuItem1.Text = "&Clear All";
            this.clearAllToolStripMenuItem1.Click += new System.EventHandler(this.clearAllToolStripMenuItem1_Click);
            // 
            // listViewAddress
            // 
            this.listViewAddress.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnAddress});
            this.listViewAddress.ContextMenuStrip = this.contextMenuStrip;
            this.listViewAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewAddress.FullRowSelect = true;
            this.listViewAddress.Location = new System.Drawing.Point(3, 3);
            this.listViewAddress.Name = "listViewAddress";
            this.listViewAddress.Size = new System.Drawing.Size(946, 527);
            this.listViewAddress.TabIndex = 1;
            this.listViewAddress.UseCompatibleStateImageBehavior = false;
            this.listViewAddress.View = System.Windows.Forms.View.Details;
            this.listViewAddress.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView_MouseClick);
            // 
            // columnAddress
            // 
            this.columnAddress.Text = "Address";
            this.columnAddress.Width = 480;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detailsToolStripMenuItem,
            this.recoverParentToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(214, 97);
            this.contextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip_Opening);
            // 
            // detailsToolStripMenuItem
            // 
            this.detailsToolStripMenuItem.Name = "detailsToolStripMenuItem";
            this.detailsToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.detailsToolStripMenuItem.Text = "Details";
            this.detailsToolStripMenuItem.Click += new System.EventHandler(this.detailsToolStripMenuItem_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageAddress);
            this.tabControl.Controls.Add(this.tabPageKeys);
            this.tabControl.Controls.Add(this.tabPageDrived);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 33);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(960, 566);
            this.tabControl.TabIndex = 2;
            // 
            // tabPageAddress
            // 
            this.tabPageAddress.Controls.Add(this.listViewAddress);
            this.tabPageAddress.Location = new System.Drawing.Point(4, 29);
            this.tabPageAddress.Name = "tabPageAddress";
            this.tabPageAddress.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddress.Size = new System.Drawing.Size(952, 533);
            this.tabPageAddress.TabIndex = 0;
            this.tabPageAddress.Text = "Addresses";
            this.tabPageAddress.UseVisualStyleBackColor = true;
            // 
            // tabPageKeys
            // 
            this.tabPageKeys.Controls.Add(this.listViewKey);
            this.tabPageKeys.Location = new System.Drawing.Point(4, 29);
            this.tabPageKeys.Name = "tabPageKeys";
            this.tabPageKeys.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageKeys.Size = new System.Drawing.Size(952, 533);
            this.tabPageKeys.TabIndex = 1;
            this.tabPageKeys.Text = "Keys";
            this.tabPageKeys.UseVisualStyleBackColor = true;
            // 
            // listViewKey
            // 
            this.listViewKey.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnPrivateKey,
            this.columnPublicKey,
            this.columnKeyAddress});
            this.listViewKey.ContextMenuStrip = this.contextMenuStrip;
            this.listViewKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewKey.FullRowSelect = true;
            this.listViewKey.Location = new System.Drawing.Point(3, 3);
            this.listViewKey.Name = "listViewKey";
            this.listViewKey.Size = new System.Drawing.Size(946, 527);
            this.listViewKey.TabIndex = 2;
            this.listViewKey.UseCompatibleStateImageBehavior = false;
            this.listViewKey.View = System.Windows.Forms.View.Details;
            // 
            // columnPrivateKey
            // 
            this.columnPrivateKey.Text = "Private Key";
            this.columnPrivateKey.Width = 400;
            // 
            // columnPublicKey
            // 
            this.columnPublicKey.Text = "Public Key";
            this.columnPublicKey.Width = 400;
            // 
            // columnKeyAddress
            // 
            this.columnKeyAddress.Text = "Address";
            this.columnKeyAddress.Width = 400;
            // 
            // findVanityAddressToolStripMenuItem
            // 
            this.findVanityAddressToolStripMenuItem.Name = "findVanityAddressToolStripMenuItem";
            this.findVanityAddressToolStripMenuItem.Size = new System.Drawing.Size(254, 30);
            this.findVanityAddressToolStripMenuItem.Text = "Find &Vanity Address";
            this.findVanityAddressToolStripMenuItem.Click += new System.EventHandler(this.findVanityAddressToolStripMenuItem_Click);
            // 
            // derivedToolStripMenuItem
            // 
            this.derivedToolStripMenuItem.Name = "derivedToolStripMenuItem";
            this.derivedToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.derivedToolStripMenuItem.Text = "&Derived";
            this.derivedToolStripMenuItem.Click += new System.EventHandler(this.derivedToolStripMenuItem_Click);
            // 
            // tabPageDrived
            // 
            this.tabPageDrived.Controls.Add(this.treeViewDrived);
            this.tabPageDrived.Location = new System.Drawing.Point(4, 29);
            this.tabPageDrived.Name = "tabPageDrived";
            this.tabPageDrived.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDrived.Size = new System.Drawing.Size(952, 533);
            this.tabPageDrived.TabIndex = 2;
            this.tabPageDrived.Text = "Derived Keys";
            this.tabPageDrived.UseVisualStyleBackColor = true;
            // 
            // treeViewDrived
            // 
            this.treeViewDrived.ContextMenuStrip = this.contextMenuStrip;
            this.treeViewDrived.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewDrived.Location = new System.Drawing.Point(3, 3);
            this.treeViewDrived.Name = "treeViewDrived";
            this.treeViewDrived.Size = new System.Drawing.Size(946, 527);
            this.treeViewDrived.TabIndex = 0;
            this.treeViewDrived.MouseClick += new System.Windows.Forms.MouseEventHandler(this.treeViewDrived_MouseClick);
            // 
            // recoverParentToolStripMenuItem
            // 
            this.recoverParentToolStripMenuItem.Name = "recoverParentToolStripMenuItem";
            this.recoverParentToolStripMenuItem.Size = new System.Drawing.Size(213, 30);
            this.recoverParentToolStripMenuItem.Text = "&Recover Parent";
            this.recoverParentToolStripMenuItem.Click += new System.EventHandler(this.recoverParentToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 599);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormMain";
            this.Text = "knoledge-keychain";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPageAddress.ResumeLayout(false);
            this.tabPageKeys.ResumeLayout(false);
            this.tabPageDrived.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem validateBase58ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addressToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAddressKeyToolStripMenuItem;
        private System.Windows.Forms.ListView listViewAddress;
        private System.Windows.Forms.ColumnHeader columnAddress;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem detailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newAddressToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem keysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newKeyToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageAddress;
        private System.Windows.Forms.TabPage tabPageKeys;
        private System.Windows.Forms.ListView listViewKey;
        private System.Windows.Forms.ColumnHeader columnPrivateKey;
        private System.Windows.Forms.ColumnHeader columnPublicKey;
        private System.Windows.Forms.ColumnHeader columnKeyAddress;
        private System.Windows.Forms.ToolStripMenuItem addKeyToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem clearAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem clearAllToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fromScriptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proofOfOwnershipToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findVanityAddressToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem derivedToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPageDrived;
        private System.Windows.Forms.TreeView treeViewDrived;
        private System.Windows.Forms.ToolStripMenuItem recoverParentToolStripMenuItem;
    }
}

