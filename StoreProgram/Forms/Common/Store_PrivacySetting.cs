using MySql.Data.MySqlClient;
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
    public partial class Store_PrivacySetting : Form
    {
        public Store_PrivacySetting()
        {
            InitializeComponent();
        }

        private void Store_PrivacySetting_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void Init()
        {
            usingIdLabel.Text = $"{Program.UserInfo.ID}";
            pwInput.Text = $"{Program.UserInfo.PW}";
            confirmPwInput.Text = "";
            nameInput.Text = $"{Program.UserInfo.Name}";
            phoneNumberInput.Text = $"{Program.UserInfo.PhoneNumber}";
            addressInput.Text = $"{Program.UserInfo.Address}";
        }

        //개인 정보 변경 버튼 이벤트
        private void changeButton_Click(object sender, EventArgs e)
        {
            string pw = pwInput.Text;
            string confirmPw = confirmPwInput.Text;
            string name = nameInput.Text;
            string phoneNumber = phoneNumberInput.Text;
            string address = addressInput.Text;

            DB.ChangePrivacyInfo(pw, confirmPw, name, phoneNumber, address, () => { Init(); });
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            switch (Program.UserInfo.Authority)
            {
                case "admin":
                    Program.privacySettingForm.Hide();
                    Program.adminMenuForm.Show();
                    break;
                case "user":
                    Program.privacySettingForm.Hide();
                    Program.userMenuForm.Show();
                    break;
            }
        }
    }
}
