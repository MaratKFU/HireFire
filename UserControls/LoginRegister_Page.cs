using HireFire.Classes.Entities;

namespace HireFire
{
    public partial class LoginRegister_Page : UserControl
    {
        
        public LoginRegister_Page()
        {
            InitializeComponent();
        }

        private void LoginRegiser_Page_Load(object sender, EventArgs e) { }

        private void Btn_employer_Press(object sender, EventArgs e)
        {
            Btn_employee.AnotherBtnClicked();
        }

        private void Btn_employee_Press(object sender, EventArgs e)
        {
            Btn_employer.AnotherBtnClicked();
        }

        private void Btn_Enter_Click(object sender, EventArgs e)
        {

            Controls.Clear();
            Login_Page enter_control;
            if (Btn_employer.MousePressed)
            {
                enter_control = new Login_Page(true);
            }
            else
            {
                enter_control = new Login_Page(false);
            }
            enter_control.Dock = DockStyle.Fill;
            Controls.Add(enter_control);
            
        }

        private void Btn_register_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            
            if (Btn_employer.MousePressed)
            {
                var employer_register_control = new EmployerRegister0_Page(new Employer());
                employer_register_control.Dock = DockStyle.Fill;
                Controls.Add(employer_register_control);
            }
            else
            {
                JobSeekerRegister0_Page employee_register_control = new JobSeekerRegister0_Page(new JobSeeker());
                employee_register_control.Dock = DockStyle.Fill;
                Controls.Add(employee_register_control);
            }
        }
    }
}
