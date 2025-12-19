namespace FitHubManagement.UI.ReportsUI
{
    partial class ReportsForm
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
            btnActiveCustomerReport = new Button();
            btnPopularActivityReport = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // btnActiveCustomerReport
            // 
            btnActiveCustomerReport.Location = new Point(67, 135);
            btnActiveCustomerReport.Name = "btnActiveCustomerReport";
            btnActiveCustomerReport.Size = new Size(130, 23);
            btnActiveCustomerReport.TabIndex = 0;
            btnActiveCustomerReport.Text = "Aktive Medlemmer";
            btnActiveCustomerReport.UseVisualStyleBackColor = true;
            btnActiveCustomerReport.Click += btnActiveCustomerReport_Click;
            // 
            // btnPopularActivityReport
            // 
            btnPopularActivityReport.Location = new Point(67, 200);
            btnPopularActivityReport.Name = "btnPopularActivityReport";
            btnPopularActivityReport.Size = new Size(130, 23);
            btnPopularActivityReport.TabIndex = 1;
            btnPopularActivityReport.Text = "Populære Hold";
            btnPopularActivityReport.UseVisualStyleBackColor = true;
            btnPopularActivityReport.Click += btnPopularActivityReport_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(99, 25);
            label1.TabIndex = 2;
            label1.Text = "Rapporter";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 46);
            label2.Name = "label2";
            label2.Size = new Size(117, 15);
            label2.TabIndex = 3;
            label2.Text = "Vælg en rapport type";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 391);
            label3.Name = "label3";
            label3.Size = new Size(333, 15);
            label3.TabIndex = 4;
            label3.Text = "* Rapporter bliver udskrevet mappen: Rapporter i Dokumenter";
            // 
            // button1
            // 
            button1.Location = new Point(697, 415);
            button1.Name = "button1";
            button1.Size = new Size(91, 23);
            button1.TabIndex = 5;
            button1.Text = "Tilbage";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 139);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 6;
            label4.Text = "Udskriv:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 204);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 7;
            label5.Text = "Udskriv:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 426);
            label6.Name = "label6";
            label6.Size = new Size(214, 15);
            label6.TabIndex = 8;
            label6.Text = "* Rapporter erstatter automatisk kopier.";
            // 
            // ReportsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnPopularActivityReport);
            Controls.Add(btnActiveCustomerReport);
            Name = "ReportsForm";
            Text = "ReportsForm";
            Load += ReportsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnActiveCustomerReport;
        private Button btnPopularActivityReport;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}