using FitHubManagement.BusinessLogic; //Importerer/reference til BLL
using FitHubManagement.Models;

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
            LoadInstructors();

        }

        //Panel create activity
        //---------------------------------------------MONA--------------------------------
        private List<string> locations;
        private List<string> GetAllActivityTypeNames;
        private List<ActivityTypeModel> activityType;

        private List<string> duration;

        private void LoadActivityTypes()
        {
            activityType = activityService.GetAllActivityTypes();
            comboBox2.DataSource = null;
            comboBox2.DisplayMember = "ActivityTypeName";
            comboBox2.ValueMember = "ActivityTypeId";
            comboBox2.DataSource = activityType;
            comboBox2.SelectedIndex = -1;
        }
        private void LoadInstructors()
        {
            LoadInstructor bll = new LoadInstructor();
            List<InstructorModel> instructors = bll.Instructors();

            cmbHoldTypeInstruktor.DataSource = instructors;
            cmbHoldTypeInstruktor.DisplayMember = "FullName";  // Eller fx $"{FirstName} {LastName}" via en property
            cmbHoldTypeInstruktor.ValueMember = "InstructorId";
        }

        private void CreateActivityForm_Load(object sender, EventArgs e) //Man bruger et load-event fordi UI skal hente data før brugeren har interageret

        {
            locations = activityService.GetAllLocations();

            cmbLocationActivity.DataSource = locations;
            cmbLocationActivity.SelectedIndex = -1;

            LoadActivityTypes();


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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadActivityTypes();
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
                label10.Text = instructorName ?? "Ingen instruktør fundet"; //Men hvorfor, da en holdtype SKAL have tilknyttet en instruktør?
            }
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // Lad den være tom for nu, så fejlen forsvinder
        }

        private void btnSaveActivityType_Click(object sender, EventArgs e)
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

            // Hent valgt instruktør fra ComboBox
            if (cmbHoldTypeInstruktor.SelectedItem is not InstructorModel selectedInstructor)
            {
                MessageBox.Show("Du skal vælge en instruktør", "Valideringsfejl",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Opret model med data fra UI
            ActivityTypeModel model = new ActivityTypeModel
            {
                InstructorId = selectedInstructor.InstructorId,
                ActivityTypeName = txtHoldTypeName.Text,
                ActivityTypeDescription = txtHoldTypeBeskrivelse.Text
            };

            // Kald BLL for at gemme
            ActivityTypeBLL1 bll = new ActivityTypeBLL1();
            try
            {
                bll.CreateActivityType(model);
                MessageBox.Show("Holdtype gemt!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Ryd felter efter gemning
                txtHoldTypeName.Text = "";
                txtHoldTypeBeskrivelse.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fejl under gemning: {ex.Message}", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CreateActivityType_Click(object sender, EventArgs e)
        {
            LoadInstructor bll = new LoadInstructor();
            List<InstructorModel> instructors = bll.Instructors();

            cmbHoldTypeInstruktor.DataSource = instructors;
            cmbHoldTypeInstruktor.DisplayMember = "FullName";
            cmbHoldTypeInstruktor.ValueMember = "InstructorId";

            pnlHoldType.Visible = true;
        }

        private void cmbHoldTypeInstruktor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelActivityType_Click(object sender, EventArgs e)
        {
            txtHoldTypeName.Clear();
            txtHoldTypeBeskrivelse.Clear();
            pnlHoldType.Visible = false;
        }
    }
}
