using FitHubManagement.BusinessLogic; //Importerer/reference til BLL
using FitHubManagement.BusinessLogic.ActivityBL;
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
using System.Reflection.Metadata.Ecma335; // ????
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitHubManagement.UI.Activity
{
    public partial class CreateActivityForm : Form
    {
        private readonly ActivityService activityService = new ActivityService(); //Et objekt bliver oprettet af klassen ActivityService, så metoder i BLL kan bruges. Readonly sikrer, at objektet aldrig ændres
        private readonly ActivityTypeService activityTypeService = new ActivityTypeService();

        public CreateActivityForm()
        {
            InitializeComponent();
            panel1.Visible = true;
            pnlSearchActivity.Visible = false;

        }

        //Panel create activity
        //---------------------------------------------MONA--------------------------------
        private List<string> locations;
        private List<string> GetAllActivityTypeNames;
        private List<ActivityTypeModel> activityType;

        private List<string> duration;
        private void CreateActivityForm_Load(object sender, EventArgs e) //Man bruger et load-event fordi UI skal hente data før brugeren har interageret

        {
            locations = activityService.GetAllLocations();

            cmbLocationActivity.DataSource = locations;
            cmbLocationActivity.SelectedIndex = -1;

            cmbSearchLocation.DataSource = locations;
            cmbSearchLocation.SelectedIndex = -1;

            activityType = activityService.GetAllActivityTypes();


            cmbSearchActivity.DataSource = activityType;
            cmbSearchActivity.SelectedIndex = -1;

            List<ActivityTypeModel> activityTypes =
                activityTypeService.GetAllActivityTypes();

            comboBox2.DisplayMember = "ActivityTypeName";
            comboBox2.ValueMember = "ActivityTypeID";
            comboBox2.DataSource = activityTypes;
            comboBox2.SelectedIndex = -1;

            label10.Text = "";


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

        private void btnSearchActivity_Click(object sender, EventArgs e)
        {
            pnlSearchActivity.Visible = true;
            panel1.Visible = false;


        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            pnlSearchActivity.Visible=false;
            panel1.Visible = true;

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

            try
            {
                ActivityTypeModel selectedType = (ActivityTypeModel)comboBox2.SelectedItem;
                int activityTypeId = selectedType.ActivityTypeId;
                int instructorId = selectedType.InstructorId;

                string activityLocation = locations[cmbLocationActivity.SelectedIndex];
                string activityDuration = duration[comboBox1.SelectedIndex];
                int maxParticipants = (int)nmrUpDwnMaxPartisipant.Value;
                DateTime startDateTime = dateTimePicker1.Value;

                ActivityModel newActivity = activityService.CreateActivity(
                        activityTypeId,
                        instructorId,
                        dateTimePicker1.Value, // StartTime, halvdelen af StartDateTime
                        duration[comboBox1.SelectedIndex],
                        locations[cmbLocationActivity.SelectedIndex],
                        (int)nmrUpDwnMaxPartisipant.Value
                );

                MessageBox.Show($"Nyt hold oprettet d. {startDateTime}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fejl: " + ex.Message);
            }
        }
        // Monas stuff goes here 



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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Vi tjekker, om der faktisk er valgt noget (index er ikke -1)
            // Og vi tjekker om SelectedValue er en int (for at undgå fejl ved opstart)
            if (comboBox2.SelectedIndex != -1 && comboBox2.SelectedValue is int selectedTypeId)
            {
                // 1. Kald metoden i din Service (som kalder DAL)
                // Her antager jeg, du har lavet metoden i Service-laget også:
                string instructorName = activityTypeService.GetCertifiedInstructor(selectedTypeId);

                // 2. Vis navnet i labelen
                // Vi tjekker for null, hvis nu databasen ikke fandt nogen
                label10.Text = instructorName ?? "Ingen instruktør fundet";
            }
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void cmbInstructorCreateActivity_SelectedIndexChanged(object sender, EventArgs e) // Sorryyy
        {

        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // Lad den være tom for nu, så fejlen forsvinder
        }

        private void lstbxSearchGet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
