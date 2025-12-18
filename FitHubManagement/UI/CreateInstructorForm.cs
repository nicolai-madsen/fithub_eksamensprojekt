using FitHubManagement.BusinessLogic;
using FitHubManagement.DataAccess;
using FitHubManagement.BusinessLogic.ActivityBL;
using FitHubManagement.Models;
using FitHubManagement.Models.FilterModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FitHubManagement.UI.Instructor
{
    public partial class CreateInstructorForm : Form
    {


        public CreateInstructorForm()
        {
            InitializeComponent();
            LoadInstructors();
            GetAll.Visible = true;
            panel1.Visible = false;
            pnlSearchActivity.Visible = false;
            newInstructorpanel.Visible = false;
        }

        private void FirstNameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void OpretInsLabel_Click(object sender, EventArgs e)
        {

        }

        private void GetAllPanel()
        {
            GetAll.Visible = true;
            panel1.Visible = false;
            pnlSearchActivity.Visible = false;
            newInstructorpanel.Visible = false;
            LoadInstructors();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            GetAllPanel();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            newInstructorpanel.Visible = true;
            pnlSearchActivity.Visible = false;
            GetAll.Visible = false;
            panel1.Visible = false;

        }
        private void savenewInstructor_Click(object sender, EventArgs e)
        {
            CreateNewInstructorWithActivityBLL NewInstructor = new CreateNewInstructorWithActivityBLL();

            try
            {
                NewInstructor.CreateInstructorWithActivity(
                    newtxtFirstName.Text,
                    newtxtLastName.Text,
                    newtxtEmail.Text,
                    newtxtPhone.Text,
                    newtxtActivityName.Text,
                    newtxtActivityDescription.Text
                );

                MessageBox.Show("Instruktør og aktivitet oprettet!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fejl: " + ex.Message);
            }
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
            LoadInstructor bll = new LoadInstructor();
            List<InstructorModel> instructors = bll.Instructors();

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
                ActivityTypeModel activity = activityBLL.GetActivityByInstructorID(selectedInstructor.InstructorId);
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

        private void btnShowCustomerBooking_Click(object sender, EventArgs e)
        {
            pnlSearchActivity.Visible = true;
            panel1.Visible = false;
            GetAll.Visible = false;

        }






        private void LoadInstructorsComboBox() //Laver en metode til at fylde en combobox
        {
            LoadInstructor bll = new LoadInstructor();
            List<InstructorModel> instructors = bll.Instructors();

            // Opret en tom instruktør som placeholder
            InstructorModel emptyInstructor = new InstructorModel //"Tom" instruktør, altså en tom plads i comboboxen
            {
                InstructorId = -1,
                FirstName = "-- Alle instruktører --",
                LastName = ""
            };

            instructors.Insert(0, emptyInstructor); //Indsætter det tomme felt øverst i comboboxen
            cmbShowInstructors.DataSource = instructors;
            cmbShowInstructors.DisplayMember = "FullName";
            cmbShowInstructors.ValueMember = "InstructorID";
            cmbShowInstructors.SelectedIndex = -1; //Gør at comboboxen er tom fra start
            cmbShowInstructors.SelectedIndex = 0; // Standard = Alle instruktører


            dTPSearchDate.Enabled = false; // Sæt DateTimePicker til inaktiv som standard
            chkFilterByDate.Checked = false;
        }

        private void CreateInstructorForm_Load(object sender, EventArgs e) //Formload, der fylder comboboxes
        {
            LoadInstructorsComboBox();
        }




        private void chkFilterByDate_CheckedChanged(object sender, EventArgs e) //DateTimePicker er inaktiv/grå, når checkboxen ikke er krydset af
        {
            dTPSearchDate.Enabled = chkFilterByDate.Checked;
        }

        private void btnSearchGet_Click(object sender, EventArgs e)
        {


            int? instructorID = null; //Da det er en filtrering må begge parametre gerne være nullable
            DateOnly? activityDate = null;


            if (cmbShowInstructors.SelectedIndex > 0) // Tjek om der er valgt en instruktør
            {
                InstructorModel selectedInstructor = (InstructorModel)cmbShowInstructors.SelectedItem;
                if (selectedInstructor.InstructorId != -1)
                {
                    instructorID = selectedInstructor.InstructorId;
                }
            }

            // Tjek om dato-filter er aktiveret
            if (chkFilterByDate.Checked)
            {
                activityDate = DateOnly.FromDateTime(dTPSearchDate.Value);
            }
            // Linje 266 i din form:
            InstructorService instructorService = new InstructorService();
            List<ActivityFilterModel> activities = instructorService.GetFilteredActivities(instructorID, activityDate);

            // Clear listBox1 og vis hold
            listBox1.DataSource = activities;
            listBox1.DisplayMember = "DisplayInfo";

            // Nulstil label når vi viser hold igen
            lblBookingCount.Text = $"Antal hold: {activities.Count}";

        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            listBox1.DisplayMember = "DisplayInfo";

        }



        private void button2_Click_1(object sender, EventArgs e)


        {

            if (listBox1.SelectedItem == null) // Tjek om der er valgt/markeret et hold i listboxen
            {
                MessageBox.Show("Vælg venligst et hold først.");
                return;
            }



            if (listBox1.SelectedItem is ActivityFilterModel selectedActivity)
            {
                // Hent bookinger for aktivitet
                BookingService bookingService = new BookingService();
                var bookings = bookingService.GetBookingsByActivityID(selectedActivity.ActivityId);
                listBox1.DataSource = bookings;
                listBox1.DisplayMember = "DisplayInfo";
                lblBookingCount.Text = $"Antal tilmeldinger: {bookings.Count}";
            }
            else
            {
                MessageBox.Show("Vælg venligst et hold først.");
            }
        }



        private void ClearTextBoxes()
        {
            newtxtFirstName.Text = "";
            newtxtLastName.Text = "";
            newtxtEmail.Text = "";
            newtxtPhone.Text = "";
            newtxtActivityName.Text = "";
            newtxtActivityDescription.Text = "";
        }

        private void ClearAlltxtPanel1()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
            

        }
        private void btnCancelCreateIns_Click(object sender, EventArgs e)
        {
            GetAllPanel();
            ClearAlltxtPanel1();

        }


        private void button3_Click(object sender, EventArgs e)
        {
            pnlSearchActivity.Visible = true;
            GetAll.Visible = false;
            panel1.Visible = false;
            newInstructorpanel.Visible = false;
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }
    }
}



