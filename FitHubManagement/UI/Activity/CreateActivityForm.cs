using FitHubManagement.BusinessLogic; //Importerer/reference til BLL
using FitHubManagement.Models;
using Microsoft.IdentityModel.Tokens;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            pnlCreateActivity.Visible = true;
            pnlSearchActivity.Visible = false;

        }

        //Panel create activity
        //---------------------------------------------MONA--------------------------------
        private List<string> locations;
        private List<string> activityType;

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

            comboBox2.DataSource = activityType;
            comboBox2.SelectedIndex = -1;
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


        private void btnCreateActivity_Click(object sender, EventArgs e)
        {
            // Valider comboboxes FØRST
            if (!ValidateComboBox(cmbLocationActivity)) return;
            if (!ValidateComboBox(comboBox2)) return;

            // NumericUpDown
            int maxParticipant = (int)nmrUpDwnMaxPartisipant.Value; // Læser input og konverterer numericUpDpwn til int, da det default er decimal

            // Location via index
            int locationIndex = cmbLocationActivity.SelectedIndex;
            string activityLocation = locations[locationIndex];

            // Activity type via index
            int activityTypeIndex = comboBox2.SelectedIndex;
            string activityTypeName = activityType[activityTypeIndex];

            // Date
            DateTime chosenDate = dateTimePicker1.Value;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnlCreateActivity.Visible = true;
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
            pnlCreateActivity.Visible = false;


        }

        private void button4_Click(object sender, EventArgs e) //Tilbageknap
        {
            this.Owner.Show();
            this.Close();
        }

        //Panel søgning

    }
}
