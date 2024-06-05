namespace WinFormsApp3
{
    partial class Form8
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
            label1 = new Label();
            label5 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label7 = new Label();
            textBox6 = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Simplified Arabic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(57, 20);
            label1.Name = "label1";
            label1.Size = new Size(179, 41);
            label1.TabIndex = 0;
            label1.Text = "Quiz on tutorial";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F);
            label5.ForeColor = Color.Gray;
            label5.Location = new Point(13, 208);
            label5.Name = "label5";
            label5.Size = new Size(85, 15);
            label5.TabIndex = 17;
            label5.Text = "How to log in :";
            label5.Click += label5_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(117, 205);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(172, 26);
            textBox4.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F);
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(6, 122);
            label4.Name = "label4";
            label4.Size = new Size(111, 15);
            label4.TabIndex = 15;
            label4.Text = "How is the 5s used :";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(117, 119);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(174, 26);
            textBox3.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(19, 167);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 13;
            label3.Text = " 5s benifites :";
            label3.Click += label3_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(117, 164);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(174, 26);
            textBox2.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(15, 81);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 11;
            label2.Text = "What is the 5s :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(117, 78);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(174, 26);
            textBox1.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F);
            label7.ForeColor = Color.Gray;
            label7.Location = new Point(6, 258);
            label7.Name = "label7";
            label7.Size = new Size(109, 15);
            label7.TabIndex = 21;
            label7.Text = "How to send tasks :";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(117, 255);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(174, 26);
            textBox6.TabIndex = 20;
            // 
            // button2
            // 
            button2.BackColor = Color.MediumSeaGreen;
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(57, 321);
            button2.Name = "button2";
            button2.Size = new Size(194, 44);
            button2.TabIndex = 22;
            button2.Text = "Continue";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(303, 436);
            Controls.Add(button2);
            Controls.Add(label7);
            Controls.Add(textBox6);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form8";
            Text = "Form8";
            Load += Form8_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label5;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label7;
        private TextBox textBox6;
        private Button button2;
    }
}