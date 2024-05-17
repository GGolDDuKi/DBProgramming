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
            this.checkOrderButton = new System.Windows.Forms.Button();
            this.privacySettingButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buyItemButton
            // 
            this.buyItemButton.Location = new System.Drawing.Point(17, 18);
            this.buyItemButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buyItemButton.Name = "buyItemButton";
            this.buyItemButton.Size = new System.Drawing.Size(207, 134);
            this.buyItemButton.TabIndex = 0;
            this.buyItemButton.Text = "제품 구매";
            this.buyItemButton.UseVisualStyleBackColor = true;
            this.buyItemButton.Click += new System.EventHandler(this.buyItemButton_Click);
            // 
            // checkOrderButton
            // 
            this.checkOrderButton.Location = new System.Drawing.Point(233, 18);
            this.checkOrderButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkOrderButton.Name = "checkOrderButton";
            this.checkOrderButton.Size = new System.Drawing.Size(207, 134);
            this.checkOrderButton.TabIndex = 1;
            this.checkOrderButton.Text = "주문 조회";
            this.checkOrderButton.UseVisualStyleBackColor = true;
            this.checkOrderButton.Click += new System.EventHandler(this.checkOrderButton_Click);
            // 
            // privacySettingButton
            // 
            this.privacySettingButton.Location = new System.Drawing.Point(17, 165);
            this.privacySettingButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.privacySettingButton.Name = "privacySettingButton";
            this.privacySettingButton.Size = new System.Drawing.Size(207, 56);
            this.privacySettingButton.TabIndex = 2;
            this.privacySettingButton.Text = "개인정보 설정";
            this.privacySettingButton.UseVisualStyleBackColor = true;
            this.privacySettingButton.Click += new System.EventHandler(this.privacySettingButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(233, 165);
            this.backButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(207, 56);
            this.backButton.TabIndex = 3;
            this.backButton.Text = "돌아가기";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // Store_UserMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 238);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.privacySettingButton);
            this.Controls.Add(this.checkOrderButton);
            this.Controls.Add(this.buyItemButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Store_UserMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "사용자 메뉴";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buyItemButton;
        private System.Windows.Forms.Button checkOrderButton;
        private System.Windows.Forms.Button privacySettingButton;
        private System.Windows.Forms.Button backButton;
    }
}