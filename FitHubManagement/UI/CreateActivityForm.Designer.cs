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
            btnEditHoldType = new Button();
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
            HoldType = new Label();
            dateTimePicker2 = new DateTimePicker();
            comboBox2 = new ComboBox();
            btnCreateActivityPanel = new Button();
            label2 = new Label();
            pnlHoldType = new Panel();
            btnSaveHoldType = new Button();
            cmbHoldTypeInstruktor = new ComboBox();
            btnCancelHoldType = new Button();
            label8 = new Label();
            txtHoldTypeBeskrivelse = new TextBox();
            lblHoldTypeDescription = new Label();
            txtHoldTypeName = new TextBox();
            lblHoldTypeNavn = new Label();
            lblHoldTypeTitle = new Label();
            pnlSearchActivity.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmrUpDwnMaxPartisipant).BeginInit();
            pnlHoldType.SuspendLayout();
            SuspendLayout();
            // 
            // LblDuration
            // 
            LblDuration.AutoSize = true;
            LblDuration.Location = new Point(34, 379);
            LblDuration.Margin = new Padding(7, 0, 7, 0);
            LblDuration.Name = "LblDuration";
            LblDuration.Size = new Size(68, 20);
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
            pnlSearchActivity.Location = new Point(20, 40);
            pnlSearchActivity.Margin = new Padding(1);
            pnlSearchActivity.Name = "pnlSearchActivity";
            pnlSearchActivity.Size = new Size(581, 591);
            pnlSearchActivity.TabIndex = 20;
            pnlSearchActivity.Paint += pnlSearcActivity_Paint;
            // 
            // chkFilterByDate
            // 
            chkFilterByDate.AutoSize = true;
            chkFilterByDate.Location = new Point(297, 135);
            chkFilterByDate.Margin = new Padding(3, 4, 3, 4);
            chkFilterByDate.Name = "chkFilterByDate";
            chkFilterByDate.Size = new Size(99, 24);
            chkFilterByDate.TabIndex = 20;
            chkFilterByDate.Text = "Brug Dato";
            chkFilterByDate.UseVisualStyleBackColor = true;
            // 
            // btnSearchGet
            // 
            btnSearchGet.Location = new Point(423, 212);
            btnSearchGet.Margin = new Padding(2, 4, 2, 4);
            btnSearchGet.Name = "btnSearchGet";
            btnSearchGet.Size = new Size(126, 31);
            btnSearchGet.TabIndex = 19;
            btnSearchGet.Text = "Vis søgeresultater";
            btnSearchGet.UseVisualStyleBackColor = true;
            btnSearchGet.Click += btnSearchGet_Click;
            // 
            // cmbSearchLocation
            // 
            cmbSearchLocation.FormattingEnabled = true;
            cmbSearchLocation.Location = new Point(102, 191);
            cmbSearchLocation.Margin = new Padding(1);
            cmbSearchLocation.Name = "cmbSearchLocation";
            cmbSearchLocation.Size = new Size(189, 28);
            cmbSearchLocation.TabIndex = 14;
            cmbSearchLocation.SelectedIndexChanged += comboBox4_SelectedIndexChanged;
            // 
            // dTPSearchDate
            // 
            dTPSearchDate.Location = new Point(102, 129);
            dTPSearchDate.Margin = new Padding(2, 4, 2, 4);
            dTPSearchDate.Name = "dTPSearchDate";
            dTPSearchDate.Size = new Size(189, 27);
            dTPSearchDate.TabIndex = 6;
            // 
            // cmbSearchActivity
            // 
            cmbSearchActivity.FormattingEnabled = true;
            cmbSearchActivity.Location = new Point(102, 73);
            cmbSearchActivity.Margin = new Padding(1);
            cmbSearchActivity.Name = "cmbSearchActivity";
            cmbSearchActivity.Size = new Size(189, 28);
            cmbSearchActivity.TabIndex = 5;
            // 
            // lstbxSearchGet
            // 
            lstbxSearchGet.FormattingEnabled = true;
            lstbxSearchGet.Location = new Point(7, 260);
            lstbxSearchGet.Margin = new Padding(1);
            lstbxSearchGet.Name = "lstbxSearchGet";
            lstbxSearchGet.Size = new Size(561, 244);
            lstbxSearchGet.TabIndex = 4;
            // 
            // lblSearchLocation
            // 
            lblSearchLocation.AutoSize = true;
            lblSearchLocation.Location = new Point(17, 195);
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
            lblSearchDate.Location = new Point(25, 129);
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
            btnActivityCreate.Location = new Point(1653, 188);
            btnActivityCreate.Margin = new Padding(7, 11, 7, 11);
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
            label3.Location = new Point(162, 4);
            label3.Margin = new Padding(1, 0, 1, 0);
            label3.Name = "label3";
            label3.Size = new Size(272, 41);
            label3.TabIndex = 17;
            label3.Text = "Holdadministration";
            // 
            // btnSearchActivity
            // 
            btnSearchActivity.Location = new Point(330, 464);
            btnSearchActivity.Margin = new Padding(2, 4, 2, 4);
            btnSearchActivity.Name = "btnSearchActivity";
            btnSearchActivity.Size = new Size(86, 31);
            btnSearchActivity.TabIndex = 18;
            btnSearchActivity.Text = "Søgning";
            btnSearchActivity.UseVisualStyleBackColor = true;
            btnSearchActivity.Click += button1_Click;
            // 
            // button4
            // 
            button4.Location = new Point(483, 464);
            button4.Margin = new Padding(2, 4, 2, 4);
            button4.Name = "button4";
            button4.Size = new Size(86, 31);
            button4.TabIndex = 19;
            button4.Text = "Tilbage";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnEditHoldType);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(cmbLocationActivity);
            panel1.Controls.Add(lblTimeActivity);
            panel1.Controls.Add(btnSearchActivity);
            panel1.Controls.Add(LblDuration);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(lblDateActivity);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(nmrUpDwnMaxPartisipant);
            panel1.Controls.Add(cmbInstructorCreateActivity);
            panel1.Controls.Add(HoldType);
            panel1.Controls.Add(dateTimePicker2);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(btnCreateActivityPanel);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 40);
            panel1.Margin = new Padding(1);
            panel1.Name = "panel1";
            panel1.Size = new Size(577, 554);
            panel1.TabIndex = 21;
            // 
            // btnEditHoldType
            // 
            btnEditHoldType.Location = new Point(117, 157);
            btnEditHoldType.Name = "btnEditHoldType";
            btnEditHoldType.Size = new Size(123, 29);
            btnEditHoldType.TabIndex = 23;
            btnEditHoldType.Text = "Opret/Rediger";
            btnEditHoldType.UseVisualStyleBackColor = true;
            btnEditHoldType.Click += btnEditHoldType_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(154, 257);
            comboBox1.Margin = new Padding(2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(373, 28);
            comboBox1.TabIndex = 20;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button3
            // 
            button3.Location = new Point(181, 464);
            button3.Margin = new Padding(7, 11, 7, 11);
            button3.Name = "button3";
            button3.Size = new Size(86, 31);
            button3.TabIndex = 18;
            button3.Text = "Annuller";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(432, 54);
            dateTimePicker1.Margin = new Padding(7, 11, 7, 11);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(118, 27);
            dateTimePicker1.TabIndex = 2;
            // 
            // cmbLocationActivity
            // 
            cmbLocationActivity.FormattingEnabled = true;
            cmbLocationActivity.Location = new Point(154, 371);
            cmbLocationActivity.Margin = new Padding(2);
            cmbLocationActivity.Name = "cmbLocationActivity";
            cmbLocationActivity.Size = new Size(156, 28);
            cmbLocationActivity.TabIndex = 13;
            // 
            // lblTimeActivity
            // 
            lblTimeActivity.AutoSize = true;
            lblTimeActivity.Location = new Point(353, 107);
            lblTimeActivity.Margin = new Padding(2, 0, 2, 0);
            lblTimeActivity.Name = "lblTimeActivity";
            lblTimeActivity.Size = new Size(33, 20);
            lblTimeActivity.TabIndex = 15;
            lblTimeActivity.Text = "Tid:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 311);
            label5.Margin = new Padding(7, 0, 7, 0);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 10;
            label5.Text = "Deltagere";
            // 
            // lblDateActivity
            // 
            lblDateActivity.AutoSize = true;
            lblDateActivity.Location = new Point(353, 54);
            lblDateActivity.Margin = new Padding(7, 0, 7, 0);
            lblDateActivity.Name = "lblDateActivity";
            lblDateActivity.Size = new Size(45, 20);
            lblDateActivity.TabIndex = 11;
            lblDateActivity.Text = "Dato:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 59);
            label4.Margin = new Padding(7, 0, 7, 0);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 9;
            label4.Text = "Lokation";
            // 
            // nmrUpDwnMaxPartisipant
            // 
            nmrUpDwnMaxPartisipant.Location = new Point(117, 311);
            nmrUpDwnMaxPartisipant.Margin = new Padding(7, 11, 7, 11);
            nmrUpDwnMaxPartisipant.Maximum = new decimal(new int[] { 25, 0, 0, 0 });
            nmrUpDwnMaxPartisipant.Name = "nmrUpDwnMaxPartisipant";
            nmrUpDwnMaxPartisipant.Size = new Size(54, 27);
            nmrUpDwnMaxPartisipant.TabIndex = 5;
            nmrUpDwnMaxPartisipant.ValueChanged += nmrUpDwnMaxPartisipant_ValueChanged;
            // 
            // cmbInstructorCreateActivity
            // 
            cmbInstructorCreateActivity.FormattingEnabled = true;
            cmbInstructorCreateActivity.Location = new Point(117, 115);
            cmbInstructorCreateActivity.Margin = new Padding(7, 11, 7, 11);
            cmbInstructorCreateActivity.Name = "cmbInstructorCreateActivity";
            cmbInstructorCreateActivity.Size = new Size(150, 28);
            cmbInstructorCreateActivity.TabIndex = 22;
            cmbInstructorCreateActivity.SelectedIndexChanged += cmbInstructorCreateActivity_SelectedIndexChanged;
            // 
            // HoldType
            // 
            HoldType.AutoSize = true;
            HoldType.Location = new Point(20, 123);
            HoldType.Margin = new Padding(7, 0, 7, 0);
            HoldType.Name = "HoldType";
            HoldType.Size = new Size(71, 20);
            HoldType.TabIndex = 6;
            HoldType.Text = "Holdtype";
            HoldType.Click += label1_Click;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "HH:mm";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(432, 100);
            dateTimePicker2.Margin = new Padding(2);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.ShowUpDown = true;
            dateTimePicker2.Size = new Size(118, 27);
            dateTimePicker2.TabIndex = 14;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(117, 55);
            comboBox2.Margin = new Padding(7, 11, 7, 11);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(156, 28);
            comboBox2.TabIndex = 1;
            // 
            // btnCreateActivityPanel
            // 
            btnCreateActivityPanel.Location = new Point(20, 455);
            btnCreateActivityPanel.Margin = new Padding(3, 4, 3, 4);
            btnCreateActivityPanel.Name = "btnCreateActivityPanel";
            btnCreateActivityPanel.Size = new Size(121, 49);
            btnCreateActivityPanel.TabIndex = 21;
            btnCreateActivityPanel.Text = "Opret hold";
            btnCreateActivityPanel.UseVisualStyleBackColor = true;
            btnCreateActivityPanel.Click += btnCreateActivityPanel_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 260);
            label2.Margin = new Padding(7, 0, 7, 0);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 7;
            label2.Text = "Instruktør";
            // 
            // pnlHoldType
            // 
            pnlHoldType.BackColor = Color.White;
            pnlHoldType.BorderStyle = BorderStyle.FixedSingle;
            pnlHoldType.Controls.Add(lblHoldTypeTitle);
            pnlHoldType.Controls.Add(btnSaveHoldType);
            pnlHoldType.Controls.Add(cmbHoldTypeInstruktor);
            pnlHoldType.Controls.Add(btnCancelHoldType);
            pnlHoldType.Controls.Add(label8);
            pnlHoldType.Controls.Add(txtHoldTypeBeskrivelse);
            pnlHoldType.Controls.Add(lblHoldTypeDescription);
            pnlHoldType.Controls.Add(txtHoldTypeName);
            pnlHoldType.Controls.Add(lblHoldTypeNavn);
            pnlHoldType.Location = new Point(620, 99);
            pnlHoldType.Name = "pnlHoldType";
            pnlHoldType.Size = new Size(392, 373);
            pnlHoldType.TabIndex = 22;
            pnlHoldType.Visible = false;
            // 
            // btnSaveHoldType
            // 
            btnSaveHoldType.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSaveHoldType.Location = new Point(60, 310);
            btnSaveHoldType.Name = "btnSaveHoldType";
            btnSaveHoldType.Size = new Size(94, 29);
            btnSaveHoldType.TabIndex = 9;
            btnSaveHoldType.Text = "Gem";
            btnSaveHoldType.UseVisualStyleBackColor = true;
            btnSaveHoldType.Click += btnSaveHoldType_Click_1;
            // 
            // cmbHoldTypeInstruktor
            // 
            cmbHoldTypeInstruktor.FormattingEnabled = true;
            cmbHoldTypeInstruktor.Location = new Point(223, 222);
            cmbHoldTypeInstruktor.Name = "cmbHoldTypeInstruktor";
            cmbHoldTypeInstruktor.Size = new Size(151, 28);
            cmbHoldTypeInstruktor.TabIndex = 8;
            cmbHoldTypeInstruktor.SelectedIndexChanged += cmbHoldTypeInstruktor_SelectedIndexChanged;
            // 
            // btnCancelHoldType
            // 
            btnCancelHoldType.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCancelHoldType.Location = new Point(258, 310);
            btnCancelHoldType.Name = "btnCancelHoldType";
            btnCancelHoldType.Size = new Size(94, 29);
            btnCancelHoldType.TabIndex = 7;
            btnCancelHoldType.Text = "Luk/Annuller";
            btnCancelHoldType.UseVisualStyleBackColor = true;
            btnCancelHoldType.Click += btnCancelHoldType_ckick;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(60, 230);
            label8.Name = "label8";
            label8.Size = new Size(71, 20);
            label8.TabIndex = 4;
            label8.Text = "Instruktør";
            label8.Click += label8_Click_1;
            // 
            // txtHoldTypeBeskrivelse
            // 
            txtHoldTypeBeskrivelse.Location = new Point(174, 116);
            txtHoldTypeBeskrivelse.Multiline = true;
            txtHoldTypeBeskrivelse.Name = "txtHoldTypeBeskrivelse";
            txtHoldTypeBeskrivelse.ScrollBars = ScrollBars.Vertical;
            txtHoldTypeBeskrivelse.Size = new Size(200, 80);
            txtHoldTypeBeskrivelse.TabIndex = 3;
            txtHoldTypeBeskrivelse.TextChanged += txtHoldTypeBeskrivelse_TextChanged;
            // 
            // lblHoldTypeDescription
            // 
            lblHoldTypeDescription.AutoSize = true;
            lblHoldTypeDescription.Location = new Point(50, 106);
            lblHoldTypeDescription.Name = "lblHoldTypeDescription";
            lblHoldTypeDescription.Size = new Size(81, 20);
            lblHoldTypeDescription.TabIndex = 2;
            lblHoldTypeDescription.Text = "Beskrivelse";
            // 
            // txtHoldTypeName
            // 
            txtHoldTypeName.Location = new Point(189, 63);
            txtHoldTypeName.Name = "txtHoldTypeName";
            txtHoldTypeName.Size = new Size(125, 27);
            txtHoldTypeName.TabIndex = 1;
            txtHoldTypeName.TextChanged += txtHoldTypeName_TextChanged;
            // 
            // lblHoldTypeNavn
            // 
            lblHoldTypeNavn.AutoSize = true;
            lblHoldTypeNavn.Location = new Point(60, 69);
            lblHoldTypeNavn.Name = "lblHoldTypeNavn";
            lblHoldTypeNavn.Size = new Size(43, 20);
            lblHoldTypeNavn.TabIndex = 0;
            lblHoldTypeNavn.Text = "Navn";
            lblHoldTypeNavn.Click += label6_Click;
            // 
            // lblHoldTypeTitle
            // 
            lblHoldTypeTitle.AutoSize = true;
            lblHoldTypeTitle.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHoldTypeTitle.Location = new Point(128, 18);
            lblHoldTypeTitle.Name = "lblHoldTypeTitle";
            lblHoldTypeTitle.Size = new Size(126, 31);
            lblHoldTypeTitle.TabIndex = 10;
            lblHoldTypeTitle.Text = "HOLDTYPE";
            // 
            // CreateActivityForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1121, 600);
            Controls.Add(pnlHoldType);
            Controls.Add(panel1);
            Controls.Add(btnActivityCreate);
            Controls.Add(label3);
            Controls.Add(pnlSearchActivity);
            Margin = new Padding(2, 4, 2, 4);
            MinimumSize = new Size(901, 488);
            Name = "CreateActivityForm";
            Text = "CreateActivityForm";
            Load += CreateActivityForm_Load;
            pnlSearchActivity.ResumeLayout(false);
            pnlSearchActivity.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmrUpDwnMaxPartisipant).EndInit();
            pnlHoldType.ResumeLayout(false);
            pnlHoldType.PerformLayout();
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
        private ComboBox cmbHoldTypeInstruktor;
        private Label label9;
        private Label label8;
        private Label lblHoldTypeDescription;
        private Label lblHoldTypeNavn;
        private ComboBox comboBox4;
        private Button btnEditHoldType;
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
        private Label HoldType;
        private DateTimePicker dateTimePicker2;
        private ComboBox comboBox2;
        private Button btnCreateActivityPanel;
        private Label label2;
        private Panel pnlHoldType;
        private TextBox txtHoldTypeBeskrivelse;
        private TextBox txtHoldTypeName;
        private Button btnCancelHoldType;
        private Button btnSaveHoldType;

        //Disse tre var problemet. Jeg tror ikke, at vi har haft fat i de samme og jeg har renamet dem? Hvis det ER de samme, burde den "bare" lave error og vi kan slette dem uden reference

        private void btnSaveHoldType_Click(object sender, EventArgs e)
        {
            // Her skriver du hvad der skal ske når man klikker
            MessageBox.Show("Gem-knappen blev trykket!");
        }
        private Label lblHoldTypeTitle;
    }
}