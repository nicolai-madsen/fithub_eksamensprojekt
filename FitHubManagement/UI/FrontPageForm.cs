using FitHubManagement.UI.Activity;
using FitHubManagement.UI.Booking;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FitHubManagement.UI.Instructor;
using FitHubManagement.UI.CustomerUI;

namespace FitHubManagement.UI
{

    public partial class FrontPageForm : Form
    {
        public FrontPageForm()
        {
            InitializeComponent();

        }
        private void FrontPage_Load(object sender, EventArgs e)
        {

        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateActivityForm createActivityForm = new CreateActivityForm(); //Vi er enige om, at denne button bare åbner en ny form?
            createActivityForm.ShowDialog();
        }


        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            CreateInstructorForm createInstructorForm = new CreateInstructorForm();
            createInstructorForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm();
            customerForm.Owner = this;
            customerForm.ShowDialog();
        }


        /*CreateBookingForm createBookingform = new CreateBookingForm();
        createBookingform.ShowDialog();*/




    }
}

