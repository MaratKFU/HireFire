using HireFire.Classes.CustomInterfaceControls;

namespace HireFire
{
    partial class EmployerRegister2_Page
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            ProfilePictureBox = new PictureBox();
            AddPhoto_Button = new RoundedButton1();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            Back_Button = new RoundedButton1();
            Finish_Button = new RoundedButton1();
            roundedRectangle1 = new RoundedRectangle();
            ((System.ComponentModel.ISupportInitialize)ProfilePictureBox).BeginInit();
            SuspendLayout();
            // 
            // ProfilePictureBox
            // 
            ProfilePictureBox.Location = new Point(400, 279);
            ProfilePictureBox.Name = "ProfilePictureBox";
            ProfilePictureBox.Size = new Size(156, 121);
            ProfilePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            ProfilePictureBox.TabIndex = 72;
            ProfilePictureBox.TabStop = false;
            // 
            // AddPhoto_Button
            // 
            AddPhoto_Button.BackColor = Color.White;
            AddPhoto_Button.CornerColor = Color.White;
            AddPhoto_Button.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Bold);
            AddPhoto_Button.ForeColor = Color.FromArgb(242, 85, 26);
            AddPhoto_Button.Location = new Point(433, 238);
            AddPhoto_Button.Name = "AddPhoto_Button";
            AddPhoto_Button.Rounding = 20;
            AddPhoto_Button.Size = new Size(95, 35);
            AddPhoto_Button.TabIndex = 71;
            AddPhoto_Button.Text = "Добавить фото";
            AddPhoto_Button.Click += AddPhotoButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Microsoft Sans Serif", 5F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(161, 148, 148);
            label5.Location = new Point(400, 223);
            label5.Name = "label5";
            label5.Size = new Size(156, 12);
            label5.TabIndex = 70;
            label5.Text = "Вам легче смогут довериться\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            label2.Location = new Point(369, 183);
            label2.Name = "label2";
            label2.Size = new Size(229, 40);
            label2.TabIndex = 69;
            label2.Text = "Добавьте фотографию\n    к вашему профилю";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Window;
            label1.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(241, 78, 28);
            label1.Location = new Point(400, 159);
            label1.Name = "label1";
            label1.Size = new Size(167, 24);
            label1.TabIndex = 68;
            label1.Text = "Последний шаг!";
            // 
            // Back_Button
            // 
            Back_Button.BackColor = Color.White;
            Back_Button.CornerColor = Color.White;
            Back_Button.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Bold);
            Back_Button.ForeColor = Color.FromArgb(242, 85, 26);
            Back_Button.Location = new Point(345, 421);
            Back_Button.Name = "Back_Button";
            Back_Button.Rounding = 20;
            Back_Button.Size = new Size(75, 25);
            Back_Button.TabIndex = 66;
            Back_Button.Text = "Назад";
            Back_Button.Click += BackButton_Click;
            // 
            // Finish_Button
            // 
            Finish_Button.BackColor = Color.FromArgb(242, 85, 26);
            Finish_Button.CornerColor = Color.White;
            Finish_Button.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Bold);
            Finish_Button.ForeColor = Color.White;
            Finish_Button.Location = new Point(545, 421);
            Finish_Button.Name = "Finish_Button";
            Finish_Button.Rounding = 20;
            Finish_Button.Size = new Size(75, 25);
            Finish_Button.TabIndex = 65;
            Finish_Button.Text = "Завершить";
            Finish_Button.Click += FinishButton_Click;
            // 
            // roundedRectangle1
            // 
            roundedRectangle1.BackColor = Color.White;
            roundedRectangle1.CornerColor = Color.FromArgb(229, 229, 229);
            roundedRectangle1.ForeColor = Color.White;
            roundedRectangle1.Location = new Point(317, 80);
            roundedRectangle1.Name = "roundedRectangle1";
            roundedRectangle1.Rounding = 100;
            roundedRectangle1.Size = new Size(327, 380);
            roundedRectangle1.TabIndex = 64;
            roundedRectangle1.Text = "roundedRectangle1";
            // 
            // EmployerRegister2_Page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(229, 229, 229);
            Controls.Add(ProfilePictureBox);
            Controls.Add(AddPhoto_Button);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Back_Button);
            Controls.Add(Finish_Button);
            Controls.Add(roundedRectangle1);
            Name = "EmployerRegister2_Page";
            Size = new Size(960, 540);
            Load += EmployerRegister2_Page_Load;
            ((System.ComponentModel.ISupportInitialize)ProfilePictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox ProfilePictureBox;
        private RoundedButton1 AddPhoto_Button;
        private Label label5;
        private Label label2;
        private Label label1;
        private RoundedButton1 Back_Button;
        private RoundedButton1 Finish_Button;
        private RoundedRectangle roundedRectangle1;
    }
}
