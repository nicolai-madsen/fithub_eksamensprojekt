using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitHubManagement.UI.Instructor
{
    public partial class CreateInstructorForm : Form
    {
        public CreateInstructorForm()
        {
            InitializeComponent();
            panel1.Visible = true;
            GetAll.Visible = false;

        }

        private void FirstNameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void OpretInsLabel_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            GetAll.Visible = true;
            panel1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            GetAll.Visible = false;
        }

        private void GetAll_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LastNameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBackToFront_Click(object sender, EventArgs e) //Tilbageknap fra Instruktør-form til frontpage
        {


            this.Owner.Show();  // vis forsideform igen
            this.Close();       // luk instruktør-formentPage.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

