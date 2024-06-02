using System;
using System.Windows.Forms;
using System.Drawing;
using MySql.Data.MySqlClient;

namespace StoreDB
{
    public partial class Store_Register : Form
    {
        public Store_Register()
        {
            InitializeComponent();
        }

        private void Store_Load(object sender, EventArgs e)
        {
            Init();
            //비밀번호 입력 시 *로 표시
            pwInput.PasswordChar = '*';
            confirmPwInput.PasswordChar = '*';
        }

        private void Init()
        {
            idInput.Text = "";
            pwInput.Text = "";
            confirmPwInput.Text = "";
            nameInput.Text = "";
            phoneNumberInput.Text = "";
            addressInput.Text = "";
        }

        //입력한 정보로 계정 생성
        private void registerButton_Click(object sender, EventArgs e)
        {
            string id = idInput.Text;
            string pw = pwInput.Text;
            string confirmPw = confirmPwInput.Text;
            string name = nameInput.Text;
            string phoneNumber = phoneNumberInput.Text;
            string address = addressInput.Text;

            DB.RegisterAccount(id, pw, confirmPw, name, phoneNumber, address, () => { Init(); });
        }

        //이전 화면으로 돌아가기
        private void cancelButton_Click(object sender, EventArgs e)
        {
            Program.registerForm.Hide();
            Program.loginForm.Show();
        }
    }
}
