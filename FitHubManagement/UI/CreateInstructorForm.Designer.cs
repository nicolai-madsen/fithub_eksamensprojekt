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
            lblFirstName = new Label();
            lblLastName = new Label();
            lblEmail = new Label();
            lblPhone = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
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
            label8 = new Label();
            lstbxGetAllIns = new ListBox();
            button1 = new Button();
            btnCreateIns = new Button();
            btnGetAllIns = new Button();
            btnBackToFront = new Button();
            label1 = new Label();
            newInstructorpanel = new Panel();
            savenewInstructor = new Button();
            newtxtActivityDescription = new TextBox();
            newtxtActivityName = new TextBox();
            newtxtEmail = new TextBox();
            newtxtLastName = new TextBox();
            newtxtPhone = new TextBox();
            label7 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            newtxtFirstName = new TextBox();
            button3 = new Button();
            panel1.SuspendLayout();
            pnlSearchActivity.SuspendLayout();
            GetAll.SuspendLayout();
            newInstructorpanel.SuspendLayout();
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
            txtPhone.TextChanged += txtPhone_TextChanged;
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
            btnCancelCreateIns.Click += btnCancelCreateIns_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtLastName);
            panel1.Controls.Add(btnCancelCreateIns);
            panel1.Controls.Add(lblFirstName);
            panel1.Controls.Add(btnSaveIns);
            panel1.Controls.Add(lblLastName);
            panel1.Controls.Add(lblEmail);
            panel1.Controls.Add(txtPhone);
            panel1.Controls.Add(lblPhone);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(txtFirstName);
            panel1.Location = new Point(3, 45);
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
            pnlSearchActivity.Location = new Point(0, 1);
            pnlSearchActivity.Margin = new Padding(1);
            pnlSearchActivity.Name = "pnlSearchActivity";
            pnlSearchActivity.Size = new Size(528, 470);
            pnlSearchActivity.TabIndex = 25;
            // 
            // lblBookingCount
            // 
            lblBookingCount.AutoSize = true;
            lblBookingCount.Location = new Point(396, 240);
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
            cmbShowInstructors.Margin = new Padding(1);
            cmbShowInstructors.Name = "cmbShowInstructors";
            cmbShowInstructors.Size = new Size(128, 23);
            cmbShowInstructors.TabIndex = 0;
            // 
            // button2
            // 
            button2.Location = new Point(400, 196);
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
            listBox1.Location = new Point(9, 197);
            listBox1.Margin = new Padding(1);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(380, 259);
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
            GetAll.Controls.Add(label8);
            GetAll.Controls.Add(lstbxGetAllIns);
            GetAll.Controls.Add(button1);
            GetAll.Location = new Point(11, 13);
            GetAll.Margin = new Padding(1);
            GetAll.Name = "GetAll";
            GetAll.Size = new Size(485, 503);
            GetAll.TabIndex = 21;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(7, 14);
            label8.Name = "label8";
            label8.Size = new Size(133, 21);
            label8.TabIndex = 24;
            label8.Text = "Alle instruktører:";
            // 
            // lstbxGetAllIns
            // 
            lstbxGetAllIns.FormattingEnabled = true;
            lstbxGetAllIns.ItemHeight = 15;
            lstbxGetAllIns.Location = new Point(1, 46);
            lstbxGetAllIns.Margin = new Padding(1);
            lstbxGetAllIns.Name = "lstbxGetAllIns";
            lstbxGetAllIns.Size = new Size(450, 349);
            lstbxGetAllIns.TabIndex = 0;
            lstbxGetAllIns.SelectedIndexChanged += lstbxGetAllIns_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(143, 430);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(138, 46);
            button1.TabIndex = 23;
            button1.Text = "Rediger instruktør";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // btnCreateIns
            // 
            btnCreateIns.Location = new Point(556, 153);
            btnCreateIns.Margin = new Padding(2);
            btnCreateIns.Name = "btnCreateIns";
            btnCreateIns.Size = new Size(158, 29);
            btnCreateIns.TabIndex = 17;
            btnCreateIns.Text = "Opret Ny Instruktør";
            btnCreateIns.UseVisualStyleBackColor = true;
            btnCreateIns.Click += button1_Click;
            // 
            // btnGetAllIns
            // 
            btnGetAllIns.Location = new Point(556, 59);
            btnGetAllIns.Margin = new Padding(2);
            btnGetAllIns.Name = "btnGetAllIns";
            btnGetAllIns.Size = new Size(158, 29);
            btnGetAllIns.TabIndex = 18;
            btnGetAllIns.Text = "Vis alle";
            btnGetAllIns.UseVisualStyleBackColor = true;
            btnGetAllIns.Click += button2_Click;
            // 
            // btnBackToFront
            // 
            btnBackToFront.Location = new Point(544, 415);
            btnBackToFront.Margin = new Padding(1);
            btnBackToFront.Name = "btnBackToFront";
            btnBackToFront.Size = new Size(158, 28);
            btnBackToFront.TabIndex = 20;
            btnBackToFront.Text = "Tilbage Til Forsiden";
            btnBackToFront.UseVisualStyleBackColor = true;
            btnBackToFront.Click += btnBackToFront_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(244, 1);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(269, 32);
            label1.TabIndex = 22;
            label1.Text = "Personaleadministration";
            label1.Click += label1_Click;
            // 
            // newInstructorpanel
            // 
            newInstructorpanel.Controls.Add(savenewInstructor);
            newInstructorpanel.Controls.Add(newtxtActivityDescription);
            newInstructorpanel.Controls.Add(newtxtActivityName);
            newInstructorpanel.Controls.Add(newtxtEmail);
            newInstructorpanel.Controls.Add(newtxtLastName);
            newInstructorpanel.Controls.Add(newtxtPhone);
            newInstructorpanel.Controls.Add(label7);
            newInstructorpanel.Controls.Add(label2);
            newInstructorpanel.Controls.Add(label3);
            newInstructorpanel.Controls.Add(label4);
            newInstructorpanel.Controls.Add(label5);
            newInstructorpanel.Controls.Add(label6);
            newInstructorpanel.Controls.Add(newtxtFirstName);
            newInstructorpanel.Location = new Point(3, 12);
            newInstructorpanel.Name = "newInstructorpanel";
            newInstructorpanel.Size = new Size(466, 491);
            newInstructorpanel.TabIndex = 24;
            // 
            // savenewInstructor
            // 
            savenewInstructor.Location = new Point(123, 389);
            savenewInstructor.Name = "savenewInstructor";
            savenewInstructor.Size = new Size(166, 29);
            savenewInstructor.TabIndex = 20;
            savenewInstructor.Text = "Gem Ny Instruktør";
            savenewInstructor.UseVisualStyleBackColor = true;
            savenewInstructor.Click += savenewInstructor_Click;
            // 
            // newtxtActivityDescription
            // 
            newtxtActivityDescription.Location = new Point(151, 288);
            newtxtActivityDescription.Multiline = true;
            newtxtActivityDescription.Name = "newtxtActivityDescription";
            newtxtActivityDescription.Size = new Size(240, 72);
            newtxtActivityDescription.TabIndex = 19;
            // 
            // newtxtActivityName
            // 
            newtxtActivityName.Location = new Point(151, 243);
            newtxtActivityName.Name = "newtxtActivityName";
            newtxtActivityName.Size = new Size(240, 23);
            newtxtActivityName.TabIndex = 18;
            // 
            // newtxtEmail
            // 
            newtxtEmail.Location = new Point(151, 148);
            newtxtEmail.Name = "newtxtEmail";
            newtxtEmail.Size = new Size(240, 23);
            newtxtEmail.TabIndex = 16;
            // 
            // newtxtLastName
            // 
            newtxtLastName.Location = new Point(151, 96);
            newtxtLastName.Name = "newtxtLastName";
            newtxtLastName.Size = new Size(240, 23);
            newtxtLastName.TabIndex = 15;
            // 
            // newtxtPhone
            // 
            newtxtPhone.Location = new Point(151, 198);
            newtxtPhone.Name = "newtxtPhone";
            newtxtPhone.Size = new Size(240, 23);
            newtxtPhone.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(30, 288);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(64, 15);
            label7.TabIndex = 14;
            label7.Text = "Beskrivelse";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 46);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 9;
            label2.Text = "Fornavn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 94);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 10;
            label3.Text = "Efternavn";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 148);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 11;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 198);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(46, 15);
            label5.TabIndex = 12;
            label5.Text = "Telefon";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 246);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(61, 15);
            label6.TabIndex = 13;
            label6.Text = "HoldNavn";
            // 
            // newtxtFirstName
            // 
            newtxtFirstName.Location = new Point(151, 39);
            newtxtFirstName.Name = "newtxtFirstName";
            newtxtFirstName.Size = new Size(240, 23);
            newtxtFirstName.TabIndex = 0;
            // 
            // button3
            // 
            button3.Location = new Point(556, 244);
            button3.Name = "button3";
            button3.Size = new Size(158, 23);
            button3.TabIndex = 27;
            button3.Text = "Vis tilmeldinger";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // CreateInstructorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 515);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(btnBackToFront);
            Controls.Add(btnGetAllIns);
            Controls.Add(btnCreateIns);
            Controls.Add(panel1);
            Controls.Add(newInstructorpanel);
            Controls.Add(GetAll);
            Controls.Add(pnlSearchActivity);
            Margin = new Padding(2);
            Name = "CreateInstructorForm";
            Text = "Form1";
            Load += CreateInstructorForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlSearchActivity.ResumeLayout(false);
            pnlSearchActivity.PerformLayout();
            GetAll.ResumeLayout(false);
            GetAll.PerformLayout();
            newInstructorpanel.ResumeLayout(false);
            newInstructorpanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblEmail;
        private Label lblPhone;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtEmail;
        private TextBox txtPhone;
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

        // --- Controls referenced in code-behind ---
        private Panel newInstructorpanel;

        private TextBox newtxtFirstName;
        private TextBox newtxtLastName;
        private TextBox newtxtEmail;
        private TextBox newtxtPhone;

        private TextBox newtxtActivityName;
        private TextBox newtxtActivityDescription;

        private Button savenewInstructor;

        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button3;
        private Label label8;
    }
}