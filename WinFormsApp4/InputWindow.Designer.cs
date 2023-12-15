namespace WinFormsApp4
{
    partial class InputWindow
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
            AuthorizeBtn = new Button();
            RegistrationBtn = new Button();
            SuspendLayout();
            // 
            // AuthorizeBtn
            // 
            AuthorizeBtn.Location = new Point(122, 66);
            AuthorizeBtn.Name = "AuthorizeBtn";
            AuthorizeBtn.Size = new Size(251, 49);
            AuthorizeBtn.TabIndex = 0;
            AuthorizeBtn.Text = "Авторизоваться";
            AuthorizeBtn.UseVisualStyleBackColor = true;
            AuthorizeBtn.Click += AuthorizeBtn_Click;
            // 
            // RegistrationBtn
            // 
            RegistrationBtn.Location = new Point(122, 187);
            RegistrationBtn.Name = "RegistrationBtn";
            RegistrationBtn.Size = new Size(251, 49);
            RegistrationBtn.TabIndex = 1;
            RegistrationBtn.Text = "Регистрация";
            RegistrationBtn.UseVisualStyleBackColor = true;
            RegistrationBtn.Click += RegistrationBtn_Click;
            // 
            // InputWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(486, 334);
            Controls.Add(RegistrationBtn);
            Controls.Add(AuthorizeBtn);
            MaximumSize = new Size(502, 373);
            MinimumSize = new Size(502, 373);
            Name = "InputWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registration";
            ResumeLayout(false);
        }

        #endregion

        private Button AuthorizeBtn;
        private Button RegistrationBtn;
    }
}