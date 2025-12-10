namespace FitHubManagement.UI
{
    partial class FrontPageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrontPageForm));
            button1 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(41, 245);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(131, 31);
            button1.TabIndex = 3;
            button1.Text = "Hold";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(41, 97);
            button2.Name = "button2";
            button2.Size = new Size(131, 29);
            button2.TabIndex = 4;
            button2.Text = "Medlemmer";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(41, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(384, 460);
            panel1.TabIndex = 5;
            panel1.Paint += panel1_Paint;
            // 
            // button3
            // 
            button3.Location = new Point(41, 388);
            button3.Name = "button3";
            button3.Size = new Size(131, 29);
            button3.TabIndex = 6;
            button3.Text = "Rapport";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(41, 174);
            button4.Name = "button4";
            button4.Size = new Size(131, 29);
            button4.TabIndex = 7;
            button4.Text = "Booking";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(41, 313);
            button5.Name = "button5";
            button5.Size = new Size(131, 33);
            button5.TabIndex = 8;
            button5.Text = "Personale";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(137, -38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(693, 650);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // FrontPageForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(869, 540);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            MaximumSize = new Size(887, 587);
            MinimumSize = new Size(887, 587);
            Name = "FrontPageForm";
            Text = "FrontPage";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private Button button2;
        private Panel panel1;
        private Button button3;
        private Button button4;
        private Button button5;
        private PictureBox pictureBox1;
    }
}