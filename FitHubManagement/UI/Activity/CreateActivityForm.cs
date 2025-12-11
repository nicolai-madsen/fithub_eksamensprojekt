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
            cmbLocationActivity.DataSource = location; //Binder data til combobox
            cmbLocationActivity.SelectedIndex = -1; //Feltet er tomt fra start
        }


        private void btnCreateActivity_Click(object sender, EventArgs e)
        {


            int maxParticipant = (int)nmrUpDwnMaxPartisipant.Value; //Læser input og konverterer numericUpDpwn til int, da det default er decimal

            //string duration = txtDuration.Text; //Læser input i textboks og konverterer til string

            if (cmbLocationActivity.SelectedItem == null) //comboBox kan være null, men må ikke være null ved oprettelse. Derfor checkes og udsendes fejlmeddelelse hvis tomt.
            {
                MessageBox.Show("Vælg venligst en lokation");
                return;
            }

            string activityLocation = cmbLocationActivity.SelectedItem.ToString();

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

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
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
