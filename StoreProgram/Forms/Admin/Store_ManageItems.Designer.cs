namespace StoreDB
{
    partial class Store_ManageItems
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.inputInfoGroup = new System.Windows.Forms.GroupBox();
            this.countInput = new System.Windows.Forms.TextBox();
            this.countLabel = new System.Windows.Forms.Label();
            this.eachPriceInput = new System.Windows.Forms.TextBox();
            this.eachPriceLabel = new System.Windows.Forms.Label();
            this.itemNameLabel = new System.Windows.Forms.Label();
            this.itemNameInput = new System.Windows.Forms.TextBox();
            this.controlGroup = new System.Windows.Forms.GroupBox();
            this.modifyButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.itemListBox = new System.Windows.Forms.GroupBox();
            this.itemListView = new System.Windows.Forms.ListView();
            this.ItemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EachPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Count = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuButton = new System.Windows.Forms.Button();
            this.inputInfoGroup.SuspendLayout();
            this.controlGroup.SuspendLayout();
            this.itemListBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputInfoGroup
            // 
            this.inputInfoGroup.Controls.Add(this.countInput);
            this.inputInfoGroup.Controls.Add(this.countLabel);
            this.inputInfoGroup.Controls.Add(this.eachPriceInput);
            this.inputInfoGroup.Controls.Add(this.eachPriceLabel);
            this.inputInfoGroup.Controls.Add(this.itemNameLabel);
            this.inputInfoGroup.Controls.Add(this.itemNameInput);
            this.inputInfoGroup.Location = new System.Drawing.Point(12, 12);
            this.inputInfoGroup.Name = "inputInfoGroup";
            this.inputInfoGroup.Size = new System.Drawing.Size(193, 118);
            this.inputInfoGroup.TabIndex = 0;
            this.inputInfoGroup.TabStop = false;
            this.inputInfoGroup.Text = "Item Information";
            // 
            // countInput
            // 
            this.countInput.Location = new System.Drawing.Point(79, 83);
            this.countInput.Name = "countInput";
            this.countInput.Size = new System.Drawing.Size(100, 21);
            this.countInput.TabIndex = 5;
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.Location = new System.Drawing.Point(35, 88);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(38, 12);
            this.countLabel.TabIndex = 4;
            this.countLabel.Text = "Count";
            // 
            // eachPriceInput
            // 
            this.eachPriceInput.Location = new System.Drawing.Point(79, 51);
            this.eachPriceInput.Name = "eachPriceInput";
            this.eachPriceInput.Size = new System.Drawing.Size(100, 21);
            this.eachPriceInput.TabIndex = 3;
            // 
            // eachPriceLabel
            // 
            this.eachPriceLabel.AutoSize = true;
            this.eachPriceLabel.Location = new System.Drawing.Point(6, 56);
            this.eachPriceLabel.Name = "eachPriceLabel";
            this.eachPriceLabel.Size = new System.Drawing.Size(67, 12);
            this.eachPriceLabel.TabIndex = 2;
            this.eachPriceLabel.Text = "Each Price";
            // 
            // itemNameLabel
            // 
            this.itemNameLabel.AutoSize = true;
            this.itemNameLabel.Location = new System.Drawing.Point(6, 25);
            this.itemNameLabel.Name = "itemNameLabel";
            this.itemNameLabel.Size = new System.Drawing.Size(67, 12);
            this.itemNameLabel.TabIndex = 1;
            this.itemNameLabel.Text = "Item Name";
            // 
            // itemNameInput
            // 
            this.itemNameInput.Location = new System.Drawing.Point(79, 20);
            this.itemNameInput.Name = "itemNameInput";
            this.itemNameInput.Size = new System.Drawing.Size(100, 21);
            this.itemNameInput.TabIndex = 0;
            // 
            // controlGroup
            // 
            this.controlGroup.Controls.Add(this.modifyButton);
            this.controlGroup.Controls.Add(this.updateButton);
            this.controlGroup.Controls.Add(this.deleteButton);
            this.controlGroup.Controls.Add(this.addButton);
            this.controlGroup.Location = new System.Drawing.Point(211, 12);
            this.controlGroup.Name = "controlGroup";
            this.controlGroup.Size = new System.Drawing.Size(291, 118);
            this.controlGroup.TabIndex = 6;
            this.controlGroup.TabStop = false;
            this.controlGroup.Text = "Control";
            // 
            // modifyButton
            // 
            this.modifyButton.Location = new System.Drawing.Point(6, 65);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(135, 39);
            this.modifyButton.TabIndex = 3;
            this.modifyButton.Text = "Modify";
            this.modifyButton.UseVisualStyleBackColor = true;
            this.modifyButton.Click += new System.EventHandler(this.modifyButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(147, 65);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(135, 39);
            this.updateButton.TabIndex = 2;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(147, 20);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(135, 39);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(6, 20);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(135, 39);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // itemListBox
            // 
            this.itemListBox.Controls.Add(this.itemListView);
            this.itemListBox.Location = new System.Drawing.Point(12, 136);
            this.itemListBox.Name = "itemListBox";
            this.itemListBox.Size = new System.Drawing.Size(490, 270);
            this.itemListBox.TabIndex = 6;
            this.itemListBox.TabStop = false;
            this.itemListBox.Text = "Item List";
            // 
            // itemListView
            // 
            this.itemListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ItemName,
            this.EachPrice,
            this.Count});
            this.itemListView.HideSelection = false;
            this.itemListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.itemListView.Location = new System.Drawing.Point(8, 17);
            this.itemListView.Name = "itemListView";
            this.itemListView.Size = new System.Drawing.Size(473, 243);
            this.itemListView.TabIndex = 0;
            this.itemListView.UseCompatibleStateImageBehavior = false;
            this.itemListView.View = System.Windows.Forms.View.Details;
            this.itemListView.SelectedIndexChanged += ItemListView_SelectedIndexChanged;
            this.itemListView.FullRowSelect = true;
            // 
            // ItemName
            // 
            this.ItemName.Text = "Item Name";
            this.ItemName.Width = 196;
            // 
            // EachPrice
            // 
            this.EachPrice.Text = "Each Price";
            this.EachPrice.Width = 145;
            // 
            // Count
            // 
            this.Count.Text = "Count";
            this.Count.Width = 127;
            // 
            // menuButton
            // 
            this.menuButton.Location = new System.Drawing.Point(20, 413);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(473, 26);
            this.menuButton.TabIndex = 7;
            this.menuButton.Text = "Go to Menu";
            this.menuButton.UseVisualStyleBackColor = true;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // Store_ManageItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 450);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.itemListBox);
            this.Controls.Add(this.controlGroup);
            this.Controls.Add(this.inputInfoGroup);
            this.Name = "Store_ManageItems";
            this.Text = "Store_ManageItems";
            this.VisibleChanged += new System.EventHandler(this.Store_ManageItems_VisibleChanged);
            this.inputInfoGroup.ResumeLayout(false);
            this.inputInfoGroup.PerformLayout();
            this.controlGroup.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox controlGroup;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.GroupBox itemListBox;
        private System.Windows.Forms.Button modifyButton;
        private System.Windows.Forms.ListView itemListView;
        private System.Windows.Forms.ColumnHeader ItemName;
        private System.Windows.Forms.ColumnHeader EachPrice;
        private System.Windows.Forms.ColumnHeader Count;
        private System.Windows.Forms.Button menuButton;
    }
}