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
            comboBox1.Items.Add("Anders Andersen");
            comboBox1.Items.Add("Birgitte Jensen");
            comboBox1.Items.Add("Carl Nielsen");
            comboBox1.Items.Add("Dorte Hansen");
            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;

        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActivityForm activityForm = new ActivityForm();
            activityForm.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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
        
        
            /*CreateBookingForm createBookingform = new CreateBookingForm();
            createBookingform.ShowDialog();*/



        
    }
}

