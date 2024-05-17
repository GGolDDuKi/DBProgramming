namespace StoreDB
{
    partial class Store_BuyItems
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
            this.inputInfoGroup = new System.Windows.Forms.GroupBox();
            this.totalPriceInput = new System.Windows.Forms.TextBox();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.buyItemButton = new System.Windows.Forms.Button();
            this.countInput = new System.Windows.Forms.TextBox();
            this.countLabel = new System.Windows.Forms.Label();
            this.eachPriceInput = new System.Windows.Forms.TextBox();
            this.eachPriceLabel = new System.Windows.Forms.Label();
            this.itemNameLabel = new System.Windows.Forms.Label();
            this.itemNameInput = new System.Windows.Forms.TextBox();
            this.itemListBox = new System.Windows.Forms.GroupBox();
            this.itemListView = new System.Windows.Forms.ListView();
            this.ItemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EachPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Count = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuButton = new System.Windows.Forms.Button();
            this.inputInfoGroup.SuspendLayout();
            this.itemListBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputInfoGroup
            // 
            this.inputInfoGroup.Controls.Add(this.totalPriceInput);
            this.inputInfoGroup.Controls.Add(this.totalPriceLabel);
            this.inputInfoGroup.Controls.Add(this.buyItemButton);
            this.inputInfoGroup.Controls.Add(this.countInput);
            this.inputInfoGroup.Controls.Add(this.countLabel);
            this.inputInfoGroup.Controls.Add(this.eachPriceInput);
            this.inputInfoGroup.Controls.Add(this.eachPriceLabel);
            this.inputInfoGroup.Controls.Add(this.itemNameLabel);
            this.inputInfoGroup.Controls.Add(this.itemNameInput);
            this.inputInfoGroup.Location = new System.Drawing.Point(12, 12);
            this.inputInfoGroup.Name = "inputInfoGroup";
            this.inputInfoGroup.Size = new System.Drawing.Size(490, 101);
            this.inputInfoGroup.TabIndex = 0;
            this.inputInfoGroup.TabStop = false;
            this.inputInfoGroup.Text = "제품 정보 입력란";
            // 
            // totalPriceInput
            // 
            this.totalPriceInput.Location = new System.Drawing.Point(265, 71);
            this.totalPriceInput.Name = "totalPriceInput";
            this.totalPriceInput.Size = new System.Drawing.Size(100, 21);
            this.totalPriceInput.TabIndex = 7;
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.Location = new System.Drawing.Point(214, 74);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(45, 12);
            this.totalPriceLabel.TabIndex = 6;
            this.totalPriceLabel.Text = "총 가격";
            // 
            // buyItemButton
            // 
            this.buyItemButton.Location = new System.Drawing.Point(380, 55);
            this.buyItemButton.Name = "buyItemButton";
            this.buyItemButton.Size = new System.Drawing.Size(99, 35);
            this.buyItemButton.TabIndex = 2;
            this.buyItemButton.Text = "구매";
            this.buyItemButton.UseVisualStyleBackColor = true;
            this.buyItemButton.Click += new System.EventHandler(this.buyItemButton_Click);
            // 
            // countInput
            // 
            this.countInput.Location = new System.Drawing.Point(380, 20);
            this.countInput.Name = "countInput";
            this.countInput.Size = new System.Drawing.Size(101, 21);
            this.countInput.TabIndex = 5;
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.Location = new System.Drawing.Point(345, 24);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(29, 12);
            this.countLabel.TabIndex = 4;
            this.countLabel.Text = "수량";
            // 
            // eachPriceInput
            // 
            this.eachPriceInput.Location = new System.Drawing.Point(232, 20);
            this.eachPriceInput.Name = "eachPriceInput";
            this.eachPriceInput.Size = new System.Drawing.Size(100, 21);
            this.eachPriceInput.TabIndex = 3;
            // 
            // eachPriceLabel
            // 
            this.eachPriceLabel.AutoSize = true;
            this.eachPriceLabel.Location = new System.Drawing.Point(197, 24);
            this.eachPriceLabel.Name = "eachPriceLabel";
            this.eachPriceLabel.Size = new System.Drawing.Size(29, 12);
            this.eachPriceLabel.TabIndex = 2;
            this.eachPriceLabel.Text = "단가";
            // 
            // itemNameLabel
            // 
            this.itemNameLabel.AutoSize = true;
            this.itemNameLabel.Location = new System.Drawing.Point(19, 24);
            this.itemNameLabel.Name = "itemNameLabel";
            this.itemNameLabel.Size = new System.Drawing.Size(53, 12);
            this.itemNameLabel.TabIndex = 1;
            this.itemNameLabel.Text = "제품이름";
            // 
            // itemNameInput
            // 
            this.itemNameInput.Location = new System.Drawing.Point(79, 20);
            this.itemNameInput.Name = "itemNameInput";
            this.itemNameInput.Size = new System.Drawing.Size(100, 21);
            this.itemNameInput.TabIndex = 0;
            // 
            // itemListBox
            // 
            this.itemListBox.Controls.Add(this.itemListView);
            this.itemListBox.Location = new System.Drawing.Point(12, 116);
            this.itemListBox.Name = "itemListBox";
            this.itemListBox.Size = new System.Drawing.Size(490, 270);
            this.itemListBox.TabIndex = 6;
            this.itemListBox.TabStop = false;
            this.itemListBox.Text = "제품목록";
            // 
            // itemListView
            // 
            this.itemListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ItemName,
            this.EachPrice,
            this.Count});
            this.itemListView.FullRowSelect = true;
            this.itemListView.HideSelection = false;
            this.itemListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.itemListView.Location = new System.Drawing.Point(8, 17);
            this.itemListView.Name = "itemListView";
            this.itemListView.Size = new System.Drawing.Size(473, 243);
            this.itemListView.TabIndex = 0;
            this.itemListView.UseCompatibleStateImageBehavior = false;
            this.itemListView.View = System.Windows.Forms.View.Details;
            // 
            // ItemName
            // 
            this.ItemName.Text = "제품이름";
            this.ItemName.Width = 196;
            // 
            // EachPrice
            // 
            this.EachPrice.Text = "단가";
            this.EachPrice.Width = 145;
            // 
            // Count
            // 
            this.Count.Text = "수량";
            this.Count.Width = 127;
            // 
            // menuButton
            // 
            this.menuButton.Location = new System.Drawing.Point(20, 393);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(473, 26);
            this.menuButton.TabIndex = 7;
            this.menuButton.Text = "돌아가기";
            this.menuButton.UseVisualStyleBackColor = true;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // Store_BuyItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 433);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.itemListBox);
            this.Controls.Add(this.inputInfoGroup);
            this.Name = "Store_BuyItems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "제품구매";
            this.inputInfoGroup.ResumeLayout(false);
            this.inputInfoGroup.PerformLayout();
            this.itemListBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox inputInfoGroup;
        private System.Windows.Forms.Label itemNameLabel;
        private System.Windows.Forms.TextBox itemNameInput;
        private System.Windows.Forms.TextBox eachPriceInput;
        private System.Windows.Forms.Label eachPriceLabel;
        private System.Windows.Forms.TextBox countInput;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.Button buyItemButton;
        private System.Windows.Forms.GroupBox itemListBox;
        private System.Windows.Forms.ListView itemListView;
        private System.Windows.Forms.ColumnHeader ItemName;
        private System.Windows.Forms.ColumnHeader EachPrice;
        private System.Windows.Forms.ColumnHeader Count;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.TextBox totalPriceInput;
        private System.Windows.Forms.Label totalPriceLabel;
    }
}