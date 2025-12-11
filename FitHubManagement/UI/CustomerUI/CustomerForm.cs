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
            panel1.Visible = true;
            panel2.Visible = true;
            panel3.Visible = true;
            panel1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //gem for "oppret medlem"
        }

        private void button6_Click(object sender, EventArgs e) //"vis liste"
        {
            panel1.Show();
            panel1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e) //"Ny medlem"
        {
            panel2.Show();
            panel2.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e) //Rediger
        {
            panel3.Show();
            panel3.BringToFront();
        }


        private void button9_Click(object sender, EventArgs e)
        {
            //denne skal klear all for "create customer"
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //anuller for rediger kunde
            this.clear();
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        #region helpers

        private void clear()
        {
            panel1.Show();
            panel2.Hide();
            panel3.Hide();
        }

        #endregion

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
