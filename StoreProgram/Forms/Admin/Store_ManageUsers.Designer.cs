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
            this.VisibleChanged += Store_ManageUsers_VisibleChanged;
            this.userListBox.SuspendLayout();
            this.SuspendLayout();
            this.userListView.SelectedIndexChanged += userListView_SelectedIndexChanged;
            // 
            // userListBox
            // 
            this.userListBox.Controls.Add(this.userListView);
            this.userListBox.Location = new System.Drawing.Point(12, 12);
            this.userListBox.Name = "userListBox";
            this.userListBox.Size = new System.Drawing.Size(321, 274);
            this.userListBox.TabIndex = 6;
            this.userListBox.TabStop = false;
            this.userListBox.Text = "User List";
            // 
            // userListView
            // 
            this.userListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.UserID,
            this.UserName,
            this.Authority});
            this.userListView.HideSelection = false;
            this.userListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.userListView.Location = new System.Drawing.Point(8, 17);
            this.userListView.Name = "userListView";
            this.userListView.Size = new System.Drawing.Size(305, 243);
            this.userListView.TabIndex = 0;
            this.userListView.UseCompatibleStateImageBehavior = false;
            this.userListView.View = System.Windows.Forms.View.Details;
            this.userListView.FullRowSelect = true;
            // 
            // UserID
            // 
            this.UserID.Text = "User ID";
            this.UserID.Width = 126;
            // 
            // UserName
            // 
            this.UserName.Text = "User Name";
            this.UserName.Width = 109;
            // 
            // Authority
            // 
            this.Authority.Text = "Authority";
            this.Authority.Width = 66;
            // 
            // menuButton
            // 
            this.menuButton.Location = new System.Drawing.Point(12, 324);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(321, 26);
            this.menuButton.TabIndex = 7;
            this.menuButton.Text = "Go to Menu";
            this.menuButton.UseVisualStyleBackColor = true;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // changeAuthButton
            // 
            this.changeAuthButton.Location = new System.Drawing.Point(12, 292);
            this.changeAuthButton.Name = "changeAuthButton";
            this.changeAuthButton.Size = new System.Drawing.Size(321, 26);
            this.changeAuthButton.TabIndex = 8;
            this.changeAuthButton.Text = "Change Authority";
            this.changeAuthButton.UseVisualStyleBackColor = true;
            this.changeAuthButton.Click += new System.EventHandler(this.changeAuthButton_Click);
            // 
            // Store_ManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 360);
            this.Controls.Add(this.changeAuthButton);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.userListBox);
            this.Name = "Store_ManageUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Store_ManageUsers";
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
    }
}