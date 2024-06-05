namespace WinFormsApp3
{
    partial class Form20
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
            button2 = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.MediumSeaGreen;
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(54, 328);
            button2.Name = "button2";
            button2.Size = new Size(194, 44);
            button2.TabIndex = 5;
            button2.Text = "Continue";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.MediumSeaGreen;
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(54, 269);
            button1.Name = "button1";
            button1.Size = new Size(194, 44);
            button1.TabIndex = 4;
            button1.Text = "Want to reapeat it";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Screenshot_2024_06_02_112836;
            pictureBox1.Location = new Point(12, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(279, 203);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // Form20
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(303, 436);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Name = "Form20";
            Text = "Form20";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button2;
        private Button button1;
        private PictureBox pictureBox1;
    }
}