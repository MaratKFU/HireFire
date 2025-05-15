using HireFire.Classes.DataBase;
using HireFire.Classes.Entities;
using HireFire.Classes.CustomInterfaceControls;

namespace HireFire
{
    public partial class JobSeekerRegister0_Page : UserControl
    {
        JobSeeker _account;
        public JobSeekerRegister0_Page(JobSeeker account)
        {
            DoubleBuffered = true;

            InitializeComponent();
            _account = account;

            SurnameTextBox.AddPlaceholder("Фамилию");
            NameTextBox.AddPlaceholder("Имя");
            LastnameTextBox.AddPlaceholder("Отчество");
            CityTextBox.AddPlaceholder("Город");
        }

        private void Btn_SexMale_Press(object sender, EventArgs e)
        {
            Btn_SexFemale.AnotherBtnClicked();
            _account.Gender = "M";
        }

        private void Btn_SexFemale_Press(object sender, EventArgs e)
        {
            Btn_SexMale.AnotherBtnClicked();
            _account.Gender = "F";
        }

        private void Previous_Button_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            var login_register_control = new LoginRegister_Page();
            login_register_control.Dock = DockStyle.Fill;
            Controls.Add(login_register_control);
        }

        private void Next_Button_Click(object sender, EventArgs e)
        {
            bool isNameValid = NameTextBox.ForeColor == Color.Black && !string.IsNullOrEmpty(NameTextBox.Text);
            bool isSurnameValid = SurnameTextBox.ForeColor == Color.Black && !string.IsNullOrEmpty(SurnameTextBox.Text);
            bool isLastnameValid = LastnameTextBox.ForeColor == Color.Black && !string.IsNullOrEmpty(LastnameTextBox.Text);
            bool isCityValid = CityTextBox.ForeColor == Color.Black && !string.IsNullOrEmpty(CityTextBox.Text);

            if (!isNameValid || !isSurnameValid || !isLastnameValid || !isCityValid)
            {
                MessageBox.Show("Заполните все обязательные поля!");
                return;
            }

            _account.Name = NameTextBox.Text;
            _account.Surname = SurnameTextBox.Text;
            _account.Lastname = LastnameTextBox.Text;
            _account.City = CityTextBox.Text;
            _account.BirthDate = DateTime.Parse(BirthDatePicker.Text);

            Controls.Clear();
            var employee_register_control = new JobSeekerRegister1_Page(_account);
            employee_register_control.Dock = DockStyle.Fill;
            Controls.Add(employee_register_control);
        }
    }
}
