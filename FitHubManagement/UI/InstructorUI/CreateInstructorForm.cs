using FitHubManagement.DataLogic.ActivityTypeDL;
using FitHubManagement.DataLogic.InstructorDL;
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
            List<InstructorModel> instructors = GetAllInstructorDL.ReadAllInstructors();

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
            // Hent den valgte instruktør fra listen
            var selectedInstructor = lstbxGetAllIns.SelectedItem as InstructorModel;

            if (selectedInstructor != null)
            {
                // Vis panel og skjul liste
                panel1.Visible = true;
                GetAll.Visible = false;

                // Sæt navn i tekstboksen
                txtFirstName.Text = selectedInstructor.FirstName;
                txtLastName.Text = selectedInstructor.LastName;
                txtEmail.Text = selectedInstructor.Email;
                txtPhone.Text = selectedInstructor.PhoneNumber;

                // Hent aktivitetstype baseret på InstructorID
                var activity = GetAllActivityTypeDL.ReadActivityByInstructorID(selectedInstructor.InstructorID);

                if (activity != null)
                {
                    // Fx vis certifikat i en label eller textbox
                    txtCert.Text = selectedInstructor.FirstName + "Er godkendt til at undervise: " + activity.ActivityTypeName;
                }
                else
                {
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
            var selectedInstructor = lstbxGetAllIns.SelectedItem as InstructorModel;

            if (selectedInstructor != null)
            {
                // Opdater modellen med nye værdier fra UI
                selectedInstructor.FirstName = txtFirstName.Text;
                selectedInstructor.LastName = txtLastName.Text;
                selectedInstructor.Email = txtEmail.Text;
                selectedInstructor.PhoneNumber = txtPhone.Text;

                // Gem i databasen via DAL
                UpdateInstructorDL.UpdateInstructor(selectedInstructor);

                MessageBox.Show("Instruktør opdateret!");

                // Genindlæs listen så ændringerne vises
                LoadInstructors();
            }
            else
            {
                MessageBox.Show("Ingen instruktør valgt.");
            }

        }
    }
}

