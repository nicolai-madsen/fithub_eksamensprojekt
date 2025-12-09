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
            OpretInsLabel = new Label();
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
            SuspendLayout();
            // 
            // OpretInsLabel
            // 
            OpretInsLabel.AutoSize = true;
            OpretInsLabel.Location = new Point(253, 25);
            OpretInsLabel.Name = "OpretInsLabel";
            OpretInsLabel.Size = new Size(140, 25);
            OpretInsLabel.TabIndex = 0;
            OpretInsLabel.Text = "Opret Instruktør";
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Location = new Point(43, 87);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(76, 25);
            labelFirstName.TabIndex = 4;
            labelFirstName.Text = "Fornavn";
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Location = new Point(43, 148);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(86, 25);
            labelLastName.TabIndex = 5;
            labelLastName.Text = "Efternavn";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(43, 215);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(54, 25);
            labelEmail.TabIndex = 6;
            labelEmail.Text = "Email";
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Location = new Point(43, 278);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(68, 25);
            labelPhone.TabIndex = 7;
            labelPhone.Text = "Telefon";
            // 
            // labelCerBtn
            // 
            labelCerBtn.AutoSize = true;
            labelCerBtn.Location = new Point(43, 337);
            labelCerBtn.Name = "labelCerBtn";
            labelCerBtn.Size = new Size(107, 25);
            labelCerBtn.TabIndex = 8;
            labelCerBtn.Text = "Certifikation";
            // 
            // FirstNameTxt
            // 
            FirstNameTxt.Location = new Point(166, 87);
            FirstNameTxt.Name = "FirstNameTxt";
            FirstNameTxt.Size = new Size(346, 31);
            FirstNameTxt.TabIndex = 9;
            // 
            // LastNameTxt
            // 
            LastNameTxt.Location = new Point(166, 148);
            LastNameTxt.Name = "LastNameTxt";
            LastNameTxt.Size = new Size(346, 31);
            LastNameTxt.TabIndex = 10;
            // 
            // EmailTxt
            // 
            EmailTxt.Location = new Point(166, 215);
            EmailTxt.Name = "EmailTxt";
            EmailTxt.Size = new Size(346, 31);
            EmailTxt.TabIndex = 11;
            // 
            // PhoneNumberTxt
            // 
            PhoneNumberTxt.Location = new Point(166, 278);
            PhoneNumberTxt.Name = "PhoneNumberTxt";
            PhoneNumberTxt.Size = new Size(346, 31);
            PhoneNumberTxt.TabIndex = 12;
            // 
            // CerTxt
            // 
            CerTxt.Location = new Point(166, 337);
            CerTxt.Name = "CerTxt";
            CerTxt.Size = new Size(346, 31);
            CerTxt.TabIndex = 13;
            // 
            // SaveInsBtn
            // 
            SaveInsBtn.Location = new Point(43, 413);
            SaveInsBtn.Name = "SaveInsBtn";
            SaveInsBtn.Size = new Size(263, 42);
            SaveInsBtn.TabIndex = 14;
            SaveInsBtn.Text = "Gem";
            SaveInsBtn.UseVisualStyleBackColor = true;
            // 
            // CancelInsBtn
            // 
            CancelInsBtn.Location = new Point(339, 413);
            CancelInsBtn.Name = "CancelInsBtn";
            CancelInsBtn.Size = new Size(283, 42);
            CancelInsBtn.TabIndex = 15;
            CancelInsBtn.Text = "Annuller";
            CancelInsBtn.UseVisualStyleBackColor = true;
            // 
            // CreateInstructorForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1268, 658);
            Controls.Add(CancelInsBtn);
            Controls.Add(SaveInsBtn);
            Controls.Add(CerTxt);
            Controls.Add(PhoneNumberTxt);
            Controls.Add(EmailTxt);
            Controls.Add(LastNameTxt);
            Controls.Add(FirstNameTxt);
            Controls.Add(labelCerBtn);
            Controls.Add(labelPhone);
            Controls.Add(labelEmail);
            Controls.Add(labelLastName);
            Controls.Add(labelFirstName);
            Controls.Add(OpretInsLabel);
            Name = "CreateInstructorForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label OpretInsLabel;
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
    }
}