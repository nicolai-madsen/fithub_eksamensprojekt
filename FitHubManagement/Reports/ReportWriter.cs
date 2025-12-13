using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitHubManagement.Reports
{
    internal class ReportWriter
    {
        public void WriteTxtReport(string formattedReport, string fileName)
        {
            try
            {
                // Fil placeres i "Dokumenter" og bliver navngivet {fileName}
                string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string fullPath = Path.Combine(documentsPath, fileName);

                // Brug StreamWriter til at skrive filen
                using (StreamWriter writer = new StreamWriter(fullPath, false)) // false = overskriv hvis fil findes
                {
                    writer.Write(formattedReport); // Skriv rapport til .txt fil
                }
            }
            catch (Exception ex)
            {
                // Fang fejl, vis MessageBox og log til Debug
                MessageBox.Show(
                    $"Der skete en fejl under skrivning af filen:\n{ex.Message}",
                    "Fejl",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                System.Diagnostics.Debug.WriteLine($"WriteTxtFile fejl: {ex.Message}\n{ex.StackTrace}");
            }
        }
    }
}
