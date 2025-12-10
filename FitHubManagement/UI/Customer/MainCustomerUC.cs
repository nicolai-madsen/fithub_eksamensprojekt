using FitHubManagement.BusinessLogic;
using FitHubManagement.DataLogic.CustomerDL;
using FitHubManagement.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitHubManagement.UI.Customer
{

    public partial class MainCustomerUC : UserControl
    {

        public MainCustomerUC()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)  // "Tilbake" knapp
        {
            FrontPageForm frontPageForm = this.FindForm() as FrontPageForm;
            if (frontPageForm != null)   //Sjekker om frontpage eksisterer
            {
                frontPageForm.Controls.Remove(this);   // Fjerner ALLE kontroller, siden dette er bare et panel inni front page, måske?

                foreach (Control ctrl in frontPageForm.Controls) //Loop som gjør alle controls KUN på main front page synlig
                {
                    ctrl.Visible = true;
                }

            }

        }

        private void button2_Click(object sender, EventArgs e) // "Vis" knapp
        {
            listBox1.Items.Clear();

            // Henter ALLE kunder via BLL
            List<CustomerModel> customers = GetAllCustomerDL.GetAllCustomer();

            foreach (var customer in customers)
            {
                listBox1.Items.Add(customer);
            }
        }

        private void button1_Click(object sender, EventArgs e) //Ny medlem knapp
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
