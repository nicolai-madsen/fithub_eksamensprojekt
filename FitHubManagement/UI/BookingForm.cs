using FitHubManagement.DataAccess;
using FitHubManagement.Models;
using FitHubManagement.DataAccess;



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

            CustomerModel selectedCustomer = GetSelectedCustomer();

            if (selectedCustomer == null)
            {
                MessageBox.Show("Vælg et medlem først.");
                return;
            }

            if (selectedCustomer.Inactive)
            {
                MessageBox.Show("Du kan ikke vælge et inaktivt medlem.");
                return;
            }

            panel1.Visible = false;
            panel2.Visible = true;
        }

        

        private CustomerModel GetSelectedCustomer() // Hent den valgte kunde fra listBox
        {
            if (listBox1.SelectedIndex == -1)
                return null;

            return (CustomerModel)listBox1.SelectedItem;
        }




        //LENA
        private void button2_Click(object sender, EventArgs e) // Panel1 Vis knap
        {

            // Tjek om der er valgt et medlem
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Vælg et medlem først.");
                return;
            }

            // Hent den valgte kunde fra listBox
            CustomerModel selectedCustomer =
                (CustomerModel)listBox1.SelectedItem;

            // Ryd listen og vis KUN den valgte kunde
            listBox1.Items.Clear();
            listBox1.Items.Add(selectedCustomer);
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

            string name = textBox1.Text;
            string phone = textBox2.Text;

            CustomerDAL customerDL = new CustomerDAL();
            List<CustomerModel> customers = customerDL.GetAllCustomer();

            listBox1.Items.Clear();

            foreach (CustomerModel customer in customers)
            {
                bool matchName =
                    name == "" ||
                    customer.FirstName.Contains(name) ||
                    customer.LastName.Contains(name);

                bool matchPhone =
                    phone == "" ||
                    customer.Phone.Contains(phone);

                if (matchName && matchPhone)
                {
                    // Vis medlemmet (aktiv eller inaktiv). INGEN MessageBox her.
                    listBox1.Items.Add(customer);
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
    

    

   







