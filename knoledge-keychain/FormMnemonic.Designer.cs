namespace knoledge_keychain
{
    partial class FormMnemonic
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxHDRoot = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxWordlist = new System.Windows.Forms.TextBox();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.comboBoxMnemonic = new System.Windows.Forms.ComboBox();
            this.comboBoxWordcount = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonRecover = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mnemonic";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bitcoin Secret";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Wordlist";
            // 
            // textBoxHDRoot
            // 
            this.textBoxHDRoot.Location = new System.Drawing.Point(146, 92);
            this.textBoxHDRoot.Name = "textBoxHDRoot";
            this.textBoxHDRoot.Size = new System.Drawing.Size(539, 26);
            this.textBoxHDRoot.TabIndex = 5;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(146, 124);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(539, 26);
            this.textBoxPassword.TabIndex = 7;
            // 
            // textBoxWordlist
            // 
            this.textBoxWordlist.Location = new System.Drawing.Point(146, 156);
            this.textBoxWordlist.Multiline = true;
            this.textBoxWordlist.Name = "textBoxWordlist";
            this.textBoxWordlist.Size = new System.Drawing.Size(539, 72);
            this.textBoxWordlist.TabIndex = 9;
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(712, 19);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(97, 33);
            this.buttonGenerate.TabIndex = 10;
            this.buttonGenerate.Text = "Generate";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // comboBoxMnemonic
            // 
            this.comboBoxMnemonic.FormattingEnabled = true;
            this.comboBoxMnemonic.Location = new System.Drawing.Point(146, 19);
            this.comboBoxMnemonic.Name = "comboBoxMnemonic";
            this.comboBoxMnemonic.Size = new System.Drawing.Size(539, 28);
            this.comboBoxMnemonic.TabIndex = 1;
            // 
            // comboBoxWordcount
            // 
            this.comboBoxWordcount.FormattingEnabled = true;
            this.comboBoxWordcount.Location = new System.Drawing.Point(146, 58);
            this.comboBoxWordcount.Name = "comboBoxWordcount";
            this.comboBoxWordcount.Size = new System.Drawing.Size(539, 28);
            this.comboBoxWordcount.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Word Count";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(712, 97);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(97, 33);
            this.buttonClear.TabIndex = 12;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonRecover
            // 
            this.buttonRecover.Location = new System.Drawing.Point(712, 58);
            this.buttonRecover.Name = "buttonRecover";
            this.buttonRecover.Size = new System.Drawing.Size(97, 33);
            this.buttonRecover.TabIndex = 11;
            this.buttonRecover.Text = "Recover";
            this.buttonRecover.UseVisualStyleBackColor = true;
            this.buttonRecover.Click += new System.EventHandler(this.buttonRecover_Click);
            // 
            // FormMnemonic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 240);
            this.Controls.Add(this.buttonRecover);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.comboBoxWordcount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxMnemonic);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.textBoxWordlist);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxHDRoot);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormMnemonic";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mnemonic";
            this.Load += new System.EventHandler(this.FormMnemonic_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxHDRoot;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxWordlist;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.ComboBox comboBoxMnemonic;
        private System.Windows.Forms.ComboBox comboBoxWordcount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonRecover;
    }
}