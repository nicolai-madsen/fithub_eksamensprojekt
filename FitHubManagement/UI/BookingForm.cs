using FitHubManagement.DataAccess;
using FitHubManagement.Models;
using FitHubManagement.Models.FilterModels;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FitHubManagement.UI.BookingUI
{
    public partial class BookingForm : Form
    {
        // Gemmer det valgte medlem fra Panel1 til Panel2
        private CustomerModel selectedCustomer;

        // Gemmer ActivityID (det konkrete hold) valgt i listBox2
        private int selectedActivityId = -1;

        public BookingForm()
        {
            InitializeComponent();

            panel1.Visible = true;
            panel2.Visible = true;
            panel1.BringToFront();

            // (Valgfrit men smart) Fyld comboBox1 når formen åbner
            Load += BookingForm_Load;
        }

        // Fylder holdtype-combobox med navne (begynder-venligt)
        private void BookingForm_Load(object sender, EventArgs e)
        {
            try
            {
                ActivityDAL dal = new ActivityDAL();
                List<string> types = dal.GetAllActivityTypes(); // du har allerede denne metode

                comboBox1.DataSource = types;
                comboBox1.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kunne ikke hente holdtyper: " + ex.Message);
            }
        }

        // ---------------- Panel1 ----------------

        // Panel1 Fortsæt knap
        private void button3_Click(object sender, EventArgs e)
        {
            CustomerModel customer = GetSelectedCustomer();

            if (customer == null)
            {
                MessageBox.Show("Vælg et medlem først.");
                return;
            }

            if (customer.Inactive)
            {
                MessageBox.Show("Du kan ikke vælge et inaktivt medlem.");
                return;
            }

            // GEM den valgte medlem til brug i Panel2
            selectedCustomer = customer;

            panel1.Visible = false;
            panel2.Visible = true;

            // Vis den valgte medlem i Panel2 
            lbl_MedlemsNavn.Text = $"Valgt medlem: {selectedCustomer.FirstName} {selectedCustomer.LastName}"; //label navn

        }

        // Henter valgt medlem (virker for både navn-item og detail-item)
        private CustomerModel GetSelectedCustomer()
        {
            if (listBox1.SelectedIndex == -1)
                return null;

            if (listBox1.SelectedItem is CustomerNameItem nameItem)
                return nameItem.Customer;

            if (listBox1.SelectedItem is CustomerDetailItem detailItem)
                return detailItem.Customer;

            return listBox1.SelectedItem as CustomerModel;
        }

        // Panel1 Vis knap: vis detaljer for den valgte person
        private void button2_Click(object sender, EventArgs e)
        {
            CustomerModel selected = GetSelectedCustomer();

            if (selected == null)
            {
                MessageBox.Show("Vælg et medlem først.");
                return;
            }

            listBox1.DataSource = null;
            listBox1.Items.Clear();
            listBox1.Items.Add(new CustomerDetailItem(selected));
            listBox1.ClearSelected();
        }

        // Tilbage knap (lukker formen)
        private void button1_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        // Søgning (forslag) - viser kun NAVNE mens du skriver
        private void textBox_Search_TextChanged(object sender, EventArgs e)
        {
            string name = textBox1.Text.Trim();
            string phone = textBox2.Text.Trim().Replace(" ", "");

            CustomerDAL customerDL = new CustomerDAL();
            List<CustomerModel> customers = customerDL.GetAllCustomer();

            listBox1.DataSource = null;
            listBox1.Items.Clear();

            foreach (CustomerModel customer in customers)
            {
                bool matchName =
                    name == "" ||
                    (customer.FirstName ?? "").StartsWith(name, StringComparison.OrdinalIgnoreCase) ||
                    (customer.LastName ?? "").StartsWith(name, StringComparison.OrdinalIgnoreCase);

                bool matchPhone =
                    phone == "" ||
                    (customer.Phone ?? "").Replace(" ", "").Contains(phone);

                if (matchName && matchPhone)
                {
                    listBox1.Items.Add(new CustomerNameItem(customer));
                }
            }

            listBox1.ClearSelected();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) => textBox_Search_TextChanged(sender, e);
        private void textBox2_TextChanged(object sender, EventArgs e) => textBox_Search_TextChanged(sender, e);

        // Nulstil knap Panel1
        public void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            listBox1.DataSource = null;
            listBox1.Items.Clear();
            textBox1.Focus();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // hold tom - ingen MessageBox her
        }

        // ---------------- Panel2 ----------------

        // Tilbage til Panel1 (find medlem igen)
        private void button7_Click(object sender, EventArgs e)
        {
            panel1.BringToFront();
        }

        // Panel2 Vis knap: hent hold baseret på dato + holdtype
        private void button5_Click(object sender, EventArgs e)
        {
            if (selectedCustomer == null)
            {
                MessageBox.Show("Vælg et medlem først.");
                return;
            }

            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Vælg en holdtype først.");
                return;
            }

            // Læs filters fra UI
            DateOnly date = DateOnly.FromDateTime(dateTimePicker1.Value.Date);
            string activityTypeName = comboBox1.SelectedItem.ToString();

            // Byg filter model
            ActivityFilterModel filter = new ActivityFilterModel
            {
                ActivityDate = date,
                ActivityTypeName = activityTypeName
            };

            // Hent fra DAL
            ActivityDAL dal = new ActivityDAL();
            List<ActivityFilterModel> activities = dal.GetFilteredActivities(filter);

            // Vis i listBox2
            listBox2.Items.Clear();
            selectedActivityId = -1;

            if (activities.Count == 0)
            {
                MessageBox.Show("Ingen hold fundet på den valgte dato.");
                return;
            }

            foreach (var a in activities)
            {
                listBox2.Items.Add(a); // kræver at ActivityFilterModel.ToString() viser pænt
            }
        }

        // Når man vælger et hold i listBox2, gemmer vi ActivityId
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedActivityId = -1;

            if (listBox2.SelectedItem is ActivityFilterModel a)
            {
                selectedActivityId = a.ActivityId;

                int spots = BookingDAL.GetAvailableSpots(selectedActivityId);

                MessageBox.Show(
                    $"Du har valgt: {a.ActivityTypeName}\n" +
                    $"Dato: {a.ActivityDate:dd-MM-yyyy} Kl: {a.StartTime:HH\\:mm}\n" +
                    $"Ledige pladser: {spots}"
                );
            }
        }


        // Tilmeld knap i Panel2
        private void button6_Click(object sender, EventArgs e)
        {
            if (selectedCustomer == null)
            {
                MessageBox.Show("Vælg et medlem først.");
                return;
            }

            if (selectedActivityId == -1)
            {
                MessageBox.Show("Vælg et hold først.");
                return;
            }

            // AC1: Tjek ledige pladser
            int availableSpots = BookingDAL.GetAvailableSpots(selectedActivityId);

            if (availableSpots <= 0)
            {
                MessageBox.Show("Der er ikke flere ledige pladser på holdet.");
                return;
            }

            // Bekræft før vi gemmer booking (brugervenligt)
            DialogResult answer = MessageBox.Show(
                $"Der er {availableSpots} ledige pladser.\nVil du tilmelde medlemmet?",
                "Bekræft booking",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (answer != DialogResult.Yes)
            {
                return; // brugeren fortryder
            }

            // AC2: Registrer booking i databasen
            BookingDAL.CreateBooking(selectedActivityId, selectedCustomer.CustomerId, null);

            // AC3 (simpel): vis at deltagerlisten er opdateret via count
            int participants = BookingDAL.GetAllBookings()
                .FindAll(b => b.ActivityId == selectedActivityId)
                .Count;

            MessageBox.Show($"Tilmelding gennemført ✅\nDeltagere på holdet nu: {participants}");

            listBox1.Items.Clear();
           

        }


        // Ny booking knap i Panel2: nulstil Panel2
        private void button8_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Today;
            comboBox1.SelectedIndex = -1;
            listBox2.Items.Clear();
            selectedActivityId = -1;
        }

        // ComboBox ændret: ryd listen og nulstil valgt hold
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            selectedActivityId = -1;
        }

        // DateTimePicker ændret: ryd listen og nulstil valgt hold
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            selectedActivityId = -1;
        }

        // ---------------- WRAPPERS (Panel1) ----------------

        private class CustomerNameItem
        {
            public CustomerModel Customer { get; }

            public CustomerNameItem(CustomerModel customer) => Customer = customer;

            public override string ToString()
            {
                string status = Customer.Inactive ? " (Inaktiv)" : "";
                return $"{Customer.FirstName} {Customer.LastName}{status}";
            }
        }

        private class CustomerDetailItem
        {
            public CustomerModel Customer { get; }

            public CustomerDetailItem(CustomerModel customer) => Customer = customer;



            public override string ToString()
            {
                string status = Customer.Inactive ? " (Inaktiv)" : "";

                MembershipDAL membershipDAL = new MembershipDAL();
                MembershipModel membership = membershipDAL.GetMembership(Customer.MembershipId);

                string membershipName = membership != null ? membership.MembershipName : "Ukendt";

                return $"ID: {Customer.CustomerId} | " +
                       $"Medlem: {membershipName} | " +
                       $"{Customer.FirstName} {Customer.LastName} | " +
                       $"Tlf: {Customer.Phone}{status}";
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
