using System;
using System.Windows.Forms;
using System.Drawing;
using MySql.Data.MySqlClient;
using static Define;

namespace StoreDB
{
    public partial class Store_Login : Form
    {
        public Store_Login()
        {
            InitializeComponent();
        }

        private void Store_Load(object sender, EventArgs e)
        {
            pwInput.PasswordChar = '*';
            Init();
        }

        private void Init()
        {
            idInput.Text = "";
            pwInput.Text = "";
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string id = idInput.Text;
            string pw = pwInput.Text;

            DB.LoadUserInfo(id, pw, () => { Init(); });
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            Init();
            Program.registerForm.Show();
            Program.loginForm.Hide();
        }
    }
}
