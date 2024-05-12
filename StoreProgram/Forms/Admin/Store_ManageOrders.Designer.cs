namespace StoreDB.Forms.Admin
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
            this.menuButton = new System.Windows.Forms.Button();
            this.OrderDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.controlGroup.Size = new System.Drawing.Size(490, 61);
            this.controlGroup.TabIndex = 6;
            this.controlGroup.TabStop = false;
            this.controlGroup.Text = "Control";
            // 
            // completeButton
            // 
            this.completeButton.Location = new System.Drawing.Point(248, 15);
            this.completeButton.Name = "completeButton";
            this.completeButton.Size = new System.Drawing.Size(233, 39);
            this.completeButton.TabIndex = 1;
            this.completeButton.Text = "Order Complete";
            this.completeButton.UseVisualStyleBackColor = true;
            this.completeButton.Click += new System.EventHandler(this.completeButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(6, 15);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(233, 39);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "Order Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // orderListBox
            // 
            this.orderListBox.Controls.Add(this.orderListView);
            this.orderListBox.Location = new System.Drawing.Point(12, 12);
            this.orderListBox.Name = "orderListBox";
            this.orderListBox.Size = new System.Drawing.Size(490, 270);
            this.orderListBox.TabIndex = 6;
            this.orderListBox.TabStop = false;
            this.orderListBox.Text = "Order List";
            // 
            // orderListView
            // 
            this.orderListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.OrderId,
            this.CustomerId,
            this.ItemName,
            this.Count,
            this.TotalPrice,
            this.OrderDate});
            this.orderListView.FullRowSelect = true;
            this.orderListView.HideSelection = false;
            this.orderListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.orderListView.Location = new System.Drawing.Point(8, 17);
            this.orderListView.Name = "orderListView";
            this.orderListView.Size = new System.Drawing.Size(473, 243);
            this.orderListView.TabIndex = 0;
            this.orderListView.UseCompatibleStateImageBehavior = false;
            this.orderListView.View = System.Windows.Forms.View.Details;
            // 
            // OrderId
            // 
            this.OrderId.Text = "Order Id";
            this.OrderId.Width = 57;
            // 
            // CustomerId
            // 
            this.CustomerId.Text = "Customer Id";
            this.CustomerId.Width = 82;
            // 
            // ItemName
            // 
            this.ItemName.Text = "Item Name";
            this.ItemName.Width = 81;
            // 
            // Count
            // 
            this.Count.Text = "Count";
            this.Count.Width = 49;
            // 
            // TotalPrice
            // 
            this.TotalPrice.Text = "Total Price";
            this.TotalPrice.Width = 90;
            // 
            // menuButton
            // 
            this.menuButton.Location = new System.Drawing.Point(12, 356);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(490, 26);
            this.menuButton.TabIndex = 7;
            this.menuButton.Text = "Go to Menu";
            this.menuButton.UseVisualStyleBackColor = true;
            // 
            // OrderDate
            // 
            this.OrderDate.Text = "Order Date";
            this.OrderDate.Width = 110;
            // 
            // Store_ManageOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 390);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.controlGroup);
            this.Controls.Add(this.orderListBox);
            this.Name = "Store_ManageOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Store_ManageItems";
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
    }
}