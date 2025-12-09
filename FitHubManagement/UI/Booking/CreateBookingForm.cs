using FitHubManagement.DataLogic.BookingDL;
using FitHubManagement.DataLogic.CustomerDL;
using FitHubManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitHubManagement.UI.Booking
{
    public partial class CreateBookingForm : Form
    {
        public CreateBookingForm()
        {
            InitializeComponent();
            Load += new EventHandler(BookingForm_Load);
        }

        private void BookingForm_Load(object? sender, EventArgs e)
        {
            // Insert GetAll data into comboBox1
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string activityIdInput = textBox1.Text;
            string customerIdInput = textBox2.Text;
            string personalNote = textBox3.Text;
            if (int.TryParse(activityIdInput, out int activityId) && int.TryParse(customerIdInput, out int customerId))
            {
                CreateBookingDL.CreateBooking(activityId, customerId, personalNote);
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoadCustomers()
        {
            // Hent kunder fra datalaget
            List<CustomerModel> customers = GetAllCustomerDL.GetAllCustomer(); 
        }

            // Bind til ComboBox
            private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
            {

            comboBox2.DisplayMember = "FirstName";   // det brugeren ser
            comboBox2.ValueMember = "CustomerID";   // det du bruger internt
            comboBox2.DataSource = GetAllCustomerDL.GetAllCustomer();


            }
        


        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreateBookingForm_Load(object sender, EventArgs e)
        {

        }
    }
}
