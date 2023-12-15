using System.Security.Cryptography;
using WinFormsApp4.Repositories;

namespace WinFormsApp4
{
    public partial class AuthorizeForm : Form
    {
        private readonly IUserRepository _userRepository;
        private readonly MainWindow _mainWindow;
        public AuthorizeForm(IUserRepository userRepository, MainWindow mainWindow)
        {
            InitializeComponent();
            _userRepository = userRepository;
            _mainWindow = mainWindow;
        }

        private void Authorize_Click(object sender, EventArgs e)
        {
            System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();

            if (LoginTextBox.Text != null && PasswordTextBox.Text != null)
            {
                var login = LoginTextBox.Text;
                var password = PasswordTextBox.Text;

                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(password);
                byte[] hashBytes = md5.ComputeHash(inputBytes);
                var hashPassword = Convert.ToHexString(hashBytes).ToUpper();

                if (_userRepository.Login(new Models.User { Login = login, Password = hashPassword }) == true)
                {
                    MessageBox.Show("Вы ввели коректные данные", "Найден пользователь", MessageBoxButtons.OK);
                    _mainWindow.Show();
                    this.Hide();
                }
                else
                    ErrorAuthLabel.Visible = true;
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
            }
            else
                PasswordTextBox.PasswordChar = '*';
        }
    }
}