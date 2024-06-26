﻿namespace StoreDB
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
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
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
            this.inputInfoGroup.Location = new System.Drawing.Point(17, 18);
            this.inputInfoGroup.Margin = new System.Windows.Forms.Padding(4);
            this.inputInfoGroup.Name = "inputInfoGroup";
            this.inputInfoGroup.Padding = new System.Windows.Forms.Padding(4);
            this.inputInfoGroup.Size = new System.Drawing.Size(276, 177);
            this.inputInfoGroup.TabIndex = 0;
            this.inputInfoGroup.TabStop = false;
            this.inputInfoGroup.Text = "제품 정보 입력란";
            // 
            // countInput
            // 
            this.countInput.Location = new System.Drawing.Point(113, 124);
            this.countInput.Margin = new System.Windows.Forms.Padding(4);
            this.countInput.Name = "countInput";
            this.countInput.Size = new System.Drawing.Size(141, 28);
            this.countInput.TabIndex = 5;
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.Location = new System.Drawing.Point(50, 132);
            this.countLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(44, 18);
            this.countLabel.TabIndex = 4;
            this.countLabel.Text = "수량";
            // 
            // eachPriceInput
            // 
            this.eachPriceInput.Location = new System.Drawing.Point(113, 76);
            this.eachPriceInput.Margin = new System.Windows.Forms.Padding(4);
            this.eachPriceInput.Name = "eachPriceInput";
            this.eachPriceInput.Size = new System.Drawing.Size(141, 28);
            this.eachPriceInput.TabIndex = 3;
            // 
            // eachPriceLabel
            // 
            this.eachPriceLabel.AutoSize = true;
            this.eachPriceLabel.Location = new System.Drawing.Point(50, 82);
            this.eachPriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.eachPriceLabel.Name = "eachPriceLabel";
            this.eachPriceLabel.Size = new System.Drawing.Size(44, 18);
            this.eachPriceLabel.TabIndex = 2;
            this.eachPriceLabel.Text = "단가";
            // 
            // itemNameLabel
            // 
            this.itemNameLabel.AutoSize = true;
            this.itemNameLabel.Location = new System.Drawing.Point(14, 37);
            this.itemNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.itemNameLabel.Name = "itemNameLabel";
            this.itemNameLabel.Size = new System.Drawing.Size(80, 18);
            this.itemNameLabel.TabIndex = 1;
            this.itemNameLabel.Text = "제품이름";
            // 
            // itemNameInput
            // 
            this.itemNameInput.Location = new System.Drawing.Point(113, 30);
            this.itemNameInput.Margin = new System.Windows.Forms.Padding(4);
            this.itemNameInput.Name = "itemNameInput";
            this.itemNameInput.Size = new System.Drawing.Size(141, 28);
            this.itemNameInput.TabIndex = 0;
            // 
            // controlGroup
            // 
            this.controlGroup.Controls.Add(this.modifyButton);
            this.controlGroup.Controls.Add(this.updateButton);
            this.controlGroup.Controls.Add(this.deleteButton);
            this.controlGroup.Controls.Add(this.addButton);
            this.controlGroup.Location = new System.Drawing.Point(301, 18);
            this.controlGroup.Margin = new System.Windows.Forms.Padding(4);
            this.controlGroup.Name = "controlGroup";
            this.controlGroup.Padding = new System.Windows.Forms.Padding(4);
            this.controlGroup.Size = new System.Drawing.Size(416, 177);
            this.controlGroup.TabIndex = 6;
            this.controlGroup.TabStop = false;
            this.controlGroup.Text = "제어";
            // 
            // modifyButton
            // 
            this.modifyButton.Location = new System.Drawing.Point(9, 98);
            this.modifyButton.Margin = new System.Windows.Forms.Padding(4);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(193, 58);
            this.modifyButton.TabIndex = 3;
            this.modifyButton.Text = "수정";
            this.modifyButton.UseVisualStyleBackColor = true;
            this.modifyButton.Click += new System.EventHandler(this.modifyButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(210, 98);
            this.updateButton.Margin = new System.Windows.Forms.Padding(4);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(193, 58);
            this.updateButton.TabIndex = 2;
            this.updateButton.Text = "갱신";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(210, 30);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(193, 58);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "삭제";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(9, 30);
            this.addButton.Margin = new System.Windows.Forms.Padding(4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(193, 58);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "추가";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // itemListBox
            // 
            this.itemListBox.Controls.Add(this.itemListView);
            this.itemListBox.Location = new System.Drawing.Point(17, 204);
            this.itemListBox.Margin = new System.Windows.Forms.Padding(4);
            this.itemListBox.Name = "itemListBox";
            this.itemListBox.Padding = new System.Windows.Forms.Padding(4);
            this.itemListBox.Size = new System.Drawing.Size(700, 405);
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
            listViewItem2});
            this.itemListView.Location = new System.Drawing.Point(11, 26);
            this.itemListView.Margin = new System.Windows.Forms.Padding(4);
            this.itemListView.Name = "itemListView";
            this.itemListView.Size = new System.Drawing.Size(674, 362);
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
            this.menuButton.Location = new System.Drawing.Point(29, 620);
            this.menuButton.Margin = new System.Windows.Forms.Padding(4);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(676, 39);
            this.menuButton.TabIndex = 7;
            this.menuButton.Text = "돌아가기";
            this.menuButton.UseVisualStyleBackColor = true;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // Store_ManageItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 675);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.itemListBox);
            this.Controls.Add(this.controlGroup);
            this.Controls.Add(this.inputInfoGroup);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Store_ManageItems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "제품관리";
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