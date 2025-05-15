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
using HireFire.UserControls;
using HireFire.Classes.DataBase;
using System.Drawing.Imaging;


namespace HireFire
{
    public partial class EmployerRegister2_Page : UserControl
    {
        Employer _account;
        public EmployerRegister2_Page(Employer account)
        {
            DoubleBuffered = true;

            InitializeComponent();
            _account = account;
        }

        private void EmployerRegister2_Page_Load(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            var employer_register_control = new EmployerRegister1_Page(_account);
            employer_register_control.Dock = DockStyle.Fill;
            Controls.Add(employer_register_control);
        }
        private void FinishButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Проверка наличия изображения
                if (ProfilePictureBox.Image == null)
                {
                    MessageBox.Show("Пожалуйста, загрузите фото профиля!");
                    return;
                }

                // Конвертация изображения в byte[]
                using (var memoryStream = new MemoryStream())
                {
                    ProfilePictureBox.Image.Save(memoryStream, ImageFormat.Jpeg);

                    // Проверка размера (например, максимум 5 МБ)
                    if (memoryStream.Length > 5 * 1024 * 1024)
                    {
                        MessageBox.Show("Размер изображения не должен превышать 5 МБ");
                        return;
                    }
                    
                    _account.PhotoData = memoryStream.ToArray();
                }

                // Проверка заполненности полей
                if (!IsAccountDataValid())
                {
                    MessageBox.Show("Заполните все обязательные поля!");
                    return;
                }

                // Сохранение в базу данных
                using (var dataService = new DataService())
                {
                    dataService.SaveEmployer(_account);
                    MessageBox.Show("Регистрация прошла успешно!");
                }

                Controls.Clear();
                var employer_register_control = new Vacancies_Page(_account);
                employer_register_control.Dock = DockStyle.Fill;
                Controls.Add(employer_register_control);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }
        private bool IsAccountDataValid()
        {
            return !string.IsNullOrEmpty(_account.Name) &&
                   !string.IsNullOrEmpty(_account.Surname) &&
                   !string.IsNullOrEmpty(_account.Lastname) &&
                   !string.IsNullOrEmpty(_account.City) &&
                   !string.IsNullOrEmpty(_account.Gender) &&
                   !string.IsNullOrEmpty(_account.Email) &&
                   !string.IsNullOrEmpty(_account.Login) &&
                   !string.IsNullOrEmpty(_account.PasswordHash);
        }

        private void AddPhotoButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (var stream = new FileStream(openFileDialog.FileName, FileMode.Open))
                        {
                            var image = Image.FromStream(stream);
                            ProfilePictureBox.Image = image;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка загрузки изображения: {ex.Message}");
                    }
                }
            }
        }

    }
}
