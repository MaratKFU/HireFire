using System.Data;
using HireFire.Classes.Entities;
using HireFire.Classes.CustomInterfaceControls;
using HireFire.Classes.DataBase;

namespace HireFire.UserControls
{
    public partial class SearchVacancies_Page : UserControl
    {
        private JobSeeker jobSeeker;
        int currentVacancyIndex = 0;
        List<Vacancy> results = [];
        public SearchVacancies_Page(JobSeeker _jobSeeker)
        {
            DoubleBuffered = true;

            InitializeComponent();
            jobSeeker = _jobSeeker;
            ProfessionCriterion.DataSource = Resourses.Lists.Professions;
            CityCriterion.DataSource = Resourses.Lists.Cities;
            SalaryCriterion.AddPlaceholder("Зарплата:");
            UpdateVacancyDisplay();
        }
        private void DialogsButton_Click(object sender, EventArgs e)
        {
            if (jobSeeker.DialogsIds == null || jobSeeker.DialogsIds.Count == 0)
            {
                MessageBox.Show("У вас пока что нету диалогов");
                return;
            }

            Controls.Clear();
            var dialog_page_control = new JobSeekerDialogs_Page(jobSeeker);
            dialog_page_control.Dock = DockStyle.Fill;
            Controls.Add(dialog_page_control);
        }
        private void ProfileButton_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            var profile_page_control = new Resumes_Page(jobSeeker);
            profile_page_control.Dock = DockStyle.Fill;
            Controls.Add(profile_page_control);
        }
        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                var profession = ProfessionCriterion.Text.Trim();
                var city = CityLabel.Text.Trim();
                var salary = SalaryCriterion.Text.Trim();
                
                if (!decimal.TryParse(salary, out var s)){
                    MessageBox.Show("Введите числовое значение для зарплаты");
                    return;
                }

                using (var db = new AppDbContext())
                {
                    results = db.Vacancies
                        .Where(r => r.Profession.Contains(profession))
                        .OrderBy(r => r.City == city ? 0 : 1)
                        .ThenByDescending(r => r.Salary)
                        .ToList();
                }
                ;
                UpdateVacancyDisplay();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }
        private void UpdateVacancyDisplay()
        {
            var dataService = new DataService();
            if (results == null || results.Count == 0)
            {
                ProfilePictureBox.Image = Properties.Resources.Profile_Icon_Passive;

                ProfessionLabel.Text = "Вакансии не найдены.";
                CompanyNameLabel.Text = "Для поиска";
                SalaryLabel.Text = "сначала выберите";
                ExperienceLabel.Text = "критерии поиска соискателей.";
                CityLabel.Text = "Затем нажмите";
                FullNameLabel.Text = "на кнопку Искать";
                return;
            }

            var currentVacancy = results[currentVacancyIndex];
            var currentEmployer = dataService.GetJobSeeker(currentVacancy.EmployerId);

            var image = Image.FromStream(new MemoryStream(currentEmployer.PhotoData));
            ProfilePictureBox.Image = new Bitmap(image);
            
            ProfessionLabel.Text = $"Профессия: {currentVacancy.Profession}";
            CompanyNameLabel.Text = $"Компания: {currentVacancy.CompanyName}";
            SalaryLabel.Text = $"Зарплата: {currentVacancy.Salary} рублей";
            ExperienceLabel.Text = $"Опыт работы (в годах): {currentVacancy.Experience}";
            CityLabel.Text = $"Город проживания: {currentVacancy.City}";
            FullNameLabel.Text = $"Работодатель: {currentEmployer.Surname} {currentEmployer.Name} {currentEmployer.Lastname}";
            DescriptionLabel.SetWrappedText(currentVacancy.Description);

            currentVacancyIndex++;
            currentVacancyIndex %= results.Count;
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            if (results == null || results.Count == 0)
            {
                MessageBox.Show("Сначала найдите вакансию");
                return;
            }

            var dataService = new DataService();

            var newDialog = new MyDialog
            {
                EmployerId = results[currentVacancyIndex].EmployerId,
                JobSeekerId = jobSeeker.Id,
                MessagesIds = [],
                JobSeekerInit = jobSeeker.ToString(),
                EmployerInit = dataService.GetEmployer(results[currentVacancyIndex].EmployerId).ToString()
            };


            int dialogId = dataService.SaveDialog(newDialog);

            jobSeeker.DialogsIds.Add(dialogId);
            dataService.GetEmployer(results[currentVacancyIndex].EmployerId).DialogsIds.Add(dialogId);

            dataService.SaveJobSeeker(jobSeeker);
            Controls.Clear();
            var dialogs_page_control = new JobSeekerDialogs_Page(dataService.GetJobSeeker(jobSeeker.Id));
            dialogs_page_control.Dock = DockStyle.Fill;
            Controls.Add(dialogs_page_control);
        }
        private void NextVacancyButton_Click(object sender, EventArgs e)
        {
            UpdateVacancyDisplay();
        }
    }
}
