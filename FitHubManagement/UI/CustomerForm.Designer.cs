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
            SearchPanel = new Panel();
            IDinfo = new TextBox();
            button3 = new Button();
            InfoBtn = new Button();
            label30 = new Label();
            ShowActiveBtn = new Button();
            label29 = new Label();
            count = new TextBox();
            CustomerInfoBtn = new Button();
            ShowInactiveBtn = new Button();
            ShowAllBtn = new Button();
            ChooseCustomerTitle = new Label();
            CustomerListBox = new ListBox();
            BookingPanel = new Panel();
            label3 = new Label();
            label1 = new Label();
            activityInfoList = new ListBox();
            label2 = new Label();
            NewCustomerPanel = new Panel();
            label10 = new Label();
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
            EditCustomerPanel = new Panel();
            label18 = new Label();
            textBox1 = new TextBox();
            label13 = new Label();
            MarkInactive = new Button();
            label36 = new Label();
            EditCustomerID = new TextBox();
            CurrentStatus = new TextBox();
            label35 = new Label();
            label17 = new Label();
            EditType = new TextBox();
            MarkActive = new Button();
            label34 = new Label();
            EditCustomerCancelBtn = new Button();
            EditCustomerConfirmBtn = new Button();
            EditNote = new TextBox();
            EditPhone = new TextBox();
            EditMail = new TextBox();
            EditLast = new TextBox();
            label11 = new Label();
            EditFirst = new TextBox();
            label12 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            EditCustomerTitle = new Label();
            ShowListBtn = new Button();
            NewCustomerBtn = new Button();
            BackBtn = new Button();
            ListPanel.SuspendLayout();
            SearchPanel.SuspendLayout();
            BookingPanel.SuspendLayout();
            NewCustomerPanel.SuspendLayout();
            EditCustomerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ListPanel
            // 
            ListPanel.Controls.Add(SearchPanel);
            ListPanel.Controls.Add(ShowActiveBtn);
            ListPanel.Controls.Add(label29);
            ListPanel.Controls.Add(count);
            ListPanel.Controls.Add(CustomerInfoBtn);
            ListPanel.Controls.Add(ShowInactiveBtn);
            ListPanel.Controls.Add(ShowAllBtn);
            ListPanel.Controls.Add(ChooseCustomerTitle);
            ListPanel.Controls.Add(CustomerListBox);
            ListPanel.Location = new Point(10, 11);
            ListPanel.Margin = new Padding(3, 2, 3, 2);
            ListPanel.Name = "ListPanel";
            ListPanel.Size = new Size(536, 494);
            ListPanel.TabIndex = 8;
            // 
            // SearchPanel
            // 
            SearchPanel.BorderStyle = BorderStyle.FixedSingle;
            SearchPanel.Controls.Add(IDinfo);
            SearchPanel.Controls.Add(button3);
            SearchPanel.Controls.Add(InfoBtn);
            SearchPanel.Controls.Add(label30);
            SearchPanel.Location = new Point(124, 146);
            SearchPanel.Margin = new Padding(3, 2, 3, 2);
            SearchPanel.Name = "SearchPanel";
            SearchPanel.Size = new Size(219, 94);
            SearchPanel.TabIndex = 50;
            // 
            // IDinfo
            // 
            IDinfo.Location = new Point(59, 32);
            IDinfo.Margin = new Padding(3, 2, 3, 2);
            IDinfo.Name = "IDinfo";
            IDinfo.Size = new Size(110, 23);
            IDinfo.TabIndex = 53;
            // 
            // button3
            // 
            button3.Location = new Point(126, 67);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(82, 22);
            button3.TabIndex = 38;
            button3.Text = "Rediger";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // InfoBtn
            // 
            InfoBtn.Location = new Point(11, 67);
            InfoBtn.Margin = new Padding(3, 2, 3, 2);
            InfoBtn.Name = "InfoBtn";
            InfoBtn.Size = new Size(102, 22);
            InfoBtn.TabIndex = 51;
            InfoBtn.Text = "Information";
            InfoBtn.UseVisualStyleBackColor = true;
            InfoBtn.Click += InfoBtn_Click;
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Location = new Point(48, 6);
            label30.Name = "label30";
            label30.Size = new Size(109, 15);
            label30.TabIndex = 0;
            label30.Text = "Indtast medlems ID";
            // 
            // ShowActiveBtn
            // 
            ShowActiveBtn.Location = new Point(151, 62);
            ShowActiveBtn.Margin = new Padding(3, 2, 3, 2);
            ShowActiveBtn.Name = "ShowActiveBtn";
            ShowActiveBtn.Size = new Size(82, 22);
            ShowActiveBtn.TabIndex = 51;
            ShowActiveBtn.Text = "Vis aktiv";
            ShowActiveBtn.UseVisualStyleBackColor = true;
            ShowActiveBtn.Click += ShowActiveBtn_Click_1;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Location = new Point(326, 64);
            label29.Name = "label29";
            label29.Size = new Size(75, 15);
            label29.TabIndex = 49;
            label29.Text = "Medlemmer:";
            // 
            // count
            // 
            count.Location = new Point(408, 62);
            count.Margin = new Padding(3, 2, 3, 2);
            count.Name = "count";
            count.ReadOnly = true;
            count.Size = new Size(29, 23);
            count.TabIndex = 21;
            // 
            // CustomerInfoBtn
            // 
            CustomerInfoBtn.Location = new Point(55, 317);
            CustomerInfoBtn.Margin = new Padding(3, 2, 3, 2);
            CustomerInfoBtn.Name = "CustomerInfoBtn";
            CustomerInfoBtn.Size = new Size(150, 22);
            CustomerInfoBtn.TabIndex = 20;
            CustomerInfoBtn.Text = "Information/Rediger";
            CustomerInfoBtn.UseVisualStyleBackColor = true;
            CustomerInfoBtn.Click += CustomerInfoBtn_Click;
            // 
            // ShowInactiveBtn
            // 
            ShowInactiveBtn.Location = new Point(239, 62);
            ShowInactiveBtn.Margin = new Padding(3, 2, 3, 2);
            ShowInactiveBtn.Name = "ShowInactiveBtn";
            ShowInactiveBtn.Size = new Size(82, 22);
            ShowInactiveBtn.TabIndex = 18;
            ShowInactiveBtn.Text = "Vis inaktiv";
            ShowInactiveBtn.UseVisualStyleBackColor = true;
            ShowInactiveBtn.Click += ShowInactiveBtn_Click;
            // 
            // ShowAllBtn
            // 
            ShowAllBtn.Location = new Point(55, 62);
            ShowAllBtn.Margin = new Padding(3, 2, 3, 2);
            ShowAllBtn.Name = "ShowAllBtn";
            ShowAllBtn.Size = new Size(82, 22);
            ShowAllBtn.TabIndex = 17;
            ShowAllBtn.Text = "Vis alle";
            ShowAllBtn.UseVisualStyleBackColor = true;
            ShowAllBtn.Click += ShowBtn_Click;
            // 
            // ChooseCustomerTitle
            // 
            ChooseCustomerTitle.AutoSize = true;
            ChooseCustomerTitle.Font = new Font("Segoe UI", 12F);
            ChooseCustomerTitle.Location = new Point(55, 19);
            ChooseCustomerTitle.Name = "ChooseCustomerTitle";
            ChooseCustomerTitle.Size = new Size(110, 21);
            ChooseCustomerTitle.TabIndex = 11;
            ChooseCustomerTitle.Text = "Kundeoversigt";
            // 
            // CustomerListBox
            // 
            CustomerListBox.FormattingEnabled = true;
            CustomerListBox.ItemHeight = 15;
            CustomerListBox.Location = new Point(55, 92);
            CustomerListBox.Margin = new Padding(3, 2, 3, 2);
            CustomerListBox.Name = "CustomerListBox";
            CustomerListBox.Size = new Size(382, 214);
            CustomerListBox.TabIndex = 8;
            // 
            // BookingPanel
            // 
            BookingPanel.Controls.Add(label3);
            BookingPanel.Controls.Add(label1);
            BookingPanel.Controls.Add(activityInfoList);
            BookingPanel.Controls.Add(label2);
            BookingPanel.Location = new Point(9, 11);
            BookingPanel.Name = "BookingPanel";
            BookingPanel.Size = new Size(534, 328);
            BookingPanel.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(231, 69);
            label3.Name = "label3";
            label3.Size = new Size(175, 45);
            label3.TabIndex = 41;
            label3.Text = "Hold 6: Forest Dance Flow\r\nHold 7: Eco-Wellness Workshop\r\nHold 8: Hiit \r\n";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 69);
            label1.Name = "label1";
            label1.Size = new Size(192, 75);
            label1.TabIndex = 40;
            label1.Text = "Hold 1: Forest Yoga\r\nHold 2: Outdoor Pilates\r\nHold 3: Mindful Hiking\r\nHold 4: Meditation and Breathwork\r\nHold 5: Community Circle Training\r\n";
            // 
            // activityInfoList
            // 
            activityInfoList.FormattingEnabled = true;
            activityInfoList.ItemHeight = 15;
            activityInfoList.Location = new Point(19, 209);
            activityInfoList.Margin = new Padding(3, 2, 3, 2);
            activityInfoList.Name = "activityInfoList";
            activityInfoList.Size = new Size(469, 79);
            activityInfoList.TabIndex = 39;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(16, 14);
            label2.Name = "label2";
            label2.Size = new Size(105, 21);
            label2.TabIndex = 38;
            label2.Text = "Bookede hold";
            // 
            // NewCustomerPanel
            // 
            NewCustomerPanel.Controls.Add(label10);
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
            NewCustomerPanel.Location = new Point(10, 13);
            NewCustomerPanel.Margin = new Padding(3, 2, 3, 2);
            NewCustomerPanel.Name = "NewCustomerPanel";
            NewCustomerPanel.Size = new Size(536, 351);
            NewCustomerPanel.TabIndex = 9;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(293, 169);
            label10.Name = "label10";
            label10.Size = new Size(74, 15);
            label10.TabIndex = 49;
            label10.Text = "\"00 00 00 00\"";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Segoe UI", 11F);
            label27.ForeColor = Color.Red;
            label27.Location = new Point(131, 196);
            label27.Name = "label27";
            label27.Size = new Size(15, 20);
            label27.TabIndex = 48;
            label27.Text = "*";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 11F);
            label23.ForeColor = Color.Red;
            label23.Location = new Point(371, 66);
            label23.Name = "label23";
            label23.Size = new Size(15, 20);
            label23.TabIndex = 47;
            label23.Text = "*";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Segoe UI", 11F);
            label28.ForeColor = Color.Red;
            label28.Location = new Point(131, 136);
            label28.Name = "label28";
            label28.Size = new Size(15, 20);
            label28.TabIndex = 46;
            label28.Text = "*";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(402, 109);
            label26.Name = "label26";
            label26.Size = new Size(76, 45);
            label26.TabIndex = 44;
            label26.Text = "1 = Basic\r\n2 = Premium\r\n3 = VIP";
            // 
            // memberType
            // 
            memberType.DropDownStyle = ComboBoxStyle.DropDownList;
            memberType.FormattingEnabled = true;
            memberType.Location = new Point(394, 64);
            memberType.Margin = new Padding(3, 2, 3, 2);
            memberType.Name = "memberType";
            memberType.Size = new Size(110, 23);
            memberType.TabIndex = 43;
            // 
            // BirthdayValue
            // 
            BirthdayValue.Location = new Point(173, 195);
            BirthdayValue.Margin = new Padding(3, 2, 3, 2);
            BirthdayValue.Name = "BirthdayValue";
            BirthdayValue.Size = new Size(219, 23);
            BirthdayValue.TabIndex = 42;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(288, 65);
            label25.Name = "label25";
            label25.Size = new Size(79, 15);
            label25.TabIndex = 41;
            label25.Text = "Medlemstype";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 11F);
            label24.ForeColor = Color.Red;
            label24.Location = new Point(131, 166);
            label24.Name = "label24";
            label24.Size = new Size(15, 20);
            label24.TabIndex = 39;
            label24.Text = "*";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 11F);
            label22.ForeColor = Color.Red;
            label22.Location = new Point(131, 104);
            label22.Name = "label22";
            label22.Size = new Size(15, 20);
            label22.TabIndex = 37;
            label22.Text = "*";
            // 
            // Required
            // 
            Required.AutoSize = true;
            Required.Font = new Font("Segoe UI", 11F);
            Required.ForeColor = Color.Red;
            Required.Location = new Point(131, 65);
            Required.Name = "Required";
            Required.Size = new Size(15, 20);
            Required.TabIndex = 36;
            Required.Text = "*";
            // 
            // NewCustomerCancelBtn
            // 
            NewCustomerCancelBtn.Location = new Point(323, 280);
            NewCustomerCancelBtn.Margin = new Padding(3, 2, 3, 2);
            NewCustomerCancelBtn.Name = "NewCustomerCancelBtn";
            NewCustomerCancelBtn.Size = new Size(82, 22);
            NewCustomerCancelBtn.TabIndex = 35;
            NewCustomerCancelBtn.Text = "Annuler";
            NewCustomerCancelBtn.UseVisualStyleBackColor = true;
            NewCustomerCancelBtn.Click += NewCustomerCancelBtn_Click;
            // 
            // NewCustomerConfirmBtn
            // 
            NewCustomerConfirmBtn.Location = new Point(410, 280);
            NewCustomerConfirmBtn.Margin = new Padding(3, 2, 3, 2);
            NewCustomerConfirmBtn.Name = "NewCustomerConfirmBtn";
            NewCustomerConfirmBtn.Size = new Size(82, 22);
            NewCustomerConfirmBtn.TabIndex = 34;
            NewCustomerConfirmBtn.Text = "Gem";
            NewCustomerConfirmBtn.UseVisualStyleBackColor = true;
            NewCustomerConfirmBtn.Click += NewCustomerConfirmBtn_Click;
            // 
            // Notes
            // 
            Notes.Location = new Point(173, 227);
            Notes.Margin = new Padding(3, 2, 3, 2);
            Notes.Multiline = true;
            Notes.Name = "Notes";
            Notes.Size = new Size(320, 44);
            Notes.TabIndex = 16;
            // 
            // Phone
            // 
            Phone.Location = new Point(173, 166);
            Phone.Margin = new Padding(3, 2, 3, 2);
            Phone.Name = "Phone";
            Phone.Size = new Size(110, 23);
            Phone.TabIndex = 14;
            // 
            // Email
            // 
            Email.Location = new Point(173, 134);
            Email.Margin = new Padding(3, 2, 3, 2);
            Email.Name = "Email";
            Email.Size = new Size(110, 23);
            Email.TabIndex = 13;
            // 
            // LastName
            // 
            LastName.Location = new Point(173, 101);
            LastName.Margin = new Padding(3, 2, 3, 2);
            LastName.Name = "LastName";
            LastName.Size = new Size(110, 23);
            LastName.TabIndex = 12;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(52, 227);
            label9.Name = "label9";
            label9.Size = new Size(37, 15);
            label9.TabIndex = 7;
            label9.Text = "Notat";
            // 
            // FirstName
            // 
            FirstName.Location = new Point(173, 63);
            FirstName.Margin = new Padding(3, 2, 3, 2);
            FirstName.Name = "FirstName";
            FirstName.Size = new Size(110, 23);
            FirstName.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(52, 169);
            label8.Name = "label8";
            label8.Size = new Size(41, 15);
            label8.TabIndex = 5;
            label8.Text = "Phone";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(52, 195);
            label7.Name = "label7";
            label7.Size = new Size(66, 15);
            label7.TabIndex = 4;
            label7.Text = "Fødselsdag";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(52, 136);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 3;
            label6.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(52, 101);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 2;
            label5.Text = "Efternavn";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(52, 65);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 1;
            label4.Text = "Fornavn";
            // 
            // NewCustomerTitle
            // 
            NewCustomerTitle.AutoSize = true;
            NewCustomerTitle.Font = new Font("Segoe UI", 12F);
            NewCustomerTitle.Location = new Point(52, 11);
            NewCustomerTitle.Name = "NewCustomerTitle";
            NewCustomerTitle.Size = new Size(207, 42);
            NewCustomerTitle.TabIndex = 0;
            NewCustomerTitle.Text = "Opret ny medlem\r\nVenligst fyld ind information\r\n";
            // 
            // EditCustomerPanel
            // 
            EditCustomerPanel.Controls.Add(label18);
            EditCustomerPanel.Controls.Add(textBox1);
            EditCustomerPanel.Controls.Add(label13);
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
            EditCustomerPanel.Location = new Point(10, 11);
            EditCustomerPanel.Margin = new Padding(3, 2, 3, 2);
            EditCustomerPanel.Name = "EditCustomerPanel";
            EditCustomerPanel.Size = new Size(536, 338);
            EditCustomerPanel.TabIndex = 12;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(429, 201);
            label18.Name = "label18";
            label18.Size = new Size(74, 15);
            label18.TabIndex = 56;
            label18.Text = "\"00 00 00 00\"";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(173, 51);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(110, 23);
            textBox1.TabIndex = 49;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(53, 51);
            label13.Name = "label13";
            label13.Size = new Size(66, 15);
            label13.TabIndex = 48;
            label13.Text = "Fødselsdag";
            // 
            // MarkInactive
            // 
            MarkInactive.Location = new Point(111, 278);
            MarkInactive.Margin = new Padding(3, 2, 3, 2);
            MarkInactive.Name = "MarkInactive";
            MarkInactive.Size = new Size(55, 22);
            MarkInactive.TabIndex = 55;
            MarkInactive.Text = "Inaktiv";
            MarkInactive.UseVisualStyleBackColor = true;
            MarkInactive.Click += MarkInactive_Click;
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Location = new Point(421, 16);
            label36.Name = "label36";
            label36.Size = new Size(18, 15);
            label36.TabIndex = 54;
            label36.Text = "ID";
            // 
            // EditCustomerID
            // 
            EditCustomerID.Location = new Point(466, 11);
            EditCustomerID.Margin = new Padding(3, 2, 3, 2);
            EditCustomerID.Name = "EditCustomerID";
            EditCustomerID.ReadOnly = true;
            EditCustomerID.Size = new Size(30, 23);
            EditCustomerID.TabIndex = 53;
            // 
            // CurrentStatus
            // 
            CurrentStatus.Location = new Point(173, 78);
            CurrentStatus.Margin = new Padding(3, 2, 3, 2);
            CurrentStatus.Name = "CurrentStatus";
            CurrentStatus.ReadOnly = true;
            CurrentStatus.Size = new Size(110, 23);
            CurrentStatus.TabIndex = 49;
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Location = new Point(62, 84);
            label35.Name = "label35";
            label35.Size = new Size(48, 15);
            label35.TabIndex = 48;
            label35.Text = "Inactive";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(420, 83);
            label17.Name = "label17";
            label17.Size = new Size(76, 45);
            label17.TabIndex = 41;
            label17.Text = "1 = Standard\r\n2 = Premium\r\n3 = VIP\r\n";
            // 
            // EditType
            // 
            EditType.Location = new Point(394, 142);
            EditType.Margin = new Padding(3, 2, 3, 2);
            EditType.Name = "EditType";
            EditType.Size = new Size(110, 23);
            EditType.TabIndex = 40;
            // 
            // MarkActive
            // 
            MarkActive.Location = new Point(62, 278);
            MarkActive.Margin = new Padding(3, 2, 3, 2);
            MarkActive.Name = "MarkActive";
            MarkActive.Size = new Size(44, 22);
            MarkActive.TabIndex = 51;
            MarkActive.Text = "Aktiv";
            MarkActive.UseVisualStyleBackColor = true;
            MarkActive.Click += MarkActive_Click;
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Location = new Point(312, 146);
            label34.Name = "label34";
            label34.Size = new Size(79, 15);
            label34.TabIndex = 38;
            label34.Text = "Medlemstype";
            // 
            // EditCustomerCancelBtn
            // 
            EditCustomerCancelBtn.Location = new Point(326, 283);
            EditCustomerCancelBtn.Margin = new Padding(3, 2, 3, 2);
            EditCustomerCancelBtn.Name = "EditCustomerCancelBtn";
            EditCustomerCancelBtn.Size = new Size(82, 22);
            EditCustomerCancelBtn.TabIndex = 36;
            EditCustomerCancelBtn.Text = "Annuler";
            EditCustomerCancelBtn.UseVisualStyleBackColor = true;
            EditCustomerCancelBtn.Click += EditCustomerCancelBtn_Click;
            // 
            // EditCustomerConfirmBtn
            // 
            EditCustomerConfirmBtn.Location = new Point(421, 283);
            EditCustomerConfirmBtn.Margin = new Padding(3, 2, 3, 2);
            EditCustomerConfirmBtn.Name = "EditCustomerConfirmBtn";
            EditCustomerConfirmBtn.Size = new Size(82, 22);
            EditCustomerConfirmBtn.TabIndex = 36;
            EditCustomerConfirmBtn.Text = "Gem";
            EditCustomerConfirmBtn.UseVisualStyleBackColor = true;
            EditCustomerConfirmBtn.Click += EditCustomerConfirmBtn_Click_1;
            // 
            // EditNote
            // 
            EditNote.Location = new Point(181, 221);
            EditNote.Margin = new Padding(3, 2, 3, 2);
            EditNote.Multiline = true;
            EditNote.Name = "EditNote";
            EditNote.Size = new Size(322, 41);
            EditNote.TabIndex = 29;
            // 
            // EditPhone
            // 
            EditPhone.Location = new Point(394, 176);
            EditPhone.Margin = new Padding(3, 2, 3, 2);
            EditPhone.Name = "EditPhone";
            EditPhone.Size = new Size(110, 23);
            EditPhone.TabIndex = 27;
            // 
            // EditMail
            // 
            EditMail.Location = new Point(179, 178);
            EditMail.Margin = new Padding(3, 2, 3, 2);
            EditMail.Name = "EditMail";
            EditMail.Size = new Size(110, 23);
            EditMail.TabIndex = 26;
            // 
            // EditLast
            // 
            EditLast.Location = new Point(177, 147);
            EditLast.Margin = new Padding(3, 2, 3, 2);
            EditLast.Name = "EditLast";
            EditLast.Size = new Size(110, 23);
            EditLast.TabIndex = 25;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(65, 208);
            label11.Name = "label11";
            label11.Size = new Size(37, 15);
            label11.TabIndex = 23;
            label11.Text = "Notat";
            // 
            // EditFirst
            // 
            EditFirst.Location = new Point(177, 111);
            EditFirst.Margin = new Padding(3, 2, 3, 2);
            EditFirst.Name = "EditFirst";
            EditFirst.Size = new Size(110, 23);
            EditFirst.TabIndex = 22;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(312, 180);
            label12.Name = "label12";
            label12.Size = new Size(41, 15);
            label12.TabIndex = 21;
            label12.Text = "Phone";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(66, 182);
            label14.Name = "label14";
            label14.Size = new Size(36, 15);
            label14.TabIndex = 19;
            label14.Text = "Email";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(66, 149);
            label15.Name = "label15";
            label15.Size = new Size(57, 15);
            label15.TabIndex = 18;
            label15.Text = "Efternavn";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(62, 113);
            label16.Name = "label16";
            label16.Size = new Size(50, 15);
            label16.TabIndex = 17;
            label16.Text = "Fornavn";
            // 
            // EditCustomerTitle
            // 
            EditCustomerTitle.AutoSize = true;
            EditCustomerTitle.Font = new Font("Segoe UI", 12F);
            EditCustomerTitle.Location = new Point(66, 20);
            EditCustomerTitle.Name = "EditCustomerTitle";
            EditCustomerTitle.Size = new Size(111, 21);
            EditCustomerTitle.TabIndex = 13;
            EditCustomerTitle.Text = "Rediger kunde";
            // 
            // ShowListBtn
            // 
            ShowListBtn.Location = new Point(552, 100);
            ShowListBtn.Margin = new Padding(3, 2, 3, 2);
            ShowListBtn.Name = "ShowListBtn";
            ShowListBtn.Size = new Size(82, 22);
            ShowListBtn.TabIndex = 13;
            ShowListBtn.Text = "Vis liste";
            ShowListBtn.UseVisualStyleBackColor = true;
            ShowListBtn.Click += ShowListBtn_Click;
            // 
            // NewCustomerBtn
            // 
            NewCustomerBtn.Location = new Point(552, 189);
            NewCustomerBtn.Margin = new Padding(3, 2, 3, 2);
            NewCustomerBtn.Name = "NewCustomerBtn";
            NewCustomerBtn.Size = new Size(82, 22);
            NewCustomerBtn.TabIndex = 14;
            NewCustomerBtn.Text = "Ny medlem";
            NewCustomerBtn.UseVisualStyleBackColor = true;
            NewCustomerBtn.Click += NewCustomerBtn_Click;
            // 
            // BackBtn
            // 
            BackBtn.Location = new Point(552, 290);
            BackBtn.Margin = new Padding(3, 2, 3, 2);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(82, 22);
            BackBtn.TabIndex = 16;
            BackBtn.Text = "Tilbage";
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += BackBtn_Click;
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(665, 370);
            Controls.Add(BookingPanel);
            Controls.Add(ListPanel);
            Controls.Add(NewCustomerPanel);
            Controls.Add(BackBtn);
            Controls.Add(NewCustomerBtn);
            Controls.Add(EditCustomerPanel);
            Controls.Add(ShowListBtn);
            Margin = new Padding(3, 2, 3, 2);
            Name = "CustomerForm";
            Text = "CustomerForm";
            ListPanel.ResumeLayout(false);
            ListPanel.PerformLayout();
            SearchPanel.ResumeLayout(false);
            SearchPanel.PerformLayout();
            BookingPanel.ResumeLayout(false);
            BookingPanel.PerformLayout();
            NewCustomerPanel.ResumeLayout(false);
            NewCustomerPanel.PerformLayout();
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
        private Button InfoBtn;
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
        private Panel SearchPanel;
        private Label label30;
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
        private TextBox textBox1;
        private Label label13;
        private Panel BookingPanel;
        private Label label3;
        private Label label1;
        private Label label10;
        private Label label18;
    }
}