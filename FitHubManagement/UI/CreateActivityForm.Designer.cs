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
            pnlSearchActivity.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmrUpDwnMaxPartisipant).BeginInit();
            SuspendLayout();
            // 
            // LblDuration
            // 
            LblDuration.AutoSize = true;
            LblDuration.Location = new Point(133, 864);
            LblDuration.Margin = new Padding(15, 0, 15, 0);
            LblDuration.Name = "LblDuration";
            LblDuration.Size = new Size(136, 41);
            LblDuration.TabIndex = 8;
            LblDuration.Text = "Varighed";
            toolTip1.SetToolTip(LblDuration, "t = time og min = minutter. Skriv f.eks. 1 t eller 45 min");
            // 
            // pnlSearchActivity
            // 
            pnlSearchActivity.Controls.Add(panel1);
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
            pnlSearchActivity.Location = new Point(42, 82);
            pnlSearchActivity.Margin = new Padding(2, 3, 2, 3);
            pnlSearchActivity.Name = "pnlSearchActivity";
            pnlSearchActivity.Size = new Size(1234, 1212);
            pnlSearchActivity.TabIndex = 20;
            pnlSearchActivity.Paint += pnlSearcActivity_Paint;
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
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1277, 1135);
            panel1.TabIndex = 21;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(303, 441);
            comboBox1.Margin = new Padding(5);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(788, 49);
            comboBox1.TabIndex = 20;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button3
            // 
            button3.Location = new Point(855, 977);
            button3.Margin = new Padding(15, 21, 15, 21);
            button3.Name = "button3";
            button3.Size = new Size(182, 62);
            button3.TabIndex = 18;
            button3.Text = "Annuller";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(750, 112);
            dateTimePicker1.Margin = new Padding(15, 21, 15, 21);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(247, 47);
            dateTimePicker1.TabIndex = 2;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // cmbLocationActivity
            // 
            cmbLocationActivity.FormattingEnabled = true;
            cmbLocationActivity.Location = new Point(328, 856);
            cmbLocationActivity.Margin = new Padding(5);
            cmbLocationActivity.Name = "cmbLocationActivity";
            cmbLocationActivity.Size = new Size(327, 49);
            cmbLocationActivity.TabIndex = 13;
            // 
            // lblTimeActivity
            // 
            lblTimeActivity.AutoSize = true;
            lblTimeActivity.Location = new Point(632, 216);
            lblTimeActivity.Margin = new Padding(5, 0, 5, 0);
            lblTimeActivity.Name = "lblTimeActivity";
            lblTimeActivity.Size = new Size(66, 41);
            lblTimeActivity.TabIndex = 15;
            lblTimeActivity.Text = "Tid:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(71, 638);
            label5.Margin = new Padding(15, 0, 15, 0);
            label5.Name = "label5";
            label5.Size = new Size(147, 41);
            label5.TabIndex = 10;
            label5.Text = "Deltagere";
            // 
            // lblDateActivity
            // 
            lblDateActivity.AutoSize = true;
            lblDateActivity.Location = new Point(590, 20);
            lblDateActivity.Margin = new Padding(15, 0, 15, 0);
            lblDateActivity.Name = "lblDateActivity";
            lblDateActivity.Size = new Size(89, 41);
            lblDateActivity.TabIndex = 11;
            lblDateActivity.Text = "Dato:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 121);
            label4.Margin = new Padding(15, 0, 15, 0);
            label4.Name = "label4";
            label4.Size = new Size(132, 41);
            label4.TabIndex = 9;
            label4.Text = "Lokation";
            // 
            // nmrUpDwnMaxPartisipant
            // 
            nmrUpDwnMaxPartisipant.Location = new Point(248, 638);
            nmrUpDwnMaxPartisipant.Margin = new Padding(15, 21, 15, 21);
            nmrUpDwnMaxPartisipant.Maximum = new decimal(new int[] { 25, 0, 0, 0 });
            nmrUpDwnMaxPartisipant.Name = "nmrUpDwnMaxPartisipant";
            nmrUpDwnMaxPartisipant.Size = new Size(114, 47);
            nmrUpDwnMaxPartisipant.TabIndex = 5;
            nmrUpDwnMaxPartisipant.ValueChanged += nmrUpDwnMaxPartisipant_ValueChanged;
            // 
            // cmbInstructorCreateActivity
            // 
            cmbInstructorCreateActivity.FormattingEnabled = true;
            cmbInstructorCreateActivity.Location = new Point(248, 235);
            cmbInstructorCreateActivity.Margin = new Padding(15, 21, 15, 21);
            cmbInstructorCreateActivity.Name = "cmbInstructorCreateActivity";
            cmbInstructorCreateActivity.Size = new Size(315, 49);
            cmbInstructorCreateActivity.TabIndex = 22;
            cmbInstructorCreateActivity.SelectedIndexChanged += cmbInstructorCreateActivity_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 276);
            label1.Margin = new Padding(15, 0, 15, 0);
            label1.Name = "label1";
            label1.Size = new Size(141, 41);
            label1.TabIndex = 6;
            label1.Text = "Holdtype";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "HH:mm";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(750, 198);
            dateTimePicker2.Margin = new Padding(5);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.ShowUpDown = true;
            dateTimePicker2.Size = new Size(247, 47);
            dateTimePicker2.TabIndex = 14;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(248, 113);
            comboBox2.Margin = new Padding(15, 21, 15, 21);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(327, 49);
            comboBox2.TabIndex = 1;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // btnCreateActivityPanel
            // 
            btnCreateActivityPanel.Location = new Point(216, 989);
            btnCreateActivityPanel.Margin = new Padding(7, 8, 7, 8);
            btnCreateActivityPanel.Name = "btnCreateActivityPanel";
            btnCreateActivityPanel.Size = new Size(258, 100);
            btnCreateActivityPanel.TabIndex = 21;
            btnCreateActivityPanel.Text = "Opret hold";
            btnCreateActivityPanel.UseVisualStyleBackColor = true;
            btnCreateActivityPanel.Click += btnCreateActivityPanel_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(104, 462);
            label2.Margin = new Padding(15, 0, 15, 0);
            label2.Name = "label2";
            label2.Size = new Size(146, 41);
            label2.TabIndex = 7;
            label2.Text = "Instruktør";
            // 
            // chkFilterByDate
            // 
            chkFilterByDate.AutoSize = true;
            chkFilterByDate.Location = new Point(631, 276);
            chkFilterByDate.Margin = new Padding(7, 8, 7, 8);
            chkFilterByDate.Name = "chkFilterByDate";
            chkFilterByDate.Size = new Size(190, 45);
            chkFilterByDate.TabIndex = 20;
            chkFilterByDate.Text = "Brug Dato";
            chkFilterByDate.UseVisualStyleBackColor = true;
            // 
            // btnSearchGet
            // 
            btnSearchGet.Location = new Point(899, 435);
            btnSearchGet.Margin = new Padding(5, 8, 5, 8);
            btnSearchGet.Name = "btnSearchGet";
            btnSearchGet.Size = new Size(267, 62);
            btnSearchGet.TabIndex = 19;
            btnSearchGet.Text = "Vis søgeresultater";
            btnSearchGet.UseVisualStyleBackColor = true;
            btnSearchGet.Click += btnSearchGet_Click;
            // 
            // cmbSearchLocation
            // 
            cmbSearchLocation.FormattingEnabled = true;
            cmbSearchLocation.Location = new Point(216, 390);
            cmbSearchLocation.Margin = new Padding(2, 3, 2, 3);
            cmbSearchLocation.Name = "cmbSearchLocation";
            cmbSearchLocation.Size = new Size(397, 49);
            cmbSearchLocation.TabIndex = 14;
            cmbSearchLocation.SelectedIndexChanged += comboBox4_SelectedIndexChanged;
            // 
            // dTPSearchDate
            // 
            dTPSearchDate.Location = new Point(216, 266);
            dTPSearchDate.Margin = new Padding(5, 8, 5, 8);
            dTPSearchDate.Name = "dTPSearchDate";
            dTPSearchDate.Size = new Size(397, 47);
            dTPSearchDate.TabIndex = 6;
            // 
            // cmbSearchActivity
            // 
            cmbSearchActivity.FormattingEnabled = true;
            cmbSearchActivity.Location = new Point(216, 149);
            cmbSearchActivity.Margin = new Padding(2, 3, 2, 3);
            cmbSearchActivity.Name = "cmbSearchActivity";
            cmbSearchActivity.Size = new Size(397, 49);
            cmbSearchActivity.TabIndex = 5;
            // 
            // lstbxSearchGet
            // 
            lstbxSearchGet.FormattingEnabled = true;
            lstbxSearchGet.ItemHeight = 41;
            lstbxSearchGet.Location = new Point(15, 533);
            lstbxSearchGet.Margin = new Padding(2, 3, 2, 3);
            lstbxSearchGet.Name = "lstbxSearchGet";
            lstbxSearchGet.Size = new Size(1187, 496);
            lstbxSearchGet.TabIndex = 4;
            // 
            // lblSearchLocation
            // 
            lblSearchLocation.AutoSize = true;
            lblSearchLocation.Location = new Point(36, 399);
            lblSearchLocation.Margin = new Padding(2, 0, 2, 0);
            lblSearchLocation.Name = "lblSearchLocation";
            lblSearchLocation.Size = new Size(132, 41);
            lblSearchLocation.TabIndex = 3;
            lblSearchLocation.Text = "Lokation";
            lblSearchLocation.Click += label9_Click;
            // 
            // lblSearchDate
            // 
            lblSearchDate.AutoSize = true;
            lblSearchDate.Location = new Point(53, 266);
            lblSearchDate.Margin = new Padding(2, 0, 2, 0);
            lblSearchDate.Name = "lblSearchDate";
            lblSearchDate.Size = new Size(82, 41);
            lblSearchDate.TabIndex = 2;
            lblSearchDate.Text = "Dato";
            lblSearchDate.Click += label8_Click;
            // 
            // lblSearchActivity
            // 
            lblSearchActivity.AutoSize = true;
            lblSearchActivity.Location = new Point(36, 153);
            lblSearchActivity.Margin = new Padding(2, 0, 2, 0);
            lblSearchActivity.Name = "lblSearchActivity";
            lblSearchActivity.Size = new Size(141, 41);
            lblSearchActivity.TabIndex = 1;
            lblSearchActivity.Text = "Holdtype";
            // 
            // lblSearchCriteria
            // 
            lblSearchCriteria.AutoSize = true;
            lblSearchCriteria.Font = new Font("Segoe UI", 9.900001F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSearchCriteria.Location = new Point(379, 38);
            lblSearchCriteria.Margin = new Padding(2, 0, 2, 0);
            lblSearchCriteria.Name = "lblSearchCriteria";
            lblSearchCriteria.Size = new Size(438, 46);
            lblSearchCriteria.TabIndex = 0;
            lblSearchCriteria.Text = "Søg på ét eller flere kriterier";
            // 
            // btnActivityCreate
            // 
            btnActivityCreate.Location = new Point(3512, 385);
            btnActivityCreate.Margin = new Padding(15, 21, 15, 21);
            btnActivityCreate.Name = "btnActivityCreate";
            btnActivityCreate.Size = new Size(182, 62);
            btnActivityCreate.TabIndex = 17;
            btnActivityCreate.Text = "Opret";
            btnActivityCreate.UseVisualStyleBackColor = true;
            btnActivityCreate.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(345, 8);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(546, 81);
            label3.TabIndex = 17;
            label3.Text = "Holdadministration";
            // 
            // btnSearchActivity
            // 
            btnSearchActivity.Location = new Point(1462, 385);
            btnSearchActivity.Margin = new Padding(5, 8, 5, 8);
            btnSearchActivity.Name = "btnSearchActivity";
            btnSearchActivity.Size = new Size(182, 62);
            btnSearchActivity.TabIndex = 18;
            btnSearchActivity.Text = "Søgning";
            btnSearchActivity.UseVisualStyleBackColor = true;
            btnSearchActivity.Click += button1_Click;
            // 
            // button4
            // 
            button4.Location = new Point(1462, 922);
            button4.Margin = new Padding(5, 8, 5, 8);
            button4.Name = "button4";
            button4.Size = new Size(182, 62);
            button4.TabIndex = 19;
            button4.Text = "Tilbage";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // CreateActivityForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2174, 1169);
            Controls.Add(btnActivityCreate);
            Controls.Add(button4);
            Controls.Add(label3);
            Controls.Add(btnSearchActivity);
            Controls.Add(pnlSearchActivity);
            Margin = new Padding(5, 8, 5, 8);
            MinimumSize = new Size(1888, 931);
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