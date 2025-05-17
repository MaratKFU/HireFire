using HireFire.Classes.CustomInterfaceControls;

namespace HireFire
{
    partial class JobSeekerRegister0_Page
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            Previous_Button = new SimpleRoundedButton();
            Next_Button = new SimpleRoundedButton();
            roundedRectangleWithOutline3 = new RoundedRectangleWithOutline();
            SurnameTextBox = new TextBox();
            roundedRectangleWithOutline2 = new RoundedRectangleWithOutline();
            roundedRectangle1 = new RoundedRectangle();
            NameTextBox = new TextBox();
            roundedRectangleWithOutline1 = new RoundedRectangleWithOutline();
            LastnameTextBox = new TextBox();
            roundedRectangleWithOutline6 = new RoundedRectangleWithOutline();
            label2 = new Label();
            label3 = new Label();
            Btn_SexMale = new OutlinedRoundedButton();
            Btn_SexFemale = new OutlinedRoundedButton();
            BirthDatePicker = new DateTimePicker();
            DateLabel = new Label();
            CityComboBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            roundedRectangleWithOutline3.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = Properties.Resources.Main_Icon;
            pictureBox1.Location = new Point(449, 86);
            pictureBox1.MaximumSize = new Size(70, 70);
            pictureBox1.MinimumSize = new Size(70, 70);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 39;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            label1.Location = new Point(364, 159);
            label1.Name = "label1";
            label1.Size = new Size(239, 48);
            label1.TabIndex = 38;
            label1.Text = "          Заполните\nосновную информацию";
            // 
            // Previous_Button
            // 
            Previous_Button.BackColor = Color.White;
            Previous_Button.CornerColor = Color.White;
            Previous_Button.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Bold);
            Previous_Button.ForeColor = Color.FromArgb(242, 85, 26);
            Previous_Button.Location = new Point(345, 421);
            Previous_Button.Name = "Previous_Button";
            Previous_Button.Rounding = 20;
            Previous_Button.Size = new Size(75, 25);
            Previous_Button.TabIndex = 37;
            Previous_Button.Text = "Назад";
            Previous_Button.Click += Previous_Button_Click;
            // 
            // Next_Button
            // 
            Next_Button.BackColor = Color.FromArgb(242, 85, 26);
            Next_Button.CornerColor = Color.White;
            Next_Button.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Bold);
            Next_Button.ForeColor = Color.White;
            Next_Button.Location = new Point(545, 421);
            Next_Button.Name = "Next_Button";
            Next_Button.Rounding = 20;
            Next_Button.Size = new Size(75, 25);
            Next_Button.TabIndex = 36;
            Next_Button.Text = "Далее";
            Next_Button.Click += Next_Button_Click;
            // 
            // roundedRectangleWithOutline3
            // 
            roundedRectangleWithOutline3.BackColor = Color.FromArgb(229, 229, 229);
            roundedRectangleWithOutline3.Controls.Add(CityComboBox);
            roundedRectangleWithOutline3.CornerColor = Color.White;
            roundedRectangleWithOutline3.ForeColor = Color.FromArgb(161, 148, 148);
            roundedRectangleWithOutline3.Location = new Point(364, 272);
            roundedRectangleWithOutline3.Name = "roundedRectangleWithOutline3";
            roundedRectangleWithOutline3.OutlineColor = Color.Black;
            roundedRectangleWithOutline3.OutlineWidth = 1;
            roundedRectangleWithOutline3.Rounding = 15;
            roundedRectangleWithOutline3.Size = new Size(235, 30);
            roundedRectangleWithOutline3.TabIndex = 30;
            roundedRectangleWithOutline3.Text = "roundedRectangleWithOutline3";
            // 
            // SurnameTextBox
            // 
            SurnameTextBox.BackColor = Color.FromArgb(229, 229, 229);
            SurnameTextBox.BorderStyle = BorderStyle.None;
            SurnameTextBox.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            SurnameTextBox.ForeColor = Color.Black;
            SurnameTextBox.Location = new Point(345, 235);
            SurnameTextBox.Name = "SurnameTextBox";
            SurnameTextBox.Size = new Size(66, 16);
            SurnameTextBox.TabIndex = 29;
            // 
            // roundedRectangleWithOutline2
            // 
            roundedRectangleWithOutline2.BackColor = Color.FromArgb(229, 229, 229);
            roundedRectangleWithOutline2.CornerColor = Color.White;
            roundedRectangleWithOutline2.ForeColor = Color.FromArgb(161, 148, 148);
            roundedRectangleWithOutline2.Location = new Point(338, 228);
            roundedRectangleWithOutline2.Name = "roundedRectangleWithOutline2";
            roundedRectangleWithOutline2.OutlineColor = Color.Black;
            roundedRectangleWithOutline2.OutlineWidth = 1;
            roundedRectangleWithOutline2.Rounding = 15;
            roundedRectangleWithOutline2.Size = new Size(81, 30);
            roundedRectangleWithOutline2.TabIndex = 28;
            roundedRectangleWithOutline2.Text = "roundedRectangleWithOutline2";
            // 
            // roundedRectangle1
            // 
            roundedRectangle1.BackColor = Color.White;
            roundedRectangle1.CornerColor = Color.FromArgb(229, 229, 229);
            roundedRectangle1.ForeColor = Color.White;
            roundedRectangle1.Location = new Point(316, 80);
            roundedRectangle1.Name = "roundedRectangle1";
            roundedRectangle1.Rounding = 100;
            roundedRectangle1.Size = new Size(327, 380);
            roundedRectangle1.TabIndex = 27;
            roundedRectangle1.Text = "roundedRectangle1";
            // 
            // NameTextBox
            // 
            NameTextBox.BackColor = Color.FromArgb(229, 229, 229);
            NameTextBox.BorderStyle = BorderStyle.None;
            NameTextBox.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            NameTextBox.ForeColor = Color.Black;
            NameTextBox.Location = new Point(439, 235);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(66, 16);
            NameTextBox.TabIndex = 41;
            // 
            // roundedRectangleWithOutline1
            // 
            roundedRectangleWithOutline1.BackColor = Color.FromArgb(229, 229, 229);
            roundedRectangleWithOutline1.CornerColor = Color.White;
            roundedRectangleWithOutline1.ForeColor = Color.FromArgb(161, 148, 148);
            roundedRectangleWithOutline1.Location = new Point(432, 228);
            roundedRectangleWithOutline1.Name = "roundedRectangleWithOutline1";
            roundedRectangleWithOutline1.OutlineColor = Color.Black;
            roundedRectangleWithOutline1.OutlineWidth = 1;
            roundedRectangleWithOutline1.Rounding = 15;
            roundedRectangleWithOutline1.Size = new Size(81, 30);
            roundedRectangleWithOutline1.TabIndex = 40;
            roundedRectangleWithOutline1.Text = "roundedRectangleWithOutline1";
            // 
            // LastnameTextBox
            // 
            LastnameTextBox.BackColor = Color.FromArgb(229, 229, 229);
            LastnameTextBox.BorderStyle = BorderStyle.None;
            LastnameTextBox.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            LastnameTextBox.ForeColor = Color.Black;
            LastnameTextBox.Location = new Point(537, 235);
            LastnameTextBox.Name = "LastnameTextBox";
            LastnameTextBox.Size = new Size(66, 16);
            LastnameTextBox.TabIndex = 43;
            // 
            // roundedRectangleWithOutline6
            // 
            roundedRectangleWithOutline6.BackColor = Color.FromArgb(229, 229, 229);
            roundedRectangleWithOutline6.CornerColor = Color.White;
            roundedRectangleWithOutline6.ForeColor = Color.FromArgb(161, 148, 148);
            roundedRectangleWithOutline6.Location = new Point(530, 228);
            roundedRectangleWithOutline6.Name = "roundedRectangleWithOutline6";
            roundedRectangleWithOutline6.OutlineColor = Color.Black;
            roundedRectangleWithOutline6.OutlineWidth = 1;
            roundedRectangleWithOutline6.Rounding = 15;
            roundedRectangleWithOutline6.Size = new Size(81, 30);
            roundedRectangleWithOutline6.TabIndex = 42;
            roundedRectangleWithOutline6.Text = "roundedRectangleWithOutline6";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(242, 85, 26);
            label2.Location = new Point(432, 207);
            label2.Name = "label2";
            label2.Size = new Size(102, 15);
            label2.TabIndex = 44;
            label2.Text = "Введите ваши";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(462, 361);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 45;
            label3.Text = "Пол";
            // 
            // Btn_SexMale
            // 
            Btn_SexMale.BackColor = Color.FromArgb(255, 255, 255);
            Btn_SexMale.CornerColor = Color.White;
            Btn_SexMale.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Bold);
            Btn_SexMale.ForeColor = Color.FromArgb(73, 73, 73);
            Btn_SexMale.Location = new Point(364, 380);
            Btn_SexMale.Margin = new Padding(5);
            Btn_SexMale.MousePressed = true;
            Btn_SexMale.Name = "Btn_SexMale";
            Btn_SexMale.OutlineColor = Color.FromArgb(242, 85, 26);
            Btn_SexMale.OutlineColorActive = Color.FromArgb(242, 85, 26);
            Btn_SexMale.OutlineColorPassive = Color.FromArgb(229, 229, 229);
            Btn_SexMale.OutlineWidth = 2;
            Btn_SexMale.Rounding = 20;
            Btn_SexMale.Size = new Size(110, 33);
            Btn_SexMale.TabIndex = 46;
            Btn_SexMale.Text = "Мужской";
            Btn_SexMale.X = 20F;
            Btn_SexMale.Y = 6F;
            Btn_SexMale.MouseDown += Btn_SexMale_Press;
            // 
            // Btn_SexFemale
            // 
            Btn_SexFemale.BackColor = Color.FromArgb(255, 255, 255);
            Btn_SexFemale.CornerColor = Color.White;
            Btn_SexFemale.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Bold);
            Btn_SexFemale.ForeColor = Color.FromArgb(73, 73, 73);
            Btn_SexFemale.Location = new Point(484, 380);
            Btn_SexFemale.Margin = new Padding(5);
            Btn_SexFemale.Name = "Btn_SexFemale";
            Btn_SexFemale.OutlineColor = Color.FromArgb(229, 229, 229);
            Btn_SexFemale.OutlineColorActive = Color.FromArgb(242, 85, 26);
            Btn_SexFemale.OutlineColorPassive = Color.FromArgb(229, 229, 229);
            Btn_SexFemale.OutlineWidth = 2;
            Btn_SexFemale.Rounding = 20;
            Btn_SexFemale.Size = new Size(110, 33);
            Btn_SexFemale.TabIndex = 47;
            Btn_SexFemale.Text = "Женский";
            Btn_SexFemale.X = 23F;
            Btn_SexFemale.Y = 6F;
            Btn_SexFemale.MouseDown += Btn_SexFemale_Press;
            // 
            // BirthDatePicker
            // 
            BirthDatePicker.CalendarMonthBackground = Color.FromArgb(161, 148, 148);
            BirthDatePicker.CalendarTitleBackColor = Color.FromArgb(161, 148, 148);
            BirthDatePicker.Location = new Point(338, 331);
            BirthDatePicker.Name = "BirthDatePicker";
            BirthDatePicker.Size = new Size(282, 27);
            BirthDatePicker.TabIndex = 71;
            // 
            // DateLabel
            // 
            DateLabel.AutoSize = true;
            DateLabel.BackColor = Color.White;
            DateLabel.Font = new Font("Segoe UI", 5F, FontStyle.Bold);
            DateLabel.Location = new Point(371, 316);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new Size(76, 12);
            DateLabel.TabIndex = 70;
            DateLabel.Text = "Дату рождения";
            // 
            // CityComboBox
            // 
            CityComboBox.BackColor = Color.FromArgb(229, 229, 229);
            CityComboBox.FlatStyle = FlatStyle.Flat;
            CityComboBox.Font = new Font("Segoe UI", 8F);
            CityComboBox.FormattingEnabled = true;
            CityComboBox.Location = new Point(4, 3);
            CityComboBox.Name = "CityComboBox";
            CityComboBox.Size = new Size(226, 25);
            CityComboBox.TabIndex = 71;
            // 
            // JobSeekerRegister0_Page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(229, 229, 229);
            Controls.Add(BirthDatePicker);
            Controls.Add(DateLabel);
            Controls.Add(Btn_SexFemale);
            Controls.Add(Btn_SexMale);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(LastnameTextBox);
            Controls.Add(roundedRectangleWithOutline6);
            Controls.Add(NameTextBox);
            Controls.Add(roundedRectangleWithOutline1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(Previous_Button);
            Controls.Add(Next_Button);
            Controls.Add(roundedRectangleWithOutline3);
            Controls.Add(SurnameTextBox);
            Controls.Add(roundedRectangleWithOutline2);
            Controls.Add(roundedRectangle1);
            Name = "JobSeekerRegister0_Page";
            Size = new Size(960, 540);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            roundedRectangleWithOutline3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private SimpleRoundedButton Previous_Button;
        private SimpleRoundedButton Next_Button;
        private RoundedRectangleWithOutline roundedRectangleWithOutline3;
        private TextBox SurnameTextBox;
        private RoundedRectangleWithOutline roundedRectangleWithOutline2;
        private RoundedRectangle roundedRectangle1;
        private TextBox NameTextBox;
        private RoundedRectangleWithOutline roundedRectangleWithOutline1;
        private TextBox LastnameTextBox;
        private RoundedRectangleWithOutline roundedRectangleWithOutline6;
        private Label label2;
        private Label label3;
        private OutlinedRoundedButton Btn_SexMale;
        private OutlinedRoundedButton Btn_SexFemale;
        private DateTimePicker BirthDatePicker;
        private Label DateLabel;
        private ComboBox CityComboBox;
    }
}
