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
            btnActivityFront = new Button();
            btnRapportFront = new Button();
            btnBookingFront = new Button();
            btnInsFront = new Button();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnActivityFront
            // 
            btnActivityFront.Location = new Point(87, 502);
            btnActivityFront.Margin = new Padding(6, 8, 6, 8);
            btnActivityFront.Name = "btnActivityFront";
            btnActivityFront.Size = new Size(278, 64);
            btnActivityFront.TabIndex = 3;
            btnActivityFront.Text = "Hold";
            btnActivityFront.UseVisualStyleBackColor = true;
            btnActivityFront.Click += button1_Click;
            // 
            // btnRapportFront
            // 
            btnRapportFront.Location = new Point(87, 795);
            btnRapportFront.Margin = new Padding(6);
            btnRapportFront.Name = "btnRapportFront";
            btnRapportFront.Size = new Size(278, 59);
            btnRapportFront.TabIndex = 6;
            btnRapportFront.Text = "Rapport";
            btnRapportFront.UseVisualStyleBackColor = true;
            btnRapportFront.Click += button3_Click;
            // 
            // btnBookingFront
            // 
            btnBookingFront.Location = new Point(87, 357);
            btnBookingFront.Margin = new Padding(6);
            btnBookingFront.Name = "btnBookingFront";
            btnBookingFront.Size = new Size(278, 59);
            btnBookingFront.TabIndex = 7;
            btnBookingFront.Text = "Booking";
            btnBookingFront.UseVisualStyleBackColor = true;
            btnBookingFront.Click += btnBookingFront_Click;
            // 
            // btnInsFront
            // 
            btnInsFront.Location = new Point(87, 642);
            btnInsFront.Margin = new Padding(6);
            btnInsFront.Name = "btnInsFront";
            btnInsFront.Size = new Size(278, 68);
            btnInsFront.TabIndex = 8;
            btnInsFront.Text = "Personale";
            btnInsFront.UseVisualStyleBackColor = true;
            btnInsFront.Click += button5_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(291, -78);
            pictureBox1.Margin = new Padding(6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1473, 1332);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.Location = new Point(87, 226);
            button2.Margin = new Padding(6);
            button2.Name = "button2";
            button2.Size = new Size(278, 59);
            button2.TabIndex = 10;
            button2.Text = "Medlemmer";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // FrontPageForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1817, 1023);
            Controls.Add(button2);
            Controls.Add(btnInsFront);
            Controls.Add(btnBookingFront);
            Controls.Add(btnRapportFront);
            Controls.Add(btnActivityFront);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            Margin = new Padding(6);
            MaximumSize = new Size(1849, 1111);
            MinimumSize = new Size(1849, 1111);
            Name = "FrontPageForm";
            Text = "FrontPage";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnActivityFront;
        private Button btnRapportFront;
        private Button btnBookingFront;
        private Button btnInsFront;
        private PictureBox pictureBox1;
        private Button button2;
    }
}