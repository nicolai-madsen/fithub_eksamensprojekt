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
            panel1.SuspendLayout();
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
            btnBackToFront.Location = new Point(861, 461);
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
    }
}