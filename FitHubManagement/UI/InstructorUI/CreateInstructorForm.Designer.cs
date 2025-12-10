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
            labelFirstName = new Label();
            labelLastName = new Label();
            labelEmail = new Label();
            labelPhone = new Label();
            labelCerBtn = new Label();
            FirstNameTxt = new TextBox();
            LastNameTxt = new TextBox();
            EmailTxt = new TextBox();
            PhoneNumberTxt = new TextBox();
            CerTxt = new TextBox();
            SaveInsBtn = new Button();
            CancelInsBtn = new Button();
            panel1 = new Panel();
            button1 = new Button();
            button2 = new Button();
            GetAll = new Panel();
            listBox1 = new ListBox();
            panel1.SuspendLayout();
            GetAll.SuspendLayout();
            SuspendLayout();
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Location = new Point(8, 66);
            labelFirstName.Margin = new Padding(2, 0, 2, 0);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(61, 20);
            labelFirstName.TabIndex = 4;
            labelFirstName.Text = "Fornavn";
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Location = new Point(8, 114);
            labelLastName.Margin = new Padding(2, 0, 2, 0);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(71, 20);
            labelLastName.TabIndex = 5;
            labelLastName.Text = "Efternavn";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(8, 168);
            labelEmail.Margin = new Padding(2, 0, 2, 0);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(46, 20);
            labelEmail.TabIndex = 6;
            labelEmail.Text = "Email";
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Location = new Point(8, 218);
            labelPhone.Margin = new Padding(2, 0, 2, 0);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(58, 20);
            labelPhone.TabIndex = 7;
            labelPhone.Text = "Telefon";
            // 
            // labelCerBtn
            // 
            labelCerBtn.AutoSize = true;
            labelCerBtn.Location = new Point(8, 266);
            labelCerBtn.Margin = new Padding(2, 0, 2, 0);
            labelCerBtn.Name = "labelCerBtn";
            labelCerBtn.Size = new Size(90, 20);
            labelCerBtn.TabIndex = 8;
            labelCerBtn.Text = "Certifikation";
            // 
            // FirstNameTxt
            // 
            FirstNameTxt.Location = new Point(107, 66);
            FirstNameTxt.Margin = new Padding(2);
            FirstNameTxt.Name = "FirstNameTxt";
            FirstNameTxt.Size = new Size(278, 27);
            FirstNameTxt.TabIndex = 9;
            FirstNameTxt.TextChanged += FirstNameTxt_TextChanged;
            // 
            // LastNameTxt
            // 
            LastNameTxt.Location = new Point(107, 114);
            LastNameTxt.Margin = new Padding(2);
            LastNameTxt.Name = "LastNameTxt";
            LastNameTxt.Size = new Size(278, 27);
            LastNameTxt.TabIndex = 10;
            // 
            // EmailTxt
            // 
            EmailTxt.Location = new Point(107, 168);
            EmailTxt.Margin = new Padding(2);
            EmailTxt.Name = "EmailTxt";
            EmailTxt.Size = new Size(278, 27);
            EmailTxt.TabIndex = 11;
            // 
            // PhoneNumberTxt
            // 
            PhoneNumberTxt.Location = new Point(107, 218);
            PhoneNumberTxt.Margin = new Padding(2);
            PhoneNumberTxt.Name = "PhoneNumberTxt";
            PhoneNumberTxt.Size = new Size(278, 27);
            PhoneNumberTxt.TabIndex = 12;
            // 
            // CerTxt
            // 
            CerTxt.Location = new Point(107, 266);
            CerTxt.Margin = new Padding(2);
            CerTxt.Name = "CerTxt";
            CerTxt.Size = new Size(278, 27);
            CerTxt.TabIndex = 13;
            // 
            // SaveInsBtn
            // 
            SaveInsBtn.Location = new Point(8, 326);
            SaveInsBtn.Margin = new Padding(2);
            SaveInsBtn.Name = "SaveInsBtn";
            SaveInsBtn.Size = new Size(210, 34);
            SaveInsBtn.TabIndex = 14;
            SaveInsBtn.Text = "Gem";
            SaveInsBtn.UseVisualStyleBackColor = true;
            // 
            // CancelInsBtn
            // 
            CancelInsBtn.Location = new Point(245, 326);
            CancelInsBtn.Margin = new Padding(2);
            CancelInsBtn.Name = "CancelInsBtn";
            CancelInsBtn.Size = new Size(226, 34);
            CancelInsBtn.TabIndex = 15;
            CancelInsBtn.Text = "Annuller";
            CancelInsBtn.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(LastNameTxt);
            panel1.Controls.Add(CancelInsBtn);
            panel1.Controls.Add(labelFirstName);
            panel1.Controls.Add(SaveInsBtn);
            panel1.Controls.Add(labelLastName);
            panel1.Controls.Add(CerTxt);
            panel1.Controls.Add(labelEmail);
            panel1.Controls.Add(PhoneNumberTxt);
            panel1.Controls.Add(labelPhone);
            panel1.Controls.Add(EmailTxt);
            panel1.Controls.Add(labelCerBtn);
            panel1.Controls.Add(FirstNameTxt);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(509, 490);
            panel1.TabIndex = 16;
            // 
            // button1
            // 
            button1.Location = new Point(635, 34);
            button1.Name = "button1";
            button1.Size = new Size(127, 29);
            button1.TabIndex = 17;
            button1.Text = "Opret Instruktør";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(610, 104);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 18;
            button2.Text = "Vis alle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // GetAll
            // 
            GetAll.Controls.Add(listBox1);
            GetAll.Location = new Point(12, 15);
            GetAll.Name = "GetAll";
            GetAll.Size = new Size(495, 453);
            GetAll.TabIndex = 19;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(3, 23);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(500, 404);
            listBox1.TabIndex = 0;
            // 
            // CreateInstructorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1014, 526);
            Controls.Add(GetAll);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "CreateInstructorForm";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            GetAll.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label labelFirstName;
        private Label labelLastName;
        private Label labelEmail;
        private Label labelPhone;
        private Label labelCerBtn;
        private TextBox FirstNameTxt;
        private TextBox LastNameTxt;
        private TextBox EmailTxt;
        private TextBox PhoneNumberTxt;
        private TextBox CerTxt;
        private Button SaveInsBtn;
        private Button CancelInsBtn;
        private Panel panel1;
        private Button button1;
        private Button button2;
        private Panel GetAll;
        private ListBox listBox1;
    }
}