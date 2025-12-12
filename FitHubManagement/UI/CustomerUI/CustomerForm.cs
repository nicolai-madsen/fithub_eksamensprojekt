using FitHubManagement.DataLogic.ActivityDL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitHubManagement.UI.CustomerUI
{
    public partial class CustomerForm : Form
    {
        public CustomerForm()  //Panel 1 = CUstomerliste, Panel 2 = ny medlem, Panel 3 = Rediger medlem
        {
            InitializeComponent();
            ListPanel.Visible = true;
            NewCustomerPanel.Visible = true;
            EditCustomerPanel.Visible = true;
            ListPanel.BringToFront();
        }

        private void ShowListBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
