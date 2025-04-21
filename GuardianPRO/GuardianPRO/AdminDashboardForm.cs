using System;
using System.Windows.Forms;

namespace GuardianPRO
{
    public partial class AdminDashboardForm : Form
    {
        

        public AdminDashboardForm()
        {
            InitializeComponent();
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            UserManagerForm userManagerForm = new UserManager   Form();
            userManagerForm.Show();
        }


        private void btnViewApps_Click(object sender, EventArgs e)
        {

        }

        private void btnViewLogs_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}

