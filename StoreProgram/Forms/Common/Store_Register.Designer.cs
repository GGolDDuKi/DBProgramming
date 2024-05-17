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
            this.idInput.Location = new System.Drawing.Point(137, 17);
            this.idInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.idInput.Name = "idInput";
            this.idInput.Size = new System.Drawing.Size(211, 28);
            this.idInput.TabIndex = 0;
            // 
            // pwInput
            // 
            this.pwInput.Location = new System.Drawing.Point(137, 58);
            this.pwInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pwInput.Name = "pwInput";
            this.pwInput.Size = new System.Drawing.Size(211, 28);
            this.pwInput.TabIndex = 1;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(59, 27);
            this.idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(62, 18);
            this.idLabel.TabIndex = 2;
            this.idLabel.Text = "아이디";
            // 
            // pwLabel
            // 
            this.pwLabel.AutoSize = true;
            this.pwLabel.Location = new System.Drawing.Point(41, 65);
            this.pwLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pwLabel.Name = "pwLabel";
            this.pwLabel.Size = new System.Drawing.Size(80, 18);
            this.pwLabel.TabIndex = 3;
            this.pwLabel.Text = "비밀번호";
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(185, 356);
            this.registerButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(163, 34);
            this.registerButton.TabIndex = 5;
            this.registerButton.Text = "회원가입";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(77, 155);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(44, 18);
            this.nameLabel.TabIndex = 6;
            this.nameLabel.Text = "이름";
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(137, 149);
            this.nameInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(137, 28);
            this.nameInput.TabIndex = 7;
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Location = new System.Drawing.Point(7, 200);
            this.phoneNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(234, 18);
            this.phoneNumberLabel.TabIndex = 8;
            this.phoneNumberLabel.Text = "전화번호 (ex.01012345678)";
            // 
            // phoneNumberInput
            // 
            this.phoneNumberInput.Location = new System.Drawing.Point(10, 231);
            this.phoneNumberInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.phoneNumberInput.Name = "phoneNumberInput";
            this.phoneNumberInput.Size = new System.Drawing.Size(338, 28);
            this.phoneNumberInput.TabIndex = 9;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(7, 273);
            this.addressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(44, 18);
            this.addressLabel.TabIndex = 10;
            this.addressLabel.Text = "주소";
            // 
            // addressInput
            // 
            this.addressInput.Location = new System.Drawing.Point(10, 304);
            this.addressInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addressInput.Name = "addressInput";
            this.addressInput.Size = new System.Drawing.Size(338, 28);
            this.addressInput.TabIndex = 11;
            // 
            // confirmPwLabel
            // 
            this.confirmPwLabel.AutoSize = true;
            this.confirmPwLabel.Location = new System.Drawing.Point(7, 107);
            this.confirmPwLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.confirmPwLabel.Name = "confirmPwLabel";
            this.confirmPwLabel.Size = new System.Drawing.Size(122, 18);
            this.confirmPwLabel.TabIndex = 13;
            this.confirmPwLabel.Text = "비밀번호 확인";
            // 
            // confirmPwInput
            // 
            this.confirmPwInput.Location = new System.Drawing.Point(137, 103);
            this.confirmPwInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.confirmPwInput.Name = "confirmPwInput";
            this.confirmPwInput.Size = new System.Drawing.Size(211, 28);
            this.confirmPwInput.TabIndex = 12;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(10, 356);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(149, 34);
            this.cancelButton.TabIndex = 14;
            this.cancelButton.Text = "취소";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // Store_Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 411);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Store_Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "회원가입";
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

