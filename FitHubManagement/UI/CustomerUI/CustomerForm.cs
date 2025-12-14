using FitHubManagement.BusinessLogic;
using FitHubManagement.DataLogic.ActivityDL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FitHubManagement.Models;
using System.Linq.Expressions;
using FitHubManagement.DataAccess;

namespace FitHubManagement.UI.CustomerUI
{
    public partial class CustomerForm : Form
    {
        private readonly CustomerService service = new();
        public CustomerForm()
        {
            InitializeComponent();
            ListPanel.Visible = true;
            NewCustomerPanel.Visible = true;
            EditCustomerPanel.Visible = true;
            ListPanel.BringToFront();
        }

        private void ShowListBtn_Click(object sender, EventArgs e)
        {

        }

        private void ShowBtn_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerCRUD customerDL = new CustomerCRUD();
                List<CustomerModel> customers = customerDL.GetAllCustomer();

                CustomerListBox.Items.Clear();
                CustomerListBox.Items.Add("Alle kunder");
                CustomerListBox.Items.Add("------------------------------------------------------------------");



                foreach (CustomerModel customer in customers)
                {
                    string line = $"ID: {customer.CustomerId}, Navn: {customer.FirstName} {customer.LastName} Medlems-Type: {customer.MembershipId} Inaktiv: {customer.Inactive}";

                    CustomerListBox.Items.Add(line);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Fejl med tilkobling af database");
            }
        }

        private void ShowActiveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerCRUD customerDL = new CustomerCRUD();
                List<CustomerModel> customers = customerDL.GetActiveCustomer();

                CustomerListBox.Items.Clear();
                CustomerListBox.Items.Add("Aktive kunder");
                CustomerListBox.Items.Add("------------------------------------------------------------------");


                foreach (CustomerModel customer in customers)
                {
                    string line = $"ID: {customer.CustomerId}, Navn: {customer.FirstName} {customer.LastName} Medlems-Type: {customer.MembershipId} Inaktiv: {customer.Inactive}";
                    CustomerListBox.Items.Add(line);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Fejl med tilkobling af database");
            }
        }

        private void ShowInactiveBtn_Click(object sender, EventArgs e)
        {
            try
            {

                CustomerCRUD customerDL = new CustomerCRUD();
                List<CustomerModel> customers = customerDL.GetIactiveCustomer();

                CustomerListBox.Items.Clear();
                CustomerListBox.Items.Add("Inaktive kunder");
                CustomerListBox.Items.Add("------------------------------------------------------------------");


                foreach (CustomerModel customer in customers)
                {
                    string line = $"ID: {customer.CustomerId}, Navn: {customer.FirstName} {customer.LastName} Medlems-Type: {customer.MembershipId} Inaktiv: {customer.Inactive}";
                    CustomerListBox.Items.Add(line);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Fejl med tilkobling af database");
            }
        }
 
    }
}
