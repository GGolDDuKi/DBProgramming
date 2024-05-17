using System.Windows.Forms;

namespace StoreDB
{
    public partial class Store_UserMenu : Form
    {
        public Store_UserMenu()
        {
            InitializeComponent();
        }

        private void buyItemButton_Click(object sender, System.EventArgs e)
        {
            Program.buyItemsForm.Show();
            Program.userMenuForm.Hide();
        }

        private void privacySettingButton_Click(object sender, System.EventArgs e)
        {
            Program.privacySettingForm.Show();
            Program.userMenuForm.Hide();
        }

        private void backButton_Click(object sender, System.EventArgs e)
        {
            Program.loginForm.Show();
            Program.userMenuForm.Hide();
        }

        private void checkOrderButton_Click(object sender, System.EventArgs e)
        {
            Program.checkOrderForm.Show();
            Program.userMenuForm.Hide();
        }
    }
}
