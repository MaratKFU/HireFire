namespace HireFire.UserControls
{
    partial class CreateResume_Page
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
            CreateButton = new HireFire.Classes.CustomInterfaceControls.SimpleRoundedButton();
            DescriptionTextBox = new TextBox();
            roundedRectangleWithOutline7 = new HireFire.Classes.CustomInterfaceControls.RoundedRectangleWithOutline();
            roundedRectangleWithOutline6 = new HireFire.Classes.CustomInterfaceControls.RoundedRectangleWithOutline();
            ExperienceTextBox = new TextBox();
            roundedRectangleWithOutline5 = new HireFire.Classes.CustomInterfaceControls.RoundedRectangleWithOutline();
            SoftSkillsTextBox = new TextBox();
            roundedRectangleWithOutline4 = new HireFire.Classes.CustomInterfaceControls.RoundedRectangleWithOutline();
            SalaryTextBox = new TextBox();
            roundedRectangleWithOutline3 = new HireFire.Classes.CustomInterfaceControls.RoundedRectangleWithOutline();
            roundedRectangleWithOutline2 = new HireFire.Classes.CustomInterfaceControls.RoundedRectangleWithOutline();
            label1 = new Label();
            roundedRectangle3 = new HireFire.Classes.CustomInterfaceControls.RoundedRectangle();
            EducationTextBox = new TextBox();
            roundedRectangleWithOutline1 = new HireFire.Classes.CustomInterfaceControls.RoundedRectangleWithOutline();
            SearchPictureBox = new RoundedPictureBox();
            DialogsPictureBox = new RoundedPictureBox();
            roundedPictureBox3 = new RoundedPictureBox();
            SearchPanel = new HireFire.Classes.CustomInterfaceControls.RoundedRectangle();
            DialogsPanel = new HireFire.Classes.CustomInterfaceControls.RoundedRectangle();
            roundedRectangle5 = new HireFire.Classes.CustomInterfaceControls.RoundedRectangle();
            BackButton = new HireFire.Classes.CustomInterfaceControls.SimpleRoundedButton();
            ProfessionsComboBox = new ComboBox();
            CitiesComboBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)roundedPictureBox5).BeginInit();
            roundedRectangleWithOutline6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SearchPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DialogsPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roundedPictureBox3).BeginInit();
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
            roundedPictureBox5.TabIndex = 57;
            roundedPictureBox5.TabStop = false;
            // 
            // CreateButton
            // 
            CreateButton.BackColor = Color.FromArgb(242, 85, 26);
            CreateButton.CornerColor = Color.White;
            CreateButton.Font = new Font("Montserrat", 10F, FontStyle.Bold);
            CreateButton.ForeColor = Color.White;
            CreateButton.Location = new Point(583, 441);
            CreateButton.Name = "CreateButton";
            CreateButton.Rounding = 30;
            CreateButton.Size = new Size(125, 38);
            CreateButton.TabIndex = 89;
            CreateButton.Text = "Создать";
            CreateButton.Click += CreateButton_Click;
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.BackColor = Color.FromArgb(229, 229, 229);
            DescriptionTextBox.BorderStyle = BorderStyle.None;
            DescriptionTextBox.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            DescriptionTextBox.Location = new Point(333, 351);
            DescriptionTextBox.Multiline = true;
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(375, 58);
            DescriptionTextBox.TabIndex = 88;
            // 
            // roundedRectangleWithOutline7
            // 
            roundedRectangleWithOutline7.BackColor = Color.FromArgb(229, 229, 229);
            roundedRectangleWithOutline7.CornerColor = Color.White;
            roundedRectangleWithOutline7.ForeColor = Color.FromArgb(161, 148, 148);
            roundedRectangleWithOutline7.Location = new Point(326, 344);
            roundedRectangleWithOutline7.Name = "roundedRectangleWithOutline7";
            roundedRectangleWithOutline7.OutlineColor = Color.Black;
            roundedRectangleWithOutline7.OutlineWidth = 1;
            roundedRectangleWithOutline7.Rounding = 15;
            roundedRectangleWithOutline7.Size = new Size(390, 73);
            roundedRectangleWithOutline7.TabIndex = 87;
            roundedRectangleWithOutline7.Text = "roundedRectangleWithOutline7";
            // 
            // roundedRectangleWithOutline6
            // 
            roundedRectangleWithOutline6.BackColor = Color.FromArgb(229, 229, 229);
            roundedRectangleWithOutline6.Controls.Add(CitiesComboBox);
            roundedRectangleWithOutline6.CornerColor = Color.White;
            roundedRectangleWithOutline6.ForeColor = Color.FromArgb(161, 148, 148);
            roundedRectangleWithOutline6.Location = new Point(589, 194);
            roundedRectangleWithOutline6.Name = "roundedRectangleWithOutline6";
            roundedRectangleWithOutline6.OutlineColor = Color.Black;
            roundedRectangleWithOutline6.OutlineWidth = 1;
            roundedRectangleWithOutline6.Rounding = 15;
            roundedRectangleWithOutline6.Size = new Size(126, 30);
            roundedRectangleWithOutline6.TabIndex = 85;
            roundedRectangleWithOutline6.Text = "roundedRectangleWithOutline6";
            // 
            // ExperienceTextBox
            // 
            ExperienceTextBox.BackColor = Color.FromArgb(229, 229, 229);
            ExperienceTextBox.BorderStyle = BorderStyle.None;
            ExperienceTextBox.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            ExperienceTextBox.Location = new Point(464, 201);
            ExperienceTextBox.Name = "ExperienceTextBox";
            ExperienceTextBox.Size = new Size(109, 16);
            ExperienceTextBox.TabIndex = 84;
            // 
            // roundedRectangleWithOutline5
            // 
            roundedRectangleWithOutline5.BackColor = Color.FromArgb(229, 229, 229);
            roundedRectangleWithOutline5.CornerColor = Color.White;
            roundedRectangleWithOutline5.ForeColor = Color.FromArgb(161, 148, 148);
            roundedRectangleWithOutline5.Location = new Point(457, 194);
            roundedRectangleWithOutline5.Name = "roundedRectangleWithOutline5";
            roundedRectangleWithOutline5.OutlineColor = Color.Black;
            roundedRectangleWithOutline5.OutlineWidth = 1;
            roundedRectangleWithOutline5.Rounding = 15;
            roundedRectangleWithOutline5.Size = new Size(123, 30);
            roundedRectangleWithOutline5.TabIndex = 83;
            roundedRectangleWithOutline5.Text = "roundedRectangleWithOutline5";
            // 
            // SoftSkillsTextBox
            // 
            SoftSkillsTextBox.BackColor = Color.FromArgb(229, 229, 229);
            SoftSkillsTextBox.BorderStyle = BorderStyle.None;
            SoftSkillsTextBox.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            SoftSkillsTextBox.Location = new Point(333, 251);
            SoftSkillsTextBox.Name = "SoftSkillsTextBox";
            SoftSkillsTextBox.Size = new Size(375, 16);
            SoftSkillsTextBox.TabIndex = 82;
            // 
            // roundedRectangleWithOutline4
            // 
            roundedRectangleWithOutline4.BackColor = Color.FromArgb(229, 229, 229);
            roundedRectangleWithOutline4.CornerColor = Color.White;
            roundedRectangleWithOutline4.ForeColor = Color.FromArgb(161, 148, 148);
            roundedRectangleWithOutline4.Location = new Point(326, 244);
            roundedRectangleWithOutline4.Name = "roundedRectangleWithOutline4";
            roundedRectangleWithOutline4.OutlineColor = Color.Black;
            roundedRectangleWithOutline4.OutlineWidth = 1;
            roundedRectangleWithOutline4.Rounding = 15;
            roundedRectangleWithOutline4.Size = new Size(390, 30);
            roundedRectangleWithOutline4.TabIndex = 81;
            roundedRectangleWithOutline4.Text = "roundedRectangleWithOutline4";
            // 
            // SalaryTextBox
            // 
            SalaryTextBox.BackColor = Color.FromArgb(229, 229, 229);
            SalaryTextBox.BorderStyle = BorderStyle.None;
            SalaryTextBox.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            SalaryTextBox.Location = new Point(333, 201);
            SalaryTextBox.Name = "SalaryTextBox";
            SalaryTextBox.Size = new Size(109, 16);
            SalaryTextBox.TabIndex = 80;
            // 
            // roundedRectangleWithOutline3
            // 
            roundedRectangleWithOutline3.BackColor = Color.FromArgb(229, 229, 229);
            roundedRectangleWithOutline3.CornerColor = Color.White;
            roundedRectangleWithOutline3.ForeColor = Color.FromArgb(161, 148, 148);
            roundedRectangleWithOutline3.Location = new Point(326, 194);
            roundedRectangleWithOutline3.Name = "roundedRectangleWithOutline3";
            roundedRectangleWithOutline3.OutlineColor = Color.Black;
            roundedRectangleWithOutline3.OutlineWidth = 1;
            roundedRectangleWithOutline3.Rounding = 15;
            roundedRectangleWithOutline3.Size = new Size(123, 30);
            roundedRectangleWithOutline3.TabIndex = 79;
            roundedRectangleWithOutline3.Text = "roundedRectangleWithOutline3";
            // 
            // roundedRectangleWithOutline2
            // 
            roundedRectangleWithOutline2.BackColor = Color.FromArgb(229, 229, 229);
            roundedRectangleWithOutline2.CornerColor = Color.White;
            roundedRectangleWithOutline2.ForeColor = Color.FromArgb(161, 148, 148);
            roundedRectangleWithOutline2.Location = new Point(326, 144);
            roundedRectangleWithOutline2.Name = "roundedRectangleWithOutline2";
            roundedRectangleWithOutline2.OutlineColor = Color.Black;
            roundedRectangleWithOutline2.OutlineWidth = 1;
            roundedRectangleWithOutline2.Rounding = 15;
            roundedRectangleWithOutline2.Size = new Size(390, 35);
            roundedRectangleWithOutline2.TabIndex = 77;
            roundedRectangleWithOutline2.Text = "roundedRectangleWithOutline2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Montserrat", 15F, FontStyle.Bold);
            label1.Location = new Point(343, 86);
            label1.Name = "label1";
            label1.Size = new Size(361, 39);
            label1.TabIndex = 76;
            label1.Text = "Создание нового резюме";
            // 
            // roundedRectangle3
            // 
            roundedRectangle3.BackColor = Color.White;
            roundedRectangle3.CornerColor = Color.FromArgb(229, 229, 229);
            roundedRectangle3.ForeColor = Color.White;
            roundedRectangle3.Location = new Point(152, 31);
            roundedRectangle3.Name = "roundedRectangle3";
            roundedRectangle3.Rounding = 100;
            roundedRectangle3.Size = new Size(722, 458);
            roundedRectangle3.TabIndex = 75;
            roundedRectangle3.Text = "roundedRectangle3";
            // 
            // EducationTextBox
            // 
            EducationTextBox.BackColor = Color.FromArgb(229, 229, 229);
            EducationTextBox.BorderStyle = BorderStyle.None;
            EducationTextBox.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            EducationTextBox.Location = new Point(333, 301);
            EducationTextBox.Name = "EducationTextBox";
            EducationTextBox.Size = new Size(375, 16);
            EducationTextBox.TabIndex = 91;
            // 
            // roundedRectangleWithOutline1
            // 
            roundedRectangleWithOutline1.BackColor = Color.FromArgb(229, 229, 229);
            roundedRectangleWithOutline1.CornerColor = Color.White;
            roundedRectangleWithOutline1.ForeColor = Color.FromArgb(161, 148, 148);
            roundedRectangleWithOutline1.Location = new Point(326, 294);
            roundedRectangleWithOutline1.Name = "roundedRectangleWithOutline1";
            roundedRectangleWithOutline1.OutlineColor = Color.Black;
            roundedRectangleWithOutline1.OutlineWidth = 1;
            roundedRectangleWithOutline1.Rounding = 15;
            roundedRectangleWithOutline1.Size = new Size(390, 30);
            roundedRectangleWithOutline1.TabIndex = 90;
            roundedRectangleWithOutline1.Text = "roundedRectangleWithOutline1";
            // 
            // SearchPictureBox
            // 
            SearchPictureBox.BackColor = Color.White;
            SearchPictureBox.BorderColor = Color.FromArgb(0, 0, 0, 0);
            SearchPictureBox.BorderWidth = 200F;
            SearchPictureBox.CornerRadius = 100;
            SearchPictureBox.Image = Properties.Resources.Search_Icon_Passive;
            SearchPictureBox.Location = new Point(14, 159);
            SearchPictureBox.Name = "SearchPictureBox";
            SearchPictureBox.Size = new Size(50, 50);
            SearchPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            SearchPictureBox.TabIndex = 97;
            SearchPictureBox.TabStop = false;
            SearchPictureBox.Click += SearchButton_Click;
            // 
            // DialogsPictureBox
            // 
            DialogsPictureBox.BackColor = Color.White;
            DialogsPictureBox.BorderColor = Color.FromArgb(0, 0, 0, 0);
            DialogsPictureBox.BorderWidth = 200F;
            DialogsPictureBox.CornerRadius = 100;
            DialogsPictureBox.Image = Properties.Resources.Messages_Icon_Passive;
            DialogsPictureBox.Location = new Point(14, 259);
            DialogsPictureBox.Name = "DialogsPictureBox";
            DialogsPictureBox.Size = new Size(50, 50);
            DialogsPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            DialogsPictureBox.TabIndex = 94;
            DialogsPictureBox.TabStop = false;
            DialogsPictureBox.Click += DialogsButton_Click;
            // 
            // roundedPictureBox3
            // 
            roundedPictureBox3.BackColor = Color.FromArgb(161, 148, 148);
            roundedPictureBox3.BorderColor = Color.FromArgb(0, 0, 0, 0);
            roundedPictureBox3.BorderWidth = 200F;
            roundedPictureBox3.CornerRadius = 100;
            roundedPictureBox3.Image = Properties.Resources.Profile_Icon_Passive;
            roundedPictureBox3.Location = new Point(14, 359);
            roundedPictureBox3.Name = "roundedPictureBox3";
            roundedPictureBox3.Size = new Size(50, 50);
            roundedPictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            roundedPictureBox3.TabIndex = 93;
            roundedPictureBox3.TabStop = false;
            // 
            // SearchPanel
            // 
            SearchPanel.BackColor = Color.White;
            SearchPanel.CornerColor = Color.FromArgb(229, 229, 229);
            SearchPanel.ForeColor = Color.White;
            SearchPanel.Location = new Point(-20, 150);
            SearchPanel.Name = "SearchPanel";
            SearchPanel.Rounding = 50;
            SearchPanel.Size = new Size(100, 67);
            SearchPanel.TabIndex = 92;
            SearchPanel.Text = "roundedRectangle2";
            SearchPanel.Click += SearchButton_Click;
            // 
            // DialogsPanel
            // 
            DialogsPanel.BackColor = Color.White;
            DialogsPanel.CornerColor = Color.FromArgb(229, 229, 229);
            DialogsPanel.ForeColor = Color.White;
            DialogsPanel.Location = new Point(-20, 250);
            DialogsPanel.Name = "DialogsPanel";
            DialogsPanel.Rounding = 50;
            DialogsPanel.Size = new Size(100, 67);
            DialogsPanel.TabIndex = 95;
            DialogsPanel.Text = "roundedRectangle4";
            DialogsPanel.Click += DialogsButton_Click;
            // 
            // roundedRectangle5
            // 
            roundedRectangle5.BackColor = Color.FromArgb(161, 148, 148);
            roundedRectangle5.CornerColor = Color.FromArgb(229, 229, 229);
            roundedRectangle5.ForeColor = Color.White;
            roundedRectangle5.Location = new Point(-20, 350);
            roundedRectangle5.Name = "roundedRectangle5";
            roundedRectangle5.Rounding = 50;
            roundedRectangle5.Size = new Size(100, 67);
            roundedRectangle5.TabIndex = 96;
            roundedRectangle5.Text = "roundedRectangle5";
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.FromArgb(255, 234, 226);
            BackButton.CornerColor = Color.White;
            BackButton.Font = new Font("Montserrat", 10F, FontStyle.Bold);
            BackButton.ForeColor = Color.FromArgb(242, 85, 26);
            BackButton.Location = new Point(326, 441);
            BackButton.Name = "BackButton";
            BackButton.Rounding = 30;
            BackButton.Size = new Size(116, 38);
            BackButton.TabIndex = 98;
            BackButton.Text = "Отмена";
            BackButton.Click += BackButton_Click;
            // 
            // ProfessionsComboBox
            // 
            ProfessionsComboBox.BackColor = Color.FromArgb(229, 229, 229);
            ProfessionsComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ProfessionsComboBox.FlatStyle = FlatStyle.Flat;
            ProfessionsComboBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ProfessionsComboBox.FormattingEnabled = true;
            ProfessionsComboBox.Location = new Point(333, 148);
            ProfessionsComboBox.Name = "ProfessionsComboBox";
            ProfessionsComboBox.Size = new Size(375, 28);
            ProfessionsComboBox.TabIndex = 99;
            // 
            // CitiesComboBox
            // 
            CitiesComboBox.BackColor = Color.FromArgb(229, 229, 229);
            CitiesComboBox.FlatStyle = FlatStyle.Flat;
            CitiesComboBox.Font = new Font("Montserrat", 6F, FontStyle.Bold);
            CitiesComboBox.FormattingEnabled = true;
            CitiesComboBox.Location = new Point(3, 3);
            CitiesComboBox.Name = "CitiesComboBox";
            CitiesComboBox.Size = new Size(118, 24);
            CitiesComboBox.TabIndex = 0;
            // 
            // CreateResume_Page
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(229, 229, 229);
            Controls.Add(ProfessionsComboBox);
            Controls.Add(BackButton);
            Controls.Add(SearchPictureBox);
            Controls.Add(DialogsPictureBox);
            Controls.Add(roundedPictureBox3);
            Controls.Add(SearchPanel);
            Controls.Add(DialogsPanel);
            Controls.Add(roundedRectangle5);
            Controls.Add(EducationTextBox);
            Controls.Add(roundedRectangleWithOutline1);
            Controls.Add(CreateButton);
            Controls.Add(DescriptionTextBox);
            Controls.Add(roundedRectangleWithOutline7);
            Controls.Add(roundedRectangleWithOutline6);
            Controls.Add(ExperienceTextBox);
            Controls.Add(roundedRectangleWithOutline5);
            Controls.Add(SoftSkillsTextBox);
            Controls.Add(roundedRectangleWithOutline4);
            Controls.Add(SalaryTextBox);
            Controls.Add(roundedRectangleWithOutline3);
            Controls.Add(roundedRectangleWithOutline2);
            Controls.Add(label1);
            Controls.Add(roundedRectangle3);
            Controls.Add(roundedPictureBox5);
            Font = new Font("Montserrat", 9F, FontStyle.Bold);
            Margin = new Padding(4);
            Name = "CreateResume_Page";
            Size = new Size(960, 540);
            ((System.ComponentModel.ISupportInitialize)roundedPictureBox5).EndInit();
            roundedRectangleWithOutline6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SearchPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)DialogsPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)roundedPictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RoundedPictureBox roundedPictureBox5;
        private Classes.CustomInterfaceControls.SimpleRoundedButton CreateButton;
        private TextBox DescriptionTextBox;
        private Classes.CustomInterfaceControls.RoundedRectangleWithOutline roundedRectangleWithOutline7;
        private Classes.CustomInterfaceControls.RoundedRectangleWithOutline roundedRectangleWithOutline6;
        private TextBox ExperienceTextBox;
        private Classes.CustomInterfaceControls.RoundedRectangleWithOutline roundedRectangleWithOutline5;
        private TextBox SoftSkillsTextBox;
        private Classes.CustomInterfaceControls.RoundedRectangleWithOutline roundedRectangleWithOutline4;
        private TextBox SalaryTextBox;
        private Classes.CustomInterfaceControls.RoundedRectangleWithOutline roundedRectangleWithOutline3;
        private Classes.CustomInterfaceControls.RoundedRectangleWithOutline roundedRectangleWithOutline2;
        private Label label1;
        private Classes.CustomInterfaceControls.RoundedRectangle roundedRectangle3;
        private TextBox EducationTextBox;
        private Classes.CustomInterfaceControls.RoundedRectangleWithOutline roundedRectangleWithOutline1;
        private RoundedPictureBox SearchPictureBox;
        private RoundedPictureBox DialogsPictureBox;
        private RoundedPictureBox roundedPictureBox3;
        private Classes.CustomInterfaceControls.RoundedRectangle SearchPanel;
        private Classes.CustomInterfaceControls.RoundedRectangle DialogsPanel;
        private Classes.CustomInterfaceControls.RoundedRectangle roundedRectangle5;
        private Classes.CustomInterfaceControls.SimpleRoundedButton BackButton;
        private ComboBox ProfessionsComboBox;
        private ComboBox CitiesComboBox;
    }
}
