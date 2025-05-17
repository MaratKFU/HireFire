using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HireFire.Classes.Entities;
using HireFire.Classes.DataBase;
using HireFire.Classes.CustomInterfaceControls;
using Microsoft.EntityFrameworkCore;
using System.Security.Principal;

namespace HireFire.UserControls
{
    public partial class SearchResumes_Page : UserControl
    {
        Employer employer;
        int currentResumeIndex = 0;
        List<Resume> results = [];
        public SearchResumes_Page(Employer _employer)
        {
            DoubleBuffered = true;

            InitializeComponent();
            employer = _employer;
            ProfessionCriterion.DataSource = Resourses.Lists.Professions;
            CityCriterion.DataSource = Resourses.Lists.Cities;
            ExpCriterion.AddPlaceholder("Стаж:");
            UpdateResumeDisplay();
        }
        private void DialogsButton_Click(object sender, EventArgs e)
        {
            if (employer.DialogsIds == null || employer.DialogsIds.Count == 0)
            {
                MessageBox.Show("У вас пока что нету диалогов");
                return;
            }
            Controls.Clear();
            var dialog_page_control = new EmployerDialogs_Page(employer);
            dialog_page_control.Dock = DockStyle.Fill;
            Controls.Add(dialog_page_control);
        }
        private void ProfileButton_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            var profile_page_control = new Vacancies_Page(employer);
            profile_page_control.Dock = DockStyle.Fill;
            Controls.Add(profile_page_control);
        }
        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                var profession = ProfessionCriterion.Text.Trim();
                var city = CityLabel.Text.Trim();
                var experience = ExpCriterion.Text.Trim();

                if (!decimal.TryParse(experience, out var s))
                {
                    MessageBox.Show("Введите числовое значение для опыта работы");
                    return;
                }

                using (var db = new AppDbContext())
                {
                    results = db.Resumes
                        .Where(r => r.Profession.Contains(profession))
                        .OrderBy(r => r.City == city ? 0 : 1)
                        .ThenByDescending(r => r.Experience)
                        .ToList();
                }
                ;
                UpdateResumeDisplay();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }
        private void UpdateResumeDisplay()
        {
            var dataService = new DataService();
            if (results == null || results.Count == 0)
            {
                ProfilePictureBox.Image = Properties.Resources.Profile_Icon_Passive;

                FullNameLabel.Text = "Резюме не найдены.";
                ProfessionLabel.Text = "Для поиска";
                EducationLabel.Text = "сначала выберите";
                ExperienceLabel.Text = "критерии поиска соискателей.";
                CityLabel.Text = "Затем нажмите";
                SalaryLabel.Text = "на кнопку";
                SkillsLabel.Text = "Искать";
                return;
            }

            var currentResume = results[currentResumeIndex];
            var currentJobSeeker = dataService.GetJobSeeker(currentResume.JobSeekerId);

            var image = Image.FromStream(new MemoryStream(currentJobSeeker.PhotoData));
            ProfilePictureBox.Image = new Bitmap(image);
            
            FullNameLabel.Text = $"{currentJobSeeker.Surname} {currentJobSeeker.Name} {currentJobSeeker.Lastname}";
            ProfessionLabel.Text = $"Профессия: {currentResume.Profession}";
            EducationLabel.Text = $"Образование: {currentResume.Education}".WrapText(new Font("Montserrat", 9F, FontStyle.Bold), 400);
            ExperienceLabel.Text = $"Опыт работы (в годах): {currentResume.Experience}";
            CityLabel.Text = $"Город проживания: {currentResume.City}";
            SalaryLabel.Text = $"Зарплата: {currentResume.Salary} рублей";
            SkillsLabel.Text = $"Навыки: {string.Join(", ", currentResume.SoftSkills)}".WrapText(new Font("Montserrat", 9F, FontStyle.Bold), 100);
            DescriptionLabel.SetWrappedText(currentResume.Description);
            
            currentResumeIndex++;
            currentResumeIndex %= results.Count;
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            if (results == null || results.Count == 0)
            {
                MessageBox.Show("Сначала найдите резюме");
                return;
            }

            var dataService = new DataService();

            var newDialog = new MyDialog
            {
                JobSeekerId = results[currentResumeIndex].JobSeekerId,
                EmployerId = employer.Id,
                MessagesIds = [],
                EmployerInit = employer.ToString(),
                JobSeekerInit = dataService.GetJobSeeker(results[currentResumeIndex].JobSeekerId).ToString()
            };


            int dialogId = dataService.SaveDialog(newDialog);

            employer.DialogsIds.Add(dialogId);
            dataService.GetJobSeeker(results[currentResumeIndex].JobSeekerId).DialogsIds.Add(dialogId);

            dataService.SaveEmployer(employer);
            Controls.Clear();
            var dialogs_page_control = new EmployerDialogs_Page(dataService.GetEmployer(employer.Id));
            dialogs_page_control.Dock = DockStyle.Fill;
            Controls.Add(dialogs_page_control);
        }
        private void NextResumeButton_Click(object sender, EventArgs e)
        {
            UpdateResumeDisplay();
        }
    }
}
