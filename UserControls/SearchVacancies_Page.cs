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
using HireFire.Classes.CustomInterfaceControls;

namespace HireFire.UserControls
{
    public partial class SearchVacancies_Page : UserControl
    {
        private JobSeeker jobSeeker;
        public SearchVacancies_Page(JobSeeker _jobSeeker)
        {
            DoubleBuffered = true;

            InitializeComponent();
            
            ProfessionCriterion.DataSource = Resourses.Lists.Professions;
            CityCriterion.DataSource = Resourses.Lists.Cities;

            SalaryCriterion.AddPlaceholder("Опыт работы");
            jobSeeker = _jobSeeker;
        }
        private void DialogsButton_Click(object sender, EventArgs e)
        {
            if (jobSeeker.DialogsIds == null || jobSeeker.DialogsIds.Count == 0)
            {
                MessageBox.Show("У вас нет диалогов");
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
    }
}
