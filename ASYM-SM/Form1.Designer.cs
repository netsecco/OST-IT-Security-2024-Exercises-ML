namespace ASYM_SM
{
    partial class Form1
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
            textBoxP = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBoxQ = new TextBox();
            label3 = new Label();
            textBoxN = new TextBox();
            label4 = new Label();
            textBoxPhi = new TextBox();
            label5 = new Label();
            textBoxE = new TextBox();
            label6 = new Label();
            textBoxD = new TextBox();
            label7 = new Label();
            textBoxClearValue = new TextBox();
            label8 = new Label();
            textBoxCipherValue = new TextBox();
            buttonEncrypt = new Button();
            buttonDecrypt = new Button();
            label9 = new Label();
            textBoxDecryptedValue = new TextBox();
            textBoxClearText = new TextBox();
            textBoxDecryptedText = new TextBox();
            SuspendLayout();
            // 
            // textBoxP
            // 
            textBoxP.Location = new Point(46, 38);
            textBoxP.Margin = new Padding(4, 5, 4, 5);
            textBoxP.Name = "textBoxP";
            textBoxP.Size = new Size(178, 31);
            textBoxP.TabIndex = 0;
            textBoxP.Text = "46399";
            textBoxP.TextChanged += textBoxP_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 43);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(23, 25);
            label1.TabIndex = 1;
            label1.Text = "p";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 92);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(23, 25);
            label2.TabIndex = 3;
            label2.Text = "q";
            // 
            // textBoxQ
            // 
            textBoxQ.Location = new Point(46, 87);
            textBoxQ.Margin = new Padding(4, 5, 4, 5);
            textBoxQ.Name = "textBoxQ";
            textBoxQ.Size = new Size(178, 31);
            textBoxQ.TabIndex = 2;
            textBoxQ.Text = "34679";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(379, 43);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(77, 25);
            label3.TabIndex = 5;
            label3.Text = "N = p*q";
            // 
            // textBoxN
            // 
            textBoxN.Location = new Point(457, 38);
            textBoxN.Margin = new Padding(4, 5, 4, 5);
            textBoxN.Name = "textBoxN";
            textBoxN.Size = new Size(178, 31);
            textBoxN.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(276, 92);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(181, 25);
            label4.TabIndex = 7;
            label4.Text = "phy(N) = (p-1) * (q-1)";
            // 
            // textBoxPhi
            // 
            textBoxPhi.Location = new Point(457, 87);
            textBoxPhi.Margin = new Padding(4, 5, 4, 5);
            textBoxPhi.Name = "textBoxPhi";
            textBoxPhi.Size = new Size(178, 31);
            textBoxPhi.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 162);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(21, 25);
            label5.TabIndex = 9;
            label5.Text = "e";
            // 
            // textBoxE
            // 
            textBoxE.Location = new Point(46, 157);
            textBoxE.Margin = new Padding(4, 5, 4, 5);
            textBoxE.Name = "textBoxE";
            textBoxE.Size = new Size(178, 31);
            textBoxE.TabIndex = 8;
            textBoxE.Text = "65537";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(266, 162);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(23, 25);
            label6.TabIndex = 11;
            label6.Text = "d";
            // 
            // textBoxD
            // 
            textBoxD.Location = new Point(294, 157);
            textBoxD.Margin = new Padding(4, 5, 4, 5);
            textBoxD.Name = "textBoxD";
            textBoxD.Size = new Size(178, 31);
            textBoxD.TabIndex = 10;
            textBoxD.Text = "471327449";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(46, 250);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(94, 25);
            label7.TabIndex = 13;
            label7.Text = "clear value";
            // 
            // textBoxClearValue
            // 
            textBoxClearValue.Location = new Point(144, 245);
            textBoxClearValue.Margin = new Padding(4, 5, 4, 5);
            textBoxClearValue.Name = "textBoxClearValue";
            textBoxClearValue.Size = new Size(178, 31);
            textBoxClearValue.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(34, 345);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(106, 25);
            label8.TabIndex = 15;
            label8.Text = "cipher value";
            // 
            // textBoxCipherValue
            // 
            textBoxCipherValue.Location = new Point(144, 340);
            textBoxCipherValue.Margin = new Padding(4, 5, 4, 5);
            textBoxCipherValue.Name = "textBoxCipherValue";
            textBoxCipherValue.Size = new Size(178, 31);
            textBoxCipherValue.TabIndex = 14;
            // 
            // buttonEncrypt
            // 
            buttonEncrypt.Location = new Point(179, 293);
            buttonEncrypt.Margin = new Padding(4, 5, 4, 5);
            buttonEncrypt.Name = "buttonEncrypt";
            buttonEncrypt.Size = new Size(107, 38);
            buttonEncrypt.TabIndex = 16;
            buttonEncrypt.Text = "Encrypt";
            buttonEncrypt.UseVisualStyleBackColor = true;
            buttonEncrypt.Click += buttonEncrypt_Click;
            // 
            // buttonDecrypt
            // 
            buttonDecrypt.Location = new Point(179, 388);
            buttonDecrypt.Margin = new Padding(4, 5, 4, 5);
            buttonDecrypt.Name = "buttonDecrypt";
            buttonDecrypt.Size = new Size(107, 38);
            buttonDecrypt.TabIndex = 19;
            buttonDecrypt.Text = "Decrypt";
            buttonDecrypt.UseVisualStyleBackColor = true;
            buttonDecrypt.Click += buttonDecrypt_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 440);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(138, 25);
            label9.TabIndex = 18;
            label9.Text = "decrypted value";
            // 
            // textBoxDecryptedValue
            // 
            textBoxDecryptedValue.Location = new Point(144, 435);
            textBoxDecryptedValue.Margin = new Padding(4, 5, 4, 5);
            textBoxDecryptedValue.Name = "textBoxDecryptedValue";
            textBoxDecryptedValue.Size = new Size(178, 31);
            textBoxDecryptedValue.TabIndex = 17;
            // 
            // textBoxClearText
            // 
            textBoxClearText.Location = new Point(364, 244);
            textBoxClearText.Margin = new Padding(4, 5, 4, 5);
            textBoxClearText.Name = "textBoxClearText";
            textBoxClearText.Size = new Size(178, 31);
            textBoxClearText.TabIndex = 20;
            textBoxClearText.TextChanged += textBoxClearText_TextChanged;
            // 
            // textBoxDecryptedText
            // 
            textBoxDecryptedText.Location = new Point(364, 435);
            textBoxDecryptedText.Margin = new Padding(4, 5, 4, 5);
            textBoxDecryptedText.Name = "textBoxDecryptedText";
            textBoxDecryptedText.Size = new Size(178, 31);
            textBoxDecryptedText.TabIndex = 21;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 750);
            Controls.Add(textBoxDecryptedText);
            Controls.Add(textBoxClearText);
            Controls.Add(buttonDecrypt);
            Controls.Add(label9);
            Controls.Add(textBoxDecryptedValue);
            Controls.Add(buttonEncrypt);
            Controls.Add(label8);
            Controls.Add(textBoxCipherValue);
            Controls.Add(label7);
            Controls.Add(textBoxClearValue);
            Controls.Add(label6);
            Controls.Add(textBoxD);
            Controls.Add(label5);
            Controls.Add(textBoxE);
            Controls.Add(label4);
            Controls.Add(textBoxPhi);
            Controls.Add(label3);
            Controls.Add(textBoxN);
            Controls.Add(label2);
            Controls.Add(textBoxQ);
            Controls.Add(label1);
            Controls.Add(textBoxP);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxP;
        private Label label1;
        private Label label2;
        private TextBox textBoxQ;
        private Label label3;
        private TextBox textBoxN;
        private Label label4;
        private TextBox textBoxPhi;
        private Label label5;
        private TextBox textBoxE;
        private Label label6;
        private TextBox textBoxD;
        private Label label7;
        private TextBox textBoxClearValue;
        private Label label8;
        private TextBox textBoxCipherValue;
        private Button buttonEncrypt;
        private Button buttonDecrypt;
        private Label label9;
        private TextBox textBoxDecryptedValue;
        private TextBox textBoxClearText;
        private TextBox textBoxDecryptedText;
    }
}