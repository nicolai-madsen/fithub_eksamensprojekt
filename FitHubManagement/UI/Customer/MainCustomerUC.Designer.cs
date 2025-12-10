namespace FitHubManagement.UI.Customer
{
    partial class MainCustomerUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBox1 = new ComboBox();
            listBox1 = new ListBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Alle", "Aktiv", "Inaktiv" });
            comboBox1.Location = new Point(287, 71);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(107, 28);
            comboBox1.TabIndex = 0;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(20, 104);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(523, 324);
            listBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(584, 104);
            button1.Name = "button1";
            button1.Size = new Size(111, 29);
            button1.TabIndex = 2;
            button1.Text = "Ny medlem";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(464, 69);
            button2.Name = "button2";
            button2.Size = new Size(79, 29);
            button2.TabIndex = 3;
            button2.Text = "Vis";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(584, 221);
            button3.Name = "button3";
            button3.Size = new Size(111, 29);
            button3.TabIndex = 4;
            button3.Text = "Marker inaktiv";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(584, 399);
            button4.Name = "button4";
            button4.Size = new Size(111, 29);
            button4.TabIndex = 5;
            button4.Text = "Tilbage";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(584, 285);
            button5.Name = "button5";
            button5.Size = new Size(111, 29);
            button5.TabIndex = 6;
            button5.Text = "Marker aktiv";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(584, 165);
            button6.Name = "button6";
            button6.Size = new Size(111, 29);
            button6.TabIndex = 7;
            button6.Text = "Rediger medlem";
            button6.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(61, 71);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(107, 27);
            textBox1.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(222, 74);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 9;
            label1.Text = "Status";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 75);
            label2.Name = "label2";
            label2.Size = new Size(35, 20);
            label2.TabIndex = 10;
            label2.Text = "Søg";
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button4);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(768, 500);
            panel1.TabIndex = 11;
            panel1.Paint += panel1_Paint;
            // 
            // MainCustomerUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(comboBox1);
            Controls.Add(panel1);
            Name = "MainCustomerUC";
            Size = new Size(768, 500);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private ListBox listBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Panel panel1;
    }
}
