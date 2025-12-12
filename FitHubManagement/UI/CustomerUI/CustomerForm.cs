using FitHubManagement.DataLogic.ActivityDL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitHubManagement.UI.CustomerUI
{
    public partial class CustomerForm : Form
    {
        public CustomerForm()  //Panel 1 = CUstomerliste, Panel 2 = ny medlem, Panel 3 = Rediger medlem
        {
            InitializeComponent();
            ListPanel.Visible = true;
            panel2.Visible = true;
            panel3.Visible = true;
            ListPanel.BringToFront();




        }

        private void button4_Click(object sender, EventArgs e)
        {
            //gem for "oppret medlem"
        }

        private void button6_Click(object sender, EventArgs e) //"vis liste"
        {
            ListPanel.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e) //"Ny medlem"
        {
            panel2.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e) //Rediger
        {
            panel3.BringToFront();

        }

        private void button3_Click(object sender, EventArgs e) //Slet
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            //denne skal klear all for "create customer"
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //anuller for rediger kunde
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //gem for rediger kunde
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            //slette denne !!!
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
