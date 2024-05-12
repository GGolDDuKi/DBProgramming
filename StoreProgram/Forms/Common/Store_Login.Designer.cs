namespace StoreDB
{
    partial class Store_Login
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.idInput = new System.Windows.Forms.TextBox();
            this.pwInput = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.pwLabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.registerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // idInput
            // 
            this.idInput.Location = new System.Drawing.Point(34, 12);
            this.idInput.Name = "idInput";
            this.idInput.Size = new System.Drawing.Size(197, 21);
            this.idInput.TabIndex = 0;
            // 
            // pwInput
            // 
            this.pwInput.Location = new System.Drawing.Point(34, 39);
            this.pwInput.Name = "pwInput";
            this.pwInput.Size = new System.Drawing.Size(197, 21);
            this.pwInput.TabIndex = 1;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(12, 18);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(16, 12);
            this.idLabel.TabIndex = 2;
            this.idLabel.Text = "ID";
            // 
            // pwLabel
            // 
            this.pwLabel.AutoSize = true;
            this.pwLabel.Location = new System.Drawing.Point(5, 44);
            this.pwLabel.Name = "pwLabel";
            this.pwLabel.Size = new System.Drawing.Size(23, 12);
            this.pwLabel.TabIndex = 3;
            this.pwLabel.Text = "PW";
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(7, 66);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(224, 23);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(7, 95);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(224, 23);
            this.registerButton.TabIndex = 5;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // Store_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 125);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.pwLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.pwInput);
            this.Controls.Add(this.idInput);
            this.Name = "Store_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Store_Login";
            this.Load += new System.EventHandler(this.Store_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox idInput;
        private System.Windows.Forms.TextBox pwInput;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label pwLabel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button registerButton;
    }
}

