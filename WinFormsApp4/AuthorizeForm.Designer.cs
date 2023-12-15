namespace WinFormsApp4
{
    partial class AuthorizeForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Authorize = new Button();
            LoginTextBox = new TextBox();
            LoginLabel = new Label();
            PasswordTextBox = new TextBox();
            PasswordLabel = new Label();
            BackToInputMenu_Btn = new Button();
            OpenPassword = new CheckBox();
            ErrorAuthLabel = new Label();
            SuspendLayout();
            // 
            // Authorize
            // 
            Authorize.Location = new Point(99, 126);
            Authorize.Name = "Authorize";
            Authorize.Size = new Size(325, 54);
            Authorize.TabIndex = 0;
            Authorize.Text = "Авторизоваться";
            Authorize.UseVisualStyleBackColor = true;
            Authorize.Click += Authorize_Click;
            // 
            // LoginTextBox
            // 
            LoginTextBox.Location = new Point(99, 20);
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.Size = new Size(325, 23);
            LoginTextBox.TabIndex = 1;
            // 
            // LoginLabel
            // 
            LoginLabel.AutoSize = true;
            LoginLabel.Location = new Point(40, 28);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(41, 15);
            LoginLabel.TabIndex = 2;
            LoginLabel.Text = "Логин";
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(99, 85);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.Size = new Size(325, 23);
            PasswordTextBox.TabIndex = 3;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new Point(40, 93);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(49, 15);
            PasswordLabel.TabIndex = 4;
            PasswordLabel.Text = "Пароль";
            // 
            // BackToInputMenu_Btn
            // 
            BackToInputMenu_Btn.Location = new Point(399, 299);
            BackToInputMenu_Btn.Name = "BackToInputMenu_Btn";
            BackToInputMenu_Btn.Size = new Size(75, 23);
            BackToInputMenu_Btn.TabIndex = 5;
            BackToInputMenu_Btn.Text = "Назад";
            BackToInputMenu_Btn.UseVisualStyleBackColor = true;
            BackToInputMenu_Btn.Click += BackToInputMenu_Btn_Click;
            // 
            // OpenPassword
            // 
            OpenPassword.AutoSize = true;
            OpenPassword.Location = new Point(430, 89);
            OpenPassword.Name = "OpenPassword";
            OpenPassword.Size = new Size(15, 14);
            OpenPassword.TabIndex = 6;
            OpenPassword.UseVisualStyleBackColor = true;
            OpenPassword.Click += OpenPassword_Click;
            // 
            // ErrorAuthLabel
            // 
            ErrorAuthLabel.AutoSize = true;
            ErrorAuthLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            ErrorAuthLabel.ForeColor = Color.Red;
            ErrorAuthLabel.Location = new Point(99, 199);
            ErrorAuthLabel.Name = "ErrorAuthLabel";
            ErrorAuthLabel.Size = new Size(312, 25);
            ErrorAuthLabel.TabIndex = 7;
            ErrorAuthLabel.Text = "Неверная пара логина и пароля";
            ErrorAuthLabel.Visible = false;
            // 
            // AuthorizeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(486, 334);
            Controls.Add(ErrorAuthLabel);
            Controls.Add(OpenPassword);
            Controls.Add(BackToInputMenu_Btn);
            Controls.Add(PasswordLabel);
            Controls.Add(PasswordTextBox);
            Controls.Add(LoginLabel);
            Controls.Add(LoginTextBox);
            Controls.Add(Authorize);
            MaximumSize = new Size(502, 373);
            MinimumSize = new Size(502, 373);
            Name = "AuthorizeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Authorize;
        private TextBox LoginTextBox;
        private Label LoginLabel;
        private TextBox PasswordTextBox;
        private Label PasswordLabel;
        private Button BackToInputMenu_Btn;
        private CheckBox OpenPassword;
        private Label ErrorAuthLabel;
    }
}