using WinFormsApp4.Models;
using WinFormsApp4.Repositories;
using System.Security.Cryptography;
using System.Text;

namespace WinFormsApp4
{
    public partial class RegistrationForm : Form
    {
        private readonly IUserRepository _userRepository;

        private readonly MainWindow _mainWindow;
        public RegistrationForm(MainWindow mainWindow, IUserRepository userRepository)
        {
            InitializeComponent();
            _userRepository = userRepository;
            _mainWindow = mainWindow;
        }

        private void RegistrationBtn_Click(object sender, EventArgs e)
        {
            System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
            var login = LoginTextBox.Text;

            if (PasswordTextBox.Text == RetryPasswordTextBox.Text)
            {
                var password = PasswordTextBox.Text;
                var retryPassword = PasswordTextBox.Text;

                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(password);
                byte[] hashBytes = md5.ComputeHash(inputBytes);
                var hash = Convert.ToHexString(hashBytes);

                if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password) || string.IsNullOrEmpty(retryPassword))
                {
                    MessageBox.Show("Вы ввели некоректные данные", "Логин или пароль неверный", MessageBoxButtons.OK);
                    return;
                }

                _userRepository.Create(new User() { Login = login, Password = hash });

                _mainWindow.Show();
                this.Hide();
            }

        }

        private void BackToInputMenu_Btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            string connectionString = @"Data Source={DATA BASE};Initial Catalog=Shop;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False;";
            IUserRepository userRepository = new UserRepository(connectionString);
            AuthorizeForm authorizeForm = new AuthorizeForm(userRepository, _mainWindow);
            RegistrationForm registrationForm = new RegistrationForm(_mainWindow, userRepository);
            InputWindow inputWindow = new InputWindow(authorizeForm, registrationForm);
            inputWindow.Show();
        }

        private void OpenPassword_Click(object sender, EventArgs e)
        {
            if (OpenPassword.Checked == true)
            {
                PasswordTextBox.PasswordChar = '\0';
                RetryPasswordTextBox.PasswordChar = '\0';
            }
            else
            {
                PasswordTextBox.PasswordChar = '*';
                RetryPasswordTextBox.PasswordChar = '*';
            }
        }
    }
}
