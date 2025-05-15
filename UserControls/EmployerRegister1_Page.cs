using HireFire.Classes.DataBase;
using HireFire.Classes.CustomInterfaceControls;
using HireFire.Classes.Entities;
using System.ComponentModel.DataAnnotations;


namespace HireFire
{
    public partial class EmployerRegister1_Page : UserControl
    {
        Employer _account;
        public EmployerRegister1_Page(Employer account)
        {
            DoubleBuffered = true;

            InitializeComponent();
            _account = account;

            MailTextBox.AddPlaceholder("Ваша почта (example@mail.com)");
            LoginTextBox.AddPlaceholder("Логин");
            PasswordTextBox.AddPlaceholder("Придумайте пароль", true);
            RepeatPasswordTextBox.AddPlaceholder("Повторите пароль", true);
        }
        private void EmployerRegister_Page_Load(object sender, EventArgs e)
        {

        }

        private void Previous_Button_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            var login_register_control = new EmployerRegister0_Page(_account);
            login_register_control.Dock = DockStyle.Fill;
            Controls.Add(login_register_control);
        }
        private void Next_Button_Click(object sender, EventArgs e)
        {
            bool isMailValid = MailTextBox.ForeColor == Color.Black && !string.IsNullOrEmpty(MailTextBox.Text);
            bool isLoginValid = LoginTextBox.ForeColor == Color.Black && !string.IsNullOrEmpty(LoginTextBox.Text);
            bool isPasswordValid = PasswordTextBox.ForeColor == Color.Black && !string.IsNullOrEmpty(PasswordTextBox.Text);
            bool isPasswordMatch = PasswordTextBox.Text == RepeatPasswordTextBox.Text;

            var _context = new AppDbContext();
            var jobSeekerAlreadyExists = _context.JobSeekers.FirstOrDefault(e => e.Login == LoginTextBox.Text) != null;
            var employerAlreadyExists = _context.Employers.FirstOrDefault(e => e.Login == LoginTextBox.Text) != null;

            if (jobSeekerAlreadyExists || employerAlreadyExists)
            {
                MessageBox.Show("Пользователь с таким логином уже существует!");
                return;
            }

            if (!isMailValid || !isLoginValid || !isPasswordValid)
            {
                MessageBox.Show("Заполните все обязательные поля!");
                return;
            }
            else if (!(new EmailAddressAttribute().IsValid(MailTextBox.Text)))
            {
                MessageBox.Show("Некорректный email!");
                return;
            }
            if (!isPasswordMatch)
            {
                MessageBox.Show("Пароли не совпадают!");
                return;
            }

            _account.Email = MailTextBox.Text;
            _account.Login = LoginTextBox.Text;
            _account.PasswordHash = BCrypt.Net.BCrypt.HashPassword(PasswordTextBox.Text);

            Controls.Clear();
            var employer_register_control = new EmployerRegister2_Page(_account);
            employer_register_control.Dock = DockStyle.Fill;
            Controls.Add(employer_register_control);
        }

    }
}
