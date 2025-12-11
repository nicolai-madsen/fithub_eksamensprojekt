using FitHubManagement.UI.Activity;
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


        private void button1_Click(object sender, EventArgs e) //Hold
        {
            CreateActivityForm createActivityForm = new CreateActivityForm(); //ilbageknap på frontpage
            createActivityForm.Owner = this;
            createActivityForm.ShowDialog();
        }


        private void button5_Click(object sender, EventArgs e) //Personale
        {
            CreateInstructorForm createInstructorForm = new CreateInstructorForm();
            createInstructorForm.Owner = this; // Bruges til tilbage-knap
            createInstructorForm.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm();
            customerForm.Owner = this;
            customerForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e) //Rapport
        {

        }

        private void btnBookingFront_Click(object sender, EventArgs e)
        {
           
        }
    }
}

