namespace FitHubManagement.UI.Instructor
{
    partial class CreateInstructorForm
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
            components = new System.ComponentModel.Container();
            lblFirstName = new Label();
            lblLastName = new Label();
            lblEmail = new Label();
            lblPhone = new Label();
            lblCert = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            txtCert = new TextBox();
            btnSaveIns = new Button();
            btnCancelCreateIns = new Button();
            panel1 = new Panel();
            pnlSearchActivity = new Panel();
            lblBookingCount = new Label();
            cmbShowInstructors = new ComboBox();
            button2 = new Button();
            listBox1 = new ListBox();
            chkFilterByDate = new CheckBox();
            btnSearchGet = new Button();
            dTPSearchDate = new DateTimePicker();
            lblSearchActivity = new Label();
            GetAll = new Panel();
            lstbxGetAllIns = new ListBox();
            btnCreateIns = new Button();
            btnGetAllIns = new Button();
            btnBackToFront = new Button();
            label1 = new Label();
            button1 = new Button();
            btnShowCustomerBooking = new Button();
            toolTip1 = new ToolTip(components);
            panel1.SuspendLayout();
            pnlSearchActivity.SuspendLayout();
            GetAll.SuspendLayout();
            SuspendLayout();
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(7, 49);
            lblFirstName.Margin = new Padding(2, 0, 2, 0);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(50, 15);
            lblFirstName.TabIndex = 4;
            lblFirstName.Text = "Fornavn";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(7, 86);
            lblLastName.Margin = new Padding(2, 0, 2, 0);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(57, 15);
            lblLastName.TabIndex = 5;
            lblLastName.Text = "Efternavn";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(7, 126);
            lblEmail.Margin = new Padding(2, 0, 2, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(7, 164);
            lblPhone.Margin = new Padding(2, 0, 2, 0);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(46, 15);
            lblPhone.TabIndex = 7;
            lblPhone.Text = "Telefon";
            // 
            // lblCert
            // 
            lblCert.AutoSize = true;
            lblCert.Location = new Point(7, 199);
            lblCert.Margin = new Padding(2, 0, 2, 0);
            lblCert.Name = "lblCert";
            lblCert.Size = new Size(55, 15);
            lblCert.TabIndex = 8;
            lblCert.Text = "Certifikat";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(93, 49);
            txtFirstName.Margin = new Padding(2, 1, 2, 1);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(244, 23);
            txtFirstName.TabIndex = 9;
            txtFirstName.TextChanged += FirstNameTxt_TextChanged;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(93, 86);
            txtLastName.Margin = new Padding(2, 1, 2, 1);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(244, 23);
            txtLastName.TabIndex = 10;
            txtLastName.TextChanged += LastNameTxt_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(93, 126);
            txtEmail.Margin = new Padding(2, 1, 2, 1);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(244, 23);
            txtEmail.TabIndex = 11;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(93, 164);
            txtPhone.Margin = new Padding(2, 1, 2, 1);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(244, 23);
            txtPhone.TabIndex = 12;
            // 
            // txtCert
            // 
            txtCert.Location = new Point(93, 199);
            txtCert.Margin = new Padding(2, 1, 2, 1);
            txtCert.Name = "txtCert";
            txtCert.Size = new Size(301, 23);
            txtCert.TabIndex = 13;
            // 
            // btnSaveIns
            // 
            btnSaveIns.Location = new Point(7, 244);
            btnSaveIns.Margin = new Padding(2, 1, 2, 1);
            btnSaveIns.Name = "btnSaveIns";
            btnSaveIns.Size = new Size(184, 26);
            btnSaveIns.TabIndex = 14;
            btnSaveIns.Text = "Gem";
            btnSaveIns.UseVisualStyleBackColor = true;
            btnSaveIns.Click += btnSaveIns_Click;
            // 
            // btnCancelCreateIns
            // 
            btnCancelCreateIns.Location = new Point(198, 244);
            btnCancelCreateIns.Margin = new Padding(2, 1, 2, 1);
            btnCancelCreateIns.Name = "btnCancelCreateIns";
            btnCancelCreateIns.Size = new Size(198, 26);
            btnCancelCreateIns.TabIndex = 15;
            btnCancelCreateIns.Text = "Annuller";
            btnCancelCreateIns.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtLastName);
            panel1.Controls.Add(btnCancelCreateIns);
            panel1.Controls.Add(lblFirstName);
            panel1.Controls.Add(btnSaveIns);
            panel1.Controls.Add(lblLastName);
            panel1.Controls.Add(txtCert);
            panel1.Controls.Add(lblEmail);
            panel1.Controls.Add(txtPhone);
            panel1.Controls.Add(lblPhone);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(lblCert);
            panel1.Controls.Add(txtFirstName);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(422, 438);
            panel1.TabIndex = 16;
            panel1.Paint += panel1_Paint;
            // 
            // pnlSearchActivity
            // 
            pnlSearchActivity.Controls.Add(lblBookingCount);
            pnlSearchActivity.Controls.Add(cmbShowInstructors);
            pnlSearchActivity.Controls.Add(button2);
            pnlSearchActivity.Controls.Add(listBox1);
            pnlSearchActivity.Controls.Add(chkFilterByDate);
            pnlSearchActivity.Controls.Add(btnSearchGet);
            pnlSearchActivity.Controls.Add(dTPSearchDate);
            pnlSearchActivity.Controls.Add(lblSearchActivity);
            pnlSearchActivity.Location = new Point(19, 40);
            pnlSearchActivity.Margin = new Padding(1, 1, 1, 1);
            pnlSearchActivity.Name = "pnlSearchActivity";
            pnlSearchActivity.Size = new Size(528, 471);
            pnlSearchActivity.TabIndex = 25;
            // 
            // lblBookingCount
            // 
            lblBookingCount.AutoSize = true;
            lblBookingCount.Location = new Point(406, 231);
            lblBookingCount.Margin = new Padding(1, 0, 1, 0);
            lblBookingCount.Name = "lblBookingCount";
            lblBookingCount.Size = new Size(114, 15);
            lblBookingCount.TabIndex = 26;
            lblBookingCount.Text = "Antal tilmeldinger: 0";
            // 
            // cmbShowInstructors
            // 
            cmbShowInstructors.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbShowInstructors.Location = new Point(117, 58);
            cmbShowInstructors.Margin = new Padding(1, 1, 1, 1);
            cmbShowInstructors.Name = "cmbShowInstructors";
            cmbShowInstructors.Size = new Size(128, 23);
            cmbShowInstructors.TabIndex = 0;
            toolTip1.SetToolTip(cmbShowInstructors, "Vælg én eller alle instruktører");
            // 
            // button2
            // 
            button2.Location = new Point(406, 192);
            button2.Margin = new Padding(2, 3, 2, 3);
            button2.Name = "button2";
            button2.Size = new Size(110, 23);
            button2.TabIndex = 22;
            button2.Text = "Vis tilmeldinger";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(36, 192);
            listBox1.Margin = new Padding(1, 1, 1, 1);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(366, 184);
            listBox1.TabIndex = 21;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // chkFilterByDate
            // 
            chkFilterByDate.AutoSize = true;
            chkFilterByDate.Location = new Point(21, 101);
            chkFilterByDate.Name = "chkFilterByDate";
            chkFilterByDate.Size = new Size(51, 19);
            chkFilterByDate.TabIndex = 20;
            chkFilterByDate.Text = "Dato";
            toolTip1.SetToolTip(chkFilterByDate, "Vælg for at søge på dato");
            chkFilterByDate.UseVisualStyleBackColor = true;
            chkFilterByDate.CheckedChanged += chkFilterByDate_CheckedChanged;
            // 
            // btnSearchGet
            // 
            btnSearchGet.Location = new Point(117, 122);
            btnSearchGet.Margin = new Padding(2, 3, 2, 3);
            btnSearchGet.Name = "btnSearchGet";
            btnSearchGet.Size = new Size(110, 23);
            btnSearchGet.TabIndex = 19;
            btnSearchGet.Text = "Vis søgeresultater";
            btnSearchGet.UseVisualStyleBackColor = true;
            btnSearchGet.Click += btnSearchGet_Click;
            // 
            // dTPSearchDate
            // 
            dTPSearchDate.Location = new Point(117, 93);
            dTPSearchDate.Margin = new Padding(2, 3, 2, 3);
            dTPSearchDate.Name = "dTPSearchDate";
            dTPSearchDate.Size = new Size(166, 23);
            dTPSearchDate.TabIndex = 6;
            // 
            // lblSearchActivity
            // 
            lblSearchActivity.AutoSize = true;
            lblSearchActivity.Location = new Point(15, 56);
            lblSearchActivity.Margin = new Padding(1, 0, 1, 0);
            lblSearchActivity.Name = "lblSearchActivity";
            lblSearchActivity.Size = new Size(58, 15);
            lblSearchActivity.TabIndex = 1;
            lblSearchActivity.Text = "Instruktør";
            // 
            // GetAll
            // 
            GetAll.Controls.Add(lstbxGetAllIns);
            GetAll.Location = new Point(9, 3);
            GetAll.Margin = new Padding(1, 1, 1, 1);
            GetAll.Name = "GetAll";
            GetAll.Size = new Size(418, 384);
            GetAll.TabIndex = 21;
            // 
            // lstbxGetAllIns
            // 
            lstbxGetAllIns.FormattingEnabled = true;
            lstbxGetAllIns.ItemHeight = 15;
            lstbxGetAllIns.Location = new Point(1, 31);
            lstbxGetAllIns.Margin = new Padding(1, 1, 1, 1);
            lstbxGetAllIns.Name = "lstbxGetAllIns";
            lstbxGetAllIns.Size = new Size(394, 334);
            lstbxGetAllIns.TabIndex = 0;
            lstbxGetAllIns.SelectedIndexChanged += lstbxGetAllIns_SelectedIndexChanged;
            // 
            // btnCreateIns
            // 
            btnCreateIns.Location = new Point(556, 90);
            btnCreateIns.Margin = new Padding(2, 2, 2, 2);
            btnCreateIns.Name = "btnCreateIns";
            btnCreateIns.Size = new Size(111, 22);
            btnCreateIns.TabIndex = 17;
            btnCreateIns.Text = "Opret";
            btnCreateIns.UseVisualStyleBackColor = true;
            btnCreateIns.Click += button1_Click;
            // 
            // btnGetAllIns
            // 
            btnGetAllIns.Location = new Point(556, 152);
            btnGetAllIns.Margin = new Padding(2, 2, 2, 2);
            btnGetAllIns.Name = "btnGetAllIns";
            btnGetAllIns.Size = new Size(111, 22);
            btnGetAllIns.TabIndex = 18;
            btnGetAllIns.Text = "Vis alle";
            btnGetAllIns.UseVisualStyleBackColor = true;
            btnGetAllIns.Click += button2_Click;
            // 
            // btnBackToFront
            // 
            btnBackToFront.Location = new Point(265, 152);
            btnBackToFront.Margin = new Padding(0, 0, 0, 0);
            btnBackToFront.Name = "btnBackToFront";
            btnBackToFront.Size = new Size(77, 21);
            btnBackToFront.TabIndex = 20;
            btnBackToFront.Text = "Tilbage";
            btnBackToFront.UseVisualStyleBackColor = true;
            btnBackToFront.Click += btnBackToFront_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(320, 3);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(269, 32);
            label1.TabIndex = 22;
            label1.Text = "Personaleadministration";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(556, 204);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(111, 22);
            button1.TabIndex = 23;
            button1.Text = "Rediger";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // btnShowCustomerBooking
            // 
            btnShowCustomerBooking.Location = new Point(556, 254);
            btnShowCustomerBooking.Margin = new Padding(1, 1, 1, 1);
            btnShowCustomerBooking.Name = "btnShowCustomerBooking";
            btnShowCustomerBooking.Size = new Size(111, 40);
            btnShowCustomerBooking.TabIndex = 24;
            btnShowCustomerBooking.Text = "Vis holdtilmeldinger";
            btnShowCustomerBooking.UseVisualStyleBackColor = true;
            btnShowCustomerBooking.Click += btnShowCustomerBooking_Click;
            // 
            // CreateInstructorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 188);
            Controls.Add(panel1);
            Controls.Add(pnlSearchActivity);
            Controls.Add(btnShowCustomerBooking);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(btnBackToFront);
            Controls.Add(btnGetAllIns);
            Controls.Add(btnCreateIns);
            Controls.Add(GetAll);
            Margin = new Padding(2, 1, 2, 1);
            Name = "CreateInstructorForm";
            Text = "Form1";
            Load += CreateInstructorForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlSearchActivity.ResumeLayout(false);
            pnlSearchActivity.PerformLayout();
            GetAll.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblEmail;
        private Label lblPhone;
        private Label lblCert;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private TextBox txtCert;
        private Button btnSaveIns;
        private Button btnCancelCreateIns;
        private Panel panel1;
        private Button btnCreateIns;
        private Button btnGetAllIns;
        private Button btnBackToFront;
        private Panel GetAll;
        private Label label1;
        private ListBox lstbxGetAllIns;
        private Button button1;
        private Button btnShowCustomerBooking;
        private Panel pnlSearchActivity;
        private CheckBox chkFilterByDate;
        private Button btnSearchGet;
        private DateTimePicker dTPSearchDate;
        private Label lblSearchActivity;
        private ListBox listBox1;
        private Button button2;
        private ComboBox cmbShowInstructors;
        private ToolTip toolTip1;
        private Label lblBookingCount;
    }
}