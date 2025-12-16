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
            toolTip1 = new ToolTip(components);
            LblDuration = new Label();
            pnlSearchActivity = new Panel();
            chkFilterByDate = new CheckBox();
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
            panel1 = new Panel();
            comboBox1 = new ComboBox();
            button3 = new Button();
            dateTimePicker1 = new DateTimePicker();
            cmbLocationActivity = new ComboBox();
            lblTimeActivity = new Label();
            label5 = new Label();
            lblDateActivity = new Label();
            label4 = new Label();
            nmrUpDwnMaxPartisipant = new NumericUpDown();
            cmbInstructorCreateActivity = new ComboBox();
            label1 = new Label();
            dateTimePicker2 = new DateTimePicker();
            comboBox2 = new ComboBox();
            btnCreateActivityPanel = new Button();
            label2 = new Label();
            pnlSearchActivity.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmrUpDwnMaxPartisipant).BeginInit();
            SuspendLayout();
            // 
            // LblDuration
            // 
            LblDuration.AutoSize = true;
            LblDuration.Location = new Point(78, 527);
            LblDuration.Margin = new Padding(9, 0, 9, 0);
            LblDuration.Name = "LblDuration";
            LblDuration.Size = new Size(82, 25);
            LblDuration.TabIndex = 8;
            LblDuration.Text = "Varighed";
            toolTip1.SetToolTip(LblDuration, "t = time og min = minutter. Skriv f.eks. 1 t eller 45 min");
            // 
            // pnlSearchActivity
            // 
            pnlSearchActivity.Controls.Add(chkFilterByDate);
            pnlSearchActivity.Controls.Add(btnSearchGet);
            pnlSearchActivity.Controls.Add(cmbSearchLocation);
            pnlSearchActivity.Controls.Add(dTPSearchDate);
            pnlSearchActivity.Controls.Add(cmbSearchActivity);
            pnlSearchActivity.Controls.Add(lstbxSearchGet);
            pnlSearchActivity.Controls.Add(lblSearchLocation);
            pnlSearchActivity.Controls.Add(lblSearchDate);
            pnlSearchActivity.Controls.Add(lblSearchActivity);
            pnlSearchActivity.Controls.Add(lblSearchCriteria);
            pnlSearchActivity.Location = new Point(25, 50);
            pnlSearchActivity.Margin = new Padding(1, 2, 1, 2);
            pnlSearchActivity.Name = "pnlSearchActivity";
            pnlSearchActivity.Size = new Size(726, 739);
            pnlSearchActivity.TabIndex = 20;
            pnlSearchActivity.Paint += pnlSearcActivity_Paint;
            // 
            // chkFilterByDate
            // 
            chkFilterByDate.AutoSize = true;
            chkFilterByDate.Location = new Point(371, 168);
            chkFilterByDate.Margin = new Padding(4, 5, 4, 5);
            chkFilterByDate.Name = "chkFilterByDate";
            chkFilterByDate.Size = new Size(119, 29);
            chkFilterByDate.TabIndex = 20;
            chkFilterByDate.Text = "Brug Dato";
            chkFilterByDate.UseVisualStyleBackColor = true;
            // 
            // btnSearchGet
            // 
            btnSearchGet.Location = new Point(529, 265);
            btnSearchGet.Margin = new Padding(3, 5, 3, 5);
            btnSearchGet.Name = "btnSearchGet";
            btnSearchGet.Size = new Size(157, 38);
            btnSearchGet.TabIndex = 19;
            btnSearchGet.Text = "Vis søgeresultater";
            btnSearchGet.UseVisualStyleBackColor = true;
            btnSearchGet.Click += btnSearchGet_Click;
            // 
            // cmbSearchLocation
            // 
            cmbSearchLocation.FormattingEnabled = true;
            cmbSearchLocation.Location = new Point(127, 238);
            cmbSearchLocation.Margin = new Padding(1, 2, 1, 2);
            cmbSearchLocation.Name = "cmbSearchLocation";
            cmbSearchLocation.Size = new Size(235, 33);
            cmbSearchLocation.TabIndex = 14;
            cmbSearchLocation.SelectedIndexChanged += comboBox4_SelectedIndexChanged;
            // 
            // dTPSearchDate
            // 
            dTPSearchDate.Location = new Point(127, 162);
            dTPSearchDate.Margin = new Padding(3, 5, 3, 5);
            dTPSearchDate.Name = "dTPSearchDate";
            dTPSearchDate.Size = new Size(235, 31);
            dTPSearchDate.TabIndex = 6;
            // 
            // cmbSearchActivity
            // 
            cmbSearchActivity.FormattingEnabled = true;
            cmbSearchActivity.Location = new Point(127, 91);
            cmbSearchActivity.Margin = new Padding(1, 2, 1, 2);
            cmbSearchActivity.Name = "cmbSearchActivity";
            cmbSearchActivity.Size = new Size(235, 33);
            cmbSearchActivity.TabIndex = 5;
            // 
            // lstbxSearchGet
            // 
            lstbxSearchGet.FormattingEnabled = true;
            lstbxSearchGet.ItemHeight = 25;
            lstbxSearchGet.Location = new Point(9, 325);
            lstbxSearchGet.Margin = new Padding(1, 2, 1, 2);
            lstbxSearchGet.Name = "lstbxSearchGet";
            lstbxSearchGet.Size = new Size(700, 304);
            lstbxSearchGet.TabIndex = 4;
            // 
            // lblSearchLocation
            // 
            lblSearchLocation.AutoSize = true;
            lblSearchLocation.Location = new Point(21, 243);
            lblSearchLocation.Margin = new Padding(1, 0, 1, 0);
            lblSearchLocation.Name = "lblSearchLocation";
            lblSearchLocation.Size = new Size(80, 25);
            lblSearchLocation.TabIndex = 3;
            lblSearchLocation.Text = "Lokation";
            lblSearchLocation.Click += label9_Click;
            // 
            // lblSearchDate
            // 
            lblSearchDate.AutoSize = true;
            lblSearchDate.Location = new Point(31, 162);
            lblSearchDate.Margin = new Padding(1, 0, 1, 0);
            lblSearchDate.Name = "lblSearchDate";
            lblSearchDate.Size = new Size(51, 25);
            lblSearchDate.TabIndex = 2;
            lblSearchDate.Text = "Dato";
            lblSearchDate.Click += label8_Click;
            // 
            // lblSearchActivity
            // 
            lblSearchActivity.AutoSize = true;
            lblSearchActivity.Location = new Point(21, 93);
            lblSearchActivity.Margin = new Padding(1, 0, 1, 0);
            lblSearchActivity.Name = "lblSearchActivity";
            lblSearchActivity.Size = new Size(86, 25);
            lblSearchActivity.TabIndex = 1;
            lblSearchActivity.Text = "Holdtype";
            // 
            // lblSearchCriteria
            // 
            lblSearchCriteria.AutoSize = true;
            lblSearchCriteria.Font = new Font("Segoe UI", 9.900001F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSearchCriteria.Location = new Point(223, 23);
            lblSearchCriteria.Margin = new Padding(1, 0, 1, 0);
            lblSearchCriteria.Name = "lblSearchCriteria";
            lblSearchCriteria.Size = new Size(254, 28);
            lblSearchCriteria.TabIndex = 0;
            lblSearchCriteria.Text = "Søg på ét eller flere kriterier";
            // 
            // btnActivityCreate
            // 
            btnActivityCreate.Location = new Point(2066, 235);
            btnActivityCreate.Margin = new Padding(9, 13, 9, 13);
            btnActivityCreate.Name = "btnActivityCreate";
            btnActivityCreate.Size = new Size(107, 38);
            btnActivityCreate.TabIndex = 17;
            btnActivityCreate.Text = "Opret";
            btnActivityCreate.UseVisualStyleBackColor = true;
            btnActivityCreate.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(203, 5);
            label3.Margin = new Padding(1, 0, 1, 0);
            label3.Name = "label3";
            label3.Size = new Size(325, 48);
            label3.TabIndex = 17;
            label3.Text = "Holdadministration";
            // 
            // btnSearchActivity
            // 
            btnSearchActivity.Location = new Point(860, 235);
            btnSearchActivity.Margin = new Padding(3, 5, 3, 5);
            btnSearchActivity.Name = "btnSearchActivity";
            btnSearchActivity.Size = new Size(107, 38);
            btnSearchActivity.TabIndex = 18;
            btnSearchActivity.Text = "Søgning";
            btnSearchActivity.UseVisualStyleBackColor = true;
            btnSearchActivity.Click += button1_Click;
            // 
            // button4
            // 
            button4.Location = new Point(860, 562);
            button4.Margin = new Padding(3, 5, 3, 5);
            button4.Name = "button4";
            button4.Size = new Size(107, 38);
            button4.TabIndex = 19;
            button4.Text = "Tilbage";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(cmbLocationActivity);
            panel1.Controls.Add(lblTimeActivity);
            panel1.Controls.Add(LblDuration);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(lblDateActivity);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(nmrUpDwnMaxPartisipant);
            panel1.Controls.Add(cmbInstructorCreateActivity);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dateTimePicker2);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(btnCreateActivityPanel);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 50);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(751, 692);
            panel1.TabIndex = 21;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(178, 269);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(465, 33);
            comboBox1.TabIndex = 20;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button3
            // 
            button3.Location = new Point(503, 596);
            button3.Margin = new Padding(9, 13, 9, 13);
            button3.Name = "button3";
            button3.Size = new Size(107, 38);
            button3.TabIndex = 18;
            button3.Text = "Annuller";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(441, 68);
            dateTimePicker1.Margin = new Padding(9, 13, 9, 13);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(147, 31);
            dateTimePicker1.TabIndex = 2;
            // 
            // cmbLocationActivity
            // 
            cmbLocationActivity.FormattingEnabled = true;
            cmbLocationActivity.Location = new Point(193, 522);
            cmbLocationActivity.Name = "cmbLocationActivity";
            cmbLocationActivity.Size = new Size(194, 33);
            cmbLocationActivity.TabIndex = 13;
            // 
            // lblTimeActivity
            // 
            lblTimeActivity.AutoSize = true;
            lblTimeActivity.Location = new Point(372, 132);
            lblTimeActivity.Name = "lblTimeActivity";
            lblTimeActivity.Size = new Size(40, 25);
            lblTimeActivity.TabIndex = 15;
            lblTimeActivity.Text = "Tid:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 389);
            label5.Margin = new Padding(9, 0, 9, 0);
            label5.Name = "label5";
            label5.Size = new Size(88, 25);
            label5.TabIndex = 10;
            label5.Text = "Deltagere";
            // 
            // lblDateActivity
            // 
            lblDateActivity.AutoSize = true;
            lblDateActivity.Location = new Point(347, 12);
            lblDateActivity.Margin = new Padding(9, 0, 9, 0);
            lblDateActivity.Name = "lblDateActivity";
            lblDateActivity.Size = new Size(55, 25);
            lblDateActivity.TabIndex = 11;
            lblDateActivity.Text = "Dato:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 74);
            label4.Margin = new Padding(9, 0, 9, 0);
            label4.Name = "label4";
            label4.Size = new Size(80, 25);
            label4.TabIndex = 9;
            label4.Text = "Lokation";
            // 
            // nmrUpDwnMaxPartisipant
            // 
            nmrUpDwnMaxPartisipant.Location = new Point(146, 389);
            nmrUpDwnMaxPartisipant.Margin = new Padding(9, 13, 9, 13);
            nmrUpDwnMaxPartisipant.Maximum = new decimal(new int[] { 25, 0, 0, 0 });
            nmrUpDwnMaxPartisipant.Name = "nmrUpDwnMaxPartisipant";
            nmrUpDwnMaxPartisipant.Size = new Size(67, 31);
            nmrUpDwnMaxPartisipant.TabIndex = 5;
            nmrUpDwnMaxPartisipant.ValueChanged += nmrUpDwnMaxPartisipant_ValueChanged;
            // 
            // cmbInstructorCreateActivity
            // 
            cmbInstructorCreateActivity.FormattingEnabled = true;
            cmbInstructorCreateActivity.Location = new Point(146, 143);
            cmbInstructorCreateActivity.Margin = new Padding(9, 13, 9, 13);
            cmbInstructorCreateActivity.Name = "cmbInstructorCreateActivity";
            cmbInstructorCreateActivity.Size = new Size(187, 33);
            cmbInstructorCreateActivity.TabIndex = 22;
            cmbInstructorCreateActivity.SelectedIndexChanged += cmbInstructorCreateActivity_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 168);
            label1.Margin = new Padding(9, 0, 9, 0);
            label1.Name = "label1";
            label1.Size = new Size(86, 25);
            label1.TabIndex = 6;
            label1.Text = "Holdtype";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "HH:mm";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(441, 121);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.ShowUpDown = true;
            dateTimePicker2.Size = new Size(147, 31);
            dateTimePicker2.TabIndex = 14;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(146, 69);
            comboBox2.Margin = new Padding(9, 13, 9, 13);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(194, 33);
            comboBox2.TabIndex = 1;
            // 
            // btnCreateActivityPanel
            // 
            btnCreateActivityPanel.Location = new Point(127, 603);
            btnCreateActivityPanel.Margin = new Padding(4, 5, 4, 5);
            btnCreateActivityPanel.Name = "btnCreateActivityPanel";
            btnCreateActivityPanel.Size = new Size(152, 61);
            btnCreateActivityPanel.TabIndex = 21;
            btnCreateActivityPanel.Text = "Opret hold";
            btnCreateActivityPanel.UseVisualStyleBackColor = true;
            btnCreateActivityPanel.Click += btnCreateActivityPanel_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 282);
            label2.Margin = new Padding(9, 0, 9, 0);
            label2.Name = "label2";
            label2.Size = new Size(89, 25);
            label2.TabIndex = 7;
            label2.Text = "Instruktør";
            // 
            // CreateActivityForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1279, 713);
            Controls.Add(panel1);
            Controls.Add(btnActivityCreate);
            Controls.Add(button4);
            Controls.Add(label3);
            Controls.Add(btnSearchActivity);
            Controls.Add(pnlSearchActivity);
            Margin = new Padding(3, 5, 3, 5);
            MinimumSize = new Size(1124, 602);
            Name = "CreateActivityForm";
            Text = "CreateActivityForm";
            Load += CreateActivityForm_Load;
            pnlSearchActivity.ResumeLayout(false);
            pnlSearchActivity.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmrUpDwnMaxPartisipant).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolTip toolTip1;
        private Label label3;
        private Button btnSearchActivity;
        private Button btnActivityCreate;
        private Button button4;
        private Panel pnlSearchActivity;
        private DateTimePicker dateTimePicker3;
        private ComboBox comboBox3;
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
        private CheckBox chkFilterByDate;
        private Panel panel1;
        private ComboBox comboBox1;
        private Button button3;
        private DateTimePicker dateTimePicker1;
        private ComboBox cmbLocationActivity;
        private Label lblTimeActivity;
        private Label LblDuration;
        private Label label5;
        private Label lblDateActivity;
        private Label label4;
        private NumericUpDown nmrUpDwnMaxPartisipant;
        private ComboBox cmbInstructorCreateActivity;
        private Label label1;
        private DateTimePicker dateTimePicker2;
        private ComboBox comboBox2;
        private Button btnCreateActivityPanel;
        private Label label2;

        //Disse tre var problemet. Jeg tror ikke, at vi har haft fat i de samme og jeg har renamet dem? Hvis det ER de samme, burde den "bare" lave error og vi kan slette dem uden reference

    }
}