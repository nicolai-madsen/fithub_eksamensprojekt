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
            comboBox1 = new ComboBox();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(11, 109);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(212, 28);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(11, 83);
            label1.Name = "label1";
            label1.Size = new Size(120, 25);
            label1.TabIndex = 1;
            label1.Text = "Medlemmer:";
            label1.Click += label1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(565, 63);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(11, 464);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 3;
            button1.Text = "Hold";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 189);
            button2.Name = "button2";
            button2.Size = new Size(106, 29);
            button2.TabIndex = 4;
            button2.Text = "Medlemmer";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(843, 511);
            panel1.TabIndex = 5;
            panel1.Paint += panel1_Paint;
            // 
            // FrontPageForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Logo_for_FitHub_Fitn;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(843, 511);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Name = "FrontPageForm";
            Text = "FrontPage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private Button button2;
        private Panel panel1;

    }
}