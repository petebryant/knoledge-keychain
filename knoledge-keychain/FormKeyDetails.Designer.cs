﻿namespace knoledge_keychain
{
    partial class FormKeyDetails
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
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxBitcoinAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPubKey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxScriptPubKey = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPrivateKey = new System.Windows.Forms.TextBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createQRCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayTransactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPubHash = new System.Windows.Forms.TextBox();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 199);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Bitcoin Address";
            // 
            // textBoxBitcoinAddress
            // 
            this.textBoxBitcoinAddress.Location = new System.Drawing.Point(159, 195);
            this.textBoxBitcoinAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxBitcoinAddress.Name = "textBoxBitcoinAddress";
            this.textBoxBitcoinAddress.Size = new System.Drawing.Size(834, 26);
            this.textBoxBitcoinAddress.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 94);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Public Key";
            // 
            // textBoxPubKey
            // 
            this.textBoxPubKey.Location = new System.Drawing.Point(159, 89);
            this.textBoxPubKey.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxPubKey.Name = "textBoxPubKey";
            this.textBoxPubKey.Size = new System.Drawing.Size(834, 26);
            this.textBoxPubKey.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 164);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Script Pub Key";
            // 
            // textBoxScriptPubKey
            // 
            this.textBoxScriptPubKey.Location = new System.Drawing.Point(159, 159);
            this.textBoxScriptPubKey.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxScriptPubKey.Name = "textBoxScriptPubKey";
            this.textBoxScriptPubKey.Size = new System.Drawing.Size(834, 26);
            this.textBoxScriptPubKey.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 57);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Private Key";
            // 
            // textBoxPrivateKey
            // 
            this.textBoxPrivateKey.Location = new System.Drawing.Point(159, 53);
            this.textBoxPrivateKey.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxPrivateKey.Name = "textBoxPrivateKey";
            this.textBoxPrivateKey.Size = new System.Drawing.Size(834, 26);
            this.textBoxPrivateKey.TabIndex = 1;
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1023, 33);
            this.menuStrip.TabIndex = 13;
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
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createQRCodeToolStripMenuItem,
            this.displayTransactionsToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(88, 29);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // createQRCodeToolStripMenuItem
            // 
            this.createQRCodeToolStripMenuItem.Name = "createQRCodeToolStripMenuItem";
            this.createQRCodeToolStripMenuItem.Size = new System.Drawing.Size(256, 30);
            this.createQRCodeToolStripMenuItem.Text = "Create &QR Code";
            this.createQRCodeToolStripMenuItem.Click += new System.EventHandler(this.createQRCodeToolStripMenuItem_Click);
            // 
            // displayTransactionsToolStripMenuItem
            // 
            this.displayTransactionsToolStripMenuItem.Name = "displayTransactionsToolStripMenuItem";
            this.displayTransactionsToolStripMenuItem.Size = new System.Drawing.Size(256, 30);
            this.displayTransactionsToolStripMenuItem.Text = "Display &Transactions";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 128);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Public Key (Hash)";
            // 
            // textBoxPubHash
            // 
            this.textBoxPubHash.Location = new System.Drawing.Point(159, 123);
            this.textBoxPubHash.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxPubHash.Name = "textBoxPubHash";
            this.textBoxPubHash.Size = new System.Drawing.Size(834, 26);
            this.textBoxPubHash.TabIndex = 5;
            // 
            // FormKeyDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 265);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPubHash);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPrivateKey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxScriptPubKey);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxBitcoinAddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxPubKey);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormKeyDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Key Details";
            this.Load += new System.EventHandler(this.FormDetails_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxBitcoinAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPubKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxScriptPubKey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPrivateKey;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createQRCodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayTransactionsToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPubHash;
    }
}