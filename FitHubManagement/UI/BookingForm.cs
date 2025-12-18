using FitHubManagement.BusinessLogic;
using FitHubManagement.Models;
using FitHubManagement.Models.FilterModels;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Net;
using System.Windows.Forms;

namespace FitHubManagement.UI.BookingUI
{
    public partial class BookingForm : Form
    {
        // Business Logic-klasse instanser
        private readonly ActivityService _activityService = new ActivityService();
        private readonly BookingService _bookingService = new BookingService();
        private readonly CustomerService _customerService = new CustomerService();
        private readonly MembershipService _membershipService = new MembershipService();

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

            // Fyld comboBox1 når formen åbner
            Load += BookingForm_Load;

            List<CustomerModel> customers = _customerService.GetAllCustomerBLL();
            listBox1.DataSource = customers;
            listBox1.DisplayMember = "DisplayText";
        }

        // Fylder holdtype-combobox med navne 
        private void BookingForm_Load(object sender, EventArgs e)
        {
            try
            {

                List<string> types = _activityService.GetAllActivityTypeNames();

                comboBox1.DataSource = types;
                comboBox1.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kunne ikke hente holdtyper: " + ex.Message);
            }

            // Ryd søgefelter
            textBox1.Text = "";
            textBox2.Text = "";

            // Sørg for at cursor står klar
            textBox1.Focus();
        }


        // ---------------- Panel1 ----------------
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox_Search_TextChanged(sender, e);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox_Search_TextChanged(sender, e);
        }

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

            string membershipName = _membershipService.GetMembershipName(selected.MembershipId);

            listBox1.DataSource = null;
            listBox1.Items.Clear();

            listBox1.Items.Add(new CustomerDetailItem(selected, membershipName));
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


            List<CustomerModel> customers = _customerService.GetAllCustomerBLL();

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



        // Nulstil knap til Panel1
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

        }

        // ---------------- Panel2 ---------------

        // Panel2 Vis knap: hent hold baseret på dato + holdtype, eller 1 af delene
        private void button5_Click(object sender, EventArgs e)
        {
            if (selectedCustomer == null)
            {
                MessageBox.Show("Vælg et medlem først.");
                return;
            }

            // Modtag værdier fra UI
            // Hvis checkboxen for dato ikke er valgt, brug 'null'
            DateOnly? filteredDate = chkFilterByDate.Checked
                ? DateOnly.FromDateTime(dateTimePicker1.Value.Date)
                : null;

            string filterType = (comboBox1.SelectedIndex != -1) 
                ? comboBox1.SelectedItem.ToString() // Null check "?", "if comboBox1.SelectedItem.ToString() = null
                : null; // use null instead

            // Validering
            if (filteredDate == null && filterType == null)
            {
                MessageBox.Show("Vælg venligst enten en dato, en holdtype eller begge dele for at søge.");
                return;
            }

            try
            {
                // Hent liste fra BLL
                List<ActivityFilterModel> activities = _bookingService.GetFilteredActivities(filteredDate, filterType);

                listBox2.Items.Clear();
                selectedActivityId = -1;

                if (activities.Count == 0)
                {
                    MessageBox.Show("Ingen hold fundet med de valgte kriterier.");
                    return;
                }

                foreach (var a in activities)
                {
                    listBox2.Items.Add(a);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Der skete en fejl under hentning af hold: " + ex.Message);
            }
        }

        // Når man vælger et hold i listBox2, gemmer vi ActivityId
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedActivityId = -1;

            if (listBox2.SelectedItem is ActivityFilterModel a)
            {
                selectedActivityId = a.ActivityId;

                int spots = _bookingService.GetAvailableSpots(selectedActivityId);

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Validering af valg i UI
            if (selectedCustomer == null || selectedActivityId == -1)
            {
                MessageBox.Show("Vælg venligst både et medlem og et hold.");
                return;
            }

            // Tjek ledige pladser via BLL metode
            int availableSpots = _bookingService.GetAvailableSpots(selectedActivityId);
            if (availableSpots <= 0)
            {
                MessageBox.Show("Holdet er fyldt. Der er ikke flere ledige pladser.");
                return;
            }

            // Max 2 bookinger pr uge for standard validering
            DateTime activityDate = _activityService.GetActivityDate(selectedActivityId);
            if (!_bookingService.CanCustomerBook(selectedCustomer.CustomerId, activityDate))
            {
                MessageBox.Show("Medlemmet har nået grænsen på 2 hold om ugen.", "Begrænsning nået", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Brugerbekræftelse
            DialogResult answer = MessageBox.Show(
                $"Der er {availableSpots} ledige pladser.\nVil du tilmelde medlemmet?",
                "Bekræft booking",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (answer != DialogResult.Yes) return;

            try
            {
                // Vi opretter bookingen. 
                _bookingService.CreateBooking(selectedActivityId, selectedCustomer.CustomerId, "");

                // Hent det opdaterede antal deltagere via BLL-metode GetParticipantCount
                int currentParticipants = _bookingService.GetParticipantCount(selectedActivityId);

                MessageBox.Show($"Tilmelding gennemført ✅\nDeltagere på holdet nu: {currentParticipants}");
            }
            catch (SqlException)
            {
                MessageBox.Show("Medlemmet er allerede tilmeldt dette hold.");
            }
        }



        // Ny booking knap i Panel2: nulstil Panel2
        private void button8_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Today; // nulstil dato
            comboBox1.SelectedIndex = -1; // nulstil holdtype
            listBox2.Items.Clear(); // ryd holdliste
            selectedActivityId = -1; // nulstil valgt hold
            panel1.Visible = true; //Vis Panel1 igen
            panel2.Visible = false; //Skjul Panel2
            panel1.BringToFront(); //Læg Panel1 øverst
            textBox1.Focus(); // fokus til søgefelt
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

            public CustomerNameItem(CustomerModel customer)
            {
                Customer = customer;
            }

            public override string ToString()
            {
                string status = Customer.Inactive ? " (Inaktiv)" : "";

                // Hvis der er tastet noget i telefon-søgning → vis telefon
                if (!string.IsNullOrWhiteSpace(Customer.Phone))
                {
                    return $"{Customer.FirstName} {Customer.LastName} – {Customer.Phone}{status}";
                }

                return $"{Customer.FirstName} {Customer.LastName}{status}";
            }
        }


        private class CustomerDetailItem
        {
            public CustomerModel Customer { get; }
            private readonly string _membershipName;

            public CustomerDetailItem(CustomerModel customer, string membershipName)
            {
                Customer = customer;
                _membershipName = membershipName;
            }

            public override string ToString()
            {
                string status = Customer.Inactive ? " (Inaktiv)" : "";

                return $"ID: {Customer.CustomerId} | " +
                       $"Medlem: {_membershipName} | " +
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

        // Checkbox til dato filter
        private void chkFilterByDate_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = chkFilterByDate.Checked;
        }
    }
}
