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
            comboBox2 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            nmrUpDwnMaxPartisipant = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            LblDuration = new Label();
            label4 = new Label();
            label5 = new Label();
            lblDateActivity = new Label();
            toolTip1 = new ToolTip(components);
            cmbLocationActivity = new ComboBox();
            dateTimePicker2 = new DateTimePicker();
            lblTimeActivity = new Label();
            pnlCreateActivity = new Panel();
            comboBox1 = new ComboBox();
            btnCreateActivityPanel = new Button();
            button3 = new Button();
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
            cmbInstructorCreateActivity = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)nmrUpDwnMaxPartisipant).BeginInit();
            pnlCreateActivity.SuspendLayout();
            pnlSearchActivity.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(228, 136);
            comboBox2.Margin = new Padding(6, 8, 6, 8);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(137, 23);
            comboBox2.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(814, 132);
            dateTimePicker1.Margin = new Padding(6, 8, 6, 8);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(104, 23);
            dateTimePicker1.TabIndex = 2;
            // 
            // nmrUpDwnMaxPartisipant
            // 
            nmrUpDwnMaxPartisipant.Location = new Point(228, 583);
            nmrUpDwnMaxPartisipant.Margin = new Padding(6, 8, 6, 8);
            nmrUpDwnMaxPartisipant.Maximum = new decimal(new int[] { 25, 0, 0, 0 });
            nmrUpDwnMaxPartisipant.Name = "nmrUpDwnMaxPartisipant";
            nmrUpDwnMaxPartisipant.Size = new Size(47, 23);
            nmrUpDwnMaxPartisipant.TabIndex = 5;
            nmrUpDwnMaxPartisipant.ValueChanged += nmrUpDwnMaxPartisipant_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 136);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 6;
            label1.Text = "Holdtype";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 245);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 7;
            label2.Text = "Instruktør";
            // 
            // LblDuration
            // 
            LblDuration.AutoSize = true;
            LblDuration.Location = new Point(53, 466);
            LblDuration.Margin = new Padding(6, 0, 6, 0);
            LblDuration.Name = "LblDuration";
            LblDuration.Size = new Size(53, 15);
            LblDuration.TabIndex = 8;
            LblDuration.Text = "Varighed";
            toolTip1.SetToolTip(LblDuration, "t = time og min = minutter. Skriv f.eks. 1 t eller 45 min");
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 359);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 9;
            label4.Text = "Lokation";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(47, 585);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 10;
            label5.Text = "Deltagere";
            // 
            // lblDateActivity
            // 
            lblDateActivity.AutoSize = true;
            lblDateActivity.Location = new Point(710, 136);
            lblDateActivity.Margin = new Padding(6, 0, 6, 0);
            lblDateActivity.Name = "lblDateActivity";
            lblDateActivity.Size = new Size(35, 15);
            lblDateActivity.TabIndex = 11;
            lblDateActivity.Text = "Dato:";
            // 
            // cmbLocationActivity
            // 
            cmbLocationActivity.FormattingEnabled = true;
            cmbLocationActivity.Location = new Point(228, 355);
            cmbLocationActivity.Margin = new Padding(2);
            cmbLocationActivity.Name = "cmbLocationActivity";
            cmbLocationActivity.Size = new Size(137, 23);
            cmbLocationActivity.TabIndex = 13;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "HH:mm";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(814, 206);
            dateTimePicker2.Margin = new Padding(2);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.ShowUpDown = true;
            dateTimePicker2.Size = new Size(104, 23);
            dateTimePicker2.TabIndex = 14;
            // 
            // lblTimeActivity
            // 
            lblTimeActivity.AutoSize = true;
            lblTimeActivity.Location = new Point(710, 214);
            lblTimeActivity.Margin = new Padding(2, 0, 2, 0);
            lblTimeActivity.Name = "lblTimeActivity";
            lblTimeActivity.Size = new Size(26, 15);
            lblTimeActivity.TabIndex = 15;
            lblTimeActivity.Text = "Tid:";
            // 
            // pnlCreateActivity
            // 
            pnlCreateActivity.Controls.Add(cmbInstructorCreateActivity);
            pnlCreateActivity.Controls.Add(comboBox1);
            pnlCreateActivity.Controls.Add(btnCreateActivityPanel);
            pnlCreateActivity.Controls.Add(button3);
            pnlCreateActivity.Controls.Add(dateTimePicker1);
            pnlCreateActivity.Controls.Add(cmbLocationActivity);
            pnlCreateActivity.Controls.Add(lblTimeActivity);
            pnlCreateActivity.Controls.Add(LblDuration);
            pnlCreateActivity.Controls.Add(label5);
            pnlCreateActivity.Controls.Add(lblDateActivity);
            pnlCreateActivity.Controls.Add(label4);
            pnlCreateActivity.Controls.Add(nmrUpDwnMaxPartisipant);
            pnlCreateActivity.Controls.Add(dateTimePicker2);
            pnlCreateActivity.Controls.Add(comboBox2);
            pnlCreateActivity.Controls.Add(label2);
            pnlCreateActivity.Controls.Add(label1);
            pnlCreateActivity.Location = new Point(0, 0);
            pnlCreateActivity.Margin = new Padding(1);
            pnlCreateActivity.Name = "pnlCreateActivity";
            pnlCreateActivity.Size = new Size(509, 401);
            pnlCreateActivity.TabIndex = 16;
            pnlCreateActivity.Paint += pnlCreateActivity_Paint;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(228, 458);
            comboBox1.Margin = new Padding(2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(327, 49);
            comboBox1.TabIndex = 20;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btnCreateActivityPanel
            // 
            btnCreateActivityPanel.Location = new Point(355, 798);
            btnCreateActivityPanel.Name = "btnCreateActivityPanel";
            btnCreateActivityPanel.Size = new Size(188, 58);
            btnCreateActivityPanel.TabIndex = 21;
            btnCreateActivityPanel.Text = "Opret hold";
            btnCreateActivityPanel.UseVisualStyleBackColor = true;
            btnCreateActivityPanel.Click += btnCreateActivityPanel_Click;
            // 
            // button3
            // 
            button3.Location = new Point(1011, 949);
            button3.Margin = new Padding(6, 8, 6, 8);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 18;
            button3.Text = "Annuller";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
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
            pnlSearchActivity.Location = new Point(0, 0);
            pnlSearchActivity.Margin = new Padding(1);
            pnlSearchActivity.Name = "pnlSearchActivity";
            pnlSearchActivity.Size = new Size(492, 371);
            pnlSearchActivity.TabIndex = 20;
            pnlSearchActivity.Paint += pnlSearcActivity_Paint;
            // 
            // chkFilterByDate
            // 
            chkFilterByDate.AutoSize = true;
            chkFilterByDate.Location = new Point(260, 101);
            chkFilterByDate.Name = "chkFilterByDate";
            chkFilterByDate.Size = new Size(79, 19);
            chkFilterByDate.TabIndex = 20;
            chkFilterByDate.Text = "Brug Dato";
            chkFilterByDate.UseVisualStyleBackColor = true;
            // 
            // btnSearchGet
            // 
            btnSearchGet.Location = new Point(370, 159);
            btnSearchGet.Margin = new Padding(2, 3, 2, 3);
            btnSearchGet.Name = "btnSearchGet";
            btnSearchGet.Size = new Size(110, 23);
            btnSearchGet.TabIndex = 19;
            btnSearchGet.Text = "Vis søgeresultater";
            btnSearchGet.UseVisualStyleBackColor = true;
            btnSearchGet.Click += btnSearchGet_Click;
            // 
            // cmbSearchLocation
            // 
            cmbSearchLocation.FormattingEnabled = true;
            cmbSearchLocation.Location = new Point(89, 143);
            cmbSearchLocation.Margin = new Padding(1);
            cmbSearchLocation.Name = "cmbSearchLocation";
            cmbSearchLocation.Size = new Size(166, 23);
            cmbSearchLocation.TabIndex = 14;
            cmbSearchLocation.SelectedIndexChanged += comboBox4_SelectedIndexChanged;
            // 
            // dTPSearchDate
            // 
            dTPSearchDate.Location = new Point(89, 97);
            dTPSearchDate.Margin = new Padding(2, 3, 2, 3);
            dTPSearchDate.Name = "dTPSearchDate";
            dTPSearchDate.Size = new Size(166, 23);
            dTPSearchDate.TabIndex = 6;
            // 
            // cmbSearchActivity
            // 
            cmbSearchActivity.FormattingEnabled = true;
            cmbSearchActivity.Location = new Point(89, 55);
            cmbSearchActivity.Margin = new Padding(1);
            cmbSearchActivity.Name = "cmbSearchActivity";
            cmbSearchActivity.Size = new Size(166, 23);
            cmbSearchActivity.TabIndex = 5;
            // 
            // lstbxSearchGet
            // 
            lstbxSearchGet.FormattingEnabled = true;
            lstbxSearchGet.ItemHeight = 15;
            lstbxSearchGet.Location = new Point(6, 195);
            lstbxSearchGet.Margin = new Padding(1);
            lstbxSearchGet.Name = "lstbxSearchGet";
            lstbxSearchGet.Size = new Size(491, 184);
            lstbxSearchGet.TabIndex = 4;
            // 
            // lblSearchLocation
            // 
            lblSearchLocation.AutoSize = true;
            lblSearchLocation.Location = new Point(15, 146);
            lblSearchLocation.Margin = new Padding(1, 0, 1, 0);
            lblSearchLocation.Name = "lblSearchLocation";
            lblSearchLocation.Size = new Size(53, 15);
            lblSearchLocation.TabIndex = 3;
            lblSearchLocation.Text = "Lokation";
            lblSearchLocation.Click += label9_Click;
            // 
            // lblSearchDate
            // 
            lblSearchDate.AutoSize = true;
            lblSearchDate.Location = new Point(22, 97);
            lblSearchDate.Margin = new Padding(1, 0, 1, 0);
            lblSearchDate.Name = "lblSearchDate";
            lblSearchDate.Size = new Size(32, 15);
            lblSearchDate.TabIndex = 2;
            lblSearchDate.Text = "Dato";
            lblSearchDate.Click += label8_Click;
            // 
            // lblSearchActivity
            // 
            lblSearchActivity.AutoSize = true;
            lblSearchActivity.Location = new Point(15, 56);
            lblSearchActivity.Margin = new Padding(1, 0, 1, 0);
            lblSearchActivity.Name = "lblSearchActivity";
            lblSearchActivity.Size = new Size(56, 15);
            lblSearchActivity.TabIndex = 1;
            lblSearchActivity.Text = "Holdtype";
            // 
            // lblSearchCriteria
            // 
            lblSearchCriteria.AutoSize = true;
            lblSearchCriteria.Font = new Font("Segoe UI", 9.900001F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSearchCriteria.Location = new Point(156, 14);
            lblSearchCriteria.Margin = new Padding(1, 0, 1, 0);
            lblSearchCriteria.Name = "lblSearchCriteria";
            lblSearchCriteria.Size = new Size(177, 19);
            lblSearchCriteria.TabIndex = 0;
            lblSearchCriteria.Text = "Søg på ét eller flere kriterier";
            // 
            // btnActivityCreate
            // 
            btnActivityCreate.Location = new Point(1446, 141);
            btnActivityCreate.Margin = new Padding(6, 8, 6, 8);
            btnActivityCreate.Name = "btnActivityCreate";
            btnActivityCreate.Size = new Size(75, 23);
            btnActivityCreate.TabIndex = 17;
            btnActivityCreate.Text = "Opret";
            btnActivityCreate.UseVisualStyleBackColor = true;
            btnActivityCreate.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(142, 3);
            label3.Margin = new Padding(1, 0, 1, 0);
            label3.Name = "label3";
            label3.Size = new Size(218, 32);
            label3.TabIndex = 17;
            label3.Text = "Holdadministration";
            // 
            // btnSearchActivity
            // 
            btnSearchActivity.Location = new Point(602, 141);
            btnSearchActivity.Margin = new Padding(2, 3, 2, 3);
            btnSearchActivity.Name = "btnSearchActivity";
            btnSearchActivity.Size = new Size(75, 23);
            btnSearchActivity.TabIndex = 18;
            btnSearchActivity.Text = "Søgning";
            btnSearchActivity.UseVisualStyleBackColor = true;
            btnSearchActivity.Click += button1_Click;
            // 
            // button4
            // 
            button4.Location = new Point(602, 337);
            button4.Margin = new Padding(2, 3, 2, 3);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 19;
            button4.Text = "Tilbage";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // cmbInstructorCreateActivity
            // 
            cmbInstructorCreateActivity.FormattingEnabled = true;
            cmbInstructorCreateActivity.Location = new Point(228, 245);
            cmbInstructorCreateActivity.Margin = new Padding(6, 8, 6, 8);
            cmbInstructorCreateActivity.Name = "cmbInstructorCreateActivity";
            cmbInstructorCreateActivity.Size = new Size(327, 49);
            cmbInstructorCreateActivity.TabIndex = 22;
            cmbInstructorCreateActivity.SelectedIndexChanged += cmbInstructorCreateActivity_SelectedIndexChanged;
            // 
            // CreateActivityForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1893, 1050);
            Controls.Add(pnlCreateActivity);
            Controls.Add(btnActivityCreate);
            Controls.Add(button4);
            Controls.Add(btnSearchActivity);
            Controls.Add(label3);
            Controls.Add(pnlCreateActivity);
            Controls.Add(pnlSearchActivity);
            Margin = new Padding(2, 3, 2, 3);
            MaximumSize = new Size(802, 441);
            MinimumSize = new Size(799, 404);
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
        private ComboBox comboBox2;
        private DateTimePicker dateTimePicker1;
        private NumericUpDown nmrUpDwnMaxPartisipant;
        private Label label1;
        private Label label2;
        private Label LblDuration;
        private Label label4;
        private Label label5;
        private Label lblDateActivity;
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
        private ComboBox comboBox1;
        private CheckBox chkFilterByDate;
        private Button btnCreateActivityPanel;
        private ComboBox cmbInstructorCreateActivity;

        //Disse tre var problemet. Jeg tror ikke, at vi har haft fat i de samme og jeg har renamet dem? Hvis det ER de samme, burde den "bare" lave error og vi kan slette dem uden reference

    }
}