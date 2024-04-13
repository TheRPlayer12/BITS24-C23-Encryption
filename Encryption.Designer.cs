namespace BITS24_C23
{
    partial class Encryption
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SubmitBtn = new Button();
            label3 = new Label();
            InputTxt = new TextBox();
            OutputTxt = new TextBox();
            label4 = new Label();
            RsaKeyTxt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // SubmitBtn
            // 
            SubmitBtn.Location = new Point(426, 279);
            SubmitBtn.Name = "SubmitBtn";
            SubmitBtn.Size = new Size(133, 36);
            SubmitBtn.TabIndex = 0;
            SubmitBtn.Text = "Encrypt";
            SubmitBtn.UseVisualStyleBackColor = true;
            SubmitBtn.Click += SubmitBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(12, 46);
            label3.Name = "label3";
            label3.Size = new Size(107, 20);
            label3.TabIndex = 3;
            label3.Text = "Text to encrypt";
            // 
            // InputTxt
            // 
            InputTxt.Location = new Point(12, 79);
            InputTxt.Multiline = true;
            InputTxt.Name = "InputTxt";
            InputTxt.Size = new Size(278, 187);
            InputTxt.TabIndex = 4;
            // 
            // OutputTxt
            // 
            OutputTxt.Location = new Point(296, 79);
            OutputTxt.Multiline = true;
            OutputTxt.Name = "OutputTxt";
            OutputTxt.ReadOnly = true;
            OutputTxt.Size = new Size(263, 187);
            OutputTxt.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(296, 46);
            label4.Name = "label4";
            label4.Size = new Size(104, 20);
            label4.TabIndex = 6;
            label4.Text = "Encrypted text";
            // 
            // RsaKeyTxt
            // 
            RsaKeyTxt.Location = new Point(12, 292);
            RsaKeyTxt.Name = "RsaKeyTxt";
            RsaKeyTxt.Size = new Size(408, 23);
            RsaKeyTxt.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(12, 269);
            label1.Name = "label1";
            label1.Size = new Size(106, 20);
            label1.TabIndex = 8;
            label1.Text = "RSA Public key";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(141, 20);
            label2.TabIndex = 9;
            label2.Text = "RSA Text Encryption";
            // 
            // Encryption
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 327);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(RsaKeyTxt);
            Controls.Add(label4);
            Controls.Add(OutputTxt);
            Controls.Add(InputTxt);
            Controls.Add(label3);
            Controls.Add(SubmitBtn);
            Name = "Encryption";
            Text = "RSA Encryptor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SubmitBtn;
        private Label label3;
        private TextBox InputTxt;
        private TextBox OutputTxt;
        private Label label4;
        private TextBox RsaKeyTxt;
        private Label label1;
        private Label label2;
    }
}
