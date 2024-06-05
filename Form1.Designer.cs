namespace WinFormsApp3
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Screenshot_2024_06_02_100656;
            pictureBox1.Location = new Point(32, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(235, 109);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Simplified Arabic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(87, 141);
            label1.Name = "label1";
            label1.Size = new Size(108, 48);
            label1.TabIndex = 1;
            label1.Text = "Sign in";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(32, 220);
            button1.Name = "button1";
            button1.Size = new Size(235, 75);
            button1.TabIndex = 2;
            button1.Text = "Admin";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(33, 306);
            button2.Name = "button2";
            button2.Size = new Size(235, 94);
            button2.TabIndex = 3;
            button2.Text = "Worker";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.WhatsApp_Image_2024_06_02_at_10_04_22_AM;
            pictureBox2.Location = new Point(44, 224);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(61, 67);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.WhatsApp_Image_2024_06_02_at_10_04_22_AM__1_;
            pictureBox3.Location = new Point(44, 312);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(72, 83);
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(303, 436);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}
