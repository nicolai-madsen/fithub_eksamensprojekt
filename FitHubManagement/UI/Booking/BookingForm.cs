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
    public partial class BookingForm : Form
    {
        public BookingForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateBookingForm createBookingform = new CreateBookingForm();
            createBookingform.ShowDialog();
        }
    }
}
