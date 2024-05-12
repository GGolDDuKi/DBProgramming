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

namespace StoreDB.Forms.Admin
{
    public partial class Store_ManageOrders : Form
    {
		int orderId = default(int);

        public Store_ManageOrders()
        {
            InitializeComponent();
        }

        private void Store_ManageOrders_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                updateTable();
                Init();
            }
        }

		private void OrderListView_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (orderListView.SelectedItems.Count > 0)
			{
				ListViewItem selectedItem = orderListView.SelectedItems[0];

				orderId = int.Parse(selectedItem.SubItems[0].Text);

				selectedItem.BackColor = System.Drawing.Color.LightBlue;
			}
		}

		private void Init()
		{
			orderId = default(int);
		}

		private void updateTable()
		{
			try
			{
				using (MySqlConnection mysql = new MySqlConnection(Program.connectionString))
				{
					mysql.Open();
					//ordertbl 조회
					string selectQuery = string.Format("SELECT orderId, customerId, itemName, count, totalPrice, orderDate FROM ordertbl");

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

        private void cancelButton_Click(object sender, EventArgs e)
        {

        }

        private void completeButton_Click(object sender, EventArgs e)
        {

        }
    }
}
