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

            SetPlaceholderValues();
        }


        //Бизнес логика
        private bool DataValidation()
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
                return false;
            }

            if (!isMailValid || !isLoginValid || !isPasswordValid)
            {
                MessageBox.Show("Заполните все обязательные поля!");
                return false;
            }
            else if (!(new EmailAddressAttribute().IsValid(MailTextBox.Text)))
            {
                MessageBox.Show("Некорректный email!");
                return false;
            }
            if (!isPasswordMatch)
            {
                MessageBox.Show("Пароли не совпадают!");
                return false;
            }
            return true;
        }
        private void SetAccountValues()
        {
            _account.Email = MailTextBox.Text;
            _account.Login = LoginTextBox.Text;
            _account.PasswordHash = BCrypt.Net.BCrypt.HashPassword(PasswordTextBox.Text);
        }



        //Интерфейс
        private void SetPlaceholderValues()
        {
            MailTextBox.AddPlaceholder("Ваша почта (example@mail.com)");
            LoginTextBox.AddPlaceholder("Логин");
            PasswordTextBox.AddPlaceholder("Придумайте пароль", true);
            RepeatPasswordTextBox.AddPlaceholder("Повторите пароль", true);
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
            DataValidation();

            SetAccountValues();
            Controls.Clear();
            var employer_register_control = new EmployerRegister2_Page(_account);
            employer_register_control.Dock = DockStyle.Fill;
            Controls.Add(employer_register_control);
        }
    }
}
