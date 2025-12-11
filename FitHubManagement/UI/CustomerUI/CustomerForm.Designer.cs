namespace FitHubManagement.UI.CustomerUI
{
    partial class CustomerForm
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
            label2 = new Label();
            label1 = new Label();
            comboBox1 = new ComboBox();
            listBox1 = new ListBox();
            button5 = new Button();
            panel3 = new Panel();
            button8 = new Button();
            label17 = new Label();
            comboBox2 = new ComboBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            textBox10 = new TextBox();
            textBox11 = new TextBox();
            button7 = new Button();
            label11 = new Label();
            textBox12 = new TextBox();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label10 = new Label();
            button1 = new Button();
            button2 = new Button();
            panel2 = new Panel();
            button9 = new Button();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            button4 = new Button();
            label9 = new Label();
            textBox1 = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            button6 = new Button();
            button3 = new Button();
            button10 = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(listBox1);
            panel1.Controls.Add(button5);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(578, 564);
            panel1.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 73);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 12;
            label2.Text = "Status";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(63, 25);
            label1.Name = "label1";
            label1.Size = new Size(116, 28);
            label1.TabIndex = 11;
            label1.Text = "Vælg kunde";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Alle", "Aktiv", "Inaktiv" });
            comboBox1.Location = new Point(121, 56);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 9;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(63, 122);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(436, 284);
            listBox1.TabIndex = 8;
            // 
            // button5
            // 
            button5.Location = new Point(405, 56);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 7;
            button5.Text = "Vis alle";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(button8);
            panel3.Controls.Add(label17);
            panel3.Controls.Add(comboBox2);
            panel3.Controls.Add(textBox7);
            panel3.Controls.Add(textBox8);
            panel3.Controls.Add(textBox9);
            panel3.Controls.Add(textBox10);
            panel3.Controls.Add(textBox11);
            panel3.Controls.Add(button7);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(textBox12);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(label14);
            panel3.Controls.Add(label15);
            panel3.Controls.Add(label16);
            panel3.Controls.Add(label10);
            panel3.Location = new Point(12, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(613, 451);
            panel3.TabIndex = 12;
            // 
            // button8
            // 
            button8.Location = new Point(359, 377);
            button8.Name = "button8";
            button8.Size = new Size(94, 29);
            button8.TabIndex = 32;
            button8.Text = "Annuler";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(373, 97);
            label17.Name = "label17";
            label17.Size = new Size(49, 20);
            label17.TabIndex = 31;
            label17.Text = "Status";
            // 
            // comboBox2
            // 
            comboBox2.AutoCompleteCustomSource.AddRange(new string[] { "Aktiv", "Inaktiv" });
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Aktiv", "Inaktiv" });
            comboBox2.Location = new Point(428, 90);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(94, 28);
            comboBox2.TabIndex = 30;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(198, 309);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(368, 53);
            textBox7.TabIndex = 29;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(198, 266);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(125, 27);
            textBox8.TabIndex = 28;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(198, 228);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(125, 27);
            textBox9.TabIndex = 27;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(198, 184);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(125, 27);
            textBox10.TabIndex = 26;
            // 
            // textBox11
            // 
            textBox11.Location = new Point(198, 141);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(125, 27);
            textBox11.TabIndex = 25;
            // 
            // button7
            // 
            button7.Location = new Point(472, 377);
            button7.Name = "button7";
            button7.Size = new Size(94, 29);
            button7.TabIndex = 24;
            button7.Text = "Gem";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(60, 309);
            label11.Name = "label11";
            label11.Size = new Size(47, 20);
            label11.TabIndex = 23;
            label11.Text = "Notat";
            // 
            // textBox12
            // 
            textBox12.Location = new Point(198, 90);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(125, 27);
            textBox12.TabIndex = 22;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(60, 231);
            label12.Name = "label12";
            label12.Size = new Size(50, 20);
            label12.TabIndex = 21;
            label12.Text = "Phone";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(60, 266);
            label13.Name = "label13";
            label13.Size = new Size(84, 20);
            label13.TabIndex = 20;
            label13.Text = "Fødselsdag";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(60, 187);
            label14.Name = "label14";
            label14.Size = new Size(46, 20);
            label14.TabIndex = 19;
            label14.Text = "Email";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(60, 141);
            label15.Name = "label15";
            label15.Size = new Size(71, 20);
            label15.TabIndex = 18;
            label15.Text = "Efternavn";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(60, 93);
            label16.Name = "label16";
            label16.Size = new Size(61, 20);
            label16.TabIndex = 17;
            label16.Text = "Fornavn";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.Location = new Point(60, 34);
            label10.Name = "label10";
            label10.Size = new Size(138, 28);
            label10.TabIndex = 13;
            label10.Text = "Rediger kunde";
            // 
            // button1
            // 
            button1.Location = new Point(631, 193);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Ny medlem";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(631, 252);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "Rediger";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(button9);
            panel2.Controls.Add(textBox6);
            panel2.Controls.Add(textBox5);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(584, 426);
            panel2.TabIndex = 9;
            // 
            // button9
            // 
            button9.Location = new Point(359, 374);
            button9.Name = "button9";
            button9.Size = new Size(94, 29);
            button9.TabIndex = 33;
            button9.Text = "Annuler";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(198, 303);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(365, 57);
            textBox6.TabIndex = 16;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(198, 260);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 15;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(198, 222);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 14;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(198, 178);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 13;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(198, 135);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 12;
            // 
            // button4
            // 
            button4.Location = new Point(469, 374);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 11;
            button4.Text = "Gem";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(60, 303);
            label9.Name = "label9";
            label9.Size = new Size(47, 20);
            label9.TabIndex = 7;
            label9.Text = "Notat";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(198, 84);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(60, 225);
            label8.Name = "label8";
            label8.Size = new Size(50, 20);
            label8.TabIndex = 5;
            label8.Text = "Phone";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(60, 260);
            label7.Name = "label7";
            label7.Size = new Size(84, 20);
            label7.TabIndex = 4;
            label7.Text = "Fødselsdag";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(60, 181);
            label6.Name = "label6";
            label6.Size = new Size(46, 20);
            label6.TabIndex = 3;
            label6.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(60, 135);
            label5.Name = "label5";
            label5.Size = new Size(71, 20);
            label5.TabIndex = 2;
            label5.Text = "Efternavn";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(60, 87);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 1;
            label4.Text = "Fornavn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(60, 15);
            label3.Name = "label3";
            label3.Size = new Size(260, 56);
            label3.TabIndex = 0;
            label3.Text = "Opret ny medlem\r\nVenligst fyld ind information\r\n";
            // 
            // button6
            // 
            button6.Location = new Point(631, 134);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 10;
            button6.Text = "Vis liste";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button3
            // 
            button3.Location = new Point(631, 312);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 11;
            button3.Text = "Slet";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button10
            // 
            button10.Location = new Point(631, 373);
            button10.Name = "button10";
            button10.Size = new Size(94, 29);
            button10.TabIndex = 13;
            button10.Text = "Tilbage";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(747, 443);
            Controls.Add(panel1);
            Controls.Add(button10);
            Controls.Add(button3);
            Controls.Add(button6);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Name = "CustomerForm";
            Text = "CustomerForm";
            Load += CustomerForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Panel panel1;
        private ComboBox comboBox1;
        private ListBox listBox1;
        private Button button5;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button6;
        private Button button3;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Button button4;
        private Label label9;
        private TextBox textBox1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox textBox6;
        private Panel panel3;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private TextBox textBox10;
        private TextBox textBox11;
        private Button button7;
        private Label label11;
        private TextBox textBox12;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label10;
        private Label label17;
        private ComboBox comboBox2;
        private Button button8;
        private Button button9;
        private Button button10;
    }
}