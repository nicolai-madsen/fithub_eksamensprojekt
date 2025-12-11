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
            btnCreateIns = new Button();
            btnGetAllIns = new Button();
            btnBackToFront = new Button();
            label1 = new Label();
            lstbxGetAllIns = new ListBox();
            panel1.SuspendLayout();
            GetAll.SuspendLayout();
            SuspendLayout();
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(17, 135);
            lblFirstName.Margin = new Padding(4, 0, 4, 0);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(124, 41);
            lblFirstName.TabIndex = 4;
            lblFirstName.Text = "Fornavn";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(17, 234);
            lblLastName.Margin = new Padding(4, 0, 4, 0);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(141, 41);
            lblLastName.TabIndex = 5;
            lblLastName.Text = "Efternavn";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(17, 344);
            lblEmail.Margin = new Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(88, 41);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(17, 447);
            lblPhone.Margin = new Padding(4, 0, 4, 0);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(114, 41);
            lblPhone.TabIndex = 7;
            lblPhone.Text = "Telefon";
            // 
            // lblCert
            // 
            lblCert.AutoSize = true;
            lblCert.Location = new Point(17, 545);
            lblCert.Margin = new Padding(4, 0, 4, 0);
            lblCert.Name = "lblCert";
            lblCert.Size = new Size(136, 41);
            lblCert.TabIndex = 8;
            lblCert.Text = "Certifikat";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(227, 135);
            txtFirstName.Margin = new Padding(4);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(586, 47);
            txtFirstName.TabIndex = 9;
            txtFirstName.TextChanged += FirstNameTxt_TextChanged;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(227, 234);
            txtLastName.Margin = new Padding(4);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(586, 47);
            txtLastName.TabIndex = 10;
            txtLastName.TextChanged += LastNameTxt_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(227, 344);
            txtEmail.Margin = new Padding(4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(586, 47);
            txtEmail.TabIndex = 11;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(227, 447);
            txtPhone.Margin = new Padding(4);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(586, 47);
            txtPhone.TabIndex = 12;
            // 
            // txtCert
            // 
            txtCert.Location = new Point(227, 545);
            txtCert.Margin = new Padding(4);
            txtCert.Name = "txtCert";
            txtCert.Size = new Size(586, 47);
            txtCert.TabIndex = 13;
            // 
            // btnSaveIns
            // 
            btnSaveIns.Location = new Point(17, 668);
            btnSaveIns.Margin = new Padding(4);
            btnSaveIns.Name = "btnSaveIns";
            btnSaveIns.Size = new Size(446, 70);
            btnSaveIns.TabIndex = 14;
            btnSaveIns.Text = "Gem";
            btnSaveIns.UseVisualStyleBackColor = true;
            // 
            // btnCancelCreateIns
            // 
            btnCancelCreateIns.Location = new Point(521, 668);
            btnCancelCreateIns.Margin = new Padding(4);
            btnCancelCreateIns.Name = "btnCancelCreateIns";
            btnCancelCreateIns.Size = new Size(480, 70);
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
            panel1.Location = new Point(15, 15);
            panel1.Margin = new Padding(6);
            panel1.Name = "panel1";
            panel1.Size = new Size(1027, 1080);
            panel1.TabIndex = 16;
            // 
            // GetAll
            // 
            GetAll.Controls.Add(lstbxGetAllIns);
            GetAll.Location = new Point(0, 0);
            GetAll.Name = "GetAll";
            GetAll.Size = new Size(1016, 1050);
            GetAll.TabIndex = 21;
            // 
            // btnCreateIns
            // 
            btnCreateIns.Location = new Point(1155, 144);
            btnCreateIns.Margin = new Padding(6);
            btnCreateIns.Name = "btnCreateIns";
            btnCreateIns.Size = new Size(270, 59);
            btnCreateIns.TabIndex = 17;
            btnCreateIns.Text = "Opret";
            btnCreateIns.UseVisualStyleBackColor = true;
            btnCreateIns.Click += button1_Click;
            // 
            // btnGetAllIns
            // 
            btnGetAllIns.Location = new Point(1155, 285);
            btnGetAllIns.Margin = new Padding(6);
            btnGetAllIns.Name = "btnGetAllIns";
            btnGetAllIns.Size = new Size(270, 59);
            btnGetAllIns.TabIndex = 18;
            btnGetAllIns.Text = "Vis alle";
            btnGetAllIns.UseVisualStyleBackColor = true;
            btnGetAllIns.Click += button2_Click;
            // 
            // btnBackToFront
            // 
            btnBackToFront.Location = new Point(1829, 946);
            btnBackToFront.Name = "btnBackToFront";
            btnBackToFront.Size = new Size(188, 58);
            btnBackToFront.TabIndex = 20;
            btnBackToFront.Text = "Tilbage";
            btnBackToFront.UseVisualStyleBackColor = true;
            btnBackToFront.Click += btnBackToFront_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(778, 9);
            label1.Name = "label1";
            label1.Size = new Size(673, 81);
            label1.TabIndex = 22;
            label1.Text = "Personaleadministration";
            label1.Click += label1_Click;
            // 
            // lstbxGetAllIns
            // 
            lstbxGetAllIns.FormattingEnabled = true;
            lstbxGetAllIns.ItemHeight = 41;
            lstbxGetAllIns.Location = new Point(32, 130);
            lstbxGetAllIns.Name = "lstbxGetAllIns";
            lstbxGetAllIns.Size = new Size(951, 865);
            lstbxGetAllIns.TabIndex = 0;
            // 
            // CreateInstructorForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2155, 1078);
            Controls.Add(label1);
            Controls.Add(btnBackToFront);
            Controls.Add(btnGetAllIns);
            Controls.Add(btnCreateIns);
            Controls.Add(GetAll);
            Controls.Add(panel1);
            Margin = new Padding(4);
            Name = "CreateInstructorForm";
            Text = "Form1";
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
    }
}