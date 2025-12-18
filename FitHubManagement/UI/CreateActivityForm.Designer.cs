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
            panel1 = new Panel();
            label11 = new Label();
            label10 = new Label();
            comboBox1 = new ComboBox();
            button3 = new Button();
            dateTimePicker1 = new DateTimePicker();
            cmbLocationActivity = new ComboBox();
            lblTimeActivity = new Label();
            label5 = new Label();
            lblDateActivity = new Label();
            label4 = new Label();
            nmrUpDwnMaxPartisipant = new NumericUpDown();
            label1 = new Label();
            dateTimePicker2 = new DateTimePicker();
            comboBox2 = new ComboBox();
            btnCreateActivityPanel = new Button();
            btnActivityCreate = new Button();
            label3 = new Label();
            button4 = new Button();
            button1 = new Button();
            pnlHoldType = new Panel();
            btnCancelActivityType = new Button();
            btnSaveActivityType = new Button();
            label6 = new Label();
            lblHoldTypeTitle = new Label();
            cmbHoldTypeInstruktor = new ComboBox();
            txtHoldTypeBeskrivelse = new TextBox();
            lblHoldTypeDescription = new Label();
            txtHoldTypeName = new TextBox();
            lblHoldTypeNavn = new Label();
            CreateActivityType = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmrUpDwnMaxPartisipant).BeginInit();
            pnlHoldType.SuspendLayout();
            SuspendLayout();
            // 
            // LblDuration
            // 
            LblDuration.AutoSize = true;
            LblDuration.Location = new Point(18, 159);
            LblDuration.Margin = new Padding(6, 0, 6, 0);
            LblDuration.Name = "LblDuration";
            LblDuration.Size = new Size(56, 15);
            LblDuration.TabIndex = 8;
            LblDuration.Text = "Varighed:";
            toolTip1.SetToolTip(LblDuration, "t = time og min = minutter. Skriv f.eks. 1 t eller 45 min");
            // 
            // panel1
            // 
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
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
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dateTimePicker2);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(btnCreateActivityPanel);
            panel1.Location = new Point(0, 41);
            panel1.Margin = new Padding(1);
            panel1.Name = "panel1";
            panel1.Size = new Size(526, 415);
            panel1.TabIndex = 21;
            panel1.Paint += panel1_Paint;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(18, 86);
            label11.Margin = new Padding(6, 0, 6, 0);
            label11.Name = "label11";
            label11.Size = new Size(61, 15);
            label11.TabIndex = 24;
            label11.Text = "Instruktør:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(85, 86);
            label10.Name = "label10";
            label10.Size = new Size(0, 15);
            label10.TabIndex = 23;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(79, 156);
            comboBox1.Margin = new Padding(2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(134, 23);
            comboBox1.TabIndex = 20;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button3
            // 
            button3.Location = new Point(255, 384);
            button3.Margin = new Padding(6, 8, 6, 8);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 18;
            button3.Text = "Annuller";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(334, 41);
            dateTimePicker1.Margin = new Padding(6, 8, 6, 8);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(104, 23);
            dateTimePicker1.TabIndex = 2;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // cmbLocationActivity
            // 
            cmbLocationActivity.FormattingEnabled = true;
            cmbLocationActivity.Location = new Point(79, 116);
            cmbLocationActivity.Margin = new Padding(2);
            cmbLocationActivity.Name = "cmbLocationActivity";
            cmbLocationActivity.Size = new Size(134, 23);
            cmbLocationActivity.TabIndex = 13;
            // 
            // lblTimeActivity
            // 
            lblTimeActivity.AutoSize = true;
            lblTimeActivity.Location = new Point(334, 72);
            lblTimeActivity.Margin = new Padding(2, 0, 2, 0);
            lblTimeActivity.Name = "lblTimeActivity";
            lblTimeActivity.Size = new Size(27, 15);
            lblTimeActivity.TabIndex = 15;
            lblTimeActivity.Text = "Tid:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 206);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(91, 15);
            label5.TabIndex = 10;
            label5.Text = "Antal Deltagere:";
            // 
            // lblDateActivity
            // 
            lblDateActivity.AutoSize = true;
            lblDateActivity.Location = new Point(336, 18);
            lblDateActivity.Margin = new Padding(6, 0, 6, 0);
            lblDateActivity.Name = "lblDateActivity";
            lblDateActivity.Size = new Size(35, 15);
            lblDateActivity.TabIndex = 11;
            lblDateActivity.Text = "Dato:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 119);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 9;
            label4.Text = "Lokation:";
            // 
            // nmrUpDwnMaxPartisipant
            // 
            nmrUpDwnMaxPartisipant.Location = new Point(109, 204);
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
            label1.Location = new Point(18, 44);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 6;
            label1.Text = "Holdtype:";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "HH:mm";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(334, 94);
            dateTimePicker2.Margin = new Padding(2);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.ShowUpDown = true;
            dateTimePicker2.Size = new Size(104, 23);
            dateTimePicker2.TabIndex = 14;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(79, 41);
            comboBox2.Margin = new Padding(6, 8, 6, 8);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(193, 23);
            comboBox2.TabIndex = 1;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // btnCreateActivityPanel
            // 
            btnCreateActivityPanel.Location = new Point(171, 384);
            btnCreateActivityPanel.Name = "btnCreateActivityPanel";
            btnCreateActivityPanel.Size = new Size(75, 23);
            btnCreateActivityPanel.TabIndex = 21;
            btnCreateActivityPanel.Text = "Opret hold";
            btnCreateActivityPanel.UseVisualStyleBackColor = true;
            btnCreateActivityPanel.Click += btnCreateActivityPanel_Click;
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
            label3.Font = new Font("Segoe UI", 18F);
            label3.Location = new Point(150, 8);
            label3.Margin = new Padding(1, 0, 1, 0);
            label3.Name = "label3";
            label3.Size = new Size(218, 32);
            label3.TabIndex = 17;
            label3.Text = "Holdadministration";
            // 
            // button4
            // 
            button4.Location = new Point(602, 336);
            button4.Margin = new Padding(2, 3, 2, 3);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 19;
            button4.Text = "Tilbage";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button1
            // 
            button1.Location = new Point(602, 172);
            button1.Margin = new Padding(2, 3, 2, 3);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 22;
            button1.Text = "Opret Hold";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pnlHoldType
            // 
            pnlHoldType.BackColor = Color.White;
            pnlHoldType.BorderStyle = BorderStyle.FixedSingle;
            pnlHoldType.Controls.Add(btnCancelActivityType);
            pnlHoldType.Controls.Add(btnSaveActivityType);
            pnlHoldType.Controls.Add(label6);
            pnlHoldType.Controls.Add(lblHoldTypeTitle);
            pnlHoldType.Controls.Add(cmbHoldTypeInstruktor);
            pnlHoldType.Controls.Add(txtHoldTypeBeskrivelse);
            pnlHoldType.Controls.Add(lblHoldTypeDescription);
            pnlHoldType.Controls.Add(txtHoldTypeName);
            pnlHoldType.Controls.Add(lblHoldTypeNavn);
            pnlHoldType.Location = new Point(692, 41);
            pnlHoldType.Margin = new Padding(3, 2, 3, 2);
            pnlHoldType.Name = "pnlHoldType";
            pnlHoldType.Size = new Size(343, 332);
            pnlHoldType.TabIndex = 23;
            pnlHoldType.Visible = false;
            // 
            // btnCancelActivityType
            // 
            btnCancelActivityType.Location = new Point(70, 246);
            btnCancelActivityType.Name = "btnCancelActivityType";
            btnCancelActivityType.Size = new Size(81, 26);
            btnCancelActivityType.TabIndex = 14;
            btnCancelActivityType.Text = "Annuller";
            btnCancelActivityType.UseVisualStyleBackColor = true;
            btnCancelActivityType.Click += btnCancelActivityType_Click;
            // 
            // btnSaveActivityType
            // 
            btnSaveActivityType.Location = new Point(194, 246);
            btnSaveActivityType.Name = "btnSaveActivityType";
            btnSaveActivityType.Size = new Size(81, 26);
            btnSaveActivityType.TabIndex = 13;
            btnSaveActivityType.Text = "Gem";
            btnSaveActivityType.UseVisualStyleBackColor = true;
            btnSaveActivityType.Click += btnSaveActivityType_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(44, 174);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 11;
            label6.Text = "Instruktør";
            // 
            // lblHoldTypeTitle
            // 
            lblHoldTypeTitle.AutoSize = true;
            lblHoldTypeTitle.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHoldTypeTitle.Location = new Point(112, 14);
            lblHoldTypeTitle.Name = "lblHoldTypeTitle";
            lblHoldTypeTitle.Size = new Size(104, 25);
            lblHoldTypeTitle.TabIndex = 10;
            lblHoldTypeTitle.Text = "HOLDTYPE";
            // 
            // cmbHoldTypeInstruktor
            // 
            cmbHoldTypeInstruktor.FormattingEnabled = true;
            cmbHoldTypeInstruktor.Location = new Point(152, 166);
            cmbHoldTypeInstruktor.Margin = new Padding(3, 2, 3, 2);
            cmbHoldTypeInstruktor.Name = "cmbHoldTypeInstruktor";
            cmbHoldTypeInstruktor.Size = new Size(176, 23);
            cmbHoldTypeInstruktor.TabIndex = 8;
            cmbHoldTypeInstruktor.SelectedIndexChanged += cmbHoldTypeInstruktor_SelectedIndexChanged;
            // 
            // txtHoldTypeBeskrivelse
            // 
            txtHoldTypeBeskrivelse.Location = new Point(152, 87);
            txtHoldTypeBeskrivelse.Margin = new Padding(3, 2, 3, 2);
            txtHoldTypeBeskrivelse.Multiline = true;
            txtHoldTypeBeskrivelse.Name = "txtHoldTypeBeskrivelse";
            txtHoldTypeBeskrivelse.ScrollBars = ScrollBars.Vertical;
            txtHoldTypeBeskrivelse.Size = new Size(176, 61);
            txtHoldTypeBeskrivelse.TabIndex = 3;
            // 
            // lblHoldTypeDescription
            // 
            lblHoldTypeDescription.AutoSize = true;
            lblHoldTypeDescription.Location = new Point(44, 80);
            lblHoldTypeDescription.Name = "lblHoldTypeDescription";
            lblHoldTypeDescription.Size = new Size(64, 15);
            lblHoldTypeDescription.TabIndex = 2;
            lblHoldTypeDescription.Text = "Beskrivelse";
            // 
            // txtHoldTypeName
            // 
            txtHoldTypeName.Location = new Point(165, 47);
            txtHoldTypeName.Margin = new Padding(3, 2, 3, 2);
            txtHoldTypeName.Name = "txtHoldTypeName";
            txtHoldTypeName.Size = new Size(110, 23);
            txtHoldTypeName.TabIndex = 1;
            // 
            // lblHoldTypeNavn
            // 
            lblHoldTypeNavn.AutoSize = true;
            lblHoldTypeNavn.Location = new Point(52, 52);
            lblHoldTypeNavn.Name = "lblHoldTypeNavn";
            lblHoldTypeNavn.Size = new Size(35, 15);
            lblHoldTypeNavn.TabIndex = 0;
            lblHoldTypeNavn.Text = "Navn";
            // 
            // CreateActivityType
            // 
            CreateActivityType.Location = new Point(554, 230);
            CreateActivityType.Name = "CreateActivityType";
            CreateActivityType.Size = new Size(123, 50);
            CreateActivityType.TabIndex = 24;
            CreateActivityType.Text = "Opret Holdtype";
            CreateActivityType.UseVisualStyleBackColor = true;
            CreateActivityType.Click += CreateActivityType_Click;
            // 
            // CreateActivityForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1057, 502);
            Controls.Add(CreateActivityType);
            Controls.Add(pnlHoldType);
            Controls.Add(button1);
            Controls.Add(btnActivityCreate);
            Controls.Add(button4);
            Controls.Add(label3);
            Controls.Add(panel1);
            Margin = new Padding(2, 3, 2, 3);
            MinimumSize = new Size(790, 373);
            Name = "CreateActivityForm";
            Text = "CreateActivityForm";
            Load += CreateActivityForm_Load;
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
        private Button btnActivityCreate;
        private Button button4;
        private DateTimePicker dateTimePicker3;
        private ComboBox comboBox3;
        private ComboBox cmbInstructorCreateActivity;
        private ListBox lstboxSearchGet;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private ComboBox comboBox4;
        private Button btnSaveActivityType;
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
        private Label label1;
        private DateTimePicker dateTimePicker2;
        private ComboBox comboBox2;
        private Button btnCreateActivityPanel;
        private Label label11;
        private Label label10;
        private Button button1;
        private Panel pnlHoldType;
        private Label lblHoldTypeTitle;
        private ComboBox cmbHoldTypeInstruktor;
        private TextBox txtHoldTypeBeskrivelse;
        private Label lblHoldTypeDescription;
        private TextBox txtHoldTypeName;
        private Label lblHoldTypeNavn;
        private Button btnCancelActivityType;
        private Button CreateActivityType;

        //Disse tre var problemet. Jeg tror ikke, at vi har haft fat i de samme og jeg har renamet dem? Hvis det ER de samme, burde den "bare" lave error og vi kan slette dem uden reference

    }
}