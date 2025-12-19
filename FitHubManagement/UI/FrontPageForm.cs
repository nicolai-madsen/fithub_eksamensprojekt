using FitHubManagement.UI.Activity;
using FitHubManagement.UI.ReportsUI;
using FitHubManagement.UI.Instructor;
using FitHubManagement.UI.CustomerUI;
using FitHubManagement.UI.BookingUI;

namespace FitHubManagement.UI
{
    // LENA / MONA
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
            ReportsForm reportsForm = new ReportsForm();
            reportsForm.ShowDialog();
        }

        private void btnBookingFront_Click(object sender, EventArgs e)
        {
            BookingForm bookingForm = new BookingForm();
            bookingForm.Owner = this;
            bookingForm.ShowDialog();
        }
    }
}

