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
            MessageBox.Show("Пожалуйста, загрузите фото профиля!");
            return ProfilePictureBox.Image == null;
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
            if (!DataValidation())
                return;
            try
            {
                using (var memoryStream = new MemoryStream())
                {
                    ProfilePictureBox.Image.Save(memoryStream, ImageFormat.Jpeg);

                    if (memoryStream.Length > 5 * 1024 * 1024)
                    {
                        MessageBox.Show("Размер изображения не должен превышать 5 МБ");
                        return;
                    }

                    _account.PhotoData = memoryStream.ToArray();
                }

                using (var dataService = new DataService())
                {
                    dataService.SaveJobSeeker(_account);
                    MessageBox.Show("Регистрация прошла успешно!");
                }

                Controls.Clear();
                var jobSeeker_register_control = new Resumes_Page(_account);
                jobSeeker_register_control.Dock = DockStyle.Fill;
                Controls.Add(jobSeeker_register_control);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }
        private void AddPhotoButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Выберите фото профиля";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        Image uploadedImage = Image.FromFile(openFileDialog.FileName);

                        ProfilePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        ProfilePictureBox.Image = uploadedImage;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка загрузки изображения: {ex.Message}",
                                      "Ошибка",
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
