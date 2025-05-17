namespace HireFire
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Acception1_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            LoginRegister_Page login_register_control = new LoginRegister_Page();
            login_register_control.Dock = DockStyle.Fill;
            Controls.Add(login_register_control);
        }
    }
}
