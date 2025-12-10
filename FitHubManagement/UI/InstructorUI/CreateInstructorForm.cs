using FitHubManagement.UI.Customer;
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
    }
}
/*            foreach (Control ctrl in this.Controls.OfType<Control>().ToList())
            {
                ctrl.Visible = false;
            }

            CreateInstructorForm instructorPage = new CreateInstructorForm();  // Panel
            this.Controls.Add(instructorPage); //Legger til alle kontroller (knapper osv)
            instructorPage.BringToFront();  //Kommer til fronten*/
