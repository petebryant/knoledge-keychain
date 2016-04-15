namespace knoledge_keychain
{
    partial class FormProof
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
            this.textBoxBase58 = new System.Windows.Forms.TextBox();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSig = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonVerify = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bitcoin Secret / \r\nAddress";
            // 
            // textBoxBase58
            // 
            this.textBoxBase58.Location = new System.Drawing.Point(143, 88);
            this.textBoxBase58.Name = "textBoxBase58";
            this.textBoxBase58.Size = new System.Drawing.Size(690, 26);
            this.textBoxBase58.TabIndex = 1;
            this.textBoxBase58.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(677, 226);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(75, 36);
            this.buttonCreate.TabIndex = 10;
            this.buttonCreate.Text = "Create";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Location = new System.Drawing.Point(143, 131);
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(690, 26);
            this.textBoxMessage.TabIndex = 5;
            this.textBoxMessage.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Message";
            // 
            // textBoxSig
            // 
            this.textBoxSig.Location = new System.Drawing.Point(143, 175);
            this.textBoxSig.Name = "textBoxSig";
            this.textBoxSig.Size = new System.Drawing.Size(690, 26);
            this.textBoxSig.TabIndex = 7;
            this.textBoxSig.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Signature";
            // 
            // buttonVerify
            // 
            this.buttonVerify.Location = new System.Drawing.Point(758, 226);
            this.buttonVerify.Name = "buttonVerify";
            this.buttonVerify.Size = new System.Drawing.Size(75, 36);
            this.buttonVerify.TabIndex = 11;
            this.buttonVerify.Text = "Verify";
            this.buttonVerify.UseVisualStyleBackColor = true;
            this.buttonVerify.Click += new System.EventHandler(this.buttonVerify_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(596, 226);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 36);
            this.buttonClear.TabIndex = 9;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(190, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(558, 40);
            this.label5.TabIndex = 8;
            this.label5.Text = "Enter a Base58 Bitcoin Secret or Address, the Message and the Signature \r\nof the " +
    "signed message,  or click [Create] to create detailas that can be verified.\r\n";
            // 
            // FormProof
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 321);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonVerify);
            this.Controls.Add(this.textBoxSig);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.textBoxBase58);
            this.Controls.Add(this.label1);
            this.Name = "FormProof";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Proof of Ownership";
            this.Load += new System.EventHandler(this.FormProof_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxBase58;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSig;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonVerify;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label label5;
    }
}