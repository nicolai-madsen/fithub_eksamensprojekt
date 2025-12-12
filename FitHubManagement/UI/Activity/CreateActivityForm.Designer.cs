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
            btnCreateActivity = new Button();
            toolTip1 = new ToolTip(components);
            cmbLocationActivity = new ComboBox();
            dateTimePicker2 = new DateTimePicker();
            lblTimeActivity = new Label();
            pnlCreateActivity = new Panel();
            textBox1 = new TextBox();
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
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)nmrUpDwnMaxPartisipant).BeginInit();
            pnlCreateActivity.SuspendLayout();
            pnlSearchActivity.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(198, 205);
            comboBox2.Margin = new Padding(6, 8, 6, 8);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(327, 49);
            comboBox2.TabIndex = 1;
            comboBox2.SelectedIndex = -1;


            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(784, 201);
            dateTimePicker1.Margin = new Padding(6, 8, 6, 8);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(246, 47);
            dateTimePicker1.TabIndex = 2;
            // 
            // nmrUpDwnMaxPartisipant
            // 
            nmrUpDwnMaxPartisipant.Location = new Point(198, 652);
            nmrUpDwnMaxPartisipant.Margin = new Padding(6, 8, 6, 8);
            nmrUpDwnMaxPartisipant.Name = "nmrUpDwnMaxPartisipant";
            nmrUpDwnMaxPartisipant.Size = new Size(115, 47);
            nmrUpDwnMaxPartisipant.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 205);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(141, 41);
            label1.TabIndex = 6;
            label1.Text = "Holdtype";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 314);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(146, 41);
            label2.TabIndex = 7;
            label2.Text = "Instruktør";
            // 
            // LblDuration
            // 
            LblDuration.AutoSize = true;
            LblDuration.Location = new Point(23, 535);
            LblDuration.Margin = new Padding(6, 0, 6, 0);
            LblDuration.Name = "LblDuration";
            LblDuration.Size = new Size(136, 41);
            LblDuration.TabIndex = 8;
            LblDuration.Text = "Varighed";
            toolTip1.SetToolTip(LblDuration, "t = time og min = minutter. Skriv f.eks. 1 t eller 45 min");
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 428);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(132, 41);
            label4.TabIndex = 9;
            label4.Text = "Lokation";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 654);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(147, 41);
            label5.TabIndex = 10;
            label5.Text = "Deltagere";
            // 
            // lblDateActivity
            // 
            lblDateActivity.AutoSize = true;
            lblDateActivity.Location = new Point(680, 205);
            lblDateActivity.Margin = new Padding(6, 0, 6, 0);
            lblDateActivity.Name = "lblDateActivity";
            lblDateActivity.Size = new Size(89, 41);
            lblDateActivity.TabIndex = 11;
            lblDateActivity.Text = "Dato:";
            // 
            // btnCreateActivity
            // 
            btnCreateActivity.Location = new Point(287, 920);
            btnCreateActivity.Margin = new Padding(6, 8, 6, 8);
            btnCreateActivity.Name = "btnCreateActivity";
            btnCreateActivity.Size = new Size(183, 64);
            btnCreateActivity.TabIndex = 12;
            btnCreateActivity.Text = "Opret";
            btnCreateActivity.UseVisualStyleBackColor = true;
            btnCreateActivity.Click += btnCreateActivity_Click;
            // 
            // cmbLocationActivity
            // 
            cmbLocationActivity.FormattingEnabled = true;
            cmbLocationActivity.Location = new Point(198, 424);
            cmbLocationActivity.Margin = new Padding(2);
            cmbLocationActivity.Name = "cmbLocationActivity";
            cmbLocationActivity.Size = new Size(327, 49);
            cmbLocationActivity.TabIndex = 13;
            cmbLocationActivity.SelectedIndex = -1;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "HH:mm";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(784, 275);
            dateTimePicker2.Margin = new Padding(2);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.ShowUpDown = true;
            dateTimePicker2.Size = new Size(246, 47);
            dateTimePicker2.TabIndex = 14;
            // 
            // lblTimeActivity
            // 
            lblTimeActivity.AutoSize = true;
            lblTimeActivity.Location = new Point(680, 283);
            lblTimeActivity.Margin = new Padding(2, 0, 2, 0);
            lblTimeActivity.Name = "lblTimeActivity";
            lblTimeActivity.Size = new Size(66, 41);
            lblTimeActivity.TabIndex = 15;
            lblTimeActivity.Text = "Tid:";
            // 
            // pnlCreateActivity
            // 
            pnlCreateActivity.Controls.Add(comboBox1);
            pnlCreateActivity.Controls.Add(textBox1);
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
            pnlCreateActivity.Controls.Add(label2);
            pnlCreateActivity.Controls.Add(label1);
            pnlCreateActivity.Location = new Point(0, 0);
            pnlCreateActivity.Margin = new Padding(2);
            pnlCreateActivity.Name = "pnlCreateActivity";
            pnlCreateActivity.Size = new Size(1235, 1095);
            pnlCreateActivity.TabIndex = 16;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(198, 324);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(327, 47);
            textBox1.TabIndex = 19;
            textBox1.Text += textBox1.Text;
            // 
            // button3
            // 
            button3.Location = new Point(635, 920);
            button3.Margin = new Padding(6, 8, 6, 8);
            button3.Name = "button3";
            button3.Size = new Size(183, 64);
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
            pnlSearchActivity.Margin = new Padding(2);
            pnlSearchActivity.Name = "pnlSearchActivity";
            pnlSearchActivity.Size = new Size(1194, 1013);
            pnlSearchActivity.TabIndex = 20;
            pnlSearchActivity.Paint += pnlSearcActivity_Paint;
            // 
            // btnSearchGet
            // 
            btnSearchGet.Location = new Point(899, 435);
            btnSearchGet.Margin = new Padding(6, 8, 6, 8);
            btnSearchGet.Name = "btnSearchGet";
            btnSearchGet.Size = new Size(268, 64);
            btnSearchGet.TabIndex = 19;
            btnSearchGet.Text = "Vis søgeresultater";
            btnSearchGet.UseVisualStyleBackColor = true;
            btnSearchGet.Click += button1_Click;
            // 
            // cmbSearchLocation
            // 
            cmbSearchLocation.FormattingEnabled = true;
            cmbSearchLocation.Location = new Point(215, 390);
            cmbSearchLocation.Margin = new Padding(2);
            cmbSearchLocation.Name = "cmbSearchLocation";
            cmbSearchLocation.Size = new Size(397, 49);
            cmbSearchLocation.TabIndex = 14;
            cmbSearchLocation.SelectedIndexChanged += comboBox4_SelectedIndexChanged;
            // 
            // dTPSearchDate
            // 
            dTPSearchDate.Location = new Point(215, 266);
            dTPSearchDate.Margin = new Padding(6, 8, 6, 8);
            dTPSearchDate.Name = "dTPSearchDate";
            dTPSearchDate.Size = new Size(397, 47);
            dTPSearchDate.TabIndex = 6;
            
            // 
            // cmbSearchActivity
            // 
            cmbSearchActivity.FormattingEnabled = true;
            cmbSearchActivity.Location = new Point(215, 150);
            cmbSearchActivity.Margin = new Padding(2);
            cmbSearchActivity.Name = "cmbSearchActivity";
            cmbSearchActivity.Size = new Size(397, 49);
            cmbSearchActivity.TabIndex = 5;
            cmbSearchActivity.SelectedIndex = -1;
            // 
            // lstbxSearchGet
            // 
            lstbxSearchGet.FormattingEnabled = true;
            lstbxSearchGet.ItemHeight = 41;
            lstbxSearchGet.Location = new Point(15, 533);
            lstbxSearchGet.Margin = new Padding(2);
            lstbxSearchGet.Name = "lstbxSearchGet";
            lstbxSearchGet.Size = new Size(1186, 496);
            lstbxSearchGet.TabIndex = 4;
            // 
            // lblSearchLocation
            // 
            lblSearchLocation.AutoSize = true;
            lblSearchLocation.Location = new Point(36, 398);
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
            lblSearchActivity.Location = new Point(36, 154);
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
            lblSearchCriteria.Location = new Point(378, 39);
            lblSearchCriteria.Margin = new Padding(2, 0, 2, 0);
            lblSearchCriteria.Name = "lblSearchCriteria";
            lblSearchCriteria.Size = new Size(438, 46);
            lblSearchCriteria.TabIndex = 0;
            lblSearchCriteria.Text = "Søg på ét eller flere kriterier";
            // 
            // btnActivityCreate
            // 
            btnActivityCreate.Location = new Point(1462, 262);
            btnActivityCreate.Margin = new Padding(6, 8, 6, 8);
            btnActivityCreate.Name = "btnActivityCreate";
            btnActivityCreate.Size = new Size(183, 64);
            btnActivityCreate.TabIndex = 17;
            btnActivityCreate.Text = "Opret";
            btnActivityCreate.UseVisualStyleBackColor = true;
            btnActivityCreate.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(346, 8);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(546, 81);
            label3.TabIndex = 17;
            label3.Text = "Holdadministration";
            // 
            // btnSearchActivity
            // 
            btnSearchActivity.Location = new Point(1462, 385);
            btnSearchActivity.Margin = new Padding(6, 8, 6, 8);
            btnSearchActivity.Name = "btnSearchActivity";
            btnSearchActivity.Size = new Size(183, 64);
            btnSearchActivity.TabIndex = 18;
            btnSearchActivity.Text = "Søgning";
            btnSearchActivity.UseVisualStyleBackColor = true;
            btnSearchActivity.Click += button1_Click;
            // 
            // button4
            // 
            button4.Location = new Point(1462, 1013);
            button4.Margin = new Padding(6, 8, 6, 8);
            button4.Name = "button4";
            button4.Size = new Size(183, 64);
            button4.TabIndex = 19;
            button4.Text = "Tilbage";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(198, 527);
            comboBox1.Margin = new Padding(2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(327, 49);
            comboBox1.TabIndex = 20;
            comboBox1.SelectedIndex = -1;
            // 
            // CreateActivityForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1893, 1050);
            Controls.Add(pnlCreateActivity);
            Controls.Add(button4);
            Controls.Add(btnSearchActivity);
            Controls.Add(btnActivityCreate);
            Controls.Add(label3);
            Controls.Add(pnlSearchActivity);
            Margin = new Padding(6, 8, 6, 8);
            MaximumSize = new Size(1925, 1138);
            MinimumSize = new Size(1925, 1138);
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
        private TextBox textBox1;
        private ComboBox comboBox1;

        //Disse tre var problemet. Jeg tror ikke, at vi har haft fat i de samme og jeg har renamet dem? Hvis det ER de samme, burde den "bare" lave error og vi kan slette dem uden reference

    }
}