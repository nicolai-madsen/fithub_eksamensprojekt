using FitHubManagement.BusinessLogic; //Importerer/reference til BLL
using Microsoft.IdentityModel.Tokens;
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
        private void CreateActivityForm_Load(object sender, EventArgs e) //Man bruger et load-event fordi UI skal hente data før brugeren har interageret
        {
            var location = activityService.GetAllLocations(); //Kalder til BLL 
            cmbLocationActivity.DataSource = location; //Binder data til combobox, Lokation
            cmbLocationActivity.SelectedIndex = -1; //Feltet er tomt fra start

            var locationSearch = activityService.GetAllLocations(); //Søg lokation
            cmbSearchLocation.DataSource = locationSearch;
            cmbSearchLocation.SelectedIndex = -1;

            var activityTypeNameSearch = activityService.GetAllActivityTypes(); //Holdtype
            cmbSearchActivity.DataSource = activityTypeNameSearch;
            cmbSearchActivity.SelectedIndex = -1;

            var activityTypeName = activityService.GetAllActivityTypes(); //Holdtype
            comboBox2.DataSource = activityTypeNameSearch;
            comboBox2.SelectedIndex = -1;


        }
        private bool ValidateComboBox(ComboBox cmb) //Fejlmeddelelse til álle combobox. comboBox kan være null, men må ikke være null ved oprettelse.
        {
            if (cmb.SelectedItem == null)
            {
                MessageBox.Show("Fejl! Sørg for, at alle felter er udfyldt");
                return false;
            }
            return true;
        }


        private void btnCreateActivity_Click(object sender, EventArgs e)
        {


            int maxParticipant = (int)nmrUpDwnMaxPartisipant.Value; //Læser input og konverterer numericUpDpwn til int, da det default er decimal

            //string duration = txtDuration.Text; //Læser input i textboks og konverterer til string

            string activityLocation = cmbLocationActivity.SelectedItem.ToString(); //ComboBox til string med Holdtype navn
            if (!ValidateComboBox(cmbLocationActivity)) return;

            string activityTypeName = comboBox2.SelectedItem.ToString();
            if (!ValidateComboBox(comboBox2)) return;

            DateTime chosenDate = dateTimePicker1.Value; //Gemmer den valgte dato og konverterer direkte til DateTime
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

        private void dTPSearchDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbSearchActivity_SelectedIndexChanged(object sender, EventArgs e) //Holdtype fyld combobox. Opret Hold.
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbLocationActivity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) //Viser tilknyttet instruktør
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //Panel søgning

    }
}
