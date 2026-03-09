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
            ListPanel = new Panel();
            CustomerInfoBtn = new Button();
            ShowActiveBtn = new Button();
            ShowInactiveBtn = new Button();
            ShowAllBtn = new Button();
            EditBtn = new Button();
            ChooseCustomerTitle = new Label();
            CustomerListBox = new ListBox();
            EditCustomerPanel = new Panel();
            EditCustomerCancelBtn = new Button();
            EditCustomerConfirmBtn = new Button();
            label17 = new Label();
            comboBox2 = new ComboBox();
            NotesEdit = new TextBox();
            BirthdayEdit = new TextBox();
            PhoneEdit = new TextBox();
            EmailEdit = new TextBox();
            LastNameEdit = new TextBox();
            label11 = new Label();
            FirstnameEdit = new TextBox();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            EditCustomerTitle = new Label();
            NewCustomerPanel = new Panel();
            NewCustomerCancelBtn = new Button();
            NewCustomerConfirmBtn = new Button();
            Notes = new TextBox();
            Birthday = new TextBox();
            Phone = new TextBox();
            Email = new TextBox();
            LastName = new TextBox();
            label9 = new Label();
            FirstName = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            NewCustomerTitle = new Label();
            ShowListBtn = new Button();
            NewCustomerBtn = new Button();
            BackBtn = new Button();
            panel1 = new Panel();
            textBox7 = new TextBox();
            listBox1 = new ListBox();
            label2 = new Label();
            InfoBackBtn = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label3 = new Label();
            textBox6 = new TextBox();
            label10 = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            Kundeinformation = new Label();
            ListPanel.SuspendLayout();
            EditCustomerPanel.SuspendLayout();
            NewCustomerPanel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // ListPanel
            // 
            ListPanel.Controls.Add(CustomerInfoBtn);
            ListPanel.Controls.Add(ShowActiveBtn);
            ListPanel.Controls.Add(ShowInactiveBtn);
            ListPanel.Controls.Add(ShowAllBtn);
            ListPanel.Controls.Add(EditBtn);
            ListPanel.Controls.Add(ChooseCustomerTitle);
            ListPanel.Controls.Add(CustomerListBox);
            ListPanel.Location = new Point(745, 21);
            ListPanel.Name = "ListPanel";
            ListPanel.Size = new Size(564, 559);
            ListPanel.TabIndex = 8;
            // 
            // CustomerInfoBtn
            // 
            CustomerInfoBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            CustomerInfoBtn.Location = new Point(63, 418);
            CustomerInfoBtn.Name = "CustomerInfoBtn";
            CustomerInfoBtn.Size = new Size(116, 29);
            CustomerInfoBtn.TabIndex = 20;
            CustomerInfoBtn.Text = "Information";
            CustomerInfoBtn.UseVisualStyleBackColor = true;
            // 
            // ShowActiveBtn
            // 
            ShowActiveBtn.Anchor = AnchorStyles.Top;
            ShowActiveBtn.Location = new Point(188, 82);
            ShowActiveBtn.Name = "ShowActiveBtn";
            ShowActiveBtn.Size = new Size(94, 29);
            ShowActiveBtn.TabIndex = 19;
            ShowActiveBtn.Text = "Vis aktiv";
            ShowActiveBtn.UseVisualStyleBackColor = true;
            ShowActiveBtn.Click += ShowActiveBtn_Click;
            // 
            // ShowInactiveBtn
            // 
            ShowInactiveBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ShowInactiveBtn.Location = new Point(306, 82);
            ShowInactiveBtn.Name = "ShowInactiveBtn";
            ShowInactiveBtn.Size = new Size(94, 29);
            ShowInactiveBtn.TabIndex = 18;
            ShowInactiveBtn.Text = "Vis inaktiv";
            ShowInactiveBtn.UseVisualStyleBackColor = true;
            ShowInactiveBtn.Click += ShowInactiveBtn_Click;
            // 
            // ShowAllBtn
            // 
            ShowAllBtn.Location = new Point(63, 82);
            ShowAllBtn.Name = "ShowAllBtn";
            ShowAllBtn.Size = new Size(94, 29);
            ShowAllBtn.TabIndex = 17;
            ShowAllBtn.Text = "Vis alle";
            ShowAllBtn.UseVisualStyleBackColor = true;
            ShowAllBtn.Click += ShowBtn_Click;
            // 
            // EditBtn
            // 
            EditBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            EditBtn.Location = new Point(391, 418);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(94, 29);
            EditBtn.TabIndex = 15;
            EditBtn.Text = "Rediger";
            EditBtn.UseVisualStyleBackColor = true;
            // 
            // ChooseCustomerTitle
            // 
            ChooseCustomerTitle.AutoSize = true;
            ChooseCustomerTitle.Font = new Font("Segoe UI", 12F);
            ChooseCustomerTitle.Location = new Point(63, 25);
            ChooseCustomerTitle.Name = "ChooseCustomerTitle";
            ChooseCustomerTitle.Size = new Size(116, 28);
            ChooseCustomerTitle.TabIndex = 11;
            ChooseCustomerTitle.Text = "Vælg kunde";
            // 
            // CustomerListBox
            // 
            CustomerListBox.Anchor = AnchorStyles.None;
            CustomerListBox.FormattingEnabled = true;
            CustomerListBox.Location = new Point(56, 119);
            CustomerListBox.Name = "CustomerListBox";
            CustomerListBox.Size = new Size(436, 284);
            CustomerListBox.TabIndex = 8;
            // 
            // EditCustomerPanel
            // 
            EditCustomerPanel.Controls.Add(EditCustomerCancelBtn);
            EditCustomerPanel.Controls.Add(EditCustomerConfirmBtn);
            EditCustomerPanel.Controls.Add(label17);
            EditCustomerPanel.Controls.Add(comboBox2);
            EditCustomerPanel.Controls.Add(NotesEdit);
            EditCustomerPanel.Controls.Add(BirthdayEdit);
            EditCustomerPanel.Controls.Add(PhoneEdit);
            EditCustomerPanel.Controls.Add(EmailEdit);
            EditCustomerPanel.Controls.Add(LastNameEdit);
            EditCustomerPanel.Controls.Add(label11);
            EditCustomerPanel.Controls.Add(FirstnameEdit);
            EditCustomerPanel.Controls.Add(label12);
            EditCustomerPanel.Controls.Add(label13);
            EditCustomerPanel.Controls.Add(label14);
            EditCustomerPanel.Controls.Add(label15);
            EditCustomerPanel.Controls.Add(label16);
            EditCustomerPanel.Controls.Add(EditCustomerTitle);
            EditCustomerPanel.Location = new Point(12, 467);
            EditCustomerPanel.Name = "EditCustomerPanel";
            EditCustomerPanel.Size = new Size(613, 451);
            EditCustomerPanel.TabIndex = 12;
            // 
            // EditCustomerCancelBtn
            // 
            EditCustomerCancelBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            EditCustomerCancelBtn.Location = new Point(373, 377);
            EditCustomerCancelBtn.Name = "EditCustomerCancelBtn";
            EditCustomerCancelBtn.Size = new Size(94, 29);
            EditCustomerCancelBtn.TabIndex = 36;
            EditCustomerCancelBtn.Text = "Annuler";
            EditCustomerCancelBtn.UseVisualStyleBackColor = true;
            // 
            // EditCustomerConfirmBtn
            // 
            EditCustomerConfirmBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            EditCustomerConfirmBtn.Location = new Point(481, 377);
            EditCustomerConfirmBtn.Name = "EditCustomerConfirmBtn";
            EditCustomerConfirmBtn.Size = new Size(94, 29);
            EditCustomerConfirmBtn.TabIndex = 36;
            EditCustomerConfirmBtn.Text = "Gem";
            EditCustomerConfirmBtn.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label17.AutoSize = true;
            label17.Location = new Point(373, 97);
            label17.Name = "label17";
            label17.Size = new Size(49, 20);
            label17.TabIndex = 31;
            label17.Text = "Status";
            // 
            // comboBox2
            // 
            comboBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBox2.AutoCompleteCustomSource.AddRange(new string[] { "Aktiv", "Inaktiv" });
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Aktiv", "Inaktiv" });
            comboBox2.Location = new Point(428, 90);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(94, 28);
            comboBox2.TabIndex = 30;
            // 
            // NotesEdit
            // 
            NotesEdit.Anchor = AnchorStyles.Bottom;
            NotesEdit.Location = new Point(198, 309);
            NotesEdit.Multiline = true;
            NotesEdit.Name = "NotesEdit";
            NotesEdit.Size = new Size(368, 53);
            NotesEdit.TabIndex = 29;
            // 
            // BirthdayEdit
            // 
            BirthdayEdit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BirthdayEdit.Location = new Point(198, 266);
            BirthdayEdit.Name = "BirthdayEdit";
            BirthdayEdit.Size = new Size(125, 27);
            BirthdayEdit.TabIndex = 28;
            // 
            // PhoneEdit
            // 
            PhoneEdit.Location = new Point(198, 228);
            PhoneEdit.Name = "PhoneEdit";
            PhoneEdit.Size = new Size(125, 27);
            PhoneEdit.TabIndex = 27;
            // 
            // EmailEdit
            // 
            EmailEdit.Location = new Point(198, 184);
            EmailEdit.Name = "EmailEdit";
            EmailEdit.Size = new Size(125, 27);
            EmailEdit.TabIndex = 26;
            // 
            // LastNameEdit
            // 
            LastNameEdit.Location = new Point(198, 141);
            LastNameEdit.Name = "LastNameEdit";
            LastNameEdit.Size = new Size(125, 27);
            LastNameEdit.TabIndex = 25;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label11.AutoSize = true;
            label11.Location = new Point(60, 309);
            label11.Name = "label11";
            label11.Size = new Size(47, 20);
            label11.TabIndex = 23;
            label11.Text = "Notat";
            // 
            // FirstnameEdit
            // 
            FirstnameEdit.Location = new Point(198, 90);
            FirstnameEdit.Name = "FirstnameEdit";
            FirstnameEdit.Size = new Size(125, 27);
            FirstnameEdit.TabIndex = 22;
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
            label13.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
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
            // EditCustomerTitle
            // 
            EditCustomerTitle.AutoSize = true;
            EditCustomerTitle.Font = new Font("Segoe UI", 12F);
            EditCustomerTitle.Location = new Point(60, 34);
            EditCustomerTitle.Name = "EditCustomerTitle";
            EditCustomerTitle.Size = new Size(138, 28);
            EditCustomerTitle.TabIndex = 13;
            EditCustomerTitle.Text = "Rediger kunde";
            // 
            // NewCustomerPanel
            // 
            NewCustomerPanel.Controls.Add(NewCustomerCancelBtn);
            NewCustomerPanel.Controls.Add(NewCustomerConfirmBtn);
            NewCustomerPanel.Controls.Add(Notes);
            NewCustomerPanel.Controls.Add(Birthday);
            NewCustomerPanel.Controls.Add(Phone);
            NewCustomerPanel.Controls.Add(Email);
            NewCustomerPanel.Controls.Add(LastName);
            NewCustomerPanel.Controls.Add(label9);
            NewCustomerPanel.Controls.Add(FirstName);
            NewCustomerPanel.Controls.Add(label8);
            NewCustomerPanel.Controls.Add(label7);
            NewCustomerPanel.Controls.Add(label6);
            NewCustomerPanel.Controls.Add(label5);
            NewCustomerPanel.Controls.Add(label4);
            NewCustomerPanel.Controls.Add(NewCustomerTitle);
            NewCustomerPanel.Location = new Point(12, 12);
            NewCustomerPanel.Name = "NewCustomerPanel";
            NewCustomerPanel.Size = new Size(584, 430);
            NewCustomerPanel.TabIndex = 9;
            // 
            // NewCustomerCancelBtn
            // 
            NewCustomerCancelBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            NewCustomerCancelBtn.Location = new Point(369, 378);
            NewCustomerCancelBtn.Name = "NewCustomerCancelBtn";
            NewCustomerCancelBtn.Size = new Size(94, 29);
            NewCustomerCancelBtn.TabIndex = 35;
            NewCustomerCancelBtn.Text = "Annuler";
            NewCustomerCancelBtn.UseVisualStyleBackColor = true;
            // 
            // NewCustomerConfirmBtn
            // 
            NewCustomerConfirmBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            NewCustomerConfirmBtn.Location = new Point(469, 378);
            NewCustomerConfirmBtn.Name = "NewCustomerConfirmBtn";
            NewCustomerConfirmBtn.Size = new Size(94, 29);
            NewCustomerConfirmBtn.TabIndex = 34;
            NewCustomerConfirmBtn.Text = "Gem";
            NewCustomerConfirmBtn.UseVisualStyleBackColor = true;
            // 
            // Notes
            // 
            Notes.Anchor = AnchorStyles.Bottom;
            Notes.Location = new Point(198, 307);
            Notes.Multiline = true;
            Notes.Name = "Notes";
            Notes.Size = new Size(365, 57);
            Notes.TabIndex = 16;
            // 
            // Birthday
            // 
            Birthday.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Birthday.Location = new Point(198, 264);
            Birthday.Name = "Birthday";
            Birthday.Size = new Size(125, 27);
            Birthday.TabIndex = 15;
            // 
            // Phone
            // 
            Phone.Location = new Point(198, 222);
            Phone.Name = "Phone";
            Phone.Size = new Size(125, 27);
            Phone.TabIndex = 14;
            // 
            // Email
            // 
            Email.Location = new Point(198, 178);
            Email.Name = "Email";
            Email.Size = new Size(125, 27);
            Email.TabIndex = 13;
            // 
            // LastName
            // 
            LastName.Location = new Point(198, 135);
            LastName.Name = "LastName";
            LastName.Size = new Size(125, 27);
            LastName.TabIndex = 12;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Location = new Point(60, 307);
            label9.Name = "label9";
            label9.Size = new Size(47, 20);
            label9.TabIndex = 7;
            label9.Text = "Notat";
            // 
            // FirstName
            // 
            FirstName.Location = new Point(198, 84);
            FirstName.Name = "FirstName";
            FirstName.Size = new Size(125, 27);
            FirstName.TabIndex = 6;
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
            label7.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Location = new Point(60, 264);
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
            // NewCustomerTitle
            // 
            NewCustomerTitle.AutoSize = true;
            NewCustomerTitle.Font = new Font("Segoe UI", 12F);
            NewCustomerTitle.Location = new Point(60, 15);
            NewCustomerTitle.Name = "NewCustomerTitle";
            NewCustomerTitle.Size = new Size(260, 56);
            NewCustomerTitle.TabIndex = 0;
            NewCustomerTitle.Text = "Opret ny medlem\r\nVenligst fyld ind information\r\n";
            // 
            // ShowListBtn
            // 
            ShowListBtn.Anchor = AnchorStyles.Top;
            ShowListBtn.Location = new Point(631, 90);
            ShowListBtn.Name = "ShowListBtn";
            ShowListBtn.Size = new Size(94, 29);
            ShowListBtn.TabIndex = 13;
            ShowListBtn.Text = "Vis liste";
            ShowListBtn.UseVisualStyleBackColor = true;
            ShowListBtn.Click += ShowListBtn_Click;
            // 
            // NewCustomerBtn
            // 
            NewCustomerBtn.Anchor = AnchorStyles.Top;
            NewCustomerBtn.Location = new Point(631, 193);
            NewCustomerBtn.Name = "NewCustomerBtn";
            NewCustomerBtn.Size = new Size(94, 29);
            NewCustomerBtn.TabIndex = 14;
            NewCustomerBtn.Text = "Ny medlem";
            NewCustomerBtn.UseVisualStyleBackColor = true;
            // 
            // BackBtn
            // 
            BackBtn.Anchor = AnchorStyles.Top;
            BackBtn.Location = new Point(631, 319);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(94, 29);
            BackBtn.TabIndex = 16;
            BackBtn.Text = "Tilbage";
            BackBtn.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox7);
            panel1.Controls.Add(listBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(InfoBackBtn);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox6);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label18);
            panel1.Controls.Add(label19);
            panel1.Controls.Add(label20);
            panel1.Controls.Add(label21);
            panel1.Controls.Add(Kundeinformation);
            panel1.Location = new Point(711, 496);
            panel1.Name = "panel1";
            panel1.Size = new Size(613, 461);
            panel1.TabIndex = 37;
            // 
            // textBox7
            // 
            textBox7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox7.Location = new Point(428, 94);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(125, 27);
            textBox7.TabIndex = 40;
            // 
            // listBox1
            // 
            listBox1.Anchor = AnchorStyles.Top;
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(373, 182);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(187, 104);
            listBox1.TabIndex = 39;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(373, 153);
            label2.Name = "label2";
            label2.Size = new Size(102, 20);
            label2.TabIndex = 38;
            label2.Text = "Bookede hold";
            // 
            // InfoBackBtn
            // 
            InfoBackBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            InfoBackBtn.Location = new Point(481, 387);
            InfoBackBtn.Name = "InfoBackBtn";
            InfoBackBtn.Size = new Size(94, 29);
            InfoBackBtn.TabIndex = 36;
            InfoBackBtn.Text = "Tilbage";
            InfoBackBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(373, 97);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 31;
            label1.Text = "Status";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            textBox1.Location = new Point(198, 319);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(368, 53);
            textBox1.TabIndex = 29;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(198, 266);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 28;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(198, 228);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 27;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(198, 184);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 26;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(198, 141);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 25;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(60, 319);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 23;
            label3.Text = "Notat";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(198, 90);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(125, 27);
            textBox6.TabIndex = 22;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(60, 231);
            label10.Name = "label10";
            label10.Size = new Size(50, 20);
            label10.TabIndex = 21;
            label10.Text = "Phone";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(60, 266);
            label18.Name = "label18";
            label18.Size = new Size(84, 20);
            label18.TabIndex = 20;
            label18.Text = "Fødselsdag";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(60, 187);
            label19.Name = "label19";
            label19.Size = new Size(46, 20);
            label19.TabIndex = 19;
            label19.Text = "Email";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(60, 141);
            label20.Name = "label20";
            label20.Size = new Size(71, 20);
            label20.TabIndex = 18;
            label20.Text = "Efternavn";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(60, 93);
            label21.Name = "label21";
            label21.Size = new Size(61, 20);
            label21.TabIndex = 17;
            label21.Text = "Fornavn";
            // 
            // Kundeinformation
            // 
            Kundeinformation.AutoSize = true;
            Kundeinformation.Font = new Font("Segoe UI", 12F);
            Kundeinformation.Location = new Point(60, 34);
            Kundeinformation.Name = "Kundeinformation";
            Kundeinformation.Size = new Size(171, 28);
            Kundeinformation.TabIndex = 13;
            Kundeinformation.Text = "Kundeinformation";
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1397, 986);
            Controls.Add(panel1);
            Controls.Add(BackBtn);
            Controls.Add(NewCustomerBtn);
            Controls.Add(ShowListBtn);
            Controls.Add(ListPanel);
            Controls.Add(EditCustomerPanel);
            Controls.Add(NewCustomerPanel);
            Name = "CustomerForm";
            Text = "CustomerForm";
            ListPanel.ResumeLayout(false);
            ListPanel.PerformLayout();
            EditCustomerPanel.ResumeLayout(false);
            EditCustomerPanel.PerformLayout();
            NewCustomerPanel.ResumeLayout(false);
            NewCustomerPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel ListPanel;
        private ListBox CustomerListBox;
        private Panel NewCustomerPanel;
        private Label ChooseCustomerTitle;
        private Label label2;
        private Label NewCustomerTitle;
        private TextBox Birthday;
        private TextBox Phone;
        private TextBox Email;
        private TextBox LastName;
        private Label label9;
        private TextBox FirstName;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox Notes;
        private Panel EditCustomerPanel;
        private TextBox NotesEdit;
        private TextBox BirthdayEdit;
        private TextBox PhoneEdit;
        private TextBox EmailEdit;
        private TextBox LastNameEdit;
        private Label label11;
        private TextBox FirstnameEdit;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label EditCustomerTitle;
        private Label label17;
        private ComboBox comboBox2;
        private Button ShowListBtn;
        private Button NewCustomerBtn;
        private Button EditBtn;
        private Button BackBtn;
        private Button EditCustomerConfirmBtn;
        private Button NewCustomerCancelBtn;
        private Button NewCustomerConfirmBtn;
        private Button EditCustomerCancelBtn;
        private ComboBox StatusComboBox;
        private Button ShowAllBtn;
        private Button ShowActiveBtn;
        private Button ShowInactiveBtn;
        private Button CustomerInfoBtn;
        private Panel panel1;
        private Button button1;
        private Button InfoBackBtn;
        private Label label1;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label3;
        private TextBox textBox6;
        private Label label10;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label Kundeinformation;
        private TextBox textBox7;
        private ListBox listBox1;
    }
}