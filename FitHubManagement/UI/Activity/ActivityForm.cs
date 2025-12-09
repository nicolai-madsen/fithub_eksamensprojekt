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
    public partial class ActivityForm : Form
    {
        public ActivityForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateActivityForm createActivityForm = new CreateActivityForm(); //Vi er enige om, at denne button bare åbner en ny form?
            createActivityForm.ShowDialog();
        }
    }
}
