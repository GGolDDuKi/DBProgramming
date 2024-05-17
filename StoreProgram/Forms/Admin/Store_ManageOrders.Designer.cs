namespace StoreDB
{
    partial class Store_ManageOrders
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.controlGroup = new System.Windows.Forms.GroupBox();
            this.completeButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.orderListBox = new System.Windows.Forms.GroupBox();
            this.orderListView = new System.Windows.Forms.ListView();
            this.OrderId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CustomerId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ItemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Count = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TotalPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OrderDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.orderState = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuButton = new System.Windows.Forms.Button();
            this.controlGroup.SuspendLayout();
            this.orderListBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // controlGroup
            // 
            this.controlGroup.Controls.Add(this.completeButton);
            this.controlGroup.Controls.Add(this.cancelButton);
            this.controlGroup.Location = new System.Drawing.Point(12, 289);
            this.controlGroup.Name = "controlGroup";
            this.controlGroup.Size = new System.Drawing.Size(691, 61);
            this.controlGroup.TabIndex = 6;
            this.controlGroup.TabStop = false;
            this.controlGroup.Text = "제어";
            // 
            // completeButton
            // 
            this.completeButton.Location = new System.Drawing.Point(348, 15);
            this.completeButton.Name = "completeButton";
            this.completeButton.Size = new System.Drawing.Size(336, 39);
            this.completeButton.TabIndex = 1;
            this.completeButton.Text = "완료";
            this.completeButton.UseVisualStyleBackColor = true;
            this.completeButton.Click += new System.EventHandler(this.completeButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(7, 15);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(336, 39);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "취소";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // orderListBox
            // 
            this.orderListBox.Controls.Add(this.orderListView);
            this.orderListBox.Location = new System.Drawing.Point(12, 12);
            this.orderListBox.Name = "orderListBox";
            this.orderListBox.Size = new System.Drawing.Size(691, 270);
            this.orderListBox.TabIndex = 6;
            this.orderListBox.TabStop = false;
            this.orderListBox.Text = "주문 목록";
            // 
            // orderListView
            // 
            this.orderListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.OrderId,
            this.CustomerId,
            this.ItemName,
            this.Count,
            this.TotalPrice,
            this.OrderDate,
            this.orderState});
            this.orderListView.FullRowSelect = true;
            this.orderListView.HideSelection = false;
            this.orderListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.orderListView.Location = new System.Drawing.Point(7, 17);
            this.orderListView.Name = "orderListView";
            this.orderListView.Size = new System.Drawing.Size(677, 243);
            this.orderListView.TabIndex = 0;
            this.orderListView.UseCompatibleStateImageBehavior = false;
            this.orderListView.View = System.Windows.Forms.View.Details;
            // 
            // OrderId
            // 
            this.OrderId.Text = "주문번호";
            // 
            // CustomerId
            // 
            this.CustomerId.Text = "구매자ID";
            this.CustomerId.Width = 103;
            // 
            // ItemName
            // 
            this.ItemName.Text = "제품명";
            this.ItemName.Width = 106;
            // 
            // Count
            // 
            this.Count.Text = "구매수량";
            // 
            // TotalPrice
            // 
            this.TotalPrice.Text = "결제금액";
            this.TotalPrice.Width = 106;
            // 
            // OrderDate
            // 
            this.OrderDate.Text = "주문날짜";
            this.OrderDate.Width = 148;
            // 
            // orderState
            // 
            this.orderState.Text = "주문상태";
            this.orderState.Width = 90;
            // 
            // menuButton
            // 
            this.menuButton.Location = new System.Drawing.Point(12, 356);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(691, 26);
            this.menuButton.TabIndex = 7;
            this.menuButton.Text = "돌아가기";
            this.menuButton.UseVisualStyleBackColor = true;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // Store_ManageOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 390);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.controlGroup);
            this.Controls.Add(this.orderListBox);
            this.Name = "Store_ManageOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "주문내역관리";
            this.VisibleChanged += new System.EventHandler(this.Store_ManageOrders_VisibleChanged);
            this.controlGroup.ResumeLayout(false);
            this.orderListBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox controlGroup;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.GroupBox orderListBox;
        private System.Windows.Forms.ListView orderListView;
        private System.Windows.Forms.ColumnHeader OrderId;
        private System.Windows.Forms.ColumnHeader CustomerId;
        private System.Windows.Forms.ColumnHeader ItemName;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.ColumnHeader Count;
        private System.Windows.Forms.ColumnHeader TotalPrice;
        private System.Windows.Forms.Button completeButton;
        private System.Windows.Forms.ColumnHeader OrderDate;
        private System.Windows.Forms.ColumnHeader orderState;
    }
}