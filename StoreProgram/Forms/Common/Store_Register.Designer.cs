namespace StoreDB
{
    partial class Store_Register
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
            this.registerButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.phoneNumberInput = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.addressInput = new System.Windows.Forms.TextBox();
            this.confirmPwLabel = new System.Windows.Forms.Label();
            this.confirmPwInput = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
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
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(117, 252);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(114, 23);
            this.registerButton.TabIndex = 5;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(5, 126);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(39, 12);
            this.nameLabel.TabIndex = 6;
            this.nameLabel.Text = "Name";
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(50, 121);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(179, 21);
            this.nameInput.TabIndex = 7;
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Location = new System.Drawing.Point(5, 154);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(184, 12);
            this.phoneNumberLabel.TabIndex = 8;
            this.phoneNumberLabel.Text = "PhoneNumber (ex.01012345678)";
            // 
            // phoneNumberInput
            // 
            this.phoneNumberInput.Location = new System.Drawing.Point(7, 169);
            this.phoneNumberInput.Name = "phoneNumberInput";
            this.phoneNumberInput.Size = new System.Drawing.Size(222, 21);
            this.phoneNumberInput.TabIndex = 9;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(5, 199);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(52, 12);
            this.addressLabel.TabIndex = 10;
            this.addressLabel.Text = "Address";
            // 
            // addressInput
            // 
            this.addressInput.Location = new System.Drawing.Point(7, 214);
            this.addressInput.Name = "addressInput";
            this.addressInput.Size = new System.Drawing.Size(222, 21);
            this.addressInput.TabIndex = 11;
            // 
            // confirmPwLabel
            // 
            this.confirmPwLabel.AutoSize = true;
            this.confirmPwLabel.Location = new System.Drawing.Point(5, 71);
            this.confirmPwLabel.Name = "confirmPwLabel";
            this.confirmPwLabel.Size = new System.Drawing.Size(71, 12);
            this.confirmPwLabel.TabIndex = 13;
            this.confirmPwLabel.Text = "Confirm PW";
            // 
            // confirmPwInput
            // 
            this.confirmPwInput.Location = new System.Drawing.Point(34, 88);
            this.confirmPwInput.Name = "confirmPwInput";
            this.confirmPwInput.Size = new System.Drawing.Size(197, 21);
            this.confirmPwInput.TabIndex = 12;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(7, 252);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(104, 23);
            this.cancelButton.TabIndex = 14;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // Store_Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 289);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.confirmPwInput);
            this.Controls.Add(this.confirmPwLabel);
            this.Controls.Add(this.addressInput);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.phoneNumberInput);
            this.Controls.Add(this.phoneNumberLabel);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.pwLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.pwInput);
            this.Controls.Add(this.idInput);
            this.Name = "Store_Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Store_Register";
            this.Load += new System.EventHandler(this.Store_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox idInput;
        private System.Windows.Forms.TextBox pwInput;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label pwLabel;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.TextBox phoneNumberInput;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox addressInput;
        private System.Windows.Forms.Label confirmPwLabel;
        private System.Windows.Forms.TextBox confirmPwInput;
        private System.Windows.Forms.Button cancelButton;
    }
}

