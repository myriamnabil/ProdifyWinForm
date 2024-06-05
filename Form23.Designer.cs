namespace WinFormsApp3
{
    partial class Form23
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
            button3 = new Button();
            button2 = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // button3
            // 
            button3.BackColor = Color.MediumSeaGreen;
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(111, 341);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 15;
            button3.Text = "Back";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(64, 301);
            button2.Name = "button2";
            button2.Size = new Size(170, 25);
            button2.TabIndex = 14;
            button2.Text = "Next";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ButtonHighlight;
            label5.ForeColor = Color.Gray;
            label5.Location = new Point(114, 242);
            label5.Name = "label5";
            label5.Size = new Size(68, 15);
            label5.TabIndex = 13;
            label5.Text = "Thank you !";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonHighlight;
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(92, 213);
            label4.Name = "label4";
            label4.Size = new Size(100, 15);
            label4.TabIndex = 12;
            label4.Text = "Will like from you";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonHighlight;
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(41, 191);
            label3.Name = "label3";
            label3.Size = new Size(220, 15);
            label3.TabIndex = 11;
            label3.Text = "From you now hope that the application";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(37, 166);
            label2.Name = "label2";
            label2.Size = new Size(228, 15);
            label2.TabIndex = 10;
            label2.Text = "Thank you for making things that request ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Font = new Font("Segoe UI Emoji", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(83, 104);
            label1.Name = "label1";
            label1.Size = new Size(135, 32);
            label1.TabIndex = 9;
            label1.Text = "Thank you";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(33, 72);
            button1.Name = "button1";
            button1.Size = new Size(237, 203);
            button1.TabIndex = 8;
            button1.UseVisualStyleBackColor = false;
            // 
            // Form23
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSeaGreen;
            ClientSize = new Size(303, 436);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form23";
            Text = "Form23";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Button button2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
    }
}