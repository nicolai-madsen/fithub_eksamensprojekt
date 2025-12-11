using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void button3_Click(object sender, EventArgs e) //fortset fra kunde knapp
        {
            // skal i tilleg tilføge noget som passer på at det faktisk er gemt information for næeste steg for at gå videre
            panel2.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //tilbage
        {
            this.Owner.Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e) //tilbage på "find booking", tager deg tilbage til kunde
        {
            //Skal passe på at information bliver reset
            panel1.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e) //tilmeld knapp
        {
            //Skal passe på at kunde faktisk bliver gemt og lagt til, gi besked med success og fail
        }
    }
}
