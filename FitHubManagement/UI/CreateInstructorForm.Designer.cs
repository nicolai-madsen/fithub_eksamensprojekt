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
            GetAll = new Panel();
            lstbxGetAllIns = new ListBox();
            btnCreateIns = new Button();
            btnGetAllIns = new Button();
            btnBackToFront = new Button();
            label1 = new Label();
            button1 = new Button();
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
            panel1.SuspendLayout();
            GetAll.SuspendLayout();
            newInstructorpanel.SuspendLayout();
            SuspendLayout();
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(8, 66);
            lblFirstName.Margin = new Padding(2, 0, 2, 0);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(61, 20);
            lblFirstName.TabIndex = 4;
            lblFirstName.Text = "Fornavn";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(8, 114);
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
            lblPhone.Location = new Point(8, 218);
            lblPhone.Margin = new Padding(2, 0, 2, 0);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(58, 20);
            lblPhone.TabIndex = 7;
            lblPhone.Text = "Telefon";
            // 
            // lblCert
            // 
            lblCert.AutoSize = true;
            lblCert.Location = new Point(8, 266);
            lblCert.Margin = new Padding(2, 0, 2, 0);
            lblCert.Name = "lblCert";
            lblCert.Size = new Size(69, 20);
            lblCert.TabIndex = 8;
            lblCert.Text = "Certifikat";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(107, 66);
            txtFirstName.Margin = new Padding(2);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(278, 27);
            txtFirstName.TabIndex = 9;
            txtFirstName.TextChanged += FirstNameTxt_TextChanged;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(107, 114);
            txtLastName.Margin = new Padding(2);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(278, 27);
            txtLastName.TabIndex = 10;
            txtLastName.TextChanged += LastNameTxt_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(107, 168);
            txtEmail.Margin = new Padding(2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(278, 27);
            txtEmail.TabIndex = 11;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(107, 218);
            txtPhone.Margin = new Padding(2);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(278, 27);
            txtPhone.TabIndex = 12;
            // 
            // txtCert
            // 
            txtCert.Location = new Point(107, 266);
            txtCert.Margin = new Padding(2);
            txtCert.Name = "txtCert";
            txtCert.Size = new Size(344, 27);
            txtCert.TabIndex = 13;
            // 
            // btnSaveIns
            // 
            btnSaveIns.Location = new Point(8, 326);
            btnSaveIns.Margin = new Padding(2);
            btnSaveIns.Name = "btnSaveIns";
            btnSaveIns.Size = new Size(210, 34);
            btnSaveIns.TabIndex = 14;
            btnSaveIns.Text = "Gem";
            btnSaveIns.UseVisualStyleBackColor = true;
            btnSaveIns.Click += btnSaveIns_Click;
            // 
            // btnCancelCreateIns
            // 
            btnCancelCreateIns.Location = new Point(226, 326);
            btnCancelCreateIns.Margin = new Padding(2);
            btnCancelCreateIns.Name = "btnCancelCreateIns";
            btnCancelCreateIns.Size = new Size(226, 34);
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
            panel1.Location = new Point(10, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(483, 584);
            panel1.TabIndex = 16;
            panel1.Paint += panel1_Paint;
            // 
            // GetAll
            // 
            GetAll.Controls.Add(lstbxGetAllIns);
            GetAll.Location = new Point(10, 4);
            GetAll.Margin = new Padding(1);
            GetAll.Name = "GetAll";
            GetAll.Size = new Size(478, 512);
            GetAll.TabIndex = 21;
            // 
            // lstbxGetAllIns
            // 
            lstbxGetAllIns.FormattingEnabled = true;
            lstbxGetAllIns.Location = new Point(1, 41);
            lstbxGetAllIns.Margin = new Padding(1);
            lstbxGetAllIns.Name = "lstbxGetAllIns";
            lstbxGetAllIns.Size = new Size(450, 444);
            lstbxGetAllIns.TabIndex = 0;
            lstbxGetAllIns.SelectedIndexChanged += lstbxGetAllIns_SelectedIndexChanged;
            // 
            // btnCreateIns
            // 
            btnCreateIns.Location = new Point(544, 70);
            btnCreateIns.Name = "btnCreateIns";
            btnCreateIns.Size = new Size(127, 29);
            btnCreateIns.TabIndex = 17;
            btnCreateIns.Text = "Opret";
            btnCreateIns.UseVisualStyleBackColor = true;
            btnCreateIns.Click += button1_Click;
            // 
            // btnGetAllIns
            // 
            btnGetAllIns.Location = new Point(544, 139);
            btnGetAllIns.Name = "btnGetAllIns";
            btnGetAllIns.Size = new Size(127, 29);
            btnGetAllIns.TabIndex = 18;
            btnGetAllIns.Text = "Vis alle";
            btnGetAllIns.UseVisualStyleBackColor = true;
            btnGetAllIns.Click += button2_Click;
            // 
            // btnBackToFront
            // 
            btnBackToFront.Location = new Point(644, 415);
            btnBackToFront.Margin = new Padding(1);
            btnBackToFront.Name = "btnBackToFront";
            btnBackToFront.Size = new Size(88, 28);
            btnBackToFront.TabIndex = 20;
            btnBackToFront.Text = "Tilbage";
            btnBackToFront.UseVisualStyleBackColor = true;
            btnBackToFront.Click += btnBackToFront_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(366, 4);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(336, 41);
            label1.TabIndex = 22;
            label1.Text = "Personaleadministration";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(544, 207);
            button1.Name = "button1";
            button1.Size = new Size(127, 29);
            button1.TabIndex = 23;
            button1.Text = "Rediger";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
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
            newInstructorpanel.Location = new Point(850, 45);
            newInstructorpanel.Name = "newInstructorpanel";
            newInstructorpanel.Size = new Size(421, 444);
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
            newtxtActivityName.Size = new Size(240, 27);
            newtxtActivityName.TabIndex = 18;
            // 
            // newtxtEmail
            // 
            newtxtEmail.Location = new Point(151, 148);
            newtxtEmail.Name = "newtxtEmail";
            newtxtEmail.Size = new Size(240, 27);
            newtxtEmail.TabIndex = 16;
            // 
            // newtxtLastName
            // 
            newtxtLastName.Location = new Point(151, 96);
            newtxtLastName.Name = "newtxtLastName";
            newtxtLastName.Size = new Size(240, 27);
            newtxtLastName.TabIndex = 15;
            // 
            // newtxtPhone
            // 
            newtxtPhone.Location = new Point(151, 198);
            newtxtPhone.Name = "newtxtPhone";
            newtxtPhone.Size = new Size(240, 27);
            newtxtPhone.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(30, 288);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(81, 20);
            label7.TabIndex = 14;
            label7.Text = "Beskrivelse";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 46);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 9;
            label2.Text = "Fornavn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 94);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 10;
            label3.Text = "Efternavn";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 148);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 11;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 198);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 12;
            label5.Text = "Telefon";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 246);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 13;
            label6.Text = "Certifikat";
            // 
            // newtxtFirstName
            // 
            newtxtFirstName.Location = new Point(151, 39);
            newtxtFirstName.Name = "newtxtFirstName";
            newtxtFirstName.Size = new Size(240, 27);
            newtxtFirstName.TabIndex = 0;
            // 
            // CreateInstructorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1360, 515);
            Controls.Add(newInstructorpanel);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(btnBackToFront);
            Controls.Add(btnGetAllIns);
            Controls.Add(btnCreateIns);
            Controls.Add(GetAll);
            Margin = new Padding(2);
            Name = "CreateInstructorForm";
            Text = "Form1";
            Load += CreateInstructorForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Panel newInstructorpanel;
        private Label label7;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox newtxtFirstName;
        private TextBox newtxtActivityDescription;
        private TextBox newtxtActivityName;
        private TextBox newtxtEmail;
        private TextBox newtxtLastName;
        private TextBox newtxtPhone;
        private Button savenewInstructor;
    }
}