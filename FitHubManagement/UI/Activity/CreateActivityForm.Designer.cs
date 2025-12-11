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
            pnlCreateActivity = new Panel();
            button3 = new Button();
            pnlSearchActivity = new Panel();
            btnSearchGet = new Button();
            cmbSearchLocation = new ComboBox();
            dTPSearchDate = new DateTimePicker();
            cmbSearchActivity = new ComboBox();
            lstbxSearchGet = new ListBox();
            lblSearchLocation = new Label();
            lblSearchDate = new Label();
            lblSearchActivity = new Label();
            lblSearchCriteria = new Label();
            btnActivityCreate = new Button();
            label3 = new Label();
            btnSearchActivity = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)nmrUpDwnMaxPartisipant).BeginInit();
            pnlCreateActivity.SuspendLayout();
            pnlSearchActivity.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(93, 149);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(156, 28);
            comboBox1.TabIndex = 0;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(93, 100);
            comboBox2.Margin = new Padding(3, 4, 3, 4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(156, 28);
            comboBox2.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(369, 98);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(189, 27);
            dateTimePicker1.TabIndex = 2;
            // 
            // nmrUpDwnMaxPartisipant
            // 
            nmrUpDwnMaxPartisipant.Location = new Point(93, 318);
            nmrUpDwnMaxPartisipant.Margin = new Padding(3, 4, 3, 4);
            nmrUpDwnMaxPartisipant.Name = "nmrUpDwnMaxPartisipant";
            nmrUpDwnMaxPartisipant.Size = new Size(54, 27);
            nmrUpDwnMaxPartisipant.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 100);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 6;
            label1.Text = "Holdtype";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 153);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 7;
            label2.Text = "Instruktør";
            // 
            // LblDuration
            // 
            LblDuration.AutoSize = true;
            LblDuration.Location = new Point(11, 261);
            LblDuration.Name = "LblDuration";
            LblDuration.Size = new Size(68, 20);
            LblDuration.TabIndex = 8;
            LblDuration.Text = "Varighed";
            toolTip1.SetToolTip(LblDuration, "t = time og min = minutter. Skriv f.eks. 1 t eller 45 min");
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 209);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 9;
            label4.Text = "Lokation";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 319);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 10;
            label5.Text = "Deltagere";
            // 
            // lblDateActivity
            // 
            lblDateActivity.AutoSize = true;
            lblDateActivity.Location = new Point(320, 100);
            lblDateActivity.Name = "lblDateActivity";
            lblDateActivity.Size = new Size(45, 20);
            lblDateActivity.TabIndex = 11;
            lblDateActivity.Text = "Dato:";
            // 
            // btnCreateActivity
            // 
            btnCreateActivity.Location = new Point(135, 449);
            btnCreateActivity.Margin = new Padding(3, 4, 3, 4);
            btnCreateActivity.Name = "btnCreateActivity";
            btnCreateActivity.Size = new Size(86, 31);
            btnCreateActivity.TabIndex = 12;
            btnCreateActivity.Text = "Opret";
            btnCreateActivity.UseVisualStyleBackColor = true;
            btnCreateActivity.Click += btnCreateActivity_Click;
            // 
            // cmbLocationActivity
            // 
            cmbLocationActivity.FormattingEnabled = true;
            cmbLocationActivity.Location = new Point(93, 207);
            cmbLocationActivity.Margin = new Padding(1, 1, 1, 1);
            cmbLocationActivity.Name = "cmbLocationActivity";
            cmbLocationActivity.Size = new Size(156, 28);
            cmbLocationActivity.TabIndex = 13;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "HH:mm";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(369, 134);
            dateTimePicker2.Margin = new Padding(1, 1, 1, 1);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.ShowUpDown = true;
            dateTimePicker2.Size = new Size(118, 27);
            dateTimePicker2.TabIndex = 14;
            // 
            // lblTimeActivity
            // 
            lblTimeActivity.AutoSize = true;
            lblTimeActivity.Location = new Point(320, 138);
            lblTimeActivity.Margin = new Padding(1, 0, 1, 0);
            lblTimeActivity.Name = "lblTimeActivity";
            lblTimeActivity.Size = new Size(33, 20);
            lblTimeActivity.TabIndex = 15;
            lblTimeActivity.Text = "Tid:";
            // 
            // pnlCreateActivity
            // 
            pnlCreateActivity.Controls.Add(button3);
            pnlCreateActivity.Controls.Add(dateTimePicker1);
            pnlCreateActivity.Controls.Add(cmbLocationActivity);
            pnlCreateActivity.Controls.Add(btnCreateActivity);
            pnlCreateActivity.Controls.Add(lblTimeActivity);
            pnlCreateActivity.Controls.Add(LblDuration);
            pnlCreateActivity.Controls.Add(label5);
            pnlCreateActivity.Controls.Add(lblDateActivity);
            pnlCreateActivity.Controls.Add(label4);
            pnlCreateActivity.Controls.Add(nmrUpDwnMaxPartisipant);
            pnlCreateActivity.Controls.Add(dateTimePicker2);
            pnlCreateActivity.Controls.Add(comboBox2);
            pnlCreateActivity.Controls.Add(comboBox1);
            pnlCreateActivity.Controls.Add(label2);
            pnlCreateActivity.Controls.Add(label1);
            pnlCreateActivity.Location = new Point(13, 45);
            pnlCreateActivity.Margin = new Padding(1, 1, 1, 1);
            pnlCreateActivity.Name = "pnlCreateActivity";
            pnlCreateActivity.Size = new Size(581, 534);
            pnlCreateActivity.TabIndex = 16;
            // 
            // button3
            // 
            button3.Location = new Point(299, 449);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(86, 31);
            button3.TabIndex = 18;
            button3.Text = "Annuller";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // pnlSearchActivity
            // 
            pnlSearchActivity.Controls.Add(btnSearchGet);
            pnlSearchActivity.Controls.Add(cmbSearchLocation);
            pnlSearchActivity.Controls.Add(dTPSearchDate);
            pnlSearchActivity.Controls.Add(cmbSearchActivity);
            pnlSearchActivity.Controls.Add(lstbxSearchGet);
            pnlSearchActivity.Controls.Add(lblSearchLocation);
            pnlSearchActivity.Controls.Add(lblSearchDate);
            pnlSearchActivity.Controls.Add(lblSearchActivity);
            pnlSearchActivity.Controls.Add(lblSearchCriteria);
            pnlSearchActivity.Location = new Point(0, 0);
            pnlSearchActivity.Margin = new Padding(1, 1, 1, 1);
            pnlSearchActivity.Name = "pnlSearchActivity";
            pnlSearchActivity.Size = new Size(562, 494);
            pnlSearchActivity.TabIndex = 20;
            pnlSearchActivity.Paint += pnlSearcActivity_Paint;
            // 
            // btnSearchGet
            // 
            btnSearchGet.Location = new Point(423, 212);
            btnSearchGet.Margin = new Padding(3, 4, 3, 4);
            btnSearchGet.Name = "btnSearchGet";
            btnSearchGet.Size = new Size(126, 31);
            btnSearchGet.TabIndex = 19;
            btnSearchGet.Text = "Vis søgeresultater";
            btnSearchGet.UseVisualStyleBackColor = true;
            // 
            // cmbSearchLocation
            // 
            cmbSearchLocation.FormattingEnabled = true;
            cmbSearchLocation.Location = new Point(101, 190);
            cmbSearchLocation.Margin = new Padding(1, 1, 1, 1);
            cmbSearchLocation.Name = "cmbSearchLocation";
            cmbSearchLocation.Size = new Size(189, 28);
            cmbSearchLocation.TabIndex = 14;
            cmbSearchLocation.SelectedIndexChanged += comboBox4_SelectedIndexChanged;
            // 
            // dTPSearchDate
            // 
            dTPSearchDate.Location = new Point(101, 130);
            dTPSearchDate.Margin = new Padding(3, 4, 3, 4);
            dTPSearchDate.Name = "dTPSearchDate";
            dTPSearchDate.Size = new Size(189, 27);
            dTPSearchDate.TabIndex = 6;
            // 
            // cmbSearchActivity
            // 
            cmbSearchActivity.FormattingEnabled = true;
            cmbSearchActivity.Location = new Point(101, 73);
            cmbSearchActivity.Margin = new Padding(1, 1, 1, 1);
            cmbSearchActivity.Name = "cmbSearchActivity";
            cmbSearchActivity.Size = new Size(189, 28);
            cmbSearchActivity.TabIndex = 5;
            // 
            // lstbxSearchGet
            // 
            lstbxSearchGet.FormattingEnabled = true;
            lstbxSearchGet.Location = new Point(7, 260);
            lstbxSearchGet.Margin = new Padding(1, 1, 1, 1);
            lstbxSearchGet.Name = "lstbxSearchGet";
            lstbxSearchGet.Size = new Size(560, 244);
            lstbxSearchGet.TabIndex = 4;
            // 
            // lblSearchLocation
            // 
            lblSearchLocation.AutoSize = true;
            lblSearchLocation.Location = new Point(17, 194);
            lblSearchLocation.Margin = new Padding(1, 0, 1, 0);
            lblSearchLocation.Name = "lblSearchLocation";
            lblSearchLocation.Size = new Size(66, 20);
            lblSearchLocation.TabIndex = 3;
            lblSearchLocation.Text = "Lokation";
            lblSearchLocation.Click += label9_Click;
            // 
            // lblSearchDate
            // 
            lblSearchDate.AutoSize = true;
            lblSearchDate.Location = new Point(25, 130);
            lblSearchDate.Margin = new Padding(1, 0, 1, 0);
            lblSearchDate.Name = "lblSearchDate";
            lblSearchDate.Size = new Size(42, 20);
            lblSearchDate.TabIndex = 2;
            lblSearchDate.Text = "Dato";
            lblSearchDate.Click += label8_Click;
            // 
            // lblSearchActivity
            // 
            lblSearchActivity.AutoSize = true;
            lblSearchActivity.Location = new Point(17, 75);
            lblSearchActivity.Margin = new Padding(1, 0, 1, 0);
            lblSearchActivity.Name = "lblSearchActivity";
            lblSearchActivity.Size = new Size(71, 20);
            lblSearchActivity.TabIndex = 1;
            lblSearchActivity.Text = "Holdtype";
            // 
            // lblSearchCriteria
            // 
            lblSearchCriteria.AutoSize = true;
            lblSearchCriteria.Font = new Font("Segoe UI", 9.900001F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSearchCriteria.Location = new Point(178, 19);
            lblSearchCriteria.Margin = new Padding(1, 0, 1, 0);
            lblSearchCriteria.Name = "lblSearchCriteria";
            lblSearchCriteria.Size = new Size(221, 23);
            lblSearchCriteria.TabIndex = 0;
            lblSearchCriteria.Text = "Søg på ét eller flere kriterier";
            // 
            // btnActivityCreate
            // 
            btnActivityCreate.Location = new Point(688, 128);
            btnActivityCreate.Margin = new Padding(3, 4, 3, 4);
            btnActivityCreate.Name = "btnActivityCreate";
            btnActivityCreate.Size = new Size(86, 31);
            btnActivityCreate.TabIndex = 17;
            btnActivityCreate.Text = "Opret";
            btnActivityCreate.UseVisualStyleBackColor = true;
            btnActivityCreate.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(163, 4);
            label3.Margin = new Padding(1, 0, 1, 0);
            label3.Name = "label3";
            label3.Size = new Size(272, 41);
            label3.TabIndex = 17;
            label3.Text = "Holdadministration";
            // 
            // btnSearchActivity
            // 
            btnSearchActivity.Location = new Point(688, 188);
            btnSearchActivity.Margin = new Padding(3, 4, 3, 4);
            btnSearchActivity.Name = "btnSearchActivity";
            btnSearchActivity.Size = new Size(86, 31);
            btnSearchActivity.TabIndex = 18;
            btnSearchActivity.Text = "Søgning";
            btnSearchActivity.UseVisualStyleBackColor = true;
            btnSearchActivity.Click += button1_Click;
            // 
            // button4
            // 
            button4.Location = new Point(688, 494);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(86, 31);
            button4.TabIndex = 19;
            button4.Text = "Tilbage";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // CreateActivityForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(905, 553);
            Controls.Add(button4);
            Controls.Add(btnSearchActivity);
            Controls.Add(btnActivityCreate);
            Controls.Add(label3);
            Controls.Add(pnlSearchActivity);
            Controls.Add(pnlCreateActivity);
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(923, 600);
            MinimumSize = new Size(923, 600);
            Name = "CreateActivityForm";
            Text = "CreateActivityForm";
            Load += CreateActivityForm_Load;
            ((System.ComponentModel.ISupportInitialize)nmrUpDwnMaxPartisipant).EndInit();
            pnlCreateActivity.ResumeLayout(false);
            pnlCreateActivity.PerformLayout();
            pnlSearchActivity.ResumeLayout(false);
            pnlSearchActivity.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private DateTimePicker dateTimePicker1;
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
        private Panel pnlCreateActivity;
        private Label label3;
        private Button btnSearchActivity;
        private Button button3;
        private Button btnActivityCreate;
        private Button button4;
        private Panel pnlSearchActivity;
        private DateTimePicker dateTimePicker3;
        private ComboBox comboBox3;
        private ListBox listBox1;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private ComboBox comboBox4;
        private Button button5;
        private Button btnSearchGet;
        private ComboBox cmbSearchLocation;
        private DateTimePicker dTPSearchDate;
        private ComboBox cmbSearchActivity;
        private ListBox lstbxSearchGet;
        private Label lblSearchLocation;
        private Label lblSearchDate;
        private Label lblSearchActivity;
        private Label lblSearchCriteria;

        //Disse tre var problemet. Jeg tror ikke, at vi har haft fat i de samme og jeg har renamet dem? Hvis det ER de samme, burde den "bare" lave error og vi kan slette dem uden reference

    }
}