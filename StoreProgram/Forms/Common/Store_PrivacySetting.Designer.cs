namespace StoreDB
{
    partial class Store_PrivacySetting
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
            this.pwInput = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.pwLabel = new System.Windows.Forms.Label();
            this.changeButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.phoneNumberInput = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.addressInput = new System.Windows.Forms.TextBox();
            this.confirmPwLabel = new System.Windows.Forms.Label();
            this.confirmPwInput = new System.Windows.Forms.TextBox();
            this.usingIdLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pwInput
            // 
            this.pwInput.Location = new System.Drawing.Point(136, 58);
            this.pwInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pwInput.Name = "pwInput";
            this.pwInput.Size = new System.Drawing.Size(193, 28);
            this.pwInput.TabIndex = 1;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(67, 27);
            this.idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(62, 18);
            this.idLabel.TabIndex = 2;
            this.idLabel.Text = "아이디";
            // 
            // pwLabel
            // 
            this.pwLabel.AutoSize = true;
            this.pwLabel.Location = new System.Drawing.Point(49, 63);
            this.pwLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pwLabel.Name = "pwLabel";
            this.pwLabel.Size = new System.Drawing.Size(80, 18);
            this.pwLabel.TabIndex = 3;
            this.pwLabel.Text = "비밀번호";
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(141, 342);
            this.changeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(186, 34);
            this.changeButton.TabIndex = 5;
            this.changeButton.Text = "정보 변경";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(85, 152);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(44, 18);
            this.nameLabel.TabIndex = 6;
            this.nameLabel.Text = "이름";
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(136, 146);
            this.nameInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(193, 28);
            this.nameInput.TabIndex = 7;
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Location = new System.Drawing.Point(7, 192);
            this.phoneNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(234, 18);
            this.phoneNumberLabel.TabIndex = 8;
            this.phoneNumberLabel.Text = "전화번호 (ex.01012345678)";
            // 
            // phoneNumberInput
            // 
            this.phoneNumberInput.Location = new System.Drawing.Point(10, 223);
            this.phoneNumberInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.phoneNumberInput.Name = "phoneNumberInput";
            this.phoneNumberInput.Size = new System.Drawing.Size(315, 28);
            this.phoneNumberInput.TabIndex = 9;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(7, 267);
            this.addressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(44, 18);
            this.addressLabel.TabIndex = 10;
            this.addressLabel.Text = "주소";
            // 
            // addressInput
            // 
            this.addressInput.Location = new System.Drawing.Point(10, 296);
            this.addressInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addressInput.Name = "addressInput";
            this.addressInput.Size = new System.Drawing.Size(315, 28);
            this.addressInput.TabIndex = 11;
            // 
            // confirmPwLabel
            // 
            this.confirmPwLabel.AutoSize = true;
            this.confirmPwLabel.Location = new System.Drawing.Point(7, 106);
            this.confirmPwLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.confirmPwLabel.Name = "confirmPwLabel";
            this.confirmPwLabel.Size = new System.Drawing.Size(122, 18);
            this.confirmPwLabel.TabIndex = 13;
            this.confirmPwLabel.Text = "비밀번호 확인";
            // 
            // confirmPwInput
            // 
            this.confirmPwInput.Location = new System.Drawing.Point(136, 103);
            this.confirmPwInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.confirmPwInput.Name = "confirmPwInput";
            this.confirmPwInput.Size = new System.Drawing.Size(193, 28);
            this.confirmPwInput.TabIndex = 12;
            // 
            // usingIdLabel
            // 
            this.usingIdLabel.AutoSize = true;
            this.usingIdLabel.Location = new System.Drawing.Point(173, 27);
            this.usingIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usingIdLabel.Name = "usingIdLabel";
            this.usingIdLabel.Size = new System.Drawing.Size(62, 18);
            this.usingIdLabel.TabIndex = 14;
            this.usingIdLabel.Text = "아이디";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(10, 342);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(123, 34);
            this.cancelButton.TabIndex = 15;
            this.cancelButton.Text = "취소";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // Store_PrivacySetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 397);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.usingIdLabel);
            this.Controls.Add(this.confirmPwInput);
            this.Controls.Add(this.confirmPwLabel);
            this.Controls.Add(this.addressInput);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.phoneNumberInput);
            this.Controls.Add(this.phoneNumberLabel);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.pwLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.pwInput);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Store_PrivacySetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "개인정보변경";
            this.VisibleChanged += new System.EventHandler(this.Store_PrivacySetting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox pwInput;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label pwLabel;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.TextBox phoneNumberInput;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox addressInput;
        private System.Windows.Forms.Label confirmPwLabel;
        private System.Windows.Forms.TextBox confirmPwInput;
        private System.Windows.Forms.Label usingIdLabel;
        private System.Windows.Forms.Button cancelButton;
    }
}

