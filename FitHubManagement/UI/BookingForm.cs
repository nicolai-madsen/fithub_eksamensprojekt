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

            // Anbefaling: brug samme TextChanged event på begge textBoxe i Designer
            // textBox1.TextChanged += textBox_Search_TextChanged;
            // textBox2.TextChanged += textBox_Search_TextChanged;
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

        // Henter valgt medlem (virker både med wrapper og uden)
        private CustomerModel GetSelectedCustomer()
        {
            if (listBox1.SelectedIndex == -1)
                return null;

            // Hvis du bruger wrapper (som vi gør), så henter vi Customer her
            if (listBox1.SelectedItem is CustomerListItem item)
                return item.Customer;

            // Hvis du en dag går tilbage til at gemme direkte CustomerModel
            return listBox1.SelectedItem as CustomerModel;
        }

        // Panel1 Vis knap: vis kun den valgte person
        private void button2_Click(object sender, EventArgs e)
        {
            CustomerModel selectedCustomer = GetSelectedCustomer();

            if (selectedCustomer == null)
            {
                MessageBox.Show("Vælg et medlem først.");
                return;
            }

            listBox1.Items.Clear();
            listBox1.Items.Add(new CustomerListItem(selectedCustomer));
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

        // Søgning (kald fra textBox1 og textBox2)

        //LENA
        private void textBox_Search_TextChanged(object sender, EventArgs e)
        {
            string name = textBox1.Text.Trim();
            string phone = textBox2.Text.Trim().Replace(" ", "");

            CustomerDAL customerDL = new CustomerDAL();
            List<CustomerModel> customers = customerDL.GetAllCustomer();

            listBox1.Items.Clear();

            foreach (CustomerModel customer in customers)
            {
                // match navn hvis name ikke er tom
                bool matchName = name == "" || (customer.FirstName ?? "").StartsWith(name, StringComparison.OrdinalIgnoreCase) || 
                    (customer.LastName ?? "").StartsWith(name, StringComparison.OrdinalIgnoreCase);


                // match telefon hvis phone ikke er tom (ignorer mellemrum)
                bool matchPhone =
                    phone == "" ||
                    (customer.Phone ?? "").Replace(" ", "").Contains(phone);

                if (matchName && matchPhone)
                {
                    // Wrapper sørger for " (Inaktiv)" i teksten uden at ændre model
                    listBox1.Items.Add(new CustomerListItem(customer));
                }
            }

            // Forhindrer auto-valg efter søgning
            listBox1.ClearSelected();
        }


        // Hvis du stadig har textBox1_TextChanged fra Designer, kan du bare kalde metoden:
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox_Search_TextChanged(sender, e);
            
        }

        // Og for textBox2 (lav denne event i Designer)
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox_Search_TextChanged(sender, e);
        }

        // Nulstil knap
        public void button4_Click(object sender, EventArgs e) //Ryd knap i Panel1
        {
            textBox1.Text = "";
            textBox2.Text = "";
            listBox1.Items.Clear();
            textBox1.Focus();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lad denne være tom - ingen MessageBox her (ellers spammer den)
        }

        // ✅ Lille wrapper-klasse: styrer visning i ListBox uden at ændre CustomerModel
        private class CustomerListItem
        {
            public CustomerModel Customer { get; }

            public CustomerListItem(CustomerModel customer)
            {
                Customer = customer;
            }

            public override string ToString()
            {
                if (Customer.Inactive)
                    return $"{Customer.FirstName} {Customer.LastName} (Inaktiv)";

                return $"{Customer.FirstName} {Customer.LastName}";
            }
        }
    }
}
