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
            SuspendLayout();
            // 
            // btnActiveCustomerReport
            // 
            btnActiveCustomerReport.Location = new Point(12, 96);
            btnActiveCustomerReport.Name = "btnActiveCustomerReport";
            btnActiveCustomerReport.Size = new Size(117, 23);
            btnActiveCustomerReport.TabIndex = 0;
            btnActiveCustomerReport.Text = "Aktive Medlemmer";
            btnActiveCustomerReport.UseVisualStyleBackColor = true;
            btnActiveCustomerReport.Click += btnActiveCustomerReport_Click;
            // 
            // btnPopularActivityReport
            // 
            btnPopularActivityReport.Location = new Point(12, 125);
            btnPopularActivityReport.Name = "btnPopularActivityReport";
            btnPopularActivityReport.Size = new Size(117, 23);
            btnPopularActivityReport.TabIndex = 1;
            btnPopularActivityReport.Text = "Populære Hold";
            btnPopularActivityReport.UseVisualStyleBackColor = true;
            btnPopularActivityReport.Click += btnPopularActivityReport_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // ReportsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnPopularActivityReport);
            Controls.Add(btnActiveCustomerReport);
            Name = "ReportsForm";
            Text = "ReportsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnActiveCustomerReport;
        private Button btnPopularActivityReport;
        private Label label1;
    }
}