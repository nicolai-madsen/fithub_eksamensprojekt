using FitHubManagement.DataAccess;
using FitHubManagement.Models;


namespace FitHubManagement.UI.BookingUI
{
    public partial class BookingForm : Form
    {
        public BookingForm()
        {
            InitializeComponent();
            panel1.Visible = true;
            panel2.Visible = true;
            panel1.BringToFront();
        }


        //LENA
        private void button3_Click(object sender, EventArgs e) //Panel1 Fortsæt knap
        {


            // 1. Tjek om der er valgt et medlem
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Vælg et medlem før du fortsætter.");
                return;
            }

            // 2. Hent det valgte medlem
            CustomerModel selectedCustomer = (CustomerModel)listBox1.SelectedItem;

            // 3. Tjek om medlemmet er inaktiv
            if (selectedCustomer.Inactive == true)
            {
                MessageBox.Show("Du kan ikke vælge et inaktivt medlem.");
                return;
            }

            // 4. Gå videre til næste panel
            panel1.Visible = false;
            panel2.Visible = true;
        }

        //LENA
        private void button2_Click(object sender, EventArgs e) // Panel1 Vis knap
        {

            // 1. Hent det, brugeren har skrevet i tekstfelterne
            string name = textBox1.Text;
            string phone = textBox2.Text;

            // 2. Ryd ListBox, så gamle resultater ikke bliver vist
            listBox1.Items.Clear();

            // 3. Opret DAL-objekt og hent alle kunder fra databasen
            CustomerDAL dal = new CustomerDAL();
            List<CustomerModel> customers = dal.GetAllCustomer();

            // 4. Gennemgå alle kunder én ad gangen
            foreach (CustomerModel customer in customers)
            {
                // 5. Lav en tekst, som skal vises i ListBox
                string text = customer.FirstName + " " + customer.LastName;

                // 6. Hvis kunden er inaktiv, så vis det i teksten
                if (customer.Inactive)
                {
                    text += " (Inaktiv)";
                }

                // 7. Tilføj teksten til ListBox
                listBox1.Items.Add(text);
            }

        }


        private void button1_Click(object sender, EventArgs e) //tilbage knap
        {
            this.Owner.Show();
            this.Close();
        }



        private void button7_Click(object sender, EventArgs e) //tilbage på "find booking", tager deg tilbage til kunde
        {
            //Skal passe på at information bliver reset
            panel1.BringToFront();
        }


        private void button6_Click(object sender, EventArgs e) //tilmeld knapp
        {
            //Skal passe på at kunde faktisk bliver gemt og lagt til, gi besked med success og fail
        }


        private void textBox1_TextChanged(object sender, EventArgs e) //Søg knap i panel1
        {

            // Henter det, brugeren har skrevet i navn-TextBoxen
            string name = textBox1.Text;

            // Henter det, brugeren har skrevet i telefon-TextBoxen
            string phone = textBox2.Text;

            // Opretter forbindelse til databasen via DAL
            CustomerDAL customerDL = new CustomerDAL();

            // Henter alle kunder fra databasen
            List<CustomerModel> customers = customerDL.GetAllCustomer();

            // Rydder listBox før nye søgeresultater vises
            listBox1.Items.Clear();

            // Gennemgår alle kunder én ad gangen
            foreach (CustomerModel customer in customers)
            {
                // Tjekker om navnet matcher (eller hvis navnefeltet er tomt)
                bool matchName =
                    name == "" ||
                    customer.FirstName.Contains(name) ||
                    customer.LastName.Contains(name);

                // Tjekker om telefonnummeret matcher (eller hvis telefonfeltet er tomt)
                bool matchPhone =
                    phone == "" ||
                    customer.Phone.Contains(phone);

                // Kunden vises kun, hvis begge betingelser er opfyldt
                if (matchName && matchPhone)
                {
                    // Viser kundens fulde navn i listBox
                    listBox1.Items.Add(customer.FirstName + " " + customer.LastName);
                }
            }
        }

        //LENA
        public void button4_Click(object sender, EventArgs e) //Nulstil knap i panel1
        {
            textBox1.Text = "";
            textBox2.Text = "";
            listBox1.Items.Clear();

            textBox1.Focus(); //Sætter fokus tilbage til navne-tekstfeltet
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            //    int index = lstCustomers.SelectedIndex;
            //    if (index == -1) return;

            //    string name = txtName.Text;
            //    string phone = txtPhone.Text;

            //    List<CustomerModel> customers = GetAllCustomerDL.SearchCustomers(name, phone);

            //    GetAllCustomer = customers[index];
            //}

            //string query = "SELECT * FROM Customer " +
            //    "WHERE (@Name = '' OR FirstName LIKE '%' + @Name + '%' OR LastName LIKE '%' + @Name + '%') " +
            //    "AND (@Phone = '' OR REPLACE(Phone, ' ', '') = REPLACE(@Phone, ' ', ''))";
        }
    }
}
    

    

   







