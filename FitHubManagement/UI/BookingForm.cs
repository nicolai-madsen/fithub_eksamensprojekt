using FitHubManagement.DataAccess;
using FitHubManagement.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FitHubManagement.UI.BookingUI
{
    public partial class BookingForm : Form
    {
        public BookingForm()
        {
            InitializeComponent();

            panel1.Visible = true;
            panel2.Visible = true;
            panel1.BringToFront();
        }

        // Panel1 Fortsæt knap
        private void button3_Click(object sender, EventArgs e)
        {
            CustomerModel selectedCustomer = GetSelectedCustomer();

            if (selectedCustomer == null)
            {
                MessageBox.Show("Vælg et medlem først.");
                return;
            }

            if (selectedCustomer.Inactive)
            {
                MessageBox.Show("Du kan ikke vælge et inaktivt medlem.");
                return;
            }

            panel1.Visible = false;
            panel2.Visible = true;
        }

        // Henter valgt medlem (virker for både navn-item og detail-item)
        private CustomerModel GetSelectedCustomer()
        {
            if (listBox1.SelectedIndex == -1)
                return null;

            if (listBox1.SelectedItem is CustomerNameItem nameItem)
                return nameItem.Customer;

            if (listBox1.SelectedItem is CustomerDetailItem detailItem)
                return detailItem.Customer;

            return listBox1.SelectedItem as CustomerModel;
        }

        // Panel1 Vis knap: vis detaljer for den valgte person
        private void button2_Click(object sender, EventArgs e)
        {
            CustomerModel selectedCustomer = GetSelectedCustomer();

            if (selectedCustomer == null)
            {
                MessageBox.Show("Vælg et medlem først.");
                return;
            }

            // Vis KUN den valgte - med detaljer
            listBox1.DataSource = null;
            listBox1.Items.Clear();
            listBox1.Items.Add(new CustomerDetailItem(selectedCustomer));
            listBox1.ClearSelected();
        }

        // Tilbage knap
        private void button1_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        // Tilbage på "find booking"
        private void button7_Click(object sender, EventArgs e)
        {
            panel1.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // TODO: tilmeld booking
        }

        // Søgning (forslag) - viser kun NAVNE mens du skriver
        private void textBox_Search_TextChanged(object sender, EventArgs e)
        {
            string name = textBox1.Text.Trim();
            string phone = textBox2.Text.Trim().Replace(" ", "");

            CustomerDAL customerDL = new CustomerDAL();
            List<CustomerModel> customers = customerDL.GetAllCustomer();

            listBox1.DataSource = null;
            listBox1.Items.Clear();

            foreach (CustomerModel customer in customers)
            {
                bool matchName =
                    name == "" ||
                    (customer.FirstName ?? "").StartsWith(name, StringComparison.OrdinalIgnoreCase) ||
                    (customer.LastName ?? "").StartsWith(name, StringComparison.OrdinalIgnoreCase);

                bool matchPhone =
                    phone == "" ||
                    (customer.Phone ?? "").Replace(" ", "").Contains(phone);

                if (matchName && matchPhone)
                {
                    // Her viser vi KUN navne som forslag
                    listBox1.Items.Add(new CustomerNameItem(customer));
                }
            }

            listBox1.ClearSelected();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox_Search_TextChanged(sender, e);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox_Search_TextChanged(sender, e);
        }

        // Nulstil knap
        public void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            listBox1.DataSource = null;
            listBox1.Items.Clear();
            textBox1.Focus();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // hold tom - ingen MessageBox her
        }

        // ---------- WRAPPERS ----------

        // Forslag mens man skriver: kun navn (+ evt inaktiv)
        private class CustomerNameItem
        {
            public CustomerModel Customer { get; }

            public CustomerNameItem(CustomerModel customer)
            {
                Customer = customer;
            }

            public override string ToString()
            {
                string status = Customer.Inactive ? " (Inaktiv)" : "";
                return $"{Customer.FirstName} {Customer.LastName}{status}";
            }
        }

        // Når man trykker "Vis": detaljer
        private class CustomerDetailItem
        {
            public CustomerModel Customer { get; }

            public CustomerDetailItem(CustomerModel customer)
            {
                Customer = customer;
            }

            public override string ToString()
            {
                string status = Customer.Inactive ? " (Inaktiv)" : "";

                return $"ID: {Customer.CustomerId} | " +
                       $"Medlem: {Customer.MembershipId} | " +
                       $"{Customer.FirstName} {Customer.LastName} | " +
                       $"Tlf: {Customer.Phone}{status}";
            }
        }
    }
}
