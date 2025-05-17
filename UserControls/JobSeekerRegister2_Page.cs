using HireFire.Classes.DataBase;
using HireFire.Classes.Entities;
using System.Drawing.Imaging;
using HireFire.UserControls;

namespace HireFire
{
    public partial class JobSeekerRegister2_Page : UserControl
    {
        JobSeeker _account;
        public JobSeekerRegister2_Page(JobSeeker account)
        {
            DoubleBuffered = true;

            InitializeComponent();
            _account = account;
        }

        //Бизнес логика
        private bool DataValidation()
        {
            if (ProfilePictureBox.Image == null)
            {
                MessageBox.Show("Пожалуйста, загрузите фото профиля!");
                return false;
            }
            return true;
        }
        private void SaveAccountData()
        {
            using var dataService = new DataService();
            dataService.SaveJobSeeker(_account);
            MessageBox.Show("Регистрация прошла успешно!");
        }
        private void SaveProfileImage()
        {
            using var memoryStream = new MemoryStream();
            ProfilePictureBox.Image.Save(memoryStream, ImageFormat.Jpeg);

            if (memoryStream.Length > 5 * 1024 * 1024)
            {
                MessageBox.Show("Размер изображения не должен превышать 5 МБ");
                throw new InvalidOperationException("Image size exceeded");
            }

            _account.PhotoData = memoryStream.ToArray();
        }




        //Интерфейс
        private void BackButton_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            var employee_register_control = new JobSeekerRegister1_Page(_account);
            employee_register_control.Dock = DockStyle.Fill;
            Controls.Add(employee_register_control);
        }
        private void FinishButton_Click(object sender, EventArgs e)
        {
            if (!DataValidation()) return;

            try
            {
                SaveProfileImage();
                SaveAccountData();
                NavigateToResumesPage();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private void NavigateToResumesPage()
        {
            Controls.Clear();
            var resumesPage = new Resumes_Page(_account) { Dock = DockStyle.Fill };
            Controls.Add(resumesPage);
        }
        private void AddPhotoButton_Click(object sender, EventArgs e)
        {
            using var openFileDialog = new OpenFileDialog
            {
                Title = "Выберите фото профиля",
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp",
                FilterIndex = 1,
                RestoreDirectory = true
            };

            if (openFileDialog.ShowDialog() != DialogResult.OK) return;

            try
            {
                var image = Image.FromFile(openFileDialog.FileName);
                ProfilePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                ProfilePictureBox.Image = image;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки изображения: {ex.Message}", "Ошибка");
            }
        }
    }
}
