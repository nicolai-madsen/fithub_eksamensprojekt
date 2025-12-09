namespace FitHubManagement.UI.Activity
{
    partial class CreateActivityForm
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
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            txtDuration = new TextBox();
            nmrUpDwnMaxPartisipant = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            LblDuration = new Label();
            label4 = new Label();
            label5 = new Label();

            lblDateActivity = new Label();
            btnCreateActivity = new Button();
            toolTip1 = new ToolTip(components);
            cmbLocationActivity = new ComboBox();
            dateTimePicker2 = new DateTimePicker();
            lblTimeActivity = new Label();
            ((System.ComponentModel.ISupportInitialize)nmrUpDwnMaxPartisipant).BeginInit();

            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(524, 115);
            comboBox1.Margin = new Padding(7, 8, 7, 8);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(327, 49);
            comboBox1.TabIndex = 0;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(524, 41);
            comboBox2.Margin = new Padding(7, 8, 7, 8);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(327, 49);
            comboBox2.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(1058, 41);
            dateTimePicker1.Margin = new Padding(7, 8, 7, 8);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(327, 47);
            dateTimePicker1.TabIndex = 2;
            // 
            // txtDuration
            // 
            txtDuration.Location = new Point(553, 428);
            txtDuration.Margin = new Padding(7, 8, 7, 8);
            txtDuration.Name = "txtDuration";
            txtDuration.Size = new Size(327, 47);
            txtDuration.TabIndex = 3;
            // 
            // nmrUpDwnMaxPartisipant
            // 
            nmrUpDwnMaxPartisipant.Location = new Point(257, 935);
            nmrUpDwnMaxPartisipant.Margin = new Padding(7, 8, 7, 8);
            nmrUpDwnMaxPartisipant.Name = "nmrUpDwnMaxPartisipant";
            nmrUpDwnMaxPartisipant.Size = new Size(114, 47);
            nmrUpDwnMaxPartisipant.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(403, 41);
            label1.Margin = new Padding(7, 0, 7, 0);
            label1.Name = "label1";
            label1.Size = new Size(81, 41);
            label1.TabIndex = 6;
            label1.Text = "Type";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(351, 118);
            label2.Margin = new Padding(7, 0, 7, 0);
            label2.Name = "label2";
            label2.Size = new Size(146, 41);
            label2.TabIndex = 7;
            label2.Text = "Instruktør";
            // 
            // LblDuration
            // 
            LblDuration.AutoSize = true;
            LblDuration.Location = new Point(403, 428);
            LblDuration.Margin = new Padding(7, 0, 7, 0);
            LblDuration.Name = "LblDuration";
            LblDuration.Size = new Size(136, 41);
            LblDuration.TabIndex = 8;
            LblDuration.Text = "Varighed";
            toolTip1.SetToolTip(LblDuration, "t = time og min = minutter. Skriv f.eks. 1 t eller 45 min");
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 839);
            label4.Margin = new Padding(7, 0, 7, 0);
            label4.Name = "label4";
            label4.Size = new Size(139, 41);
            label4.TabIndex = 9;
            label4.Text = "Placering";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(63, 935);
            label5.Margin = new Padding(7, 0, 7, 0);
            label5.Name = "label5";
            label5.Size = new Size(147, 41);
            label5.TabIndex = 10;
            label5.Text = "Deltagere";
            // 
            // lblDateActivity
            // 
            lblDateActivity.AutoSize = true;
            lblDateActivity.Location = new Point(955, 40);
            lblDateActivity.Margin = new Padding(7, 0, 7, 0);
            lblDateActivity.Name = "lblDateActivity";
            lblDateActivity.Size = new Size(89, 41);
            lblDateActivity.TabIndex = 11;
            lblDateActivity.Text = "Dato:";
            // 
            // btnCreateActivity
            // 
            btnCreateActivity.Location = new Point(52, 1040);
            btnCreateActivity.Margin = new Padding(7, 8, 7, 8);
            btnCreateActivity.Name = "btnCreateActivity";
            btnCreateActivity.Size = new Size(182, 63);
            btnCreateActivity.TabIndex = 12;
            btnCreateActivity.Text = "Opret";
            btnCreateActivity.UseVisualStyleBackColor = true;
            btnCreateActivity.Click += btnCreateActivity_Click;
            // 
            // cmbLocationActivity
            // 
            cmbLocationActivity.FormattingEnabled = true;
            cmbLocationActivity.Location = new Point(229, 831);
            cmbLocationActivity.Name = "cmbLocationActivity";
            cmbLocationActivity.Size = new Size(302, 49);
            cmbLocationActivity.TabIndex = 13;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "HH:mm";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(1058, 115);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.ShowUpDown = true;
            dateTimePicker2.Size = new Size(247, 47);
            dateTimePicker2.TabIndex = 14;
            // 
            // lblTimeActivity
            // 
            lblTimeActivity.AutoSize = true;
            lblTimeActivity.Location = new Point(955, 123);
            lblTimeActivity.Name = "lblTimeActivity";
            lblTimeActivity.Size = new Size(66, 41);
            lblTimeActivity.TabIndex = 15;
            lblTimeActivity.Text = "Tid:";
            // 
            // CreateActivityForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;

            ClientSize = new Size(1943, 1230);
            Controls.Add(lblTimeActivity);
            Controls.Add(dateTimePicker2);
            Controls.Add(cmbLocationActivity);
            Controls.Add(btnCreateActivity);
            Controls.Add(lblDateActivity);

            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(LblDuration);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(nmrUpDwnMaxPartisipant);
            Controls.Add(txtDuration);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Margin = new Padding(7, 8, 7, 8);
            Name = "CreateActivityForm";
            Text = "CreateActivityForm";
            Load += CreateActivityForm_Load;
            ((System.ComponentModel.ISupportInitialize)nmrUpDwnMaxPartisipant).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private DateTimePicker dateTimePicker1;
        private TextBox txtDuration;
        private NumericUpDown nmrUpDwnMaxPartisipant;
        private Label label1;
        private Label label2;
        private Label LblDuration;
        private Label label4;
        private Label label5;
        private Label lblDateActivity;
        private Button btnCreateActivity;
        private ToolTip toolTip1;
        private ComboBox cmbLocationActivity;
        private DateTimePicker dateTimePicker2;
        private Label lblTimeActivity;

        //Disse tre var problemet. Jeg tror ikke, at vi har haft fat i de samme og jeg har renamet dem? Hvis det ER de samme, burde den "bare" lave error og vi kan slette dem uden reference

    }
}