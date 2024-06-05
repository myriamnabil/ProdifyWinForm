namespace WinFormsApp3
{
    partial class Form15
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
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.WhatsApp_Image_2024_06_02_at_8_03_26_PM;
            pictureBox1.Location = new Point(33, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(238, 259);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.MediumSeaGreen;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(3, 7);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 1;
            label1.Text = "Back";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(24, 303);
            button1.Name = "button1";
            button1.Size = new Size(256, 47);
            button1.TabIndex = 3;
            button1.Text = "Worker 1                                                       Helloo my maneger....";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(24, 359);
            button2.Name = "button2";
            button2.Size = new Size(256, 43);
            button2.TabIndex = 4;
            button2.Text = "Worker                                                                    I finished all my tasks ....";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.MediumSeaGreen;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(248, 7);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 5;
            label2.Text = "Log out";
            label2.Click += label2_Click;
            // 
            // Form15
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(303, 436);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form15";
            Text = "Form15";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Button button1;
        private Button button2;
        private Label label2;
    }
}