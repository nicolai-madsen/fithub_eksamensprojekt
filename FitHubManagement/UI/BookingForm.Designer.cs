namespace FitHubManagement.UI.BookingUI
{
    partial class BookingForm
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
            panel1 = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            listBox1 = new ListBox();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            chkFilterByDate = new CheckBox();
            lbl_MedlemsNavn = new Label();
            label5 = new Label();
            button8 = new Button();
            button6 = new Button();
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            label6 = new Label();
            label4 = new Label();
            button5 = new Button();
            listBox2 = new ListBox();
            button1 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSeaGreen;
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(listBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(10, 9);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(451, 373);
            panel1.TabIndex = 0;
            // 
            // button4
            // 
            button4.Location = new Point(237, 271);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(83, 22);
            button4.TabIndex = 8;
            button4.Text = "Ryd";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(335, 271);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(83, 22);
            button3.TabIndex = 7;
            button3.Text = "Fortsæt";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(236, 128);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(182, 26);
            button2.TabIndex = 6;
            button2.Text = "Vis medlemsoplysninger";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(104, 85);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(179, 23);
            textBox2.TabIndex = 5;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(104, 59);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(179, 23);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(23, 159);
            listBox1.Margin = new Padding(3, 2, 3, 2);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(396, 109);
            listBox1.TabIndex = 3;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 89);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 2;
            label3.Text = "Telefon";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 61);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 1;
            label1.Text = "Navn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 22);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 0;
            label2.Text = "Søg medlem";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSeaGreen;
            panel2.Controls.Add(chkFilterByDate);
            panel2.Controls.Add(lbl_MedlemsNavn);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(button8);
            panel2.Controls.Add(button6);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(listBox2);
            panel2.Location = new Point(10, 9);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(454, 373);
            panel2.TabIndex = 2;
            // 
            // chkFilterByDate
            // 
            chkFilterByDate.AutoSize = true;
            chkFilterByDate.Location = new Point(295, 62);
            chkFilterByDate.Name = "chkFilterByDate";
            chkFilterByDate.Size = new Size(15, 14);
            chkFilterByDate.TabIndex = 14;
            chkFilterByDate.UseVisualStyleBackColor = true;
            chkFilterByDate.CheckedChanged += chkFilterByDate_CheckedChanged;
            // 
            // lbl_MedlemsNavn
            // 
            lbl_MedlemsNavn.AutoSize = true;
            lbl_MedlemsNavn.Location = new Point(22, 154);
            lbl_MedlemsNavn.Margin = new Padding(2, 0, 2, 0);
            lbl_MedlemsNavn.Name = "lbl_MedlemsNavn";
            lbl_MedlemsNavn.Size = new Size(85, 15);
            lbl_MedlemsNavn.TabIndex = 12;
            lbl_MedlemsNavn.Text = "Medlems navn";
            lbl_MedlemsNavn.Click += label7_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 99);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 10;
            label5.Text = "Holdtype";
            // 
            // button8
            // 
            button8.Location = new Point(22, 284);
            button8.Margin = new Padding(3, 2, 3, 2);
            button8.Name = "button8";
            button8.Size = new Size(83, 22);
            button8.TabIndex = 9;
            button8.Text = "Ny booking";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ActiveCaption;
            button6.Location = new Point(319, 274);
            button6.Margin = new Padding(3, 2, 3, 2);
            button6.Name = "button6";
            button6.Size = new Size(108, 43);
            button6.TabIndex = 7;
            button6.Text = "Tilmeld";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(104, 95);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(133, 23);
            comboBox1.TabIndex = 6;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(104, 59);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(161, 23);
            dateTimePicker1.TabIndex = 5;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 22);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 4;
            label6.Text = "Søg hold";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 61);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 2;
            label4.Text = "Dato";
            // 
            // button5
            // 
            button5.Location = new Point(342, 110);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(74, 22);
            button5.TabIndex = 1;
            button5.Text = "Vis";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(22, 176);
            listBox2.Margin = new Padding(3, 2, 3, 2);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(404, 94);
            listBox2.TabIndex = 0;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(470, 208);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(145, 22);
            button1.TabIndex = 1;
            button1.Text = "Tilbage til forsiden";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // BookingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(627, 469);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Margin = new Padding(3, 2, 3, 2);
            Name = "BookingForm";
            Text = "BookingForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Button button2;
        private TextBox textBox2;
        private TextBox textBox1;
        private ListBox listBox1;
        private Label label3;
        private Label label1;
        private Label label2;
        private Button button3;
        private Button button4;
        private Panel panel2;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private Label label6;
        private Label label4;
        private Button button5;
        private ListBox listBox2;
        private Button button8;
        private Label label5;
        private Label lbl_MedlemsNavn;
        protected internal Button button6;
        private CheckBox chkFilterByDate;
    }
}