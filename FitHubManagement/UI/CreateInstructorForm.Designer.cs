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
            lblFirstName.Location = new Point(8, 65);
            lblFirstName.Margin = new Padding(2, 0, 2, 0);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(61, 20);
            lblFirstName.TabIndex = 4;
            lblFirstName.Text = "Fornavn";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(8, 115);
            lblLastName.Margin = new Padding(2, 0, 2, 0);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(71, 20);
            lblLastName.TabIndex = 5;
            lblLastName.Text = "Efternavn";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(8, 168);
            lblEmail.Margin = new Padding(2, 0, 2, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(8, 219);
            lblPhone.Margin = new Padding(2, 0, 2, 0);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(58, 20);
            lblPhone.TabIndex = 7;
            lblPhone.Text = "Telefon";
            // 
            // lblCert
            // 
            lblCert.AutoSize = true;
            lblCert.Location = new Point(8, 265);
            lblCert.Margin = new Padding(2, 0, 2, 0);
            lblCert.Name = "lblCert";
            lblCert.Size = new Size(76, 20);
            lblCert.TabIndex = 8;
            lblCert.Text = "HoldNavn";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(106, 65);
            txtFirstName.Margin = new Padding(2, 1, 2, 1);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(278, 27);
            txtFirstName.TabIndex = 9;
            txtFirstName.TextChanged += FirstNameTxt_TextChanged;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(106, 115);
            txtLastName.Margin = new Padding(2, 1, 2, 1);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(278, 27);
            txtLastName.TabIndex = 10;
            txtLastName.TextChanged += LastNameTxt_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(106, 168);
            txtEmail.Margin = new Padding(2, 1, 2, 1);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(278, 27);
            txtEmail.TabIndex = 11;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(106, 219);
            txtPhone.Margin = new Padding(2, 1, 2, 1);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(278, 27);
            txtPhone.TabIndex = 12;
            // 
            // txtCert
            // 
            txtCert.Location = new Point(106, 265);
            txtCert.Margin = new Padding(2, 1, 2, 1);
            txtCert.Name = "txtCert";
            txtCert.Size = new Size(317, 27);
            txtCert.TabIndex = 13;
            txtCert.TextChanged += txtCert_TextChanged;
            // 
            // btnSaveIns
            // 
            btnSaveIns.Location = new Point(8, 325);
            btnSaveIns.Margin = new Padding(2, 1, 2, 1);
            btnSaveIns.Name = "btnSaveIns";
            btnSaveIns.Size = new Size(210, 35);
            btnSaveIns.TabIndex = 14;
            btnSaveIns.Text = "Gem";
            btnSaveIns.UseVisualStyleBackColor = true;
            btnSaveIns.Click += btnSaveIns_Click;
            // 
            // btnCancelCreateIns
            // 
            btnCancelCreateIns.Location = new Point(226, 325);
            btnCancelCreateIns.Margin = new Padding(2, 1, 2, 1);
            btnCancelCreateIns.Name = "btnCancelCreateIns";
            btnCancelCreateIns.Size = new Size(226, 35);
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
            panel1.Controls.Add(txtCert);
            panel1.Controls.Add(lblEmail);
            panel1.Controls.Add(txtPhone);
            panel1.Controls.Add(lblPhone);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(lblCert);
            panel1.Controls.Add(txtFirstName);
            panel1.Location = new Point(3, 60);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(482, 584);
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
            pnlSearchActivity.Location = new Point(0, 0);
            pnlSearchActivity.Margin = new Padding(1);
            pnlSearchActivity.Name = "pnlSearchActivity";
            pnlSearchActivity.Size = new Size(603, 628);
            pnlSearchActivity.TabIndex = 25;
            // 
            // lblBookingCount
            // 
            lblBookingCount.AutoSize = true;
            lblBookingCount.Location = new Point(453, 320);
            lblBookingCount.Margin = new Padding(1, 0, 1, 0);
            lblBookingCount.Name = "lblBookingCount";
            lblBookingCount.Size = new Size(144, 20);
            lblBookingCount.TabIndex = 26;
            lblBookingCount.Text = "Antal tilmeldinger: 0";
            // 
            // cmbShowInstructors
            // 
            cmbShowInstructors.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbShowInstructors.Location = new Point(134, 77);
            cmbShowInstructors.Margin = new Padding(1);
            cmbShowInstructors.Name = "cmbShowInstructors";
            cmbShowInstructors.Size = new Size(146, 28);
            cmbShowInstructors.TabIndex = 0;
            // 
            // button2
            // 
            button2.Location = new Point(457, 261);
            button2.Margin = new Padding(2, 4, 2, 4);
            button2.Name = "button2";
            button2.Size = new Size(126, 31);
            button2.TabIndex = 22;
            button2.Text = "Vis tilmeldinger";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(10, 263);
            listBox1.Margin = new Padding(1);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(434, 344);
            listBox1.TabIndex = 21;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // chkFilterByDate
            // 
            chkFilterByDate.AutoSize = true;
            chkFilterByDate.Location = new Point(24, 135);
            chkFilterByDate.Margin = new Padding(3, 4, 3, 4);
            chkFilterByDate.Name = "chkFilterByDate";
            chkFilterByDate.Size = new Size(64, 24);
            chkFilterByDate.TabIndex = 20;
            chkFilterByDate.Text = "Dato";
            chkFilterByDate.UseVisualStyleBackColor = true;
            chkFilterByDate.CheckedChanged += chkFilterByDate_CheckedChanged;
            // 
            // btnSearchGet
            // 
            btnSearchGet.Location = new Point(134, 163);
            btnSearchGet.Margin = new Padding(2, 4, 2, 4);
            btnSearchGet.Name = "btnSearchGet";
            btnSearchGet.Size = new Size(126, 31);
            btnSearchGet.TabIndex = 19;
            btnSearchGet.Text = "Vis søgeresultater";
            btnSearchGet.UseVisualStyleBackColor = true;
            btnSearchGet.Click += btnSearchGet_Click;
            // 
            // dTPSearchDate
            // 
            dTPSearchDate.Location = new Point(134, 124);
            dTPSearchDate.Margin = new Padding(2, 4, 2, 4);
            dTPSearchDate.Name = "dTPSearchDate";
            dTPSearchDate.Size = new Size(189, 27);
            dTPSearchDate.TabIndex = 6;
            // 
            // lblSearchActivity
            // 
            lblSearchActivity.AutoSize = true;
            lblSearchActivity.Location = new Point(17, 75);
            lblSearchActivity.Margin = new Padding(1, 0, 1, 0);
            lblSearchActivity.Name = "lblSearchActivity";
            lblSearchActivity.Size = new Size(71, 20);
            lblSearchActivity.TabIndex = 1;
            lblSearchActivity.Text = "Instruktør";
            // 
            // GetAll
            // 
            GetAll.Controls.Add(lstbxGetAllIns);
            GetAll.Controls.Add(button1);
            GetAll.Location = new Point(13, 5);
            GetAll.Margin = new Padding(1);
            GetAll.Name = "GetAll";
            GetAll.Size = new Size(554, 683);
            GetAll.TabIndex = 21;
            // 
            // lstbxGetAllIns
            // 
            lstbxGetAllIns.FormattingEnabled = true;
            lstbxGetAllIns.Location = new Point(1, 41);
            lstbxGetAllIns.Margin = new Padding(1);
            lstbxGetAllIns.Name = "lstbxGetAllIns";
            lstbxGetAllIns.Size = new Size(514, 484);
            lstbxGetAllIns.TabIndex = 0;
            lstbxGetAllIns.SelectedIndexChanged += lstbxGetAllIns_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(163, 574);
            button1.Margin = new Padding(2, 3, 2, 3);
            button1.Name = "button1";
            button1.Size = new Size(158, 62);
            button1.TabIndex = 23;
            button1.Text = "Rediger Oplysninger på Instruktør";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // btnCreateIns
            // 
            btnCreateIns.Location = new Point(635, 120);
            btnCreateIns.Margin = new Padding(2, 3, 2, 3);
            btnCreateIns.Name = "btnCreateIns";
            btnCreateIns.Size = new Size(181, 39);
            btnCreateIns.TabIndex = 17;
            btnCreateIns.Text = "Opret Ny Instruktør";
            btnCreateIns.UseVisualStyleBackColor = true;
            btnCreateIns.Click += button1_Click;
            // 
            // btnGetAllIns
            // 
            btnGetAllIns.Location = new Point(635, 203);
            btnGetAllIns.Margin = new Padding(2, 3, 2, 3);
            btnGetAllIns.Name = "btnGetAllIns";
            btnGetAllIns.Size = new Size(181, 39);
            btnGetAllIns.TabIndex = 18;
            btnGetAllIns.Text = "Vis alle";
            btnGetAllIns.UseVisualStyleBackColor = true;
            btnGetAllIns.Click += button2_Click;
            // 
            // btnBackToFront
            // 
            btnBackToFront.Location = new Point(622, 553);
            btnBackToFront.Margin = new Padding(1);
            btnBackToFront.Name = "btnBackToFront";
            btnBackToFront.Size = new Size(181, 37);
            btnBackToFront.TabIndex = 20;
            btnBackToFront.Text = "Tilbage Til Forsiden";
            btnBackToFront.UseVisualStyleBackColor = true;
            btnBackToFront.Click += btnBackToFront_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(279, 1);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(336, 41);
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
            newInstructorpanel.Location = new Point(3, 16);
            newInstructorpanel.Margin = new Padding(3, 4, 3, 4);
            newInstructorpanel.Name = "newInstructorpanel";
            newInstructorpanel.Size = new Size(533, 655);
            newInstructorpanel.TabIndex = 24;
            // 
            // savenewInstructor
            // 
            savenewInstructor.Location = new Point(141, 519);
            savenewInstructor.Margin = new Padding(3, 4, 3, 4);
            savenewInstructor.Name = "savenewInstructor";
            savenewInstructor.Size = new Size(190, 39);
            savenewInstructor.TabIndex = 20;
            savenewInstructor.Text = "Gem Ny Instruktør";
            savenewInstructor.UseVisualStyleBackColor = true;
            savenewInstructor.Click += savenewInstructor_Click;
            // 
            // newtxtActivityDescription
            // 
            newtxtActivityDescription.Location = new Point(173, 384);
            newtxtActivityDescription.Margin = new Padding(3, 4, 3, 4);
            newtxtActivityDescription.Multiline = true;
            newtxtActivityDescription.Name = "newtxtActivityDescription";
            newtxtActivityDescription.Size = new Size(274, 95);
            newtxtActivityDescription.TabIndex = 19;
            // 
            // newtxtActivityName
            // 
            newtxtActivityName.Location = new Point(173, 324);
            newtxtActivityName.Margin = new Padding(3, 4, 3, 4);
            newtxtActivityName.Name = "newtxtActivityName";
            newtxtActivityName.Size = new Size(274, 27);
            newtxtActivityName.TabIndex = 18;
            // 
            // newtxtEmail
            // 
            newtxtEmail.Location = new Point(173, 197);
            newtxtEmail.Margin = new Padding(3, 4, 3, 4);
            newtxtEmail.Name = "newtxtEmail";
            newtxtEmail.Size = new Size(274, 27);
            newtxtEmail.TabIndex = 16;
            // 
            // newtxtLastName
            // 
            newtxtLastName.Location = new Point(173, 128);
            newtxtLastName.Margin = new Padding(3, 4, 3, 4);
            newtxtLastName.Name = "newtxtLastName";
            newtxtLastName.Size = new Size(274, 27);
            newtxtLastName.TabIndex = 15;
            // 
            // newtxtPhone
            // 
            newtxtPhone.Location = new Point(173, 264);
            newtxtPhone.Margin = new Padding(3, 4, 3, 4);
            newtxtPhone.Name = "newtxtPhone";
            newtxtPhone.Size = new Size(274, 27);
            newtxtPhone.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(34, 384);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(81, 20);
            label7.TabIndex = 14;
            label7.Text = "Beskrivelse";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 61);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 9;
            label2.Text = "Fornavn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 125);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 10;
            label3.Text = "Efternavn";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 197);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 11;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 264);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 12;
            label5.Text = "Telefon";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(34, 328);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(76, 20);
            label6.TabIndex = 13;
            label6.Text = "HoldNavn";
            // 
            // newtxtFirstName
            // 
            newtxtFirstName.Location = new Point(173, 52);
            newtxtFirstName.Margin = new Padding(3, 4, 3, 4);
            newtxtFirstName.Name = "newtxtFirstName";
            newtxtFirstName.Size = new Size(274, 27);
            newtxtFirstName.TabIndex = 0;
            // 
            // button3
            // 
            button3.Location = new Point(646, 325);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(170, 31);
            button3.TabIndex = 27;
            button3.Text = "Vis tilmeldinger";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // CreateInstructorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(922, 687);
            Controls.Add(pnlSearchActivity);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(btnBackToFront);
            Controls.Add(btnGetAllIns);
            Controls.Add(btnCreateIns);
            Controls.Add(panel1);
            Controls.Add(GetAll);
            Controls.Add(newInstructorpanel);
            Margin = new Padding(2, 3, 2, 3);
            Name = "CreateInstructorForm";
            Text = "Form1";
            Load += CreateInstructorForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlSearchActivity.ResumeLayout(false);
            pnlSearchActivity.PerformLayout();
            GetAll.ResumeLayout(false);
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
    }
}