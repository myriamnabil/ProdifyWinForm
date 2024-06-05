namespace WinFormsApp3
{
    partial class Form11
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form11));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            linkLabel1 = new LinkLabel();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Simplified Arabic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(38, 24);
            label1.Name = "label1";
            label1.Size = new Size(230, 41);
            label1.TabIndex = 0;
            label1.Text = "Message the Worker";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(65, 82);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(171, 274);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.MediumSeaGreen;
            linkLabel1.Location = new Point(12, 9);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(32, 15);
            linkLabel1.TabIndex = 2;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Back";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // button1
            // 
            button1.BackColor = Color.MediumSeaGreen;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(78, 378);
            button1.Name = "button1";
            button1.Size = new Size(137, 36);
            button1.TabIndex = 3;
            button1.Text = "Send";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form11
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(303, 436);
            Controls.Add(button1);
            Controls.Add(linkLabel1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "Form11";
            Text = "Form11";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private LinkLabel linkLabel1;
        private Button button1;
    }
}