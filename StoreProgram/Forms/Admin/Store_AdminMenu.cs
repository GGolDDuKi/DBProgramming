using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreDB
{
    public partial class Store_AdminMenu : Form
    {
        public Store_AdminMenu()
        {
            InitializeComponent();
        }

        private void manageItemsButton_Click(object sender, EventArgs e)
        {
            Program.adminMenuForm.Hide();
            Program.manageItemForm.Show();
        }

        private void manageUsersButton_Click(object sender, EventArgs e)
        {
            Program.adminMenuForm.Hide();
            Program.manageUsersForm.Show();
        }

        private void manageOrdersButton_Click(object sender, EventArgs e)
        {
            Program.manageOrdersForm.Show();
            Program.adminMenuForm.Hide();
        }

        private void privacySettingButton_Click(object sender, System.EventArgs e)
        {
            Program.privacySettingForm.Show();
            Program.adminMenuForm.Hide();
        }

        private void backButton_Click(object sender, System.EventArgs e)
        {
            Program.loginForm.Show();
            Program.adminMenuForm.Hide();
        }
    }
}
