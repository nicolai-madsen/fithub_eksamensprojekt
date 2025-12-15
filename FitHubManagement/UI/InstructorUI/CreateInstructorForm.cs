using FitHubManagement.BusinessLogic;
using FitHubManagement.DataAccess;
using FitHubManagement.Models;
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
            LoadInstructors();
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

        private void LoadInstructors()
        {
            List<InstructorModel> instructors = InstructorDAL.ReadAllInstructors();

            lstbxGetAllIns.DataSource = instructors;
            lstbxGetAllIns.DisplayMember = "FullName";  // Eller fx $"{FirstName} {LastName}" via en property
            lstbxGetAllIns.ValueMember = "InstructorID";
        }
        private void lstbxGetAllIns_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CreateInstructorForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int index = lstbxGetAllIns.SelectedIndex;

            if (index >= 0)
            {
                InstructorModel selectedInstructor = (InstructorModel)lstbxGetAllIns.Items[index];

                panel1.Visible = true;
                GetAll.Visible = false;

                txtFirstName.Text = selectedInstructor.FirstName;
                txtLastName.Text = selectedInstructor.LastName;
                txtEmail.Text = selectedInstructor.Email;
                txtPhone.Text = selectedInstructor.PhoneNumber;

                // Hent aktivitetstype via BLL
                ActivityTypeBLL activityBLL = new ActivityTypeBLL();
                ActivityTypeModel activity = activityBLL.GetActivityByInstructorID(selectedInstructor.InstructorID);

                if (activity != null)
                {
                    txtCert.Text = selectedInstructor.FirstName + " har certifikat til at undervise: " + activity.ActivityTypeName;
                }
                else
                {
                    txtCert.Text = "";
                    MessageBox.Show("Ingen aktivitetstype fundet for denne instruktør.");
                }
            }
            else
            {
                MessageBox.Show("Vælg en instruktør først.");
            }
        }

        private void btnSaveIns_Click(object sender, EventArgs e)
        {
            int index = lstbxGetAllIns.SelectedIndex;

            if (index >= 0)
            {
                InstructorModel selectedInstructor = (InstructorModel)lstbxGetAllIns.Items[index];

                // Opdater med værdier fra tekstbokse
                selectedInstructor.FirstName = txtFirstName.Text;
                selectedInstructor.LastName = txtLastName.Text;
                selectedInstructor.Email = txtEmail.Text;
                selectedInstructor.PhoneNumber = txtPhone.Text;

                // Kald BLL
                InstructorService instructorBLL = new InstructorService();
                instructorBLL.SaveInstructor(selectedInstructor);

                MessageBox.Show("Instruktør opdateret!");
                LoadInstructors();
            }
            else
            {
                MessageBox.Show("Ingen instruktør valgt.");
            }
        }
    }
}

