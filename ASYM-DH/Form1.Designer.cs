namespace ASYM_DH
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
            groupBox1 = new GroupBox();
            buttonAliceCalcKey = new Button();
            label6 = new Label();
            textBoxAliceK = new TextBox();
            label5 = new Label();
            textBoxAlice_B = new TextBox();
            buttonAliceCalcA = new Button();
            label4 = new Label();
            textBoxAlice_A = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBoxAliceA = new TextBox();
            textBoxAliceG = new TextBox();
            textBoxAliceP = new TextBox();
            groupBox2 = new GroupBox();
            buttonBobCalcKey = new Button();
            label7 = new Label();
            textBoxBobKey = new TextBox();
            label8 = new Label();
            textBoxBob_A = new TextBox();
            buttonBobCalcB = new Button();
            label9 = new Label();
            textBoxBob_B = new TextBox();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            textBoxBobB = new TextBox();
            textBoxBobG = new TextBox();
            textBoxBobP = new TextBox();
            buttonSendPGtoBob = new Button();
            buttonSendAtoBob = new Button();
            buttonSendBtoAlice = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonAliceCalcKey);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textBoxAliceK);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBoxAlice_B);
            groupBox1.Controls.Add(buttonAliceCalcA);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBoxAlice_A);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBoxAliceA);
            groupBox1.Controls.Add(textBoxAliceG);
            groupBox1.Controls.Add(textBoxAliceP);
            groupBox1.Location = new Point(31, 33);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(271, 540);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Alice";
            // 
            // buttonAliceCalcKey
            // 
            buttonAliceCalcKey.Location = new Point(60, 403);
            buttonAliceCalcKey.Margin = new Padding(4, 5, 4, 5);
            buttonAliceCalcKey.Name = "buttonAliceCalcKey";
            buttonAliceCalcKey.Size = new Size(143, 38);
            buttonAliceCalcKey.TabIndex = 13;
            buttonAliceCalcKey.Text = "calculate Key";
            buttonAliceCalcKey.UseVisualStyleBackColor = true;
            buttonAliceCalcKey.Click += buttonAliceCalcKey_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 457);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(22, 25);
            label6.TabIndex = 12;
            label6.Text = "K";
            // 
            // textBoxAliceK
            // 
            textBoxAliceK.Location = new Point(60, 452);
            textBoxAliceK.Margin = new Padding(4, 5, 4, 5);
            textBoxAliceK.Name = "textBoxAliceK";
            textBoxAliceK.Size = new Size(141, 31);
            textBoxAliceK.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 358);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(22, 25);
            label5.TabIndex = 10;
            label5.Text = "B";
            // 
            // textBoxAlice_B
            // 
            textBoxAlice_B.Location = new Point(60, 353);
            textBoxAlice_B.Margin = new Padding(4, 5, 4, 5);
            textBoxAlice_B.Name = "textBoxAlice_B";
            textBoxAlice_B.Size = new Size(141, 31);
            textBoxAlice_B.TabIndex = 9;
            // 
            // buttonAliceCalcA
            // 
            buttonAliceCalcA.Location = new Point(60, 237);
            buttonAliceCalcA.Margin = new Padding(4, 5, 4, 5);
            buttonAliceCalcA.Name = "buttonAliceCalcA";
            buttonAliceCalcA.Size = new Size(143, 38);
            buttonAliceCalcA.TabIndex = 8;
            buttonAliceCalcA.Text = "calculate A";
            buttonAliceCalcA.UseVisualStyleBackColor = true;
            buttonAliceCalcA.Click += buttonAliceCalcA_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 290);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(24, 25);
            label4.TabIndex = 7;
            label4.Text = "A";
            // 
            // textBoxAlice_A
            // 
            textBoxAlice_A.Location = new Point(60, 285);
            textBoxAlice_A.Margin = new Padding(4, 5, 4, 5);
            textBoxAlice_A.Name = "textBoxAlice_A";
            textBoxAlice_A.Size = new Size(141, 31);
            textBoxAlice_A.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 193);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(21, 25);
            label3.TabIndex = 5;
            label3.Text = "a";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 123);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(23, 25);
            label2.TabIndex = 4;
            label2.Text = "g";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 63);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(23, 25);
            label1.TabIndex = 3;
            label1.Text = "p";
            // 
            // textBoxAliceA
            // 
            textBoxAliceA.Location = new Point(60, 188);
            textBoxAliceA.Margin = new Padding(4, 5, 4, 5);
            textBoxAliceA.Name = "textBoxAliceA";
            textBoxAliceA.Size = new Size(141, 31);
            textBoxAliceA.TabIndex = 2;
            // 
            // textBoxAliceG
            // 
            textBoxAliceG.Location = new Point(60, 118);
            textBoxAliceG.Margin = new Padding(4, 5, 4, 5);
            textBoxAliceG.Name = "textBoxAliceG";
            textBoxAliceG.Size = new Size(141, 31);
            textBoxAliceG.TabIndex = 1;
            textBoxAliceG.Text = "2281";
            // 
            // textBoxAliceP
            // 
            textBoxAliceP.Location = new Point(60, 55);
            textBoxAliceP.Margin = new Padding(4, 5, 4, 5);
            textBoxAliceP.Name = "textBoxAliceP";
            textBoxAliceP.Size = new Size(141, 31);
            textBoxAliceP.TabIndex = 0;
            textBoxAliceP.Text = "8527";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(buttonBobCalcKey);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(textBoxBobKey);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(textBoxBob_A);
            groupBox2.Controls.Add(buttonBobCalcB);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(textBoxBob_B);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(textBoxBobB);
            groupBox2.Controls.Add(textBoxBobG);
            groupBox2.Controls.Add(textBoxBobP);
            groupBox2.Location = new Point(451, 33);
            groupBox2.Margin = new Padding(4, 5, 4, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 5, 4, 5);
            groupBox2.Size = new Size(271, 540);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Bob";
            // 
            // buttonBobCalcKey
            // 
            buttonBobCalcKey.Location = new Point(60, 403);
            buttonBobCalcKey.Margin = new Padding(4, 5, 4, 5);
            buttonBobCalcKey.Name = "buttonBobCalcKey";
            buttonBobCalcKey.Size = new Size(143, 38);
            buttonBobCalcKey.TabIndex = 13;
            buttonBobCalcKey.Text = "calculate Key";
            buttonBobCalcKey.UseVisualStyleBackColor = true;
            buttonBobCalcKey.Click += buttonBobCalcKey_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 457);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(22, 25);
            label7.TabIndex = 12;
            label7.Text = "K";
            // 
            // textBoxBobKey
            // 
            textBoxBobKey.Location = new Point(60, 452);
            textBoxBobKey.Margin = new Padding(4, 5, 4, 5);
            textBoxBobKey.Name = "textBoxBobKey";
            textBoxBobKey.Size = new Size(141, 31);
            textBoxBobKey.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(14, 358);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(24, 25);
            label8.TabIndex = 10;
            label8.Text = "A";
            // 
            // textBoxBob_A
            // 
            textBoxBob_A.Location = new Point(60, 353);
            textBoxBob_A.Margin = new Padding(4, 5, 4, 5);
            textBoxBob_A.Name = "textBoxBob_A";
            textBoxBob_A.Size = new Size(141, 31);
            textBoxBob_A.TabIndex = 9;
            // 
            // buttonBobCalcB
            // 
            buttonBobCalcB.Location = new Point(60, 237);
            buttonBobCalcB.Margin = new Padding(4, 5, 4, 5);
            buttonBobCalcB.Name = "buttonBobCalcB";
            buttonBobCalcB.Size = new Size(143, 38);
            buttonBobCalcB.TabIndex = 8;
            buttonBobCalcB.Text = "calculate B";
            buttonBobCalcB.UseVisualStyleBackColor = true;
            buttonBobCalcB.Click += buttonBobCalcB_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(14, 290);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(22, 25);
            label9.TabIndex = 7;
            label9.Text = "B";
            // 
            // textBoxBob_B
            // 
            textBoxBob_B.Location = new Point(60, 285);
            textBoxBob_B.Margin = new Padding(4, 5, 4, 5);
            textBoxBob_B.Name = "textBoxBob_B";
            textBoxBob_B.Size = new Size(141, 31);
            textBoxBob_B.TabIndex = 6;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(14, 193);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(23, 25);
            label10.TabIndex = 5;
            label10.Text = "b";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(14, 123);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(23, 25);
            label11.TabIndex = 4;
            label11.Text = "g";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(14, 63);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(23, 25);
            label12.TabIndex = 3;
            label12.Text = "p";
            // 
            // textBoxBobB
            // 
            textBoxBobB.Location = new Point(60, 188);
            textBoxBobB.Margin = new Padding(4, 5, 4, 5);
            textBoxBobB.Name = "textBoxBobB";
            textBoxBobB.Size = new Size(141, 31);
            textBoxBobB.TabIndex = 2;
            // 
            // textBoxBobG
            // 
            textBoxBobG.Location = new Point(60, 118);
            textBoxBobG.Margin = new Padding(4, 5, 4, 5);
            textBoxBobG.Name = "textBoxBobG";
            textBoxBobG.Size = new Size(141, 31);
            textBoxBobG.TabIndex = 1;
            // 
            // textBoxBobP
            // 
            textBoxBobP.Location = new Point(60, 55);
            textBoxBobP.Margin = new Padding(4, 5, 4, 5);
            textBoxBobP.Name = "textBoxBobP";
            textBoxBobP.Size = new Size(141, 31);
            textBoxBobP.TabIndex = 0;
            // 
            // buttonSendPGtoBob
            // 
            buttonSendPGtoBob.Location = new Point(311, 117);
            buttonSendPGtoBob.Margin = new Padding(4, 5, 4, 5);
            buttonSendPGtoBob.Name = "buttonSendPGtoBob";
            buttonSendPGtoBob.Size = new Size(120, 38);
            buttonSendPGtoBob.TabIndex = 15;
            buttonSendPGtoBob.Text = "p, g >>>";
            buttonSendPGtoBob.UseVisualStyleBackColor = true;
            buttonSendPGtoBob.Click += buttonSendPGtoBob_Click;
            // 
            // buttonSendAtoBob
            // 
            buttonSendAtoBob.Location = new Point(311, 310);
            buttonSendAtoBob.Margin = new Padding(4, 5, 4, 5);
            buttonSendAtoBob.Name = "buttonSendAtoBob";
            buttonSendAtoBob.Size = new Size(120, 38);
            buttonSendAtoBob.TabIndex = 16;
            buttonSendAtoBob.Text = "A >>>";
            buttonSendAtoBob.UseVisualStyleBackColor = true;
            buttonSendAtoBob.Click += buttonSendAtoBob_Click;
            // 
            // buttonSendBtoAlice
            // 
            buttonSendBtoAlice.Location = new Point(311, 358);
            buttonSendBtoAlice.Margin = new Padding(4, 5, 4, 5);
            buttonSendBtoAlice.Name = "buttonSendBtoAlice";
            buttonSendBtoAlice.Size = new Size(120, 38);
            buttonSendBtoAlice.TabIndex = 17;
            buttonSendBtoAlice.Text = "<<< B";
            buttonSendBtoAlice.UseVisualStyleBackColor = true;
            buttonSendBtoAlice.Click += buttonSendBtoAlice_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(740, 602);
            Controls.Add(buttonSendBtoAlice);
            Controls.Add(buttonSendAtoBob);
            Controls.Add(buttonSendPGtoBob);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button buttonAliceCalcKey;
        private Label label6;
        private TextBox textBoxAliceK;
        private Label label5;
        private TextBox textBoxAlice_B;
        private Button buttonAliceCalcA;
        private Label label4;
        private TextBox textBoxAlice_A;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBoxAliceA;
        private TextBox textBoxAliceG;
        private TextBox textBoxAliceP;
        private GroupBox groupBox2;
        private Button buttonBobCalcKey;
        private Label label7;
        private TextBox textBoxBobKey;
        private Label label8;
        private TextBox textBoxBob_A;
        private Button buttonBobCalcB;
        private Label label9;
        private TextBox textBoxBob_B;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox textBoxBobB;
        private TextBox textBoxBobG;
        private TextBox textBoxBobP;
        private Button buttonSendPGtoBob;
        private Button buttonSendAtoBob;
        private Button buttonSendBtoAlice;
    }
}