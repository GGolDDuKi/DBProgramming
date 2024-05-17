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
    public partial class Store_BuyItems : Form
    {
        public Store_BuyItems()
        {
            InitializeComponent();
			this.VisibleChanged += Store_BuyItems_VisibleChanged;
			itemNameInput.ReadOnly = true;
			itemNameInput.BackColor = System.Drawing.Color.White;
			itemNameInput.ShortcutsEnabled = false;
			eachPriceInput.ReadOnly = true;
			eachPriceInput.BackColor = System.Drawing.Color.White;
			eachPriceInput.ShortcutsEnabled = false;
			totalPriceInput.ReadOnly = true;
			totalPriceInput.BackColor = System.Drawing.Color.White;
			totalPriceInput.ShortcutsEnabled = false;
			countInput.TextChanged += CountInput_TextChanged;
			itemListView.SelectedIndexChanged += ItemListView_SelectedIndexChanged;
		}

		private void Store_BuyItems_VisibleChanged(object sender, EventArgs e)
		{
			if (this.Visible)
			{
				UpdateTable();
				Init();
			}
		}

		private void buyItemButton_Click(object sender, EventArgs e)
		{
			if (itemNameInput.Text.Length <= 0 || eachPriceInput.Text.Length <= 0 || countInput.Text.Length <= 0 || totalPriceInput.Text.Length <= 0)
			{
				MessageBox.Show("선택된 제품이 없거나 구매수량이 입력되지 않았습니다.");
				return;
			}

			try
			{
				using (MySqlConnection mysql = new MySqlConnection(Program.connectionString))
				{
					mysql.Open();
					MySqlTransaction transaction = mysql.BeginTransaction();

					try
					{
						// 제품 재고 감소
						string query = $"UPDATE itemtbl SET count = count - {countInput.Text} WHERE name = '{itemNameInput.Text}'";
						MySqlCommand command = new MySqlCommand(query, mysql);
						command.Transaction = transaction;
						command.ExecuteNonQuery();

						// 새로운 주문 정보 테이블에 추가
						query = $"INSERT INTO ordertbl (customerId, itemName, count, totalPrice, orderDate, orderState) VALUES ('{Program.UserInfo.ID}', '{itemNameInput.Text}', {countInput.Text}, {totalPriceInput.Text}, NOW(), '주문처리중')";
						command = new MySqlCommand(query, mysql);
						command.Transaction = transaction;
						command.ExecuteNonQuery();

						// 두 쿼리가 모두 성공하면 트랜잭션을 커밋
						transaction.Commit();
						MessageBox.Show("제품을 구매하였습니다.");
						Init();
						UpdateTable();
					}
					catch (Exception)
					{
						// 오류가 발생하면 트랜잭션을 롤백
						transaction.Rollback();
						MessageBox.Show("제품 구매에 실패하였습니다.");
						Init();
						UpdateTable();
					}
				}

			}
			catch (Exception exc)
			{
				MessageBox.Show(exc.Message);
			}
		}

		private void menuButton_Click(object sender, EventArgs e)
        {
            Program.buyItemsForm.Hide();
            Program.userMenuForm.Show();
        }

		private void ItemListView_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (itemListView.SelectedItems.Count > 0)
			{
				ListViewItem selectedItem = itemListView.SelectedItems[0];

				itemNameInput.Text = selectedItem.SubItems[0].Text;
				eachPriceInput.Text = selectedItem.SubItems[1].Text;
				countInput.Text = "0";
				countInput.Text = "1";
			}
		}

		private void CountInput_TextChanged(object sender, EventArgs e)
        {
			if (countInput.Text == "")
				return;

			if (itemNameInput.Text.Length <= 0 || eachPriceInput.Text.Length <= 0)
            {
				MessageBox.Show("제품을 먼저 선택해주세요.");
				countInput.Text = "";
				return;
            }

			if (!int.TryParse(countInput.Text, out int count))
            {
				MessageBox.Show("정수만 입력 가능합니다.");
				countInput.Text = "";
				return;
            }

			totalPriceInput.Text = (int.Parse(eachPriceInput.Text) * count).ToString();
        }

		private void Init()
		{
			itemNameInput.Text = "";
			eachPriceInput.Text = "";
			countInput.Text = "";
			totalPriceInput.Text = "";
		}

		private void UpdateTable()
		{
			try
			{
				using (MySqlConnection mysql = new MySqlConnection(Program.connectionString))
				{
					mysql.Open();
					//itemtbl 조회
					string selectQuery = string.Format("SELECT * FROM itemtbl;");

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
    }
}
