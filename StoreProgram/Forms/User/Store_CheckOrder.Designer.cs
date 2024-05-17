namespace StoreDB
{
    partial class Store_CheckOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.orderListView = new System.Windows.Forms.ListView();
            this.orderId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.customerId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.count = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.totalPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.orderDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.orderState = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.orderListGroup = new System.Windows.Forms.GroupBox();
            this.orderCancelButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.orderListGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // orderListView
            // 
            this.orderListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.orderId,
            this.customerId,
            this.itemName,
            this.count,
            this.totalPrice,
            this.orderDate,
            this.orderState});
            this.orderListView.HideSelection = false;
            this.orderListView.Location = new System.Drawing.Point(8, 18);
            this.orderListView.Margin = new System.Windows.Forms.Padding(2);
            this.orderListView.Name = "orderListView";
            this.orderListView.Size = new System.Drawing.Size(699, 226);
            this.orderListView.TabIndex = 0;
            this.orderListView.UseCompatibleStateImageBehavior = false;
            this.orderListView.View = System.Windows.Forms.View.Details;
            // 
            // orderId
            // 
            this.orderId.Text = "주문번호";
            this.orderId.Width = 63;
            // 
            // customerId
            // 
            this.customerId.Text = "구매자ID";
            this.customerId.Width = 104;
            // 
            // itemName
            // 
            this.itemName.Text = "제품명";
            this.itemName.Width = 108;
            // 
            // count
            // 
            this.count.Text = "구매수량";
            this.count.Width = 63;
            // 
            // totalPrice
            // 
            this.totalPrice.Text = "결제금액";
            this.totalPrice.Width = 105;
            // 
            // orderDate
            // 
            this.orderDate.Text = "주문날짜";
            this.orderDate.Width = 160;
            // 
            // orderState
            // 
            this.orderState.Text = "주문상태";
            this.orderState.Width = 92;
            // 
            // orderListGroup
            // 
            this.orderListGroup.Controls.Add(this.orderListView);
            this.orderListGroup.Location = new System.Drawing.Point(8, 8);
            this.orderListGroup.Margin = new System.Windows.Forms.Padding(2);
            this.orderListGroup.Name = "orderListGroup";
            this.orderListGroup.Padding = new System.Windows.Forms.Padding(2);
            this.orderListGroup.Size = new System.Drawing.Size(714, 257);
            this.orderListGroup.TabIndex = 1;
            this.orderListGroup.TabStop = false;
            this.orderListGroup.Text = "주문내역";
            // 
            // orderCancelButton
            // 
            this.orderCancelButton.Location = new System.Drawing.Point(8, 273);
            this.orderCancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.orderCancelButton.Name = "orderCancelButton";
            this.orderCancelButton.Size = new System.Drawing.Size(353, 29);
            this.orderCancelButton.TabIndex = 0;
            this.orderCancelButton.Text = "주문취소";
            this.orderCancelButton.UseVisualStyleBackColor = true;
            this.orderCancelButton.Click += new System.EventHandler(this.orderCancelButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(369, 273);
            this.backButton.Margin = new System.Windows.Forms.Padding(2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(353, 29);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "돌아가기";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // Store_CheckOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 312);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.orderListGroup);
            this.Controls.Add(this.orderCancelButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Store_CheckOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "주문내역";
            this.orderListGroup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView orderListView;
        private System.Windows.Forms.GroupBox orderListGroup;
        private System.Windows.Forms.Button orderCancelButton;
        private System.Windows.Forms.ColumnHeader orderId;
        private System.Windows.Forms.ColumnHeader customerId;
        private System.Windows.Forms.ColumnHeader itemName;
        private System.Windows.Forms.ColumnHeader count;
        private System.Windows.Forms.ColumnHeader totalPrice;
        private System.Windows.Forms.ColumnHeader orderDate;
        private System.Windows.Forms.ColumnHeader orderState;
        private System.Windows.Forms.Button backButton;
    }
}