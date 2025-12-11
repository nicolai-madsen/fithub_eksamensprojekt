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
                var popularActivities = PopularActivityReportDL.GetPopularActivities();

                var formatter = new ReportFormatter();
                string formatted = formatter.FormatPopularActivities(popularActivities);

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
                var customers = ActiveCustomerReportDL.GetAllActiveCustomer();

                var formatter = new ReportFormatter();
                string formatted = formatter.FormatActiveCustomers(customers);

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
