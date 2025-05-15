using HireFire.Classes.Entities;
using HireFire.Classes.CustomInterfaceControls;


namespace HireFire.UserControls
{
    public partial class Vacancies_Page : UserControl
    {
        public Employer account;
        private int _currentVacancyIndex = 0;
        public Vacancies_Page(Employer _account)
        {
            DoubleBuffered = true;

            InitializeComponent();

            account = _account;

            Load_Values();
            UpdateResumeDisplay();
        }
        void Load_Values()
        {
            var image = Image.FromStream(new MemoryStream(account.PhotoData));
            ProfilePictureBox.Image = new Bitmap(image);
            FullNameLabel.Text = $"{account.Surname} {account.Name} {account.Lastname}";
        }
        private void UpdateResumeDisplay()
        {
            if (account.Vacancies == null || account.Vacancies.Count == 0)
            {
                ProfessionLabel.Text = "Профессия: не указана";
                SalaryLabel.Text = "Зарплата не указана";
                ExperienceLabel.Text = "Мин. стаж: не указан";
                CityLabel.Text = "Город: не указан";
                CompanyNameLabel.Text = "Название компании: не указано";
                return;
            }

            var currentVacancy = account.Vacancies.ElementAt(_currentVacancyIndex);

            ProfessionLabel.Text = $"Профессия: {currentVacancy.Profession}";
            SalaryLabel.Text = $"Зарплата: {currentVacancy.Salary} рублей";
            ExperienceLabel.Text = $"Мин стаж (в годах): {currentVacancy.Experience}";
            CityLabel.Text = $"Город проживания: {currentVacancy.City}";
            CompanyNameLabel.Text = $"Название компании: {currentVacancy.CompanyName}";
            DescriptionLabel.SetWrappedText(currentVacancy.Description);
        }
        private void NextVacancyButton_Click(object sender, EventArgs e)
        {
            if (account.Vacancies.Count != 0)
            {
                _currentVacancyIndex++;
                _currentVacancyIndex %= account.Vacancies.Count;
                UpdateResumeDisplay();
            }
        }


        private void CreateVacancyButton_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            var createVacancy_control = new CreateVacancy_Page(account);
            createVacancy_control.Dock = DockStyle.Fill;
            Controls.Add(createVacancy_control);
        }

        private void EditButton_Click(object sender, EventArgs e)
        {

        }
        private void SearchButton_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            var search_page_control = new SearchResumes_Page(account);
            search_page_control.Dock = DockStyle.Fill;
            Controls.Add(search_page_control);
        }
        private void DialogsButton_Click(object sender, EventArgs e)
        {
            if (account.DialogsIds == null || account.DialogsIds.Count == 0)
            {
                MessageBox.Show("Для начала необходимо найти соискателя!");
                return;
            }
            Controls.Clear();
            var dialog_page_control = new EmployerDialogs_Page(account);
            dialog_page_control.Dock = DockStyle.Fill;
            Controls.Add(dialog_page_control);
        }

    }
}
