using HireFire.Classes.Entities;
using System.Linq;

namespace HireFire.UserControls
{
    public partial class Resumes_Page : UserControl
    {
        public JobSeeker _account;
        private int _currentResumeIndex = 0;
        public Resumes_Page(JobSeeker account)
        {
            InitializeComponent();
            _account = account;
            Load_Values();
            UpdateResumeDisplay();
        }
        void Load_Values()
        {
            var image = Image.FromStream(new MemoryStream(_account.PhotoData));
            ProfilePictureBox.Image = new Bitmap(image);
            FullNameLabel.Text = $"{_account.Surname} {_account.Name} {_account.Lastname}";
            /*
            ProfessionLabel.Text = $"Профессия: {_account.Name}";
            EducationLabel.Text = $"Образование: {_account.Surname} {_account.Name} {_account.Lastname} ";
            ExperienceLabel.Text = $"Опыт работы: {_account.Surname} {_account.Name} {_account.Lastname} ";
            SalaryLabel.Text = $"Опыт работы: {_account.Surname} {_account.Name} {_account.Lastname} ";
            CityLabel.Text = $"Город проживания:{_account.Surname} {_account.Name} {_account.Lastname} ";
            SkillsLabel.Text = $"Навыки: {_account.Surname} {_account.Name} {_account.Lastname} ";*/
        }
        private void UpdateResumeDisplay()
        {
            if (_account.Resumes == null || _account.Resumes.Count == 0)
            {
                // Очистка или сообщение, если резюме нет
                ProfessionLabel.Text = "Профессия: не указана";
                EducationLabel.Text = "Образование: не указано";
                ExperienceLabel.Text = "Опыт работы: отсутствует";
                CityLabel.Text = "Город: не указан";
                SkillsLabel.Text = "Навыки: не добавлены";
                return;
            }

            var currentResume = _account.Resumes.ElementAt(_currentResumeIndex);

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
            _currentResumeIndex++;
            _currentResumeIndex %= _account.Resumes.Count;
            UpdateResumeDisplay();
        }

        private void CreateResumeButton_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            var createResume_control = new CreateResume_Page(_account);
            createResume_control.Dock = DockStyle.Fill;
            Controls.Add(createResume_control);
        }

        private void roundedRectangleWithOutline1_Click(object sender, EventArgs e)
        {

        }
    }
}
