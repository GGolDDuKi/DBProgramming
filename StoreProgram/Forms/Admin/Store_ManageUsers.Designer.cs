namespace StoreDB
{
    partial class Store_ManageUsers
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
            this.userListBox = new System.Windows.Forms.GroupBox();
            this.userListView = new System.Windows.Forms.ListView();
            this.UserID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UserName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Authority = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuButton = new System.Windows.Forms.Button();
            this.changeAuthButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.userListBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // userListBox
            // 
            this.userListBox.Controls.Add(this.userListView);
            this.userListBox.Location = new System.Drawing.Point(17, 18);
            this.userListBox.Margin = new System.Windows.Forms.Padding(4);
            this.userListBox.Name = "userListBox";
            this.userListBox.Padding = new System.Windows.Forms.Padding(4);
            this.userListBox.Size = new System.Drawing.Size(459, 411);
            this.userListBox.TabIndex = 6;
            this.userListBox.TabStop = false;
            this.userListBox.Text = "사용자 목록";
            // 
            // userListView
            // 
            this.userListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.UserID,
            this.UserName,
            this.Authority});
            this.userListView.FullRowSelect = true;
            this.userListView.HideSelection = false;
            this.userListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.userListView.Location = new System.Drawing.Point(11, 26);
            this.userListView.Margin = new System.Windows.Forms.Padding(4);
            this.userListView.Name = "userListView";
            this.userListView.Size = new System.Drawing.Size(434, 362);
            this.userListView.TabIndex = 0;
            this.userListView.UseCompatibleStateImageBehavior = false;
            this.userListView.View = System.Windows.Forms.View.Details;
            // 
            // UserID
            // 
            this.UserID.Text = "사용자 ID";
            this.UserID.Width = 126;
            // 
            // UserName
            // 
            this.UserName.Text = "사용자 이름";
            this.UserName.Width = 109;
            // 
            // Authority
            // 
            this.Authority.Text = "권한";
            this.Authority.Width = 66;
            // 
            // menuButton
            // 
            this.menuButton.Location = new System.Drawing.Point(17, 486);
            this.menuButton.Margin = new System.Windows.Forms.Padding(4);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(459, 39);
            this.menuButton.TabIndex = 7;
            this.menuButton.Text = "돌아가기";
            this.menuButton.UseVisualStyleBackColor = true;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // changeAuthButton
            // 
            this.changeAuthButton.Location = new System.Drawing.Point(248, 439);
            this.changeAuthButton.Margin = new System.Windows.Forms.Padding(4);
            this.changeAuthButton.Name = "changeAuthButton";
            this.changeAuthButton.Size = new System.Drawing.Size(228, 39);
            this.changeAuthButton.TabIndex = 8;
            this.changeAuthButton.Text = "사용자 권한 변경";
            this.changeAuthButton.UseVisualStyleBackColor = true;
            this.changeAuthButton.Click += new System.EventHandler(this.changeAuthButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(17, 439);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(228, 39);
            this.deleteButton.TabIndex = 9;
            this.deleteButton.Text = "사용자 삭제";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            this.VisibleChanged += new System.EventHandler(this.Store_ManageUsers_VisibleChanged);
            // 
            // Store_ManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 540);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.changeAuthButton);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.userListBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Store_ManageUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "사용자관리";
            this.userListBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox userListBox;
        private System.Windows.Forms.ListView userListView;
        private System.Windows.Forms.ColumnHeader UserID;
        private System.Windows.Forms.ColumnHeader UserName;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.ColumnHeader Authority;
        private System.Windows.Forms.Button changeAuthButton;
        private System.Windows.Forms.Button deleteButton;
    }
}