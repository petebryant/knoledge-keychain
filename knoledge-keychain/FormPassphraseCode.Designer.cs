namespace knoledge_keychain
{
    partial class FormPassphraseCode
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPhrase = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonPassphrase = new System.Windows.Forms.Button();
            this.textBoxEncKey = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxConfirmation = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "PassphraseCode";
            // 
            // textBoxPhrase
            // 
            this.textBoxPhrase.Location = new System.Drawing.Point(183, 57);
            this.textBoxPhrase.Name = "textBoxPhrase";
            this.textBoxPhrase.Size = new System.Drawing.Size(805, 26);
            this.textBoxPhrase.TabIndex = 3;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(183, 25);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(805, 26);
            this.textBoxPassword.TabIndex = 1;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(1013, 155);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(133, 35);
            this.buttonClear.TabIndex = 13;
            this.buttonClear.Text = "Clear All";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonPassphrase
            // 
            this.buttonPassphrase.Location = new System.Drawing.Point(1013, 28);
            this.buttonPassphrase.Name = "buttonPassphrase";
            this.buttonPassphrase.Size = new System.Drawing.Size(133, 35);
            this.buttonPassphrase.TabIndex = 10;
            this.buttonPassphrase.Text = "Passphrase";
            this.buttonPassphrase.UseVisualStyleBackColor = true;
            this.buttonPassphrase.Click += new System.EventHandler(this.buttonPassphrase_Click);
            // 
            // textBoxEncKey
            // 
            this.textBoxEncKey.Location = new System.Drawing.Point(183, 121);
            this.textBoxEncKey.Name = "textBoxEncKey";
            this.textBoxEncKey.Size = new System.Drawing.Size(805, 26);
            this.textBoxEncKey.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Encrypted Key";
            // 
            // textBoxConfirmation
            // 
            this.textBoxConfirmation.Location = new System.Drawing.Point(184, 153);
            this.textBoxConfirmation.Name = "textBoxConfirmation";
            this.textBoxConfirmation.Size = new System.Drawing.Size(805, 26);
            this.textBoxConfirmation.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Confirmation Code";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(183, 89);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(805, 26);
            this.textBoxAddress.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Address";
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(1013, 69);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(133, 35);
            this.buttonGenerate.TabIndex = 11;
            this.buttonGenerate.Text = "Generate Key";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(1013, 110);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(133, 35);
            this.buttonConfirm.TabIndex = 12;
            this.buttonConfirm.Text = "Confirm";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // FormPassphraseCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 241);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxConfirmation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxEncKey);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonPassphrase);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxPhrase);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormPassphraseCode";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Passphrase Code";
            this.Load += new System.EventHandler(this.FormPassphraseCode_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPhrase;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonPassphrase;
        private System.Windows.Forms.TextBox textBoxEncKey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxConfirmation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Button buttonConfirm;
    }
}