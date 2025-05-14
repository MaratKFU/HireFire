using HireFire.Classes.Entities;
using HireFire.Classes.DataBase;
using HireFire.Classes.CustomInterfaceControls;

namespace HireFire.UserControls
{
    public partial class CreateResume_Page : UserControl
    {
        JobSeeker? _jobSeeker;
        public CreateResume_Page(JobSeeker jobSeeker)
        {
            InitializeComponent();

            _jobSeeker = jobSeeker;

            ProfessionTextBox.AddPlaceholder("Профессия");
            SalaryTextBox.AddPlaceholder("Зарплата");
            ExperienceTextBox.AddPlaceholder("Стаж работы");
            CityTextBox.AddPlaceholder("Город");
            EducationTextBox.AddPlaceholder("Образование");
            SoftSkillsTextBox.AddPlaceholder("Ваши софт навыки");
            DescriptionTextBox.AddPlaceholder("Описание");
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
                var employer_register_control = new Resumes_Page(dataService.GetJobSeeker(_jobSeeker.Id));
                employer_register_control.Dock = DockStyle.Fill;
                Controls.Add(employer_register_control);
            }
        }
        private bool IsResumeDataValid()
        {
            bool isProfessionValid = ProfessionTextBox.ForeColor == Color.Black && !string.IsNullOrEmpty(ProfessionTextBox.Text);
            bool isEducationValid = EducationTextBox.ForeColor == Color.Black && !string.IsNullOrEmpty(EducationTextBox.Text);
            bool isExperienceValid = ExperienceTextBox.ForeColor == Color.Black && !string.IsNullOrEmpty(ExperienceTextBox.Text) && int.TryParse(ExperienceTextBox.Text, out var experience);
            bool isSoftSkillsValid = SoftSkillsTextBox.ForeColor == Color.Black && !string.IsNullOrEmpty(SoftSkillsTextBox.Text);
            bool isCityValid = CityTextBox.ForeColor == Color.Black && !string.IsNullOrEmpty(CityTextBox.Text);
            bool isDescriptionValid = DescriptionTextBox.ForeColor == Color.Black && !string.IsNullOrEmpty(DescriptionTextBox.Text);
            bool isSalaryValid = (SalaryTextBox.ForeColor == Color.Black && !string.IsNullOrEmpty(SalaryTextBox.Text) && decimal.TryParse(SalaryTextBox.Text, out var salary)) && salary < 1000000;

            return isProfessionValid &&
                   isEducationValid &&
                   isExperienceValid &&
                   isSoftSkillsValid &&
                   isCityValid &&
                   isDescriptionValid &&
                   isSalaryValid;
        }
        private void LoadData(ref Resume resume)
        {
            resume.JobseekerId = _jobSeeker.Id;
            resume.Profession = ProfessionTextBox.Text;
            resume.Education = EducationTextBox.Text;
            resume.Experience = int.Parse(ExperienceTextBox.Text);
            resume.SoftSkills = SoftSkillsTextBox.Text;
            resume.City = CityTextBox.Text;
            resume.Description = DescriptionTextBox.Text;
            resume.Salary = decimal.Parse(SalaryTextBox.Text);
        }
        private void CreateResume_Page_Load(object sender, EventArgs e)
        {

        }
    }
}
