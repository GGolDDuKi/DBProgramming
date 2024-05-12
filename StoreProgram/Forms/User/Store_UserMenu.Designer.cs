namespace StoreDB
{
    partial class Store_UserMenu
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
            this.buyItemButton = new System.Windows.Forms.Button();
            this.sellItemButton = new System.Windows.Forms.Button();
            this.privacySettingButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buyItemButton
            // 
            this.buyItemButton.Location = new System.Drawing.Point(12, 12);
            this.buyItemButton.Name = "buyItemButton";
            this.buyItemButton.Size = new System.Drawing.Size(145, 89);
            this.buyItemButton.TabIndex = 0;
            this.buyItemButton.Text = "Buy Items";
            this.buyItemButton.UseVisualStyleBackColor = true;
            this.buyItemButton.Click += new System.EventHandler(this.buyItemButton_Click);
            // 
            // sellItemButton
            // 
            this.sellItemButton.Location = new System.Drawing.Point(163, 12);
            this.sellItemButton.Name = "sellItemButton";
            this.sellItemButton.Size = new System.Drawing.Size(145, 89);
            this.sellItemButton.TabIndex = 1;
            this.sellItemButton.Text = "Sell Items";
            this.sellItemButton.UseVisualStyleBackColor = true;
            this.sellItemButton.Click += new System.EventHandler(this.sellItemButton_Click);
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
            // Store_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 159);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.privacySettingButton);
            this.Controls.Add(this.sellItemButton);
            this.Controls.Add(this.buyItemButton);
            this.Name = "Store_UserMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Store_UserMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buyItemButton;
        private System.Windows.Forms.Button sellItemButton;
        private System.Windows.Forms.Button privacySettingButton;
        private System.Windows.Forms.Button backButton;
    }
}