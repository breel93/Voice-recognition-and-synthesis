namespace SpeechRecognition
{
    partial class Form1
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.enableVoiceBtn = new System.Windows.Forms.Button();
            this.disabledVoiceBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(260, 212);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // enableVoiceBtn
            // 
            this.enableVoiceBtn.Location = new System.Drawing.Point(12, 230);
            this.enableVoiceBtn.Name = "enableVoiceBtn";
            this.enableVoiceBtn.Size = new System.Drawing.Size(123, 23);
            this.enableVoiceBtn.TabIndex = 1;
            this.enableVoiceBtn.Text = "Voice Enabled";
            this.enableVoiceBtn.UseVisualStyleBackColor = true;
            this.enableVoiceBtn.Click += new System.EventHandler(this.enableVoiceBtn_Click);
            // 
            // disabledVoiceBtn
            // 
            this.disabledVoiceBtn.Enabled = false;
            this.disabledVoiceBtn.Location = new System.Drawing.Point(141, 230);
            this.disabledVoiceBtn.Name = "disabledVoiceBtn";
            this.disabledVoiceBtn.Size = new System.Drawing.Size(131, 23);
            this.disabledVoiceBtn.TabIndex = 2;
            this.disabledVoiceBtn.Text = "Voice Disabled";
            this.disabledVoiceBtn.UseVisualStyleBackColor = true;
            this.disabledVoiceBtn.Click += new System.EventHandler(this.disabledVoiceBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.disabledVoiceBtn);
            this.Controls.Add(this.enableVoiceBtn);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button enableVoiceBtn;
        private System.Windows.Forms.Button disabledVoiceBtn;
    }
}

