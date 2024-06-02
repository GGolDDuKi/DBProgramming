using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace StoreDB
{
    public partial class Store_ManageOrders : Form
    {
		int orderId = default(int);

        public Store_ManageOrders()
        {
            InitializeComponent();
			this.orderListView.SelectedIndexChanged += OrderListView_SelectedIndexChanged;
		}

        private void Store_ManageOrders_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                UpdateTable();
                Init();
            }
        }

		private void OrderListView_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (orderListView.SelectedItems.Count > 0)
			{
				ListViewItem selectedItem = orderListView.SelectedItems[0];
				orderId = int.Parse(selectedItem.SubItems[0].Text);
			}
		}

		private void Init()
		{
			orderId = default(int);
		}

		private void UpdateTable()
		{
			try
			{
				using (MySqlConnection mysql = new MySqlConnection(Program.connectionString))
				{
					mysql.Open();
					//ordertbl 조회
					string selectQuery = @"SELECT orderId, customerId, itemName, count, totalPrice, DATE_FORMAT(orderDate, '%Y-%m-%d') AS orderDate, orderState FROM ordertbl";

					MySqlCommand command = new MySqlCommand(selectQuery, mysql);
					MySqlDataReader reader = command.ExecuteReader();

					orderListView.Items.Clear();

					while (reader.Read())
					{
						ListViewItem user = new ListViewItem();
						user.Text = reader["orderId"].ToString();
						user.SubItems.Add(reader["customerId"].ToString());
						user.SubItems.Add(reader["itemName"].ToString());
						user.SubItems.Add(reader["count"].ToString());
						user.SubItems.Add(reader["totalPrice"].ToString());
						user.SubItems.Add(reader["orderDate"].ToString());
						user.SubItems.Add(reader["orderState"].ToString());

						orderListView.Items.Add(user);
					}

					reader.Close();
				}
			}
			catch (Exception exc)
			{
				MessageBox.Show(exc.Message);
			}
		}

		//주문 취소 버튼 이벤트
        private void cancelButton_Click(object sender, EventArgs e)
        {
			if (orderId == default(int))
			{
				MessageBox.Show("주문을 선택해주세요.");
				return;
			}

			try
			{
				using (MySqlConnection mysql = new MySqlConnection(Program.connectionString))
				{
					mysql.Open();

					string query = $"SELECT orderState FROM ordertbl WHERE orderId = '{orderId}'";
					MySqlCommand cmd = new MySqlCommand(query, mysql);
					string orderState = (string)cmd.ExecuteScalar();

					if (!orderState.Equals("주문처리중"))
					{
						MessageBox.Show("처리중인 주문만 취소할 수 있습니다.");
						Init();
						return;
					}

					query = $"UPDATE ordertbl SET orderState ='취소됨' WHERE orderId = '{orderId}';";

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

		//주문 완료 버튼 이벤트
        private void completeButton_Click(object sender, EventArgs e)
        {
			if (orderId == default(int))
			{
				MessageBox.Show("주문을 선택해주세요.");
				return;
			}

			try
			{
				using (MySqlConnection mysql = new MySqlConnection(Program.connectionString))
				{
					mysql.Open();

					string query = $"SELECT orderState FROM ordertbl WHERE orderId = '{orderId}'";
					MySqlCommand cmd = new MySqlCommand(query, mysql);
					string orderState = (string)cmd.ExecuteScalar();

					if (!orderState.Equals("주문처리중"))
					{
						MessageBox.Show("이미 취소되거나 완료된 주문입니다.");
						Init();
						return;
					}

					query = $"UPDATE ordertbl SET orderState ='처리완료' WHERE orderId = '{orderId}';";

					MySqlCommand command = new MySqlCommand(query, mysql);
					if (command.ExecuteNonQuery() == 1)
						MessageBox.Show("선택한 주문의 처리가 완료되었습니다.");
					else
						MessageBox.Show("주문 처리 중 오류가 발생하였습니다.");

					Init();
					UpdateTable();
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
			orderListView.Items.Clear();
			Program.manageOrdersForm.Hide();
			Program.adminMenuForm.Show();
		}
    }
}
