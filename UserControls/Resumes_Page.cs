using HireFire.Classes.Entities;
using HireFire.Classes.CustomInterfaceControls;

namespace HireFire.UserControls
{
    public partial class Resumes_Page : UserControl
    {
        public JobSeeker jobSeeker;
        private int _currentResumeIndex = 0;
        public Resumes_Page(JobSeeker account)
        {
            DoubleBuffered = true;

            InitializeComponent();
            jobSeeker = account;
            Load_Values();
            UpdateResumeDisplay();
        }
        void Load_Values()
        {
            var image = Image.FromStream(new MemoryStream(jobSeeker.PhotoData));
            ProfilePictureBox.Image = new Bitmap(image);
            FullNameLabel.Text = $"{jobSeeker.Surname} {jobSeeker.Name} {jobSeeker.Lastname}";
        }
        private void UpdateResumeDisplay()
        {
            if (jobSeeker.Resumes == null || jobSeeker.Resumes.Count == 0)
            {
                ProfessionLabel.Text = "Профессия: не указана";
                EducationLabel.Text = "Образование: не указано";
                ExperienceLabel.Text = "Опыт работы: отсутствует";
                CityLabel.Text = "Город: не указан";
                SkillsLabel.Text = "Навыки: не добавлены";
                return;
            }

            var currentResume = jobSeeker.Resumes.ElementAt(_currentResumeIndex);

            ProfessionLabel.Text = $"Профессия: {currentResume.Profession}";
            EducationLabel.Text = $"Образование: {currentResume.Education}";
            ExperienceLabel.Text = $"Опыт работы (в годах): {currentResume.Experience}";
            SalaryLabel.Text = $"Желаемая зарплата: {currentResume.Salary} рублей";
            CityLabel.Text = $"Город проживания: {currentResume.City}";
            SkillsLabel.Text = $"Навыки: {string.Join(", ", currentResume.SoftSkills)}";
            DescriptionLabel.SetWrappedText(currentResume.Description);
        }
        private void EditButton_Click(object sender, EventArgs e)
        {

        }

        private void NextResumeButton_Click(object sender, EventArgs e)
        {
            if (jobSeeker.Resumes.Count != 0)
            {
                _currentResumeIndex++;
                _currentResumeIndex %= jobSeeker.Resumes.Count;
                UpdateResumeDisplay();
            }
        }

        private void CreateResumeButton_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            var createResume_control = new CreateResume_Page(jobSeeker);
            createResume_control.Dock = DockStyle.Fill;
            Controls.Add(createResume_control);
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            var search_page_control = new SearchVacancies_Page(jobSeeker);
            search_page_control.Dock = DockStyle.Fill;
            Controls.Add(search_page_control);

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
    }
}
