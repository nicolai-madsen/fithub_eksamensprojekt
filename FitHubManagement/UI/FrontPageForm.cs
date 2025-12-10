using FitHubManagement.UI.Activity;
using FitHubManagement.UI.Booking;
using FitHubManagement.UI.Customer;
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

namespace FitHubManagement.UI
{

    public partial class FrontPageForm : Form
    {
        public FrontPageForm()
        {
            InitializeComponent();
            Load += new EventHandler(FrontPage_Load);
            panel1.Visible = false; //Gjemmer UC, måske det findes bedre måde at gøre det på

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


        private void button2_Click(object sender, EventArgs e) // "medlemmer" knapp
        {
            // loop som gjemmer alt som er på denne side, frontpage, siden "panel" kommer helt på toppen, så tror ikke den er helt borte, men bare usynlig.
            foreach (Control ctrl in this.Controls.OfType<Control>().ToList())
            {
                ctrl.Visible = false;
            }

            MainCustomerUC customerPage = new MainCustomerUC();  // Panel
            customerPage.Dock = DockStyle.Fill;      // den fylder hele skermen
            this.Controls.Add(customerPage); //Legger til alle kontroller (knapper osv)
            customerPage.BringToFront();  //Kommer til fronten

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.Transparent; //Gjøre panel gjennomsiktig slik at den ikke dekker FitHub sitt logo
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
           CreateInstructorForm createInstructorForm = new CreateInstructorForm();
            createInstructorForm.ShowDialog();
        }


        /*CreateBookingForm createBookingform = new CreateBookingForm();
        createBookingform.ShowDialog();*/




    }
}

