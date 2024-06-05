namespace WinFormsApp3
{
    partial class Form28
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
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Screenshot_2024_06_03_115039;
            pictureBox1.Location = new Point(21, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(262, 286);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.MediumSeaGreen;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(12, 4);
            button1.Name = "button1";
            button1.Size = new Size(55, 23);
            button1.TabIndex = 1;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.MediumSeaGreen;
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(236, 4);
            button2.Name = "button2";
            button2.Size = new Size(61, 23);
            button2.TabIndex = 2;
            button2.Text = "Log out";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(27, 379);
            button3.Name = "button3";
            button3.Size = new Size(256, 43);
            button3.TabIndex = 6;
            button3.Text = "Admin 2                                                       Did you finish tasks?.......";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(27, 323);
            button4.Name = "button4";
            button4.Size = new Size(256, 47);
            button4.TabIndex = 5;
            button4.Text = "Admin 1                                                                  Hello my worker...";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form28
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(303, 436);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Name = "Form28";
            Text = "Form28";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}