using FitHubManagement.BusinessLogic;
using FitHubManagement.DataAccess;
using FitHubManagement.Models;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace FitHubManagement.UI.CustomerUI
{
    public partial class CustomerForm : Form
    {

        private readonly CustomerService _customerService = new(); //Businesslogic lag til customer'
        private readonly BookingService _bookingService = new();

        public CustomerForm()
        {
            InitializeComponent();
            BookingPanel.Hide();
            EditCustomerPanel.Hide();
            NewCustomerPanel.Hide();
            ListPanel.Show();
            NewCustomerPanel.SendToBack();

            ListPanel.Visible = true;
            NewCustomerPanel.Visible = true;
            EditCustomerPanel.Visible = true;
            ListPanel.BringToFront();
        }

        private void ShowBtn_Click(object sender, EventArgs e)
        {
            try
            {
                List<CustomerModel> customers = _customerService.GetAllCustomerBLL();

                CustomerListBox.Items.Clear();
                CustomerListBox.Items.Add("Alle kunder");
                CustomerListBox.Items.Add("------------------------------------------------------------------");



                foreach (CustomerModel customer in customers)
                {
                    CustomerListBox.Items.Add(customer); 
                    customerCounter();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Fejl med tilkobling af database, medlemmer ikke hentet.");
            }
        }

        private void ShowInactiveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                List<CustomerModel> customers = _customerService.GetInactiveCustomerBLL();

                CustomerListBox.Items.Clear();
                CustomerListBox.Items.Add("Inaktive kunder");
                CustomerListBox.Items.Add("-------------------------------------------------------------------");


                foreach (CustomerModel customer in customers)
                {
                    CustomerListBox.Items.Add(customer);
                    customerCounter();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Fejl med tilkobling af database, medlemmer ikke hentet.");
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
                _customerService.CreateCustomerBLL(customer);

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

        private void EditCustomerCancelBtn_Click(object sender, EventArgs e)
        {
            CurrentStatus.Clear();
            EditFirst.Clear();
            EditLast.Clear();
            EditMail.Clear();
            EditPhone.Clear();
            EditNote.Clear();
            EditType.Clear();
            EditCustomerPanel.Hide();
            ListPanel.Show();
        }



        private void ShowActiveBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                List<CustomerModel> customers = _customerService.GetActiveCustomer();

                CustomerListBox.Items.Clear();
                CustomerListBox.Items.Add("Aktive kunder");
                CustomerListBox.Items.Add("------------------------------------------------------------------");


                foreach (CustomerModel customer in customers)
                {
                    CustomerListBox.Items.Add(customer);
                    customerCounter();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Fejl med tilkobling af database, medlemmer ikke hentet.");
            }
        }
        private void EditCustomerConfirmBtn_Click_1(object sender, EventArgs e)
        {
            if (CustomerListBox.SelectedItem is not CustomerModel selectedCustomer)
            {
                MessageBox.Show("Vælg et medlem først.");
                return;
            }

            if (!int.TryParse(EditType.Text, out int membershipId))
            {
                MessageBox.Show("Medlemstype skal være et gyldigt tal.");
                return;
            }

            try
            {
                CustomerModel customer = new CustomerModel()
                {
                    CustomerId = selectedCustomer.CustomerId, 
                    FirstName = EditFirst.Text,
                    LastName = EditLast.Text,
                    Email = EditMail.Text,
                    Phone = EditPhone.Text,
                    PersonalNote = EditNote.Text,
                    MembershipId = membershipId
                };

                _customerService.UpdateCustomer(customer);
                MessageBox.Show("Medlem redigeret");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fejl med redigering af medlem.");
            }
        }
        private void MarkActive_Click(object sender, EventArgs e)
        {
            if (CustomerListBox.SelectedItem is not CustomerModel selectedCustomer)
            {
                MessageBox.Show("Vælg et medlem først.");
                return;
            }

            try
            {
                _customerService.ChangeCustomerActiveStatus(selectedCustomer.CustomerId, false);
                MessageBox.Show("Medlem markeret aktiv.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fejl med statusændring.");
            }
        }

        private void MarkInactive_Click(object sender, EventArgs e)
        {
            if (CustomerListBox.SelectedItem is not CustomerModel selectedCustomer)
            {
                MessageBox.Show("Vælg et medlem først.");
                return;
            }

            try
            {
                _customerService.ChangeCustomerActiveStatus(selectedCustomer.CustomerId, true);
                MessageBox.Show("Medlem markeret aktiv");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fejl med statusændring");
            }
        }
        private void ShowListBtn_Click(object sender, EventArgs e)
        {
            BookingPanel.Hide();
            EditCustomerPanel.Hide();
            NewCustomerPanel.Hide();
            ListPanel.Show();
        }

        private void NewCustomerBtn_Click(object sender, EventArgs e)
        {
            BookingPanel.Hide();
            EditCustomerPanel.Hide();
            NewCustomerPanel.Show();
            ListPanel.Hide();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }


        private void SearchBox_TextChanged(object sender, EventArgs e)
        {

            string name = SearchBox.Text.Trim();


            List<CustomerModel> customers = _customerService.GetAllCustomerBLL();

            CustomerListBox.DataSource = null;
            CustomerListBox.Items.Clear();

            foreach (CustomerModel customer in customers)
            {
                bool matchName =
                    name == "" ||
                    (customer.FirstName ?? "").StartsWith(name, StringComparison.OrdinalIgnoreCase) ||
                    (customer.LastName ?? "").StartsWith(name, StringComparison.OrdinalIgnoreCase);
                if (matchName)
                {
                    CustomerListBox.Items.Add(customer);
                }

            }
            CustomerListBox.ClearSelected();
        }

        private void EditCustomertxt_Click(object sender, EventArgs e)
        {

            int index = CustomerListBox.SelectedIndex;

            if (index >= 0)
            {
                CustomerModel customer = (CustomerModel)CustomerListBox.Items[index];

                EditFirst.Text = customer.FirstName;
                EditLast.Text = customer.LastName;
                EditMail.Text = customer.Email;
                EditPhone.Text = customer.Phone;
                EditNote.Text = customer.PersonalNote;
                CurrentStatus.Text = customer.Inactive ? "Inactive" : "Active";
                EditType.Text = customer.MembershipId.ToString();

                ListPanel.Hide();
                EditCustomerPanel.Show();
            }
            else
            {
                MessageBox.Show("Vælg en medlem");
            }
        }

        private void InfoCustomerBtn_Click(object sender, EventArgs e)
        {
            int index = CustomerListBox.SelectedIndex;

            if (index >= 0)
            {
                CustomerModel customer = (CustomerModel)CustomerListBox.Items[index];

                List<ViewBookingModel> viewBookings = _bookingService.GetSpecificCustomerBookings(customer.CustomerId);
                foreach (ViewBookingModel viewBooking in viewBookings)
                {
                    activityInfoList.Items.Add(viewBooking.DisplayInfo);
                }

                ListPanel.Hide();
                BookingPanel.Show();
            }
            else
            {
                MessageBox.Show("Vælg medlem");
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



    }

}
   



