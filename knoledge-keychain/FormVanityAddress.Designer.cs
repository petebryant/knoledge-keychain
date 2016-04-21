namespace knoledge_keychain
{
    partial class FormVanityAddress
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVanityAddress));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.buttonFind = new System.Windows.Forms.Button();
            this.textBoxVanity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Location = new System.Drawing.Point(591, 61);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(612, 544);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(685, 6);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 38);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Enabled = false;
            this.textBoxOutput.Location = new System.Drawing.Point(21, 61);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxOutput.Size = new System.Drawing.Size(544, 544);
            this.textBoxOutput.TabIndex = 10;
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(604, 6);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(75, 38);
            this.buttonFind.TabIndex = 8;
            this.buttonFind.Text = "Find";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // textBoxVanity
            // 
            this.textBoxVanity.Location = new System.Drawing.Point(70, 12);
            this.textBoxVanity.Name = "textBoxVanity";
            this.textBoxVanity.Size = new System.Drawing.Size(516, 26);
            this.textBoxVanity.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Vanity:";
            // 
            // FormVanityAddress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 640);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.textBoxVanity);
            this.Controls.Add(this.label1);
            this.Name = "FormVanityAddress";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Vanity Address";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormVanityAddress_FormClosing);
            this.Load += new System.EventHandler(this.FormVanityAddress_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.TextBox textBoxVanity;
        private System.Windows.Forms.Label label1;
    }
}