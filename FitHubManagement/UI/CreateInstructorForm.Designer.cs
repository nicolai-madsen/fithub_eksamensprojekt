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
            btnSaveIns = new Button();
            btnCancelCreateIns = new Button();
            panel1 = new Panel();
            panelcreate = new Panel();
            cmbCreate = new ComboBox();
            CreateLastName = new TextBox();
            button2 = new Button();
            label2 = new Label();
            button3 = new Button();
            label3 = new Label();
            label4 = new Label();
            createPhone = new TextBox();
            label5 = new Label();
            createEmail = new TextBox();
            label6 = new Label();
            createFirstName = new TextBox();
            cmbCert = new ComboBox();
            GetAll = new Panel();
            lstbxGetAllIns = new ListBox();
            btnCreateIns = new Button();
            btnGetAllIns = new Button();
            btnBackToFront = new Button();
            label1 = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            panelcreate.SuspendLayout();
            GetAll.SuspendLayout();
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
            panel1.Controls.Add(cmbCert);
            panel1.Controls.Add(txtLastName);
            panel1.Controls.Add(btnCancelCreateIns);
            panel1.Controls.Add(lblFirstName);
            panel1.Controls.Add(btnSaveIns);
            panel1.Controls.Add(lblLastName);
            panel1.Controls.Add(lblEmail);
            panel1.Controls.Add(txtPhone);
            panel1.Controls.Add(lblPhone);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(lblCert);
            panel1.Controls.Add(txtFirstName);
            panel1.Controls.Add(panelcreate);
            panel1.Location = new Point(10, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(483, 584);
            panel1.TabIndex = 16;
            panel1.Paint += panel1_Paint;
            // 
            // panelcreate
            // 
            panelcreate.Controls.Add(cmbCreate);
            panelcreate.Controls.Add(CreateLastName);
            panelcreate.Controls.Add(button2);
            panelcreate.Controls.Add(label2);
            panelcreate.Controls.Add(button3);
            panelcreate.Controls.Add(label3);
            panelcreate.Controls.Add(label4);
            panelcreate.Controls.Add(createPhone);
            panelcreate.Controls.Add(label5);
            panelcreate.Controls.Add(createEmail);
            panelcreate.Controls.Add(label6);
            panelcreate.Controls.Add(createFirstName);
            panelcreate.Location = new Point(8, 23);
            panelcreate.Name = "panelcreate";
            panelcreate.Size = new Size(467, 384);
            panelcreate.TabIndex = 24;
            // 
            // cmbCreate
            // 
            cmbCreate.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCreate.FormattingEnabled = true;
            cmbCreate.Location = new Point(107, 266);
            cmbCreate.Name = "cmbCreate";
            cmbCreate.Size = new Size(278, 28);
            cmbCreate.TabIndex = 16;
            // 
            // CreateLastName
            // 
            CreateLastName.Location = new Point(107, 114);
            CreateLastName.Margin = new Padding(2);
            CreateLastName.Name = "CreateLastName";
            CreateLastName.Size = new Size(278, 27);
            CreateLastName.TabIndex = 10;
            // 
            // button2
            // 
            button2.Location = new Point(226, 326);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(226, 34);
            button2.TabIndex = 15;
            button2.Text = "Annuller";
            button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 66);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 4;
            label2.Text = "Fornavn";
            // 
            // button3
            // 
            button3.Location = new Point(8, 326);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(210, 34);
            button3.TabIndex = 14;
            button3.Text = "Gem";
            button3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 114);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 5;
            label3.Text = "Efternavn";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 168);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 6;
            label4.Text = "Email";
            // 
            // createPhone
            // 
            createPhone.Location = new Point(107, 218);
            createPhone.Margin = new Padding(2);
            createPhone.Name = "createPhone";
            createPhone.Size = new Size(278, 27);
            createPhone.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 218);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 7;
            label5.Text = "Telefon";
            // 
            // createEmail
            // 
            createEmail.Location = new Point(107, 168);
            createEmail.Margin = new Padding(2);
            createEmail.Name = "createEmail";
            createEmail.Size = new Size(278, 27);
            createEmail.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(8, 266);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 8;
            label6.Text = "Certifikat";
            // 
            // createFirstName
            // 
            createFirstName.Location = new Point(107, 66);
            createFirstName.Margin = new Padding(2);
            createFirstName.Name = "createFirstName";
            createFirstName.Size = new Size(278, 27);
            createFirstName.TabIndex = 9;
            // 
            // cmbCert
            // 
            cmbCert.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCert.FormattingEnabled = true;
            cmbCert.Location = new Point(107, 266);
            cmbCert.Name = "cmbCert";
            cmbCert.Size = new Size(278, 28);
            cmbCert.TabIndex = 16;
            cmbCert.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
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
            btnBackToFront.Location = new Point(672, 444);
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
            // CreateInstructorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(905, 515);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(btnBackToFront);
            Controls.Add(btnGetAllIns);
            Controls.Add(btnCreateIns);
            Controls.Add(panel1);
            Controls.Add(GetAll);
            Margin = new Padding(2);
            Name = "CreateInstructorForm";
            Text = "Form1";
            Load += CreateInstructorForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelcreate.ResumeLayout(false);
            panelcreate.PerformLayout();
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
        private ComboBox cmbCert;
        private Panel panelcreate;
        private ComboBox cmbCreate;
        private TextBox CreateLastName;
        private Button button2;
        private Label label2;
        private Button button3;
        private Label label3;
        private Label label4;
        private TextBox createPhone;
        private Label label5;
        private TextBox createEmail;
        private Label label6;
        private TextBox createFirstName;
    }
}