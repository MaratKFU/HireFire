using HireFire.Classes.Entities;
using HireFire.Classes.DataBase;
using HireFire.Classes.CustomInterfaceControls;

namespace HireFire.UserControls
{
    public partial class CreateVacancy_Page : UserControl
    {
        Employer employer;
        public CreateVacancy_Page(Employer _employer)
        {
            DoubleBuffered = true;

            InitializeComponent();
            employer = _employer;

            ProfessionsComboBox.DataSource = Resourses.Lists.Professions;
            CitiesComboBox.DataSource = Resourses.Lists.Cities;

            SetPlaceholderValues();
        }



        //Бизнес логика
        private bool IsResumeDataValid()
        {
            bool isProfessionValid = ProfessionsComboBox.Text != "";
            bool isSalaryValid = (SalaryTextBox.ForeColor == Color.Black && !string.IsNullOrEmpty(SalaryTextBox.Text) && decimal.TryParse(SalaryTextBox.Text, out var salary)) && salary < 1000000;
            bool isExperienceValid = ExperienceTextBox.ForeColor == Color.Black && !string.IsNullOrEmpty(ExperienceTextBox.Text) && int.TryParse(ExperienceTextBox.Text, out var experience);
            bool isCompanyValid = CompanyTextBox.ForeColor == Color.Black && !string.IsNullOrEmpty(CompanyTextBox.Text);
            bool isDescriptionValid = DescriptionTextBox.ForeColor == Color.Black && !string.IsNullOrEmpty(DescriptionTextBox.Text);

            return isProfessionValid &&
                   isSalaryValid &&
                   isExperienceValid &&
                   isCompanyValid &&
                   isDescriptionValid;
        }
        private void LoadData(ref Vacancy vacancy)
        {
            vacancy.EmployerId = employer.Id;
            vacancy.Profession = ProfessionsComboBox.Text;
            vacancy.Salary = decimal.Parse(SalaryTextBox.Text);
            vacancy.Experience = int.Parse(ExperienceTextBox.Text);
            vacancy.City = CitiesComboBox.Text;
            vacancy.CompanyName = CompanyTextBox.Text;
            vacancy.Description = DescriptionTextBox.Text;
        }


        //Интерфейс
        private void SetPlaceholderValues()
        {
            SalaryTextBox.AddPlaceholder("Зарплата (в рублях)");
            ExperienceTextBox.AddPlaceholder("Мин. стаж");
            CompanyTextBox.AddPlaceholder("Навание компании");
            DescriptionTextBox.AddPlaceholder("Описание");
        }
        private void CreateButton_Click(object sender, EventArgs e)
        {
            var vacancy = new Vacancy();
            if (!IsResumeDataValid())
            {
                MessageBox.Show("Данные введены некорректно/не введены!");
                return;
            }

            LoadData(ref vacancy);

            using (var dataService = new DataService())
            {
                dataService.SaveVacancy(vacancy);
                MessageBox.Show("Вакансия успешно создана!");

                Controls.Clear();
                var employer_control = new Vacancies_Page(dataService.GetEmployer(employer.Id));
                employer_control.Dock = DockStyle.Fill;
                Controls.Add(employer_control);
            }
        }
        private void SearchButton_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            var search_page_control = new SearchResumes_Page(employer);
            search_page_control.Dock = DockStyle.Fill;
            Controls.Add(search_page_control);
        }
        private void DialogsButton_Click(object sender, EventArgs e)
        {
            if (employer.DialogsIds == null || employer.DialogsIds.Count == 0)
            {
                MessageBox.Show("У вас пока что нету диалогов");
                return;
            }
            Controls.Clear();
            var dialogs_page_control = new EmployerDialogs_Page(employer);
            dialogs_page_control.Dock = DockStyle.Fill;
            Controls.Add(dialogs_page_control);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            var vacancies_page_control = new Vacancies_Page(employer);
            vacancies_page_control.Dock = DockStyle.Fill;
            Controls.Add(vacancies_page_control);
        }
    }
}
