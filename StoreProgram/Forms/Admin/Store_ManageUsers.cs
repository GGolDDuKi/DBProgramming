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
    public partial class Store_ManageUsers : Form
    {
		string selectedId = "";

        public Store_ManageUsers()
        {
            InitializeComponent();
			this.userListView.SelectedIndexChanged += userListView_SelectedIndexChanged;
		}

		private void Store_ManageUsers_VisibleChanged(object sender, EventArgs e)
		{
			if (this.Visible)
			{
				UpdateTable();
				Init();
			}
		}

		private void userListView_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (userListView.SelectedItems.Count > 0)
			{
				ListViewItem selectedUser = userListView.SelectedItems[0];
				selectedId = selectedUser.SubItems[0].Text;
			}
		}

		private void changeAuthButton_Click(object sender, EventArgs e)
		{
			if (selectedId == "")
			{
				MessageBox.Show("선택된 유저가 없습니다.");
				return;
			}

			try
			{
				using (MySqlConnection mysql = new MySqlConnection(Program.connectionString))
				{
					mysql.Open();

					string query = $"SELECT authority FROM accounttbl WHERE id = '{selectedId}'";
					MySqlCommand cmd = new MySqlCommand(query, mysql);
					string authority = (string)cmd.ExecuteScalar();

					switch (authority)
					{
						case "admin":
							authority = "user";
							break;
						case "user":
							authority = "admin";
							break;
					}
					query = $"UPDATE accounttbl SET authority='{authority}' WHERE id='{selectedId}';";

					MySqlCommand command = new MySqlCommand(query, mysql);
					if (command.ExecuteNonQuery() != 1)
						MessageBox.Show("유저 권한 변경에 실패하였습니다.");
					else
						MessageBox.Show("선택된 유저의 권한을 변경하였습니다.");

					Init();
					UpdateTable();
				}
			}
			catch (Exception exc)
			{
				MessageBox.Show(exc.Message);
			}
		}

		private void Init()
		{
			selectedId = "";
		}

		private void UpdateTable()
		{
			try
			{
				using (MySqlConnection mysql = new MySqlConnection(Program.connectionString))
				{
					mysql.Open();
					//usertbl 조회
					string selectQuery = string.Format("SELECT id, name, authority FROM accounttbl");

					MySqlCommand command = new MySqlCommand(selectQuery, mysql);
					MySqlDataReader reader = command.ExecuteReader();

					userListView.Items.Clear();

					while (reader.Read())
					{
						ListViewItem user = new ListViewItem();
						user.Text = reader["id"].ToString();
						user.SubItems.Add(reader["name"].ToString());
						user.SubItems.Add(reader["authority"].ToString());

						userListView.Items.Add(user);
					}

					reader.Close();
				}
			}
			catch (Exception exc)
			{
				MessageBox.Show(exc.Message);
			}
		}

		private void menuButton_Click(object sender, EventArgs e)
		{
			Init();
			userListView.Items.Clear();
			Program.manageUsersForm.Hide();
			Program.adminMenuForm.Show();
		}

        private void deleteButton_Click(object sender, EventArgs e)
        {
			if (selectedId == "")
			{
				MessageBox.Show("선택된 유저가 없습니다.");
				return;
			}

			try
			{
				using (MySqlConnection mysql = new MySqlConnection(Program.connectionString))
				{
					mysql.Open();

					string deleteQuery = $"DELETE FROM accounttbl WHERE id='{selectedId}';";

					MySqlCommand command = new MySqlCommand(deleteQuery, mysql);
					if (command.ExecuteNonQuery() != 1)
						MessageBox.Show("선택된 계정의 삭제가 실패했습니다.");
					else
						MessageBox.Show("선택된 계정이 삭제되었습니다.");

					Init();
					UpdateTable();
				}
			}
			catch (Exception exc)
			{
				MessageBox.Show(exc.Message);
			}
		}
    }
}
