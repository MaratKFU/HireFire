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
    public partial class CreateVacancy_Page : UserControl
    {
        public CreateVacancy_Page()
        {
            InitializeComponent();
            ProfessionTextBox.AddPlaceholder("Профессия");
            SalaryTextBox.AddPlaceholder("Зарплата");
            ExperienceTextBox.AddPlaceholder("Мин. стаж");
            CityTextBox.AddPlaceholder("Город");
            CompanyTextBox.AddPlaceholder("Навание компании");
            DescriptionTextBox.AddPlaceholder("Описание");

        }

        private void CreateVacancy_Page_Load(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {

        }
        private void DialogsButton_Click(object sender, EventArgs e)
        {

        }
    }
}
