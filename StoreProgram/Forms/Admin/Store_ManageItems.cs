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
    public partial class Store_ManageItems : Form
    {
        public Store_ManageItems()
        {
            InitializeComponent();
			this.itemListView.SelectedIndexChanged += ItemListView_SelectedIndexChanged;
			this.VisibleChanged += Store_ManageItems_VisibleChanged;
		}

		private void Store_ManageItems_VisibleChanged(object sender, EventArgs e)
        {
			if (this.Visible)
            {
				UpdateTable();
				Init();
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
			UpdateTable();
		}

		private void addButton_Click(object sender, EventArgs e)
		{
			try
			{
				using (MySqlConnection mysql = new MySqlConnection(Program.connectionString))
				{
					mysql.Open();

					string insertQuery = $"INSERT INTO itemtbl VALUES ('{itemNameInput.Text}', {eachPriceInput.Text}, {countInput.Text});";

					MySqlCommand command = new MySqlCommand(insertQuery, mysql);
					if (command.ExecuteNonQuery() != 1)
						MessageBox.Show("제품 정보 추가에 실패하였습니다.");

					Init();
					UpdateTable();
				}
			}
			catch (Exception exc)
			{
				MessageBox.Show(exc.Message);
			}
		}

		private void modifyButton_Click(object sender, EventArgs e)
		{
			try
			{
				using (MySqlConnection mysql = new MySqlConnection(Program.connectionString))
				{
					mysql.Open();
					string updateQuery = $"UPDATE itemtbl SET eachPrice={eachPriceInput.Text}, count={countInput.Text} WHERE name='{itemNameInput.Text}';";

					MySqlCommand command = new MySqlCommand(updateQuery, mysql);
					if (command.ExecuteNonQuery() != 1)
						MessageBox.Show("제품 정보 수정에 실패하였습니다.");

					Init();
					UpdateTable();
				}
			}
			catch (Exception exc)
			{
				MessageBox.Show(exc.Message);
			}
		}

		private void deleteButton_Click(object sender, EventArgs e)
		{
			try
			{
				using (MySqlConnection mysql = new MySqlConnection(Program.connectionString))
				{
					mysql.Open();
					string deleteQuery = $"DELETE FROM itemtbl WHERE name='{itemNameInput.Text}';";

					MySqlCommand command = new MySqlCommand(deleteQuery, mysql);
					if (command.ExecuteNonQuery() != 1)
						MessageBox.Show("제품 정보 삭제에 실패하였습니다.");

					Init();
					UpdateTable();
				}
			}
			catch (Exception exc)
			{
				MessageBox.Show(exc.Message);
			}
		}

		private void ItemListView_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (itemListView.SelectedItems.Count > 0)
			{
				ListViewItem selectedItem = itemListView.SelectedItems[0];

				itemNameInput.Text = selectedItem.SubItems[0].Text;
				eachPriceInput.Text = selectedItem.SubItems[1].Text;
				countInput.Text = selectedItem.SubItems[2].Text;
			}
		}

		private void Init()
        {
			itemNameInput.Text = "";
			eachPriceInput.Text = "";
			countInput.Text = "";
        }

		private void UpdateTable()
		{
			try
			{
				using (MySqlConnection mysql = new MySqlConnection(Program.connectionString))
				{
					mysql.Open();
					//itemtbl 조회
					string selectQuery = string.Format("SELECT * FROM itemtbl");

					MySqlCommand command = new MySqlCommand(selectQuery, mysql);
					MySqlDataReader reader = command.ExecuteReader();

					itemListView.Items.Clear();

					while (reader.Read())
					{
						ListViewItem item = new ListViewItem();
						item.Text = reader["name"].ToString();
						item.SubItems.Add(reader["eachPrice"].ToString());
						item.SubItems.Add(reader["count"].ToString());

						itemListView.Items.Add(item);
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
			itemListView.Items.Clear();
			Program.manageItemForm.Hide();
			Program.adminMenuForm.Show();
		}
    }
}
