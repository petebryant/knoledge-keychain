namespace knoledge_keychain
{
    partial class FormDetails
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
            this.textBoxPubHash = new System.Windows.Forms.TextBox();
            this.buttonBlockr = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxScriptPubKey = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 99);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Bitcoin Address";
            // 
            // textBoxBitcoinAddress
            // 
            this.textBoxBitcoinAddress.Location = new System.Drawing.Point(157, 95);
            this.textBoxBitcoinAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxBitcoinAddress.Name = "textBoxBitcoinAddress";
            this.textBoxBitcoinAddress.Size = new System.Drawing.Size(834, 26);
            this.textBoxBitcoinAddress.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 136);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Public Key (Hash)";
            // 
            // textBoxPubHash
            // 
            this.textBoxPubHash.Location = new System.Drawing.Point(157, 131);
            this.textBoxPubHash.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxPubHash.Name = "textBoxPubHash";
            this.textBoxPubHash.Size = new System.Drawing.Size(834, 26);
            this.textBoxPubHash.TabIndex = 4;
            // 
            // buttonBlockr
            // 
            this.buttonBlockr.Location = new System.Drawing.Point(1010, 93);
            this.buttonBlockr.Name = "buttonBlockr";
            this.buttonBlockr.Size = new System.Drawing.Size(50, 36);
            this.buttonBlockr.TabIndex = 2;
            this.buttonBlockr.Text = "...";
            this.buttonBlockr.UseVisualStyleBackColor = true;
            this.buttonBlockr.Click += new System.EventHandler(this.buttonBlockr_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Type";
            // 
            // textBoxType
            // 
            this.textBoxType.Location = new System.Drawing.Point(157, 16);
            this.textBoxType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.ReadOnly = true;
            this.textBoxType.Size = new System.Drawing.Size(834, 26);
            this.textBoxType.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 172);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Script Pub Key";
            // 
            // textBoxScriptPubKey
            // 
            this.textBoxScriptPubKey.Location = new System.Drawing.Point(157, 167);
            this.textBoxScriptPubKey.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxScriptPubKey.Name = "textBoxScriptPubKey";
            this.textBoxScriptPubKey.Size = new System.Drawing.Size(834, 26);
            this.textBoxScriptPubKey.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Address";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(157, 59);
            this.textBoxAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(834, 26);
            this.textBoxAddress.TabIndex = 10;
            // 
            // FormDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 434);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxScriptPubKey);
            this.Controls.Add(this.textBoxType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBlockr);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxBitcoinAddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxPubHash);
            this.Name = "FormDetails";
            this.Text = "Details";
            this.Load += new System.EventHandler(this.FormDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxBitcoinAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPubHash;
        private System.Windows.Forms.Button buttonBlockr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxScriptPubKey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAddress;
    }
}