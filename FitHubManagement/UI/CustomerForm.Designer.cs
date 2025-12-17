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
            ShowActiveBtn = new Button();
            panel1 = new Panel();
            IDinfo = new TextBox();
            button3 = new Button();
            InfoBtn = new Button();
            label30 = new Label();
            label29 = new Label();
            count = new TextBox();
            CustomerInfoBtn = new Button();
            ShowInactiveBtn = new Button();
            ShowAllBtn = new Button();
            ChooseCustomerTitle = new Label();
            CustomerListBox = new ListBox();
            NewCustomerPanel = new Panel();
            label27 = new Label();
            label23 = new Label();
            label28 = new Label();
            label26 = new Label();
            memberType = new ComboBox();
            BirthdayValue = new DateTimePicker();
            label25 = new Label();
            label24 = new Label();
            label22 = new Label();
            Required = new Label();
            NewCustomerCancelBtn = new Button();
            NewCustomerConfirmBtn = new Button();
            Notes = new TextBox();
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
            CustomerInformationPanel = new Panel();
            memberTypetxt = new TextBox();
            label33 = new Label();
            label32 = new Label();
            IDtxt = new TextBox();
            label31 = new Label();
            statusInfoTxt = new TextBox();
            activityInfoList = new ListBox();
            label2 = new Label();
            InfoBackBtn = new Button();
            label1 = new Label();
            noteInfoTxt = new TextBox();
            birthdayInfoTxt = new TextBox();
            phoneInfoTxt = new TextBox();
            emailInfoTxt = new TextBox();
            lastNameInfoTxt = new TextBox();
            label3 = new Label();
            NameInfoTxt = new TextBox();
            label10 = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            Kundeinformation = new Label();
            EditCustomerTitle = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label12 = new Label();
            EditFirst = new TextBox();
            label11 = new Label();
            EditLast = new TextBox();
            EditMail = new TextBox();
            EditPhone = new TextBox();
            EditNote = new TextBox();
            EditCustomerConfirmBtn = new Button();
            EditCustomerCancelBtn = new Button();
            label34 = new Label();
            EditType = new TextBox();
            EditCustomerPanel = new Panel();
            MarkInactive = new Button();
            label36 = new Label();
            EditCustomerID = new TextBox();
            CurrentStatus = new TextBox();
            label35 = new Label();
            label17 = new Label();
            MarkActive = new Button();
            ListPanel.SuspendLayout();
            panel1.SuspendLayout();
            NewCustomerPanel.SuspendLayout();
            CustomerInformationPanel.SuspendLayout();
            EditCustomerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ListPanel
            // 
            ListPanel.Controls.Add(ShowActiveBtn);
            ListPanel.Controls.Add(panel1);
            ListPanel.Controls.Add(label29);
            ListPanel.Controls.Add(count);
            ListPanel.Controls.Add(CustomerInfoBtn);
            ListPanel.Controls.Add(ShowInactiveBtn);
            ListPanel.Controls.Add(ShowAllBtn);
            ListPanel.Controls.Add(ChooseCustomerTitle);
            ListPanel.Controls.Add(CustomerListBox);
            ListPanel.Location = new Point(734, 12);
            ListPanel.Name = "ListPanel";
            ListPanel.Size = new Size(578, 563);
            ListPanel.TabIndex = 8;
            // 
            // ShowActiveBtn
            // 
            ShowActiveBtn.Location = new Point(173, 82);
            ShowActiveBtn.Name = "ShowActiveBtn";
            ShowActiveBtn.Size = new Size(94, 29);
            ShowActiveBtn.TabIndex = 51;
            ShowActiveBtn.Text = "Vis aktiv";
            ShowActiveBtn.UseVisualStyleBackColor = true;
            ShowActiveBtn.Click += ShowActiveBtn_Click_1;
            // 
            // panel1
            // 
            panel1.Controls.Add(IDinfo);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(InfoBtn);
            panel1.Controls.Add(label30);
            panel1.Location = new Point(306, 221);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 125);
            panel1.TabIndex = 50;
            // 
            // IDinfo
            // 
            IDinfo.Location = new Point(67, 42);
            IDinfo.Name = "IDinfo";
            IDinfo.Size = new Size(125, 27);
            IDinfo.TabIndex = 53;
            // 
            // button3
            // 
            button3.Location = new Point(144, 89);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 38;
            button3.Text = "Rediger";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // InfoBtn
            // 
            InfoBtn.Location = new Point(13, 89);
            InfoBtn.Name = "InfoBtn";
            InfoBtn.Size = new Size(116, 29);
            InfoBtn.TabIndex = 51;
            InfoBtn.Text = "Information";
            InfoBtn.UseVisualStyleBackColor = true;
            InfoBtn.Click += InfoBtn_Click;
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Location = new Point(55, 8);
            label30.Name = "label30";
            label30.Size = new Size(138, 20);
            label30.TabIndex = 0;
            label30.Text = "Indtast medlems ID";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Location = new Point(373, 85);
            label29.Name = "label29";
            label29.Size = new Size(93, 20);
            label29.TabIndex = 49;
            label29.Text = "Medlemmer:";
            // 
            // count
            // 
            count.Location = new Point(466, 82);
            count.Name = "count";
            count.ReadOnly = true;
            count.Size = new Size(33, 27);
            count.TabIndex = 21;
            // 
            // CustomerInfoBtn
            // 
            CustomerInfoBtn.Location = new Point(63, 423);
            CustomerInfoBtn.Name = "CustomerInfoBtn";
            CustomerInfoBtn.Size = new Size(171, 29);
            CustomerInfoBtn.TabIndex = 20;
            CustomerInfoBtn.Text = "Information/Rediger";
            CustomerInfoBtn.UseVisualStyleBackColor = true;
            // 
            // ShowInactiveBtn
            // 
            ShowInactiveBtn.Location = new Point(273, 82);
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
            // ChooseCustomerTitle
            // 
            ChooseCustomerTitle.AutoSize = true;
            ChooseCustomerTitle.Font = new Font("Segoe UI", 12F);
            ChooseCustomerTitle.Location = new Point(63, 25);
            ChooseCustomerTitle.Name = "ChooseCustomerTitle";
            ChooseCustomerTitle.Size = new Size(139, 28);
            ChooseCustomerTitle.TabIndex = 11;
            ChooseCustomerTitle.Text = "Kundeoversigt";
            // 
            // CustomerListBox
            // 
            CustomerListBox.FormattingEnabled = true;
            CustomerListBox.Location = new Point(63, 122);
            CustomerListBox.Name = "CustomerListBox";
            CustomerListBox.Size = new Size(436, 284);
            CustomerListBox.TabIndex = 8;
            // 
            // NewCustomerPanel
            // 
            NewCustomerPanel.Controls.Add(label27);
            NewCustomerPanel.Controls.Add(label23);
            NewCustomerPanel.Controls.Add(label28);
            NewCustomerPanel.Controls.Add(label26);
            NewCustomerPanel.Controls.Add(memberType);
            NewCustomerPanel.Controls.Add(BirthdayValue);
            NewCustomerPanel.Controls.Add(label25);
            NewCustomerPanel.Controls.Add(label24);
            NewCustomerPanel.Controls.Add(label22);
            NewCustomerPanel.Controls.Add(Required);
            NewCustomerPanel.Controls.Add(NewCustomerCancelBtn);
            NewCustomerPanel.Controls.Add(NewCustomerConfirmBtn);
            NewCustomerPanel.Controls.Add(Notes);
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
            NewCustomerPanel.Size = new Size(584, 426);
            NewCustomerPanel.TabIndex = 9;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Segoe UI", 11F);
            label27.ForeColor = Color.Red;
            label27.Location = new Point(150, 262);
            label27.Name = "label27";
            label27.Size = new Size(20, 25);
            label27.TabIndex = 48;
            label27.Text = "*";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 11F);
            label23.ForeColor = Color.Red;
            label23.Location = new Point(424, 88);
            label23.Name = "label23";
            label23.Size = new Size(20, 25);
            label23.TabIndex = 47;
            label23.Text = "*";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Segoe UI", 11F);
            label28.ForeColor = Color.Red;
            label28.Location = new Point(150, 181);
            label28.Name = "label28";
            label28.Size = new Size(20, 25);
            label28.TabIndex = 46;
            label28.Text = "*";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(459, 145);
            label26.Name = "label26";
            label26.Size = new Size(94, 60);
            label26.TabIndex = 44;
            label26.Text = "1 = Basic\r\n2 = Premium\r\n3 = VIP";
            // 
            // memberType
            // 
            memberType.DropDownStyle = ComboBoxStyle.DropDownList;
            memberType.FormattingEnabled = true;
            memberType.Location = new Point(450, 85);
            memberType.Name = "memberType";
            memberType.Size = new Size(125, 28);
            memberType.TabIndex = 43;
            // 
            // BirthdayValue
            // 
            BirthdayValue.Location = new Point(198, 260);
            BirthdayValue.Name = "BirthdayValue";
            BirthdayValue.Size = new Size(250, 27);
            BirthdayValue.TabIndex = 42;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(329, 87);
            label25.Name = "label25";
            label25.Size = new Size(99, 20);
            label25.TabIndex = 41;
            label25.Text = "Medlemstype";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 11F);
            label24.ForeColor = Color.Red;
            label24.Location = new Point(150, 221);
            label24.Name = "label24";
            label24.Size = new Size(20, 25);
            label24.TabIndex = 39;
            label24.Text = "*";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 11F);
            label22.ForeColor = Color.Red;
            label22.Location = new Point(150, 138);
            label22.Name = "label22";
            label22.Size = new Size(20, 25);
            label22.TabIndex = 37;
            label22.Text = "*";
            // 
            // Required
            // 
            Required.AutoSize = true;
            Required.Font = new Font("Segoe UI", 11F);
            Required.ForeColor = Color.Red;
            Required.Location = new Point(150, 87);
            Required.Name = "Required";
            Required.Size = new Size(20, 25);
            Required.TabIndex = 36;
            Required.Text = "*";
            // 
            // NewCustomerCancelBtn
            // 
            NewCustomerCancelBtn.Location = new Point(369, 374);
            NewCustomerCancelBtn.Name = "NewCustomerCancelBtn";
            NewCustomerCancelBtn.Size = new Size(94, 29);
            NewCustomerCancelBtn.TabIndex = 35;
            NewCustomerCancelBtn.Text = "Annuler";
            NewCustomerCancelBtn.UseVisualStyleBackColor = true;
            NewCustomerCancelBtn.Click += NewCustomerCancelBtn_Click;
            // 
            // NewCustomerConfirmBtn
            // 
            NewCustomerConfirmBtn.Location = new Point(469, 374);
            NewCustomerConfirmBtn.Name = "NewCustomerConfirmBtn";
            NewCustomerConfirmBtn.Size = new Size(94, 29);
            NewCustomerConfirmBtn.TabIndex = 34;
            NewCustomerConfirmBtn.Text = "Gem";
            NewCustomerConfirmBtn.UseVisualStyleBackColor = true;
            NewCustomerConfirmBtn.Click += NewCustomerConfirmBtn_Click;
            // 
            // Notes
            // 
            Notes.Location = new Point(198, 303);
            Notes.Multiline = true;
            Notes.Name = "Notes";
            Notes.Size = new Size(365, 57);
            Notes.TabIndex = 16;
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
            label9.AutoSize = true;
            label9.Location = new Point(60, 303);
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
            ShowListBtn.Location = new Point(631, 134);
            ShowListBtn.Name = "ShowListBtn";
            ShowListBtn.Size = new Size(94, 29);
            ShowListBtn.TabIndex = 13;
            ShowListBtn.Text = "Vis liste";
            ShowListBtn.UseVisualStyleBackColor = true;
            // 
            // NewCustomerBtn
            // 
            NewCustomerBtn.Location = new Point(631, 252);
            NewCustomerBtn.Name = "NewCustomerBtn";
            NewCustomerBtn.Size = new Size(94, 29);
            NewCustomerBtn.TabIndex = 14;
            NewCustomerBtn.Text = "Ny medlem";
            NewCustomerBtn.UseVisualStyleBackColor = true;
            // 
            // BackBtn
            // 
            BackBtn.Location = new Point(631, 386);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(94, 29);
            BackBtn.TabIndex = 16;
            BackBtn.Text = "Tilbage";
            BackBtn.UseVisualStyleBackColor = true;
            // 
            // CustomerInformationPanel
            // 
            CustomerInformationPanel.Controls.Add(memberTypetxt);
            CustomerInformationPanel.Controls.Add(label33);
            CustomerInformationPanel.Controls.Add(label32);
            CustomerInformationPanel.Controls.Add(IDtxt);
            CustomerInformationPanel.Controls.Add(label31);
            CustomerInformationPanel.Controls.Add(statusInfoTxt);
            CustomerInformationPanel.Controls.Add(activityInfoList);
            CustomerInformationPanel.Controls.Add(label2);
            CustomerInformationPanel.Controls.Add(InfoBackBtn);
            CustomerInformationPanel.Controls.Add(label1);
            CustomerInformationPanel.Controls.Add(noteInfoTxt);
            CustomerInformationPanel.Controls.Add(birthdayInfoTxt);
            CustomerInformationPanel.Controls.Add(phoneInfoTxt);
            CustomerInformationPanel.Controls.Add(emailInfoTxt);
            CustomerInformationPanel.Controls.Add(lastNameInfoTxt);
            CustomerInformationPanel.Controls.Add(label3);
            CustomerInformationPanel.Controls.Add(NameInfoTxt);
            CustomerInformationPanel.Controls.Add(label10);
            CustomerInformationPanel.Controls.Add(label18);
            CustomerInformationPanel.Controls.Add(label19);
            CustomerInformationPanel.Controls.Add(label20);
            CustomerInformationPanel.Controls.Add(label21);
            CustomerInformationPanel.Controls.Add(Kundeinformation);
            CustomerInformationPanel.Location = new Point(737, 532);
            CustomerInformationPanel.Name = "CustomerInformationPanel";
            CustomerInformationPanel.Size = new Size(613, 451);
            CustomerInformationPanel.TabIndex = 37;
            // 
            // memberTypetxt
            // 
            memberTypetxt.Location = new Point(434, 137);
            memberTypetxt.Name = "memberTypetxt";
            memberTypetxt.ReadOnly = true;
            memberTypetxt.Size = new Size(125, 27);
            memberTypetxt.TabIndex = 47;
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Location = new Point(329, 140);
            label33.Name = "label33";
            label33.Size = new Size(99, 20);
            label33.TabIndex = 46;
            label33.Text = "Medlemstype";
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Location = new Point(465, 168);
            label32.Name = "label32";
            label32.Size = new Size(94, 60);
            label32.TabIndex = 45;
            label32.Text = "1 = Basic\r\n2 = Premium\r\n3 = VIP";
            // 
            // IDtxt
            // 
            IDtxt.Location = new Point(188, 75);
            IDtxt.Name = "IDtxt";
            IDtxt.ReadOnly = true;
            IDtxt.Size = new Size(125, 27);
            IDtxt.TabIndex = 42;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Location = new Point(50, 78);
            label31.Name = "label31";
            label31.Size = new Size(24, 20);
            label31.TabIndex = 41;
            label31.Text = "ID";
            // 
            // statusInfoTxt
            // 
            statusInfoTxt.Location = new Point(434, 75);
            statusInfoTxt.Name = "statusInfoTxt";
            statusInfoTxt.ReadOnly = true;
            statusInfoTxt.Size = new Size(125, 27);
            statusInfoTxt.TabIndex = 40;
            // 
            // activityInfoList
            // 
            activityInfoList.FormattingEnabled = true;
            activityInfoList.Location = new Point(331, 246);
            activityInfoList.Name = "activityInfoList";
            activityInfoList.Size = new Size(225, 84);
            activityInfoList.TabIndex = 39;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(331, 216);
            label2.Name = "label2";
            label2.Size = new Size(102, 20);
            label2.TabIndex = 38;
            label2.Text = "Bookede hold";
            // 
            // InfoBackBtn
            // 
            InfoBackBtn.Location = new Point(481, 395);
            InfoBackBtn.Name = "InfoBackBtn";
            InfoBackBtn.Size = new Size(94, 29);
            InfoBackBtn.TabIndex = 36;
            InfoBackBtn.Text = "Tilbage";
            InfoBackBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(329, 78);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 31;
            label1.Text = "Inactive";
            // 
            // noteInfoTxt
            // 
            noteInfoTxt.Location = new Point(188, 336);
            noteInfoTxt.Multiline = true;
            noteInfoTxt.Name = "noteInfoTxt";
            noteInfoTxt.ReadOnly = true;
            noteInfoTxt.Size = new Size(368, 53);
            noteInfoTxt.TabIndex = 29;
            // 
            // birthdayInfoTxt
            // 
            birthdayInfoTxt.Location = new Point(188, 293);
            birthdayInfoTxt.Name = "birthdayInfoTxt";
            birthdayInfoTxt.ReadOnly = true;
            birthdayInfoTxt.Size = new Size(125, 27);
            birthdayInfoTxt.TabIndex = 28;
            // 
            // phoneInfoTxt
            // 
            phoneInfoTxt.Location = new Point(188, 255);
            phoneInfoTxt.Name = "phoneInfoTxt";
            phoneInfoTxt.ReadOnly = true;
            phoneInfoTxt.Size = new Size(125, 27);
            phoneInfoTxt.TabIndex = 27;
            // 
            // emailInfoTxt
            // 
            emailInfoTxt.Location = new Point(188, 211);
            emailInfoTxt.Name = "emailInfoTxt";
            emailInfoTxt.ReadOnly = true;
            emailInfoTxt.Size = new Size(125, 27);
            emailInfoTxt.TabIndex = 26;
            // 
            // lastNameInfoTxt
            // 
            lastNameInfoTxt.Location = new Point(188, 168);
            lastNameInfoTxt.Name = "lastNameInfoTxt";
            lastNameInfoTxt.ReadOnly = true;
            lastNameInfoTxt.Size = new Size(125, 27);
            lastNameInfoTxt.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 336);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 23;
            label3.Text = "Notat";
            // 
            // NameInfoTxt
            // 
            NameInfoTxt.Location = new Point(188, 117);
            NameInfoTxt.Name = "NameInfoTxt";
            NameInfoTxt.ReadOnly = true;
            NameInfoTxt.Size = new Size(125, 27);
            NameInfoTxt.TabIndex = 22;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(50, 258);
            label10.Name = "label10";
            label10.Size = new Size(50, 20);
            label10.TabIndex = 21;
            label10.Text = "Phone";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(50, 293);
            label18.Name = "label18";
            label18.Size = new Size(84, 20);
            label18.TabIndex = 20;
            label18.Text = "Fødselsdag";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(50, 214);
            label19.Name = "label19";
            label19.Size = new Size(46, 20);
            label19.TabIndex = 19;
            label19.Text = "Email";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(50, 168);
            label20.Name = "label20";
            label20.Size = new Size(71, 20);
            label20.TabIndex = 18;
            label20.Text = "Efternavn";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(50, 120);
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
            // EditCustomerTitle
            // 
            EditCustomerTitle.AutoSize = true;
            EditCustomerTitle.Font = new Font("Segoe UI", 12F);
            EditCustomerTitle.Location = new Point(75, 27);
            EditCustomerTitle.Name = "EditCustomerTitle";
            EditCustomerTitle.Size = new Size(138, 28);
            EditCustomerTitle.TabIndex = 13;
            EditCustomerTitle.Text = "Rediger kunde";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(71, 151);
            label16.Name = "label16";
            label16.Size = new Size(61, 20);
            label16.TabIndex = 17;
            label16.Text = "Fornavn";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(75, 199);
            label15.Name = "label15";
            label15.Size = new Size(71, 20);
            label15.TabIndex = 18;
            label15.Text = "Efternavn";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(75, 242);
            label14.Name = "label14";
            label14.Size = new Size(46, 20);
            label14.TabIndex = 19;
            label14.Text = "Email";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(356, 240);
            label12.Name = "label12";
            label12.Size = new Size(50, 20);
            label12.TabIndex = 21;
            label12.Text = "Phone";
            // 
            // EditFirst
            // 
            EditFirst.Location = new Point(202, 148);
            EditFirst.Name = "EditFirst";
            EditFirst.Size = new Size(125, 27);
            EditFirst.TabIndex = 22;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(74, 278);
            label11.Name = "label11";
            label11.Size = new Size(47, 20);
            label11.TabIndex = 23;
            label11.Text = "Notat";
            // 
            // EditLast
            // 
            EditLast.Location = new Point(202, 196);
            EditLast.Name = "EditLast";
            EditLast.Size = new Size(125, 27);
            EditLast.TabIndex = 25;
            // 
            // EditMail
            // 
            EditMail.Location = new Point(205, 238);
            EditMail.Name = "EditMail";
            EditMail.Size = new Size(125, 27);
            EditMail.TabIndex = 26;
            // 
            // EditPhone
            // 
            EditPhone.Location = new Point(450, 235);
            EditPhone.Name = "EditPhone";
            EditPhone.Size = new Size(125, 27);
            EditPhone.TabIndex = 27;
            // 
            // EditNote
            // 
            EditNote.Location = new Point(207, 295);
            EditNote.Multiline = true;
            EditNote.Name = "EditNote";
            EditNote.Size = new Size(368, 53);
            EditNote.TabIndex = 29;
            // 
            // EditCustomerConfirmBtn
            // 
            EditCustomerConfirmBtn.Location = new Point(481, 377);
            EditCustomerConfirmBtn.Name = "EditCustomerConfirmBtn";
            EditCustomerConfirmBtn.Size = new Size(94, 29);
            EditCustomerConfirmBtn.TabIndex = 36;
            EditCustomerConfirmBtn.Text = "Gem";
            EditCustomerConfirmBtn.UseVisualStyleBackColor = true;
            EditCustomerConfirmBtn.Click += EditCustomerConfirmBtn_Click_1;
            // 
            // EditCustomerCancelBtn
            // 
            EditCustomerCancelBtn.Location = new Point(373, 377);
            EditCustomerCancelBtn.Name = "EditCustomerCancelBtn";
            EditCustomerCancelBtn.Size = new Size(94, 29);
            EditCustomerCancelBtn.TabIndex = 36;
            EditCustomerCancelBtn.Text = "Annuler";
            EditCustomerCancelBtn.UseVisualStyleBackColor = true;
            EditCustomerCancelBtn.Click += EditCustomerCancelBtn_Click;
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Location = new Point(356, 194);
            label34.Name = "label34";
            label34.Size = new Size(99, 20);
            label34.TabIndex = 38;
            label34.Text = "Medlemstype";
            // 
            // EditType
            // 
            EditType.Location = new Point(450, 190);
            EditType.Name = "EditType";
            EditType.Size = new Size(125, 27);
            EditType.TabIndex = 40;
            EditType.TextChanged += EditType_TextChanged;
            // 
            // EditCustomerPanel
            // 
            EditCustomerPanel.Controls.Add(MarkInactive);
            EditCustomerPanel.Controls.Add(label36);
            EditCustomerPanel.Controls.Add(EditCustomerID);
            EditCustomerPanel.Controls.Add(CurrentStatus);
            EditCustomerPanel.Controls.Add(label35);
            EditCustomerPanel.Controls.Add(label17);
            EditCustomerPanel.Controls.Add(EditType);
            EditCustomerPanel.Controls.Add(MarkActive);
            EditCustomerPanel.Controls.Add(label34);
            EditCustomerPanel.Controls.Add(EditCustomerCancelBtn);
            EditCustomerPanel.Controls.Add(EditCustomerConfirmBtn);
            EditCustomerPanel.Controls.Add(EditNote);
            EditCustomerPanel.Controls.Add(EditPhone);
            EditCustomerPanel.Controls.Add(EditMail);
            EditCustomerPanel.Controls.Add(EditLast);
            EditCustomerPanel.Controls.Add(label11);
            EditCustomerPanel.Controls.Add(EditFirst);
            EditCustomerPanel.Controls.Add(label12);
            EditCustomerPanel.Controls.Add(label14);
            EditCustomerPanel.Controls.Add(label15);
            EditCustomerPanel.Controls.Add(label16);
            EditCustomerPanel.Controls.Add(EditCustomerTitle);
            EditCustomerPanel.Location = new Point(12, 462);
            EditCustomerPanel.Name = "EditCustomerPanel";
            EditCustomerPanel.Size = new Size(613, 451);
            EditCustomerPanel.TabIndex = 12;
            // 
            // MarkInactive
            // 
            MarkInactive.Location = new Point(127, 371);
            MarkInactive.Name = "MarkInactive";
            MarkInactive.Size = new Size(63, 29);
            MarkInactive.TabIndex = 55;
            MarkInactive.Text = "Inaktiv";
            MarkInactive.UseVisualStyleBackColor = true;
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Location = new Point(481, 22);
            label36.Name = "label36";
            label36.Size = new Size(24, 20);
            label36.TabIndex = 54;
            label36.Text = "ID";
            // 
            // EditCustomerID
            // 
            EditCustomerID.Location = new Point(532, 15);
            EditCustomerID.Name = "EditCustomerID";
            EditCustomerID.ReadOnly = true;
            EditCustomerID.Size = new Size(34, 27);
            EditCustomerID.TabIndex = 53;
            // 
            // CurrentStatus
            // 
            CurrentStatus.Location = new Point(198, 104);
            CurrentStatus.Name = "CurrentStatus";
            CurrentStatus.ReadOnly = true;
            CurrentStatus.Size = new Size(125, 27);
            CurrentStatus.TabIndex = 49;
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Location = new Point(71, 112);
            label35.Name = "label35";
            label35.Size = new Size(60, 20);
            label35.TabIndex = 48;
            label35.Text = "Inactive";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(480, 111);
            label17.Name = "label17";
            label17.Size = new Size(95, 60);
            label17.TabIndex = 41;
            label17.Text = "1 = Standard\r\n2 = Premium\r\n3 = VIP\r\n";
            // 
            // MarkActive
            // 
            MarkActive.Location = new Point(71, 371);
            MarkActive.Name = "MarkActive";
            MarkActive.Size = new Size(50, 29);
            MarkActive.TabIndex = 51;
            MarkActive.Text = "Aktiv";
            MarkActive.UseVisualStyleBackColor = true;
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1397, 986);
            Controls.Add(CustomerInformationPanel);
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
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            NewCustomerPanel.ResumeLayout(false);
            NewCustomerPanel.PerformLayout();
            CustomerInformationPanel.ResumeLayout(false);
            CustomerInformationPanel.PerformLayout();
            EditCustomerPanel.ResumeLayout(false);
            EditCustomerPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel ListPanel;
        private ListBox CustomerListBox;
        private Panel NewCustomerPanel;
        private Label ChooseCustomerTitle;
        private Label label2;
        private Label NewCustomerTitle;
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
        private Button ShowListBtn;
        private Button NewCustomerBtn;
        private Button BackBtn;
        private Button NewCustomerCancelBtn;
        private Button NewCustomerConfirmBtn;
        private ComboBox StatusComboBox;
        private Button ShowAllBtn;
        private Button ShowInactiveBtn;
        private Button CustomerInfoBtn;
        private Panel CustomerInformationPanel;
        private Button InfoBtn;
        private Button InfoBackBtn;
        private Label label1;
        private TextBox noteInfoTxt;
        private TextBox birthdayInfoTxt;
        private TextBox phoneInfoTxt;
        private TextBox emailInfoTxt;
        private TextBox lastNameInfoTxt;
        private Label label3;
        private TextBox NameInfoTxt;
        private Label label10;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label Kundeinformation;
        private TextBox statusInfoTxt;
        private ListBox activityInfoList;
        private Label Required;
        private Label label24;
        private Label label22;
        private Label label25;
        private DateTimePicker BirthdayValue;
        private Label label26;
        private Label label28;
        private Label label23;
        private Label label27;
        private TextBox count;
        private Label label29;
        private Panel panel1;
        private Label label30;
        private Label label31;
        private TextBox IDtxt;
        private TextBox memberTypetxt;
        private Label label33;
        private Label label32;
        private ComboBox memberType;
        private Label EditCustomerTitle;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label12;
        private TextBox EditFirst;
        private Label label11;
        private TextBox EditLast;
        private TextBox EditMail;
        private TextBox EditPhone;
        private TextBox EditNote;
        private Button EditCustomerConfirmBtn;
        private Button EditCustomerCancelBtn;
        private Label label34;
        private TextBox EditType;
        private Label label35;
        private Panel EditCustomerPanel;
        private Button button3;
        private Label label17;
        private TextBox CurrentStatus;
        private Label label36;
        private TextBox EditCustomerID;
        private Button MarkActive;
        private Button ShowActiveBtn;
        private Button MarkInactive;
        private TextBox IDinfo;
    }
}