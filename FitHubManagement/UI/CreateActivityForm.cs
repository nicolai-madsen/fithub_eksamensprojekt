using FitHubManagement.BusinessLogic; //Importerer/reference til BLL
using FitHubManagement.BusinessLogic.ActivityBL;
using FitHubManagement.DataAccess;
using FitHubManagement.Models;
using FitHubManagement.Models.FilterModels;
using Microsoft.IdentityModel.Tokens;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitHubManagement.UI.Activity
{
    public partial class CreateActivityForm : Form
    {
        private readonly ActivityService activityService = new ActivityService(); //Et objekt bliver oprettet af klassen ActivityService, så metoder i BLL kan bruges. Readonly sikrer, at objektet aldrig ændres


        public CreateActivityForm()
        {
            InitializeComponent();
            panel1.Visible = true;
            pnlSearchActivity.Visible = false;

        }

        //Panel create activity
        //---------------------------------------------MONA--------------------------------
        private List<string> locations;
        private List<string> activityType;
        private List<string> duration;

        private object cmbInstructor;

        private void CreateActivityForm_Load(object sender, EventArgs e) //Man bruger et load-event fordi UI skal hente data før brugeren har interageret

        {
            InstructorDAL instructorDAL = new InstructorDAL();

            List<InstructorModel> instructors = instructorDAL.GetAllInstructors();

            cmbHoldTypeInstruktor.DataSource = instructors;
            cmbHoldTypeInstruktor.DisplayMember = "FullName";   // eller Name
            cmbHoldTypeInstruktor.ValueMember = "InstructorID";
            cmbHoldTypeInstruktor.SelectedIndex = -1;

            // resten af din eksisterende kode må gerne blive


            locations = activityService.GetAllLocations();

            cmbLocationActivity.DataSource = locations;
            cmbLocationActivity.SelectedIndex = -1;

            cmbSearchLocation.DataSource = locations;
            cmbSearchLocation.SelectedIndex = -1;

            activityType = activityService.GetAllActivityTypes();

            cmbSearchActivity.DataSource = activityType;
            cmbSearchActivity.SelectedIndex = -1;

            comboBox2.DataSource = activityType;
            comboBox2.SelectedIndex = -1;

            duration = activityService.GetAllDuration();

            comboBox1.DataSource = duration;
            comboBox1.SelectedIndex = -1;
        }

        private bool ValidateComboBox(ComboBox cmb)
        {
            if (cmb.SelectedIndex < 0)
            {
                MessageBox.Show("Fejl! Udfyld alle felter");
                return false;
            }
            return true;
        }




        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            pnlSearchActivity.Visible = false;
        }

        private void pnlSearcActivity_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e) //Holdtype i panel med createActivity
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlSearchActivity.Visible = true;
            panel1.Visible = false;


        }

        private void button4_Click(object sender, EventArgs e) //Tilbageknap
        {
            this.Owner.Show();
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nmrUpDwnMaxPartisipant_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pnlCreateActivity_Paint(object sender, PaintEventArgs e) //Knap til opret hold i panelet
        {


        }

        private void btnCreateActivityPanel_Click(object sender, EventArgs e)
        {
            // Valider comboboxes FØRST
            if (!ValidateComboBox(cmbLocationActivity)) return;
            if (!ValidateComboBox(comboBox2)) return;
            if (!ValidateComboBox(comboBox1)) return;

            // NumericUpDown
            int maxParticipant = (int)nmrUpDwnMaxPartisipant.Value; // Læser input og konverterer numericUpDpwn til int, da det default er decimal

            // Location via index
            int locationIndex = cmbLocationActivity.SelectedIndex;
            string activityLocation = locations[locationIndex];

            // Activity type via index
            int activityTypeIndex = comboBox2.SelectedIndex;
            string activityTypeName = activityType[activityTypeIndex];

            //Duration via index
            int durationIndex = comboBox1.SelectedIndex;
            string activityDuration = duration[durationIndex];

            // Date
            DateTime chosenDate = dateTimePicker1.Value;
        }

        private void cmbInstructorCreateActivity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //Panel søgning
        private void btnSearchGet_Click(object sender, EventArgs e)
        {
            // Model som indeholder filter kriterier, bruges i BL. BL Kalder DAL, som returnerer en liste af resultater, der vises i lstbxSearchGet
            var filterModel = new ActivityFilterModel
            {
                ActivityTypeName = cmbSearchActivity.SelectedItem?.ToString(),
                ActivityLocation = cmbSearchLocation.SelectedItem?.ToString()
            };

            if (chkFilterByDate.Checked) // Hvis filter by date checkboxen er "checked", så tilføjer den datoen i dtp.Value 
            {
                filterModel.ActivityDate = DateOnly.FromDateTime(dTPSearchDate.Value);
            }
            else
            {
                filterModel.ActivityDate = null;
            }



            var service = new ActivityFilterService();
            var activities = service.GetFilteredActivities(filterModel);

            lstbxSearchGet.DataSource = activities;
            MessageBox.Show($"Found {activities.Count} activities");

            // Sletter input fra combo boxes, når brugeren trykker på knappen (filter reset)
            cmbLocationActivity.SelectedItem = null;
            cmbLocationActivity.Text = "";

            cmbSearchLocation.SelectedItem = null;
            cmbSearchActivity.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void btnEditHoldType_Click(object sender, EventArgs e)
        {
            pnlHoldType.Visible = true;
            pnlHoldType.BringToFront();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCancelHoldType_ckick(object sender, EventArgs e)
        {
            pnlHoldType.Visible = false;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }



        private void txtHoldTypeName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHoldTypeBeskrivelse_TextChanged(object sender, EventArgs e)
        {

            if (txtHoldTypeBeskrivelse.Text.Length > 255)
            {
                MessageBox.Show("Beskrivelsen må max være 255 tegn");
                txtHoldTypeBeskrivelse.Text =
                    txtHoldTypeBeskrivelse.Text.Substring(0, 255);
                txtHoldTypeBeskrivelse.SelectionStart =
                    txtHoldTypeBeskrivelse.Text.Length;
            }
        }

        private void btnSaveHoldType_Click_1(object sender, EventArgs e)
        {
            // Validering: navn må ikke være tomt
            if (string.IsNullOrWhiteSpace(txtHoldTypeName.Text))
            {
                MessageBox.Show(
                    "Navn må ikke være tomt",
                    "Valideringsfejl",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtHoldTypeName.Focus(); // markér feltet
                return; // STOP – gem ikke
            }

            // ✅ Hvis vi kommer hertil, er navnet udfyldt
            // Her gemmer du data
        }

        private void cmbHoldTypeInstruktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbHoldTypeInstruktor.SelectedItem == null)
                return;

            InstructorModel selectedInstructor =
                (InstructorModel)cmbHoldTypeInstruktor.SelectedItem;

            // EKSEMPEL: hvis du vil teste
            // MessageBox.Show(selectedInstructor.FullName);
        }
    }
}
