using FitHubManagement.Reports;
using FitHubManagement.DataLogic.ReportsDL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FitHubManagement.BusinessLogic.ReportProviders;
using FitHubManagement.Models.ReportModels;

namespace FitHubManagement.UI.ReportsUI
{
    public partial class ReportsForm : Form
    {
        public ReportsForm()
        {
            InitializeComponent();
        }

        private void btnPopularActivityReport_Click(object sender, EventArgs e)
        {
            try
            {
                var popularActivityReportProvider = new PopularActivityReportProvider();
                List<PopularActivityReportModel> reportData = popularActivityReportProvider.GetPopularActivities();

                var formatter = new ReportFormatter();
                string formatted = formatter.FormatPopularActivities(reportData);

                var writer = new ReportWriter();
                writer.WriteTxtReport(formatted, "Populære_Hold_Rapport.txt");

                MessageBox.Show("Rapport oprettet i Dokumenter!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fejl: {ex.Message}", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Debug.WriteLine(ex.StackTrace);
            }
        }

        private void btnActiveCustomerReport_Click(object sender, EventArgs e)
        {
            try
            {
                var activeCustomerReportProvider = new ActiveCustomerReportProvider();
                List<ActiveCustomerReportModel> reportData = activeCustomerReportProvider.GetActiveCustomers();

                var formatter = new ReportFormatter();
                string formatted = formatter.FormatActiveCustomers(reportData);

                var writer = new ReportWriter();
                writer.WriteTxtReport(formatted, "Aktive_Medlemmer_Rapport.txt");

                MessageBox.Show("Rapport oprettet i Dokumenter!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fejl: {ex.Message}", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Debug.WriteLine(ex.StackTrace);
            }
        }
    }
}
