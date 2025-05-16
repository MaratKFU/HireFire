using HireFire.Classes.DataBase;
using HireFire.Classes.CustomInterfaceControls;
using HireFire.Classes.Entities;
using System.ComponentModel.DataAnnotations;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.Logging;

namespace HireFire
{
    public partial class JobSeekerRegister1_Page : UserControl
    {
        JobSeeker _account;
        public JobSeekerRegister1_Page(JobSeeker account)
        {
            DoubleBuffered = true;

            InitializeComponent();
            _account = account;

            SetPlaceholderValues();
        }
        //Бизнес логика
        private void SetAccountValues()
        {
            _account.Email = MailTextBox.Text;
            _account.Login = LoginTextBox.Text;
            _account.PasswordHash = BCrypt.Net.BCrypt.HashPassword(PasswordTextBox.Text);
        }

        private bool DataValidation()
        {
            bool isMailValid = MailTextBox.ForeColor == Color.Black && !string.IsNullOrEmpty(MailTextBox.Text);
            bool isLoginValid = (LoginTextBox.ForeColor == Color.Black && !string.IsNullOrEmpty(LoginTextBox.Text));
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



        // Интерфейс
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
            var login_register_control = new JobSeekerRegister0_Page(_account);
            login_register_control.Dock = DockStyle.Fill;
            Controls.Add(login_register_control);
        }
        private void Next_Button_Click(object sender, EventArgs e)
        {

            if (!DataValidation())
                return;

            SetAccountValues();

            Controls.Clear();
            var employee_register_control = new JobSeekerRegister2_Page(_account);
            employee_register_control.Dock = DockStyle.Fill;
            Controls.Add(employee_register_control);
        }
    }
}
