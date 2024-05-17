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
    public partial class Store_CheckOrder : Form
    {
		private int selectedId = default(int);

        public Store_CheckOrder()
        {
            InitializeComponent();
			VisibleChanged += Store_CheckOrder_VisibleChanged;
			orderListView.FullRowSelect = true;
			orderListView.SelectedIndexChanged += orderListView_SelectedIndexChanged;
		}

        private void backButton_Click(object sender, EventArgs e)
        {
            Program.checkOrderForm.Hide();
            Program.userMenuForm.Show();
        }

		private void orderListView_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (orderListView.SelectedItems.Count > 0)
			{
				ListViewItem selectedOrder = orderListView.SelectedItems[0];
				selectedId = int.Parse(selectedOrder.SubItems[0].Text);
			}
		}

		private void Store_CheckOrder_VisibleChanged(object sender, EventArgs e)
		{
			if (this.Visible)
			{
				Init();
				UpdateTable();
			}
		}

        private void UpdateTable()
		{
			try
			{
				using (MySqlConnection mysql = new MySqlConnection(Program.connectionString))
				{
					mysql.Open();
					//ordertbl 조회
					string selectQuery = $@"SELECT orderId, customerId, itemName, count, totalPrice, DATE_FORMAT(orderDate, '%Y-%m-%d') AS orderDate, orderState FROM ordertbl WHERE customerId = '{Program.UserInfo.ID}';";

					MySqlCommand command = new MySqlCommand(selectQuery, mysql);
					MySqlDataReader reader = command.ExecuteReader();

					orderListView.Items.Clear();

					while (reader.Read())
					{
						ListViewItem item = new ListViewItem();
						item.Text = reader["orderId"].ToString();
						item.SubItems.Add(reader["customerId"].ToString());
						item.SubItems.Add(reader["itemName"].ToString());
						item.SubItems.Add(reader["count"].ToString());
						item.SubItems.Add(reader["totalPrice"].ToString());
						item.SubItems.Add(reader["orderDate"].ToString());
						item.SubItems.Add(reader["orderState"].ToString());

						orderListView.Items.Add(item);
					}

					reader.Close();
				}
			}
			catch (Exception exc)
			{
				MessageBox.Show(exc.Message);
			}
		}

        private void orderCancelButton_Click(object sender, EventArgs e)
        {
            if (selectedId == default(int))
            {
                MessageBox.Show("주문을 선택해주세요.");
                return;
            }

			try
			{
				using (MySqlConnection mysql = new MySqlConnection(Program.connectionString))
				{
					mysql.Open();

					string query = $"SELECT orderState FROM ordertbl WHERE orderId = '{selectedId}'";
					MySqlCommand cmd = new MySqlCommand(query, mysql);
					string orderState = (string)cmd.ExecuteScalar();

					if(!orderState.Equals("주문처리중"))
                    {
						MessageBox.Show("처리중인 주문만 취소할 수 있습니다.");
						Init();
						return;
                    }

					query = $"UPDATE ordertbl SET orderState ='취소됨' WHERE orderId = '{selectedId}';";

					MySqlCommand command = new MySqlCommand(query, mysql);
					if (command.ExecuteNonQuery() == 1)
						MessageBox.Show("선택한 주문을 취소하였습니다.");
					else
						MessageBox.Show("주문취소가 실패하였습니다.");

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
			selectedId = default(int);
        }
    }
}
