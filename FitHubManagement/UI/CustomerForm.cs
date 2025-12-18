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

        private readonly CustomerService _customerService = new(); //Businesslogic lag til customer'
        private readonly BookingService _bookingService = new();


        public CustomerForm()
        {
            InitializeComponent();
            SearchPanel.Hide();
            BookingPanel.Hide();
            EditCustomerPanel.Hide();
            NewCustomerPanel.Hide();
            ListPanel.Show();
            NewCustomerPanel.SendToBack();




            //Legger til selection i CreateCustomer
            memberType.Items.Add("1");
            memberType.Items.Add("2");
            memberType.Items.Add("3");
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
                List<CustomerModel> customers = _customerService.GetInactiveCustomerBLL();

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

        //Information fra textbox gemmes
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
        private void InfoBtn_Click(object sender, EventArgs e)
        {
            SearchPanel.Hide();
            BookingPanel.Show();
            ListPanel.Hide();
            string IdCustomer = IDinfo.Text;
            CustomerModel customer = _customerService.GetIndividualCustomer(IdCustomer);
            if (customer != null)
            {
                int customerId = int.Parse(IDinfo.Text);
                List<BookingModel> bookings = _bookingService.GetCustomerBooking(customerId);

                foreach (BookingModel booking in bookings)
                {
                    {
                        string infoLine = $"Booking ID: {booking.BookingId} Hold: {booking.ActivityId} Notat: {booking.PersonalNote}";

                        activityInfoList.Items.Add(infoLine);

                    }
                }
            }
            else
            {
                MessageBox.Show("Indtast gyldig ID");
            }

        }

        private void button3_Click(object sender, EventArgs e) //Indlaster relevant information til redigering side fra kunde
        {
            SearchPanel.Hide();
            EditCustomerPanel.Show();
            ListPanel.Hide();
            string IdCustomer = IDinfo.Text;
            CustomerModel customer = _customerService.GetIndividualCustomer(IdCustomer);
            if (customer != null)
            {
                //clear om det er nødvendig
                //kode for panel
                EditFirst.Text = customer.FirstName;
                EditLast.Text = customer.LastName;
                EditMail.Text = customer.Email;
                EditPhone.Text = customer.Phone;
                EditNote.Text = customer.PersonalNote;
                CurrentStatus.Text = customer.Inactive ? "Inactive" : "Active";
                EditType.Text = customer.MembershipId.ToString();
                EditCustomerID.Text = customer.CustomerId.ToString();

            }
            else
            {
                MessageBox.Show("Indtast gyldig ID");
            }
        }

        private void EditCustomerCancelBtn_Click(object sender, EventArgs e)
        {
            string idCustomer = IDinfo.Text;
            CustomerModel customer = _customerService.GetIndividualCustomer(idCustomer);
            EditFirst.Text = customer.FirstName;
            EditLast.Text = customer.LastName;
            EditMail.Text = customer.Email;
            EditPhone.Text = customer.Phone;
            EditNote.Text = customer.PersonalNote;
            CurrentStatus.Text = customer.Inactive ? "Inactive" : "Active";
            EditType.Text = customer.MembershipId.ToString();

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
        private void EditCustomerConfirmBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                CustomerModel customer = new CustomerModel();
                {
                    customer.CustomerId = int.Parse(EditCustomerID.Text);
                    customer.FirstName = EditFirst.Text;
                    customer.LastName = EditLast.Text;
                    customer.Email = EditMail.Text;
                    customer.Phone = EditPhone.Text;
                    customer.PersonalNote = EditNote.Text;
                    customer.MembershipId = int.Parse(EditType.Text);
                }
                _customerService.UpdateCustomer(customer);
                MessageBox.Show("Medlem redigerert");
            }
            catch (Exception)
            {
                MessageBox.Show("Fejl med redigering af medlem");
            }
        }
        private void MarkActive_Click(object sender, EventArgs e)
        {
            try
            {
                _customerService.ChangeCustomerActiveStatus(int.Parse(EditCustomerID.Text), false);


            }
            catch (Exception)
            {
                MessageBox.Show("Fejl med statusendring");
            }
        }

        private void MarkInactive_Click(object sender, EventArgs e)
        {
            try
            {
                _customerService.ChangeCustomerActiveStatus(int.Parse(EditCustomerID.Text), true);


            }
            catch (Exception)
            {
                MessageBox.Show("Fejl med statusendring");
            }
        }
        private void ShowListBtn_Click(object sender, EventArgs e)
        {
            SearchPanel.Hide();
            BookingPanel.Hide();
            EditCustomerPanel.Hide();
            NewCustomerPanel.Hide();
            ListPanel.Show();
        }

        private void NewCustomerBtn_Click(object sender, EventArgs e)
        {
            SearchPanel.Hide();
            BookingPanel.Hide();
            EditCustomerPanel.Hide();
            NewCustomerPanel.Show();
            ListPanel.Hide();
        }

        private void CustomerInfoBtn_Click(object sender, EventArgs e)
        {
            SearchPanel.Show();
            BookingPanel.Hide();
            EditCustomerPanel.Hide();
            NewCustomerPanel.Hide();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
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


