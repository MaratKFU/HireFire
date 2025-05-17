using HireFire.Classes.Entities;
using HireFire.Classes.DataBase;
using HireFire.Classes.CustomInterfaceControls;
namespace HireFire.UserControls
{
    public partial class CreateResume_Page : UserControl
    {
        JobSeeker jobSeeker;
        public CreateResume_Page(JobSeeker _jobSeeker)
        {
            DoubleBuffered = true;

            InitializeComponent();
            jobSeeker = _jobSeeker;

            ProfessionsComboBox.DataSource = Resourses.Lists.Professions;
            CitiesComboBox.DataSource = Resourses.Lists.Cities;

            SetPlaceholderValues();
        }

        //Бизнес логика
        private void LoadData(ref Resume resume)
        {
            resume.JobSeekerId = jobSeeker.Id;
            resume.Profession = ProfessionsComboBox.Text;
            resume.Education = EducationTextBox.Text;
            resume.Experience = int.Parse(ExperienceTextBox.Text);
            resume.SoftSkills = SoftSkillsTextBox.Text;
            resume.City = CitiesComboBox.Text;
            resume.Description = DescriptionTextBox.Text;
            resume.Salary = decimal.Parse(SalaryTextBox.Text);
        }
        private bool IsResumeDataValid()
        {
            bool isProfessionValid = ProfessionsComboBox.Text != "";
            bool isEducationValid = EducationTextBox.ForeColor == Color.Black && !string.IsNullOrEmpty(EducationTextBox.Text);
            bool isExperienceValid = ExperienceTextBox.ForeColor == Color.Black && !string.IsNullOrEmpty(ExperienceTextBox.Text) && int.TryParse(ExperienceTextBox.Text, out var experience);
            bool isSoftSkillsValid = SoftSkillsTextBox.ForeColor == Color.Black && !string.IsNullOrEmpty(SoftSkillsTextBox.Text);
            bool isDescriptionValid = DescriptionTextBox.ForeColor == Color.Black && !string.IsNullOrEmpty(DescriptionTextBox.Text);
            bool isSalaryValid = (SalaryTextBox.ForeColor == Color.Black && !string.IsNullOrEmpty(SalaryTextBox.Text) && decimal.TryParse(SalaryTextBox.Text, out var salary)) && salary < 1000000;

            return isProfessionValid &&
                   isEducationValid &&
                   isExperienceValid &&
                   isSoftSkillsValid &&
                   isDescriptionValid &&
                   isSalaryValid;
        }



        //Интерфейс
        private void SetPlaceholderValues()
        {
            SalaryTextBox.AddPlaceholder("Зарплата (в рублях)");
            ExperienceTextBox.AddPlaceholder("Стаж работы");
            EducationTextBox.AddPlaceholder("Образование");
            SoftSkillsTextBox.AddPlaceholder("Ваши софт навыки");
            DescriptionTextBox.AddPlaceholder("Описание");
        }
        private void SearchButton_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            var search_page_control = new SearchVacancies_Page(jobSeeker);
            search_page_control.Dock = DockStyle.Fill;
            Controls.Add(search_page_control);

        }
        private void CreateButton_Click(object sender, EventArgs e)
        {
            var resume = new Resume();
            if (!IsResumeDataValid())
            {
                MessageBox.Show("Данные введены некорректно/не введены!");
                return;
            }

            LoadData(ref resume);

            using (var dataService = new DataService())
            {
                dataService.SaveResume(resume);
                MessageBox.Show("Резюме успешно создано!");

                Controls.Clear();
                var resumes_control = new Resumes_Page(dataService.GetJobSeeker(jobSeeker.Id));
                resumes_control.Dock = DockStyle.Fill;
                Controls.Add(resumes_control);
            }
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
        private void BackButton_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            var employer_register_control = new Resumes_Page(jobSeeker);
            employer_register_control.Dock = DockStyle.Fill;
            Controls.Add(employer_register_control);
        }
    }
}