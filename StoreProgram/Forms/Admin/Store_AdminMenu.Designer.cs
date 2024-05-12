namespace StoreDB
{
    partial class Store_AdminMenu
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
            this.manageItemsButton = new System.Windows.Forms.Button();
            this.manageUsersButton = new System.Windows.Forms.Button();
            this.privacySettingButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.manageOrdersButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // manageItemsButton
            // 
            this.manageItemsButton.Location = new System.Drawing.Point(12, 12);
            this.manageItemsButton.Name = "manageItemsButton";
            this.manageItemsButton.Size = new System.Drawing.Size(96, 89);
            this.manageItemsButton.TabIndex = 0;
            this.manageItemsButton.Text = "Manage\nItems";
            this.manageItemsButton.UseVisualStyleBackColor = true;
            this.manageItemsButton.Click += new System.EventHandler(this.manageItemsButton_Click);
            // 
            // manageUsersButton
            // 
            this.manageUsersButton.Location = new System.Drawing.Point(112, 12);
            this.manageUsersButton.Name = "manageUsersButton";
            this.manageUsersButton.Size = new System.Drawing.Size(96, 89);
            this.manageUsersButton.TabIndex = 1;
            this.manageUsersButton.Text = "Manage\nUsers";
            this.manageUsersButton.UseVisualStyleBackColor = true;
            this.manageUsersButton.Click += new System.EventHandler(this.manageUsersButton_Click);
            // 
            // privacySettingButton
            // 
            this.privacySettingButton.Location = new System.Drawing.Point(12, 110);
            this.privacySettingButton.Name = "privacySettingButton";
            this.privacySettingButton.Size = new System.Drawing.Size(145, 37);
            this.privacySettingButton.TabIndex = 2;
            this.privacySettingButton.Text = "Privacy Setting";
            this.privacySettingButton.UseVisualStyleBackColor = true;
            this.privacySettingButton.Click += new System.EventHandler(this.privacySettingButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(163, 110);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(145, 37);
            this.backButton.TabIndex = 3;
            this.backButton.Text = "Go Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // manageOrdersButton
            // 
            this.manageOrdersButton.Location = new System.Drawing.Point(212, 12);
            this.manageOrdersButton.Name = "manageOrdersButton";
            this.manageOrdersButton.Size = new System.Drawing.Size(96, 89);
            this.manageOrdersButton.TabIndex = 4;
            this.manageOrdersButton.Text = "Manage\nOrders";
            this.manageOrdersButton.UseVisualStyleBackColor = true;
            this.manageOrdersButton.Click += new System.EventHandler(this.manageOrdersButton_Click);
            // 
            // Store_AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 159);
            this.Controls.Add(this.manageOrdersButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.privacySettingButton);
            this.Controls.Add(this.manageUsersButton);
            this.Controls.Add(this.manageItemsButton);
            this.Name = "Store_AdminMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Store_AdminMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button manageItemsButton;
        private System.Windows.Forms.Button manageUsersButton;
        private System.Windows.Forms.Button privacySettingButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button manageOrdersButton;
    }
}