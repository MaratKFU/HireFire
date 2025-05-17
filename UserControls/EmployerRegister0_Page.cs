using HireFire.Classes.CustomInterfaceControls;
using HireFire.Classes.Entities;

namespace HireFire
{
    public partial class EmployerRegister0_Page : UserControl
    {
        Employer _account;
        public EmployerRegister0_Page(Employer account)
        {
            DoubleBuffered = true;

            InitializeComponent();
            _account = account;

            CityComboBox.DataSource = HireFire.Resourses.Lists.Cities;
            SetPlaceholderValues();
        }
        //Бизнес логика
        private void SetAccountValues()
        {
            _account.Name = NameTextBox.Text;
            _account.Surname = SurnameTextBox.Text;
            _account.Lastname = LastnameTextBox.Text;
            _account.City = CityComboBox.Text;
            _account.BirthDate = DateTime.Parse(BirthDatePicker.Text);
        }
        private bool DataValidation()
        {
            bool isNameValid = NameTextBox.ForeColor == Color.Black && !string.IsNullOrEmpty(NameTextBox.Text);
            bool isSurnameValid = SurnameTextBox.ForeColor == Color.Black && !string.IsNullOrEmpty(SurnameTextBox.Text);
            bool isLastnameValid = LastnameTextBox.ForeColor == Color.Black && !string.IsNullOrEmpty(LastnameTextBox.Text);
            bool isCityValid = !string.IsNullOrEmpty(CityComboBox.Text);

            if (!isNameValid || !isSurnameValid || !isLastnameValid || !isCityValid)
            {
                MessageBox.Show("Заполните все обязательные поля!");
                return false;
            }

            return true;
        }


        //Интерфейс
        private void SetPlaceholderValues()
        {
            SurnameTextBox.AddPlaceholder("Фамилию");
            NameTextBox.AddPlaceholder("Имя");
            LastnameTextBox.AddPlaceholder("Отчество");
        }
        private void Next_Button_Click(object sender, EventArgs e)
        {
            if (!DataValidation())
                return;

            SetAccountValues();
            
            Controls.Clear();
            EmployerRegister1_Page login_register_control = new EmployerRegister1_Page(_account);
            login_register_control.Dock = DockStyle.Fill;
            Controls.Add(login_register_control);
        }
        private void Previous_Button_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            var login_register_control = new LoginRegister_Page();
            login_register_control.Dock = DockStyle.Fill;
            Controls.Add(login_register_control);
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
    }
}
