﻿namespace HireFire.UserControls
{
    partial class SearchResumes_Page
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
            roundedPictureBox5 = new RoundedPictureBox();
            roundedRectangle3 = new HireFire.Classes.CustomInterfaceControls.RoundedRectangle();
            FullNameLabel = new Label();
            SalaryLabel = new Label();
            SkillsLabel = new Label();
            CityLabel = new Label();
            ExperienceLabel = new Label();
            ProfessionLabel = new Label();
            EducationLabel = new Label();
            label2 = new Label();
            roundedRectangleWithOutline1 = new HireFire.Classes.CustomInterfaceControls.RoundedRectangleWithOutline();
            DescriptionLabel = new Label();
            roundedButton13 = new HireFire.Classes.CustomInterfaceControls.SimpleRoundedButton();
            NextResume_Button = new HireFire.Classes.CustomInterfaceControls.SimpleRoundedButton();
            ProfilePictureBox = new RoundedPictureBox();
            roundedPictureBox4 = new RoundedPictureBox();
            roundedPictureBox3 = new RoundedPictureBox();
            roundedRectangle2 = new HireFire.Classes.CustomInterfaceControls.RoundedRectangle();
            roundedRectangle1 = new HireFire.Classes.CustomInterfaceControls.RoundedRectangle();
            roundedRectangle4 = new HireFire.Classes.CustomInterfaceControls.RoundedRectangle();
            roundedPictureBox2 = new RoundedPictureBox();
            roundedRectangleWithOutline3 = new HireFire.Classes.CustomInterfaceControls.RoundedRectangleWithOutline();
            ExpCriterion = new TextBox();
            SearchButton = new HireFire.Classes.CustomInterfaceControls.SimpleRoundedButton();
            CityCriterion = new ComboBox();
            ProfessionCriterion = new ComboBox();
            label1 = new Label();
            ProfessionCritLabel = new Label();
            CityCritLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)roundedPictureBox5).BeginInit();
            roundedRectangle3.SuspendLayout();
            roundedRectangleWithOutline1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProfilePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roundedPictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roundedPictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roundedPictureBox2).BeginInit();
            roundedRectangleWithOutline3.SuspendLayout();
            SuspendLayout();
            // 
            // roundedPictureBox5
            // 
            roundedPictureBox5.BackColor = Color.FromArgb(0, 0, 0, 0);
            roundedPictureBox5.BorderColor = Color.FromArgb(0, 0, 0, 0);
            roundedPictureBox5.BorderWidth = 200F;
            roundedPictureBox5.CornerRadius = 100;
            roundedPictureBox5.Image = Properties.Resources.Main_Icon;
            roundedPictureBox5.Location = new Point(0, 0);
            roundedPictureBox5.Name = "roundedPictureBox5";
            roundedPictureBox5.Size = new Size(80, 80);
            roundedPictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            roundedPictureBox5.TabIndex = 28;
            roundedPictureBox5.TabStop = false;
            // 
            // roundedRectangle3
            // 
            roundedRectangle3.BackColor = Color.White;
            roundedRectangle3.Controls.Add(FullNameLabel);
            roundedRectangle3.Controls.Add(SalaryLabel);
            roundedRectangle3.Controls.Add(SkillsLabel);
            roundedRectangle3.Controls.Add(CityLabel);
            roundedRectangle3.Controls.Add(ExperienceLabel);
            roundedRectangle3.CornerColor = Color.FromArgb(229, 229, 229);
            roundedRectangle3.ForeColor = Color.White;
            roundedRectangle3.Location = new Point(200, -34);
            roundedRectangle3.Name = "roundedRectangle3";
            roundedRectangle3.Rounding = 100;
            roundedRectangle3.Size = new Size(650, 470);
            roundedRectangle3.TabIndex = 23;
            roundedRectangle3.Text = "roundedRectangle3";
            // 
            // FullNameLabel
            // 
            FullNameLabel.AutoSize = true;
            FullNameLabel.Font = new Font("Montserrat", 10F, FontStyle.Bold);
            FullNameLabel.ForeColor = Color.FromArgb(161, 148, 148);
            FullNameLabel.Location = new Point(240, 53);
            FullNameLabel.Name = "FullNameLabel";
            FullNameLabel.Size = new Size(169, 27);
            FullNameLabel.TabIndex = 87;
            FullNameLabel.Text = "ФИО Соискателя";
            // 
            // SalaryLabel
            // 
            SalaryLabel.AutoSize = true;
            SalaryLabel.BackColor = Color.White;
            SalaryLabel.Font = new Font("Montserrat", 9F, FontStyle.Bold);
            SalaryLabel.ForeColor = Color.FromArgb(161, 148, 148);
            SalaryLabel.Location = new Point(250, 190);
            SalaryLabel.Name = "SalaryLabel";
            SalaryLabel.Size = new Size(89, 24);
            SalaryLabel.TabIndex = 87;
            SalaryLabel.Text = "Зарплата:";
            // 
            // SkillsLabel
            // 
            SkillsLabel.AutoSize = true;
            SkillsLabel.BackColor = Color.White;
            SkillsLabel.Font = new Font("Montserrat", 9F, FontStyle.Bold);
            SkillsLabel.ForeColor = Color.FromArgb(161, 148, 148);
            SkillsLabel.Location = new Point(250, 214);
            SkillsLabel.Name = "SkillsLabel";
            SkillsLabel.Size = new Size(78, 24);
            SkillsLabel.TabIndex = 37;
            SkillsLabel.Text = "Навыки:";
            // 
            // CityLabel
            // 
            CityLabel.AutoSize = true;
            CityLabel.BackColor = Color.White;
            CityLabel.Font = new Font("Montserrat", 9F, FontStyle.Bold);
            CityLabel.ForeColor = Color.FromArgb(161, 148, 148);
            CityLabel.Location = new Point(250, 166);
            CityLabel.Name = "CityLabel";
            CityLabel.Size = new Size(62, 24);
            CityLabel.TabIndex = 47;
            CityLabel.Text = "Город:";
            // 
            // ExperienceLabel
            // 
            ExperienceLabel.AutoSize = true;
            ExperienceLabel.BackColor = Color.White;
            ExperienceLabel.Font = new Font("Montserrat", 9F, FontStyle.Bold);
            ExperienceLabel.ForeColor = Color.FromArgb(161, 148, 148);
            ExperienceLabel.Location = new Point(250, 142);
            ExperienceLabel.Name = "ExperienceLabel";
            ExperienceLabel.Size = new Size(120, 24);
            ExperienceLabel.TabIndex = 38;
            ExperienceLabel.Text = "Стаж работы:";
            // 
            // ProfessionLabel
            // 
            ProfessionLabel.AutoSize = true;
            ProfessionLabel.BackColor = Color.White;
            ProfessionLabel.Font = new Font("Montserrat", 9F, FontStyle.Bold);
            ProfessionLabel.ForeColor = Color.FromArgb(161, 148, 148);
            ProfessionLabel.Location = new Point(450, 43);
            ProfessionLabel.Name = "ProfessionLabel";
            ProfessionLabel.Size = new Size(107, 24);
            ProfessionLabel.TabIndex = 35;
            ProfessionLabel.Text = "Профессия:";
            // 
            // EducationLabel
            // 
            EducationLabel.AutoSize = true;
            EducationLabel.BackColor = Color.White;
            EducationLabel.Font = new Font("Montserrat", 9F, FontStyle.Bold);
            EducationLabel.ForeColor = Color.FromArgb(161, 148, 148);
            EducationLabel.Location = new Point(450, 65);
            EducationLabel.Name = "EducationLabel";
            EducationLabel.Size = new Size(123, 24);
            EducationLabel.TabIndex = 36;
            EducationLabel.Text = "Образование:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Montserrat", 9F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(161, 148, 148);
            label2.Location = new Point(270, 230);
            label2.Name = "label2";
            label2.Size = new Size(97, 24);
            label2.TabIndex = 39;
            label2.Text = "Описание:";
            // 
            // roundedRectangleWithOutline1
            // 
            roundedRectangleWithOutline1.BackColor = Color.FromArgb(229, 229, 229);
            roundedRectangleWithOutline1.Controls.Add(DescriptionLabel);
            roundedRectangleWithOutline1.CornerColor = Color.White;
            roundedRectangleWithOutline1.ForeColor = Color.White;
            roundedRectangleWithOutline1.Location = new Point(250, 260);
            roundedRectangleWithOutline1.Name = "roundedRectangleWithOutline1";
            roundedRectangleWithOutline1.OutlineColor = Color.Black;
            roundedRectangleWithOutline1.OutlineWidth = 1;
            roundedRectangleWithOutline1.Rounding = 20;
            roundedRectangleWithOutline1.Size = new Size(550, 127);
            roundedRectangleWithOutline1.TabIndex = 40;
            roundedRectangleWithOutline1.Text = "roundedRectangleWithOutline1";
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Font = new Font("Montserrat", 7F);
            DescriptionLabel.ForeColor = Color.Black;
            DescriptionLabel.Location = new Point(10, 10);
            DescriptionLabel.MaximumSize = new Size(1000, 1000);
            DescriptionLabel.MinimumSize = new Size(510, 110);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(510, 110);
            DescriptionLabel.TabIndex = 87;
            // 
            // roundedButton13
            // 
            roundedButton13.BackColor = Color.FromArgb(242, 85, 26);
            roundedButton13.CornerColor = Color.White;
            roundedButton13.Font = new Font("Montserrat", 8F, FontStyle.Bold);
            roundedButton13.ForeColor = Color.White;
            roundedButton13.Location = new Point(313, 390);
            roundedButton13.Name = "roundedButton13";
            roundedButton13.Rounding = 20;
            roundedButton13.Size = new Size(137, 35);
            roundedButton13.TabIndex = 42;
            roundedButton13.Text = "Добавить";
            roundedButton13.Click += AddButton_Click;
            // 
            // NextResume_Button
            // 
            NextResume_Button.BackColor = Color.FromArgb(255, 234, 226);
            NextResume_Button.CornerColor = Color.White;
            NextResume_Button.Font = new Font("Montserrat", 8F, FontStyle.Bold);
            NextResume_Button.ForeColor = Color.FromArgb(242, 85, 26);
            NextResume_Button.Location = new Point(607, 390);
            NextResume_Button.Name = "NextResume_Button";
            NextResume_Button.Rounding = 20;
            NextResume_Button.Size = new Size(137, 35);
            NextResume_Button.TabIndex = 43;
            NextResume_Button.Text = "Следующий";
            NextResume_Button.Click += NextResumeButton_Click;
            // 
            // ProfilePictureBox
            // 
            ProfilePictureBox.BackColor = Color.White;
            ProfilePictureBox.BorderColor = Color.White;
            ProfilePictureBox.BorderWidth = 200F;
            ProfilePictureBox.CornerRadius = 40;
            ProfilePictureBox.Image = Properties.Resources.Profile_Icon_Passive;
            ProfilePictureBox.Location = new Point(250, 19);
            ProfilePictureBox.Name = "ProfilePictureBox";
            ProfilePictureBox.Size = new Size(185, 185);
            ProfilePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            ProfilePictureBox.TabIndex = 46;
            ProfilePictureBox.TabStop = false;
            // 
            // roundedPictureBox4
            // 
            roundedPictureBox4.BackColor = Color.White;
            roundedPictureBox4.BorderColor = Color.FromArgb(0, 0, 0, 0);
            roundedPictureBox4.BorderWidth = 200F;
            roundedPictureBox4.CornerRadius = 100;
            roundedPictureBox4.Image = Properties.Resources.Messages_Icon_Passive;
            roundedPictureBox4.Location = new Point(14, 259);
            roundedPictureBox4.Name = "roundedPictureBox4";
            roundedPictureBox4.Size = new Size(50, 50);
            roundedPictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            roundedPictureBox4.TabIndex = 76;
            roundedPictureBox4.TabStop = false;
            roundedPictureBox4.Click += DialogsButton_Click;
            // 
            // roundedPictureBox3
            // 
            roundedPictureBox3.BackColor = Color.White;
            roundedPictureBox3.BorderColor = Color.FromArgb(0, 0, 0, 0);
            roundedPictureBox3.BorderWidth = 200F;
            roundedPictureBox3.CornerRadius = 100;
            roundedPictureBox3.Image = Properties.Resources.Profile_Icon_Passive;
            roundedPictureBox3.Location = new Point(14, 359);
            roundedPictureBox3.Name = "roundedPictureBox3";
            roundedPictureBox3.Size = new Size(50, 50);
            roundedPictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            roundedPictureBox3.TabIndex = 75;
            roundedPictureBox3.TabStop = false;
            roundedPictureBox3.Click += ProfileButton_Click;
            // 
            // roundedRectangle2
            // 
            roundedRectangle2.BackColor = Color.FromArgb(161, 148, 148);
            roundedRectangle2.CornerColor = Color.FromArgb(229, 229, 229);
            roundedRectangle2.ForeColor = Color.White;
            roundedRectangle2.Location = new Point(-20, 150);
            roundedRectangle2.Name = "roundedRectangle2";
            roundedRectangle2.Rounding = 50;
            roundedRectangle2.Size = new Size(100, 67);
            roundedRectangle2.TabIndex = 74;
            roundedRectangle2.Text = "roundedRectangle2";
            // 
            // roundedRectangle1
            // 
            roundedRectangle1.BackColor = Color.White;
            roundedRectangle1.CornerColor = Color.FromArgb(229, 229, 229);
            roundedRectangle1.ForeColor = Color.White;
            roundedRectangle1.Location = new Point(-20, 250);
            roundedRectangle1.Name = "roundedRectangle1";
            roundedRectangle1.Rounding = 50;
            roundedRectangle1.Size = new Size(100, 67);
            roundedRectangle1.TabIndex = 77;
            roundedRectangle1.Text = "roundedRectangle1";
            roundedRectangle1.Click += DialogsButton_Click;
            // 
            // roundedRectangle4
            // 
            roundedRectangle4.BackColor = Color.White;
            roundedRectangle4.CornerColor = Color.FromArgb(229, 229, 229);
            roundedRectangle4.ForeColor = Color.White;
            roundedRectangle4.Location = new Point(-20, 350);
            roundedRectangle4.Name = "roundedRectangle4";
            roundedRectangle4.Rounding = 50;
            roundedRectangle4.Size = new Size(100, 67);
            roundedRectangle4.TabIndex = 78;
            roundedRectangle4.Text = "roundedRectangle4";
            roundedRectangle4.Click += ProfileButton_Click;
            // 
            // roundedPictureBox2
            // 
            roundedPictureBox2.BackColor = Color.FromArgb(161, 148, 148);
            roundedPictureBox2.BorderColor = Color.FromArgb(0, 0, 0, 0);
            roundedPictureBox2.BorderWidth = 200F;
            roundedPictureBox2.CornerRadius = 100;
            roundedPictureBox2.Image = Properties.Resources.Seatch_Icon_Active;
            roundedPictureBox2.Location = new Point(14, 159);
            roundedPictureBox2.Name = "roundedPictureBox2";
            roundedPictureBox2.Size = new Size(50, 50);
            roundedPictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            roundedPictureBox2.TabIndex = 79;
            roundedPictureBox2.TabStop = false;
            // 
            // roundedRectangleWithOutline3
            // 
            roundedRectangleWithOutline3.BackColor = Color.White;
            roundedRectangleWithOutline3.Controls.Add(ExpCriterion);
            roundedRectangleWithOutline3.CornerColor = Color.FromArgb(229, 229, 229);
            roundedRectangleWithOutline3.ForeColor = Color.FromArgb(161, 148, 148);
            roundedRectangleWithOutline3.Location = new Point(528, 469);
            roundedRectangleWithOutline3.Name = "roundedRectangleWithOutline3";
            roundedRectangleWithOutline3.OutlineColor = Color.Black;
            roundedRectangleWithOutline3.OutlineWidth = 1;
            roundedRectangleWithOutline3.Rounding = 15;
            roundedRectangleWithOutline3.Size = new Size(118, 26);
            roundedRectangleWithOutline3.TabIndex = 86;
            roundedRectangleWithOutline3.Text = "roundedRectangleWithOutline3";
            // 
            // ExpCriterion
            // 
            ExpCriterion.BackColor = Color.White;
            ExpCriterion.BorderStyle = BorderStyle.None;
            ExpCriterion.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            ExpCriterion.Location = new Point(7, 5);
            ExpCriterion.Name = "ExpCriterion";
            ExpCriterion.Size = new Size(104, 16);
            ExpCriterion.TabIndex = 82;
            // 
            // SearchButton
            // 
            SearchButton.BackColor = Color.FromArgb(242, 85, 26);
            SearchButton.CornerColor = Color.FromArgb(229, 229, 229);
            SearchButton.Font = new Font("Montserrat", 8F, FontStyle.Bold);
            SearchButton.ForeColor = Color.White;
            SearchButton.Location = new Point(663, 466);
            SearchButton.Name = "SearchButton";
            SearchButton.Rounding = 25;
            SearchButton.Size = new Size(100, 35);
            SearchButton.TabIndex = 85;
            SearchButton.Text = "Искать";
            SearchButton.Click += SearchButton_Click;
            // 
            // CityCriterion
            // 
            CityCriterion.Font = new Font("Montserrat", 7F, FontStyle.Bold);
            CityCriterion.ForeColor = Color.FromArgb(161, 148, 148);
            CityCriterion.FormattingEnabled = true;
            CityCriterion.Location = new Point(398, 469);
            CityCriterion.Name = "CityCriterion";
            CityCriterion.Size = new Size(124, 26);
            CityCriterion.TabIndex = 84;
            CityCriterion.Text = "           Город";
            // 
            // ProfessionCriterion
            // 
            ProfessionCriterion.Font = new Font("Montserrat", 7F, FontStyle.Bold);
            ProfessionCriterion.ForeColor = Color.FromArgb(161, 148, 148);
            ProfessionCriterion.FormattingEnabled = true;
            ProfessionCriterion.Location = new Point(268, 469);
            ProfessionCriterion.Name = "ProfessionCriterion";
            ProfessionCriterion.Size = new Size(124, 26);
            ProfessionCriterion.TabIndex = 83;
            ProfessionCriterion.Text = "    Профессия";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat", 10F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(83, 466);
            label1.Name = "label1";
            label1.Size = new Size(179, 27);
            label1.TabIndex = 82;
            label1.Text = "Критерии поиска:";
            // 
            // ProfessionCritLabel
            // 
            ProfessionCritLabel.AutoSize = true;
            ProfessionCritLabel.Font = new Font("Montserrat", 7F, FontStyle.Bold);
            ProfessionCritLabel.Location = new Point(270, 448);
            ProfessionCritLabel.MaximumSize = new Size(1000, 1000);
            ProfessionCritLabel.Name = "ProfessionCritLabel";
            ProfessionCritLabel.Size = new Size(86, 18);
            ProfessionCritLabel.TabIndex = 87;
            ProfessionCritLabel.Text = "Профессия:";
            // 
            // CityCritLabel
            // 
            CityCritLabel.AutoSize = true;
            CityCritLabel.Font = new Font("Montserrat", 7F, FontStyle.Bold);
            CityCritLabel.Location = new Point(398, 448);
            CityCritLabel.MaximumSize = new Size(1000, 1000);
            CityCritLabel.Name = "CityCritLabel";
            CityCritLabel.Size = new Size(49, 18);
            CityCritLabel.TabIndex = 88;
            CityCritLabel.Text = "Город:";
            // 
            // SearchResumes_Page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(229, 229, 229);
            Controls.Add(CityCritLabel);
            Controls.Add(ProfessionCritLabel);
            Controls.Add(roundedRectangleWithOutline3);
            Controls.Add(SearchButton);
            Controls.Add(CityCriterion);
            Controls.Add(ProfessionCriterion);
            Controls.Add(label1);
            Controls.Add(roundedPictureBox2);
            Controls.Add(roundedPictureBox4);
            Controls.Add(roundedPictureBox3);
            Controls.Add(roundedRectangle2);
            Controls.Add(roundedRectangle1);
            Controls.Add(roundedRectangle4);
            Controls.Add(ProfilePictureBox);
            Controls.Add(NextResume_Button);
            Controls.Add(roundedButton13);
            Controls.Add(roundedRectangleWithOutline1);
            Controls.Add(label2);
            Controls.Add(EducationLabel);
            Controls.Add(ProfessionLabel);
            Controls.Add(roundedPictureBox5);
            Controls.Add(roundedRectangle3);
            Name = "SearchResumes_Page";
            Size = new Size(960, 540);
            ((System.ComponentModel.ISupportInitialize)roundedPictureBox5).EndInit();
            roundedRectangle3.ResumeLayout(false);
            roundedRectangle3.PerformLayout();
            roundedRectangleWithOutline1.ResumeLayout(false);
            roundedRectangleWithOutline1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ProfilePictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)roundedPictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)roundedPictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)roundedPictureBox2).EndInit();
            roundedRectangleWithOutline3.ResumeLayout(false);
            roundedRectangleWithOutline3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RoundedPictureBox roundedPictureBox5;
        private Classes.CustomInterfaceControls.RoundedRectangle roundedRectangle3;
        private Label ProfessionLabel;
        private Label EducationLabel;
        private Label SkillsLabel;
        private Label ExperienceLabel;
        private Label label2;
        private Classes.CustomInterfaceControls.RoundedRectangleWithOutline roundedRectangleWithOutline1;
        private Classes.CustomInterfaceControls.SimpleRoundedButton roundedButton13;
        private Classes.CustomInterfaceControls.SimpleRoundedButton NextResume_Button;
        private RoundedPictureBox ProfilePictureBox;
        private Label CityLabel;
        private RoundedPictureBox roundedPictureBox4;
        private RoundedPictureBox roundedPictureBox3;
        private Classes.CustomInterfaceControls.RoundedRectangle roundedRectangle2;
        private Classes.CustomInterfaceControls.RoundedRectangle roundedRectangle1;
        private Classes.CustomInterfaceControls.RoundedRectangle roundedRectangle4;
        private RoundedPictureBox roundedPictureBox2;
        private Classes.CustomInterfaceControls.RoundedRectangleWithOutline roundedRectangleWithOutline3;
        private TextBox ExpCriterion;
        private Classes.CustomInterfaceControls.SimpleRoundedButton SearchButton;
        private ComboBox CityCriterion;
        private ComboBox ProfessionCriterion;
        private Label label1;
        private Label SalaryLabel;
        private Label DescriptionLabel;
        private Label FullNameLabel;
        private Label ProfessionCritLabel;
        private Label CityCritLabel;
    }
}
