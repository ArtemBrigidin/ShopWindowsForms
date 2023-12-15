namespace WinFormsApp4
{
    partial class RegistrationForm
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
            LoginTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            LoginLabel = new Label();
            PasswordLabel = new Label();
            RegistrationBtn = new Button();
            RetryPasswordLabel = new Label();
            RetryPasswordTextBox = new TextBox();
            BackToInputMenu_Btn = new Button();
            OpenPassword = new CheckBox();
            SuspendLayout();
            // 
            // LoginTextBox
            // 
            LoginTextBox.Location = new Point(123, 16);
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.Size = new Size(325, 23);
            LoginTextBox.TabIndex = 0;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(123, 82);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.Size = new Size(325, 23);
            PasswordTextBox.TabIndex = 1;
            // 
            // LoginLabel
            // 
            LoginLabel.AutoSize = true;
            LoginLabel.Location = new Point(22, 19);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(41, 15);
            LoginLabel.TabIndex = 2;
            LoginLabel.Text = "Логин";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new Point(22, 85);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(49, 15);
            PasswordLabel.TabIndex = 3;
            PasswordLabel.Text = "Пароль";
            // 
            // RegistrationBtn
            // 
            RegistrationBtn.Location = new Point(123, 181);
            RegistrationBtn.Name = "RegistrationBtn";
            RegistrationBtn.Size = new Size(325, 54);
            RegistrationBtn.TabIndex = 4;
            RegistrationBtn.Text = "Регистрация";
            RegistrationBtn.UseVisualStyleBackColor = true;
            RegistrationBtn.Click += RegistrationBtn_Click;
            // 
            // RetryPasswordLabel
            // 
            RetryPasswordLabel.AutoSize = true;
            RetryPasswordLabel.Location = new Point(22, 137);
            RetryPasswordLabel.Name = "RetryPasswordLabel";
            RetryPasswordLabel.Size = new Size(91, 15);
            RetryPasswordLabel.TabIndex = 6;
            RetryPasswordLabel.Text = "Повтор пароля";
            // 
            // RetryPasswordTextBox
            // 
            RetryPasswordTextBox.Location = new Point(123, 134);
            RetryPasswordTextBox.Name = "RetryPasswordTextBox";
            RetryPasswordTextBox.PasswordChar = '*';
            RetryPasswordTextBox.Size = new Size(325, 23);
            RetryPasswordTextBox.TabIndex = 5;
            // 
            // BackToInputMenu_Btn
            // 
            BackToInputMenu_Btn.Location = new Point(373, 299);
            BackToInputMenu_Btn.Name = "BackToInputMenu_Btn";
            BackToInputMenu_Btn.Size = new Size(75, 23);
            BackToInputMenu_Btn.TabIndex = 7;
            BackToInputMenu_Btn.Text = "Назад";
            BackToInputMenu_Btn.UseVisualStyleBackColor = true;
            BackToInputMenu_Btn.Click += BackToInputMenu_Btn_Click;
            // 
            // OpenPassword
            // 
            OpenPassword.AutoSize = true;
            OpenPassword.Location = new Point(454, 133);
            OpenPassword.Name = "OpenPassword";
            OpenPassword.Size = new Size(15, 14);
            OpenPassword.TabIndex = 8;
            OpenPassword.UseVisualStyleBackColor = true;
            OpenPassword.Click += OpenPassword_Click;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(486, 334);
            Controls.Add(OpenPassword);
            Controls.Add(BackToInputMenu_Btn);
            Controls.Add(RetryPasswordLabel);
            Controls.Add(RetryPasswordTextBox);
            Controls.Add(RegistrationBtn);
            Controls.Add(PasswordLabel);
            Controls.Add(LoginLabel);
            Controls.Add(PasswordTextBox);
            Controls.Add(LoginTextBox);
            MaximumSize = new Size(502, 373);
            MinimumSize = new Size(502, 373);
            Name = "RegistrationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegistrationForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox LoginTextBox;
        private TextBox PasswordTextBox;
        private Label LoginLabel;
        private Label PasswordLabel;
        private Button RegistrationBtn;
        private Label RetryPasswordLabel;
        private TextBox RetryPasswordTextBox;
        private Button BackToInputMenu_Btn;
        private CheckBox OpenPassword;
    }
}