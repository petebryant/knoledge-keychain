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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.validateBase58ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAddressKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newAddressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.addKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageAddress.SuspendLayout();
            this.tabPageKeys.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.utilitiesToolStripMenuItem,
            this.addressToolStripMenuItem,
            this.keysToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(960, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
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
            this.validateBase58ToolStripMenuItem});
            this.utilitiesToolStripMenuItem.Name = "utilitiesToolStripMenuItem";
            this.utilitiesToolStripMenuItem.Size = new System.Drawing.Size(81, 29);
            this.utilitiesToolStripMenuItem.Text = "&Utilities";
            // 
            // validateBase58ToolStripMenuItem
            // 
            this.validateBase58ToolStripMenuItem.Name = "validateBase58ToolStripMenuItem";
            this.validateBase58ToolStripMenuItem.Size = new System.Drawing.Size(220, 30);
            this.validateBase58ToolStripMenuItem.Text = "&Validate Base58";
            this.validateBase58ToolStripMenuItem.Click += new System.EventHandler(this.validateBase58ToolStripMenuItem_Click);
            // 
            // addressToolStripMenuItem
            // 
            this.addressToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAddressKeyToolStripMenuItem,
            this.newAddressToolStripMenuItem});
            this.addressToolStripMenuItem.Name = "addressToolStripMenuItem";
            this.addressToolStripMenuItem.Size = new System.Drawing.Size(89, 29);
            this.addressToolStripMenuItem.Text = "&Address";
            // 
            // addAddressKeyToolStripMenuItem
            // 
            this.addAddressKeyToolStripMenuItem.Name = "addAddressKeyToolStripMenuItem";
            this.addAddressKeyToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.addAddressKeyToolStripMenuItem.Text = "&Add Address";
            this.addAddressKeyToolStripMenuItem.Click += new System.EventHandler(this.addAddressKeyToolStripMenuItem_Click);
            // 
            // newAddressToolStripMenuItem
            // 
            this.newAddressToolStripMenuItem.Name = "newAddressToolStripMenuItem";
            this.newAddressToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.newAddressToolStripMenuItem.Text = "&New Address";
            this.newAddressToolStripMenuItem.Click += new System.EventHandler(this.newAddressToolStripMenuItem_Click);
            // 
            // keysToolStripMenuItem
            // 
            this.keysToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addKeyToolStripMenuItem,
            this.newKeyToolStripMenuItem});
            this.keysToolStripMenuItem.Name = "keysToolStripMenuItem";
            this.keysToolStripMenuItem.Size = new System.Drawing.Size(60, 29);
            this.keysToolStripMenuItem.Text = "&Keys";
            // 
            // newKeyToolStripMenuItem
            // 
            this.newKeyToolStripMenuItem.Name = "newKeyToolStripMenuItem";
            this.newKeyToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.newKeyToolStripMenuItem.Text = "&New Key";
            this.newKeyToolStripMenuItem.Click += new System.EventHandler(this.newKeyToolStripMenuItem_Click);
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
            this.detailsToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(151, 34);
            this.contextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip_Opening);
            // 
            // detailsToolStripMenuItem
            // 
            this.detailsToolStripMenuItem.Name = "detailsToolStripMenuItem";
            this.detailsToolStripMenuItem.Size = new System.Drawing.Size(150, 30);
            this.detailsToolStripMenuItem.Text = "Details";
            this.detailsToolStripMenuItem.Click += new System.EventHandler(this.detailsToolStripMenuItem_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageAddress);
            this.tabControl.Controls.Add(this.tabPageKeys);
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
            // addKeyToolStripMenuItem
            // 
            this.addKeyToolStripMenuItem.Name = "addKeyToolStripMenuItem";
            this.addKeyToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.addKeyToolStripMenuItem.Text = "&Add Key";
            this.addKeyToolStripMenuItem.Click += new System.EventHandler(this.addKeyToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 599);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "knoledge-keychain";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPageAddress.ResumeLayout(false);
            this.tabPageKeys.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
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
    }
}

