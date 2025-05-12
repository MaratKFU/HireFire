using HireFire.Classes.CustomInterfaceControls;
using HireFire.Classes.DataBase;
using HireFire.Classes.Entities;
using HireFire.UserControls;
using System.Security.Principal;

namespace HireFire
{
    public partial class Login_Page : UserControl
    {
        private readonly bool _isEmployer;
        public Login_Page(bool IsEmployer)
        {
            InitializeComponent();
            _isEmployer = IsEmployer;
            LoginTextBox.AddPlaceholder("Введите логин");
            PasswordTextBox.AddPlaceholder("Введите пароль", true);
        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            var login_register_control = new LoginRegister_Page();
            login_register_control.Dock = DockStyle.Fill;
            Controls.Add(login_register_control);
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            string login = LoginTextBox.Text.Trim();
            string password = PasswordTextBox.Text;

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }

            try
            {
                using (var context = new AppDbContext())
                {
                    var authService = new AuthService(context);

                    if (authService.AuthenticateEmployer(login, password) != null)
                    {
                        if (!_isEmployer)
                        {
                            MessageBox.Show("Вы не являетесь соискателем!");
                            return;
                        }
                        Controls.Clear();
                        var employer_register_control = new Dialogs_Page();
                        employer_register_control.Dock = DockStyle.Fill;
                        Controls.Add(employer_register_control);
                        return;
                    }

                    if (authService.AuthenticateJobSeeker(login, password) != null)
                    {
                        if (_isEmployer)
                        {
                            MessageBox.Show("Вы не являетесь работодателем!");
                            return;
                        }
                        Controls.Clear();
                        var employer_register_control = new Dialogs_Page();
                        employer_register_control.Dock = DockStyle.Fill;
                        Controls.Add(employer_register_control);
                        return;
                    }

                    MessageBox.Show("Неверный логин или пароль!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка авторизации: {ex.Message}");
            }
        }

    }
}
