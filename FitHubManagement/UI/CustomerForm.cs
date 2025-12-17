using FitHubManagement.BusinessLogic;
using FitHubManagement.DataAccess;
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
using Microsoft.Identity.Client;

namespace FitHubManagement.UI.CustomerUI
{
    public partial class CustomerForm : Form
    {

        private readonly CustomerService service = new();  //Businesslogic lag
        public CustomerForm()
        {
            InitializeComponent();
            memberType.Items.Add("1");
            memberType.Items.Add("2");
            memberType.Items.Add("3");
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
                List<CustomerModel> customers = service.GetAllCustomerBLL();

                CustomerListBox.Items.Clear();
                CustomerListBox.Items.Add("Alle kunder");
                CustomerListBox.Items.Add("------------------------------------------------------------------");



                foreach (CustomerModel customer in customers)
                {
                    string infoLine = $"ID: {customer.CustomerId} Navn: {customer.FirstName} {customer.LastName} Telefon: {customer.Phone}";
                    CustomerListBox.Items.Add(infoLine);
                    customerCounter();
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
                List<CustomerModel> customers = service.GetActiveCustomer();

                CustomerListBox.Items.Clear();
                CustomerListBox.Items.Add("Aktive kunder");
                CustomerListBox.Items.Add("------------------------------------------------------------------");


                foreach (CustomerModel customer in customers)
                {
                    string infoLine = $"ID: {customer.CustomerId} Navn: {customer.FirstName} {customer.LastName} Telefon: {customer.Phone}";
                    CustomerListBox.Items.Add(infoLine);
                    customerCounter();
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
                List<CustomerModel> customers = service.GetInactiveCustomerBLL();

                CustomerListBox.Items.Clear();
                CustomerListBox.Items.Add("Inaktive kunder");
                CustomerListBox.Items.Add("-------------------------------------------------------------------");


                foreach (CustomerModel customer in customers)
                {
                    string infoLine = $"ID: {customer.CustomerId} Navn: {customer.FirstName} {customer.LastName} Telefon: {customer.Phone}";

                    CustomerListBox.Items.Add(infoLine);
                    customerCounter();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Fejl med tilkobling af database");
            }
        }

        private void NewCustomerCancelBtn_Click(object sender, EventArgs e)
        {
            FirstName.Clear();
            LastName.Clear();
            Email.Clear();
            Phone.Clear();
            Notes.Clear();
        }

        private void NewCustomerConfirmBtn_Click(object sender, EventArgs e)
        {
            CustomerModel customer = new CustomerModel();
            customer.FirstName = FirstName.Text;
            customer.LastName = LastName.Text;
            customer.Email = Email.Text;
            customer.Phone = Phone.Text;
            customer.MembershipId = Convert.ToInt32(memberType.SelectedItem);
            customer.Birthday = BirthdayValue.Value;
            customer.PersonalNote = Notes.Text;

            try
            {
                service.CreateCustomerBLL(customer);

                MessageBox.Show("Medlem opretted");
                FirstName.Clear();
                LastName.Clear();
                Email.Clear();
                Phone.Clear();
                Notes.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Fejl med indtasting af medlem, husket at fylde alle nødvendige felter?");
            }
        }



        #region
        public void customerCounter()
        {
            int totalItems = CustomerListBox.Items.Count;
            int totalCustomer = totalItems - 2;
            count.Text = totalCustomer.ToString();
        }
        #endregion



        private void InfoBtn_Click(object sender, EventArgs e)
        {
            string phone = PhoneText.Text;
            CustomerModel customer = service.GetIndividualCustomer(phone);
            if (customer != null)
            {
                //Kode for at gå til panel
                NameInfoTxt.Text = customer.FirstName;
                lastNameInfoTxt.Text = customer.LastName;
                emailInfoTxt.Text = customer.Email;
                phoneInfoTxt.Text = customer.Phone;
                birthdayInfoTxt.Text += customer.Birthday;
                noteInfoTxt.Text += customer.PersonalNote;
                statusInfoTxt.Text = customer.MembershipId.ToString();
                IDtxt.Text = customer.CustomerId.ToString();
                memberTypetxt.Text = customer.MembershipId.ToString();
            }
            else
            {
                MessageBox.Show("Indtast gyldig mobilnummer");
            }
        }
    }
}
