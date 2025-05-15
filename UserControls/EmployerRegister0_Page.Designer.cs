using HireFire.Classes.CustomInterfaceControls;
using System.Xml.Linq;

namespace HireFire
{
    partial class EmployerRegister0_Page
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
            Btn_SexFemale = new OutlinedRoundedButton();
            Btn_SexMale = new OutlinedRoundedButton();
            label3 = new Label();
            label2 = new Label();
            LastnameTextBox = new TextBox();
            roundedRectangleWithOutline6 = new RoundedRectangleWithOutline();
            NameTextBox = new TextBox();
            roundedRectangleWithOutline1 = new RoundedRectangleWithOutline();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            Previous_Button = new SimpleRoundedButton();
            Next_Button = new SimpleRoundedButton();
            CityTextBox = new TextBox();
            roundedRectangleWithOutline3 = new RoundedRectangleWithOutline();
            SurnameTextBox = new TextBox();
            roundedRectangleWithOutline2 = new RoundedRectangleWithOutline();
            roundedRectangle1 = new RoundedRectangle();
            DateLabel = new Label();
            BirthDatePicker = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Btn_SexFemale
            // 
            Btn_SexFemale.BackColor = Color.FromArgb(255, 255, 255);
            Btn_SexFemale.CornerColor = Color.White;
            Btn_SexFemale.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Bold);
            Btn_SexFemale.ForeColor = Color.FromArgb(73, 73, 73);
            Btn_SexFemale.Location = new Point(485, 380);
            Btn_SexFemale.Margin = new Padding(5);
            Btn_SexFemale.Name = "Btn_SexFemale";
            Btn_SexFemale.OutlineColor = Color.FromArgb(229, 229, 229);
            Btn_SexFemale.OutlineColorActive = Color.FromArgb(242, 85, 26);
            Btn_SexFemale.OutlineColorPassive = Color.FromArgb(229, 229, 229);
            Btn_SexFemale.OutlineWidth = 2;
            Btn_SexFemale.Rounding = 20;
            Btn_SexFemale.Size = new Size(110, 33);
            Btn_SexFemale.TabIndex = 66;
            Btn_SexFemale.Text = "Женский";
            Btn_SexFemale.X = 23F;
            Btn_SexFemale.Y = 6F;
            Btn_SexFemale.MouseDown += Btn_SexFemale_Press;
            // 
            // Btn_SexMale
            // 
            Btn_SexMale.BackColor = Color.FromArgb(255, 255, 255);
            Btn_SexMale.CornerColor = Color.White;
            Btn_SexMale.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Bold);
            Btn_SexMale.ForeColor = Color.FromArgb(73, 73, 73);
            Btn_SexMale.Location = new Point(365, 380);
            Btn_SexMale.Margin = new Padding(5);
            Btn_SexMale.MousePressed = true;
            Btn_SexMale.Name = "Btn_SexMale";
            Btn_SexMale.OutlineColor = Color.FromArgb(242, 85, 26);
            Btn_SexMale.OutlineColorActive = Color.FromArgb(242, 85, 26);
            Btn_SexMale.OutlineColorPassive = Color.FromArgb(229, 229, 229);
            Btn_SexMale.OutlineWidth = 2;
            Btn_SexMale.Rounding = 20;
            Btn_SexMale.Size = new Size(110, 33);
            Btn_SexMale.TabIndex = 65;
            Btn_SexMale.Text = "Мужской";
            Btn_SexMale.X = 20F;
            Btn_SexMale.Y = 6F;
            Btn_SexMale.MouseDown += Btn_SexMale_Press;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(463, 361);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 64;
            label3.Text = "Пол";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(242, 85, 26);
            label2.Location = new Point(433, 207);
            label2.Name = "label2";
            label2.Size = new Size(102, 15);
            label2.TabIndex = 63;
            label2.Text = "Введите ваши";
            // 
            // LastnameTextBox
            // 
            LastnameTextBox.BackColor = Color.FromArgb(229, 229, 229);
            LastnameTextBox.BorderStyle = BorderStyle.None;
            LastnameTextBox.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            LastnameTextBox.ForeColor = Color.Black;
            LastnameTextBox.Location = new Point(538, 235);
            LastnameTextBox.Name = "LastnameTextBox";
            LastnameTextBox.Size = new Size(66, 16);
            LastnameTextBox.TabIndex = 62;
            // 
            // roundedRectangleWithOutline6
            // 
            roundedRectangleWithOutline6.BackColor = Color.FromArgb(229, 229, 229);
            roundedRectangleWithOutline6.CornerColor = Color.White;
            roundedRectangleWithOutline6.ForeColor = Color.FromArgb(161, 148, 148);
            roundedRectangleWithOutline6.Location = new Point(531, 228);
            roundedRectangleWithOutline6.Name = "roundedRectangleWithOutline6";
            roundedRectangleWithOutline6.OutlineColor = Color.Black;
            roundedRectangleWithOutline6.OutlineWidth = 1;
            roundedRectangleWithOutline6.Rounding = 15;
            roundedRectangleWithOutline6.Size = new Size(81, 30);
            roundedRectangleWithOutline6.TabIndex = 61;
            roundedRectangleWithOutline6.Text = "roundedRectangleWithOutline6";
            // 
            // NameTextBox
            // 
            NameTextBox.BackColor = Color.FromArgb(229, 229, 229);
            NameTextBox.BorderStyle = BorderStyle.None;
            NameTextBox.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            NameTextBox.ForeColor = Color.Black;
            NameTextBox.Location = new Point(440, 235);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(66, 16);
            NameTextBox.TabIndex = 60;
            // 
            // roundedRectangleWithOutline1
            // 
            roundedRectangleWithOutline1.BackColor = Color.FromArgb(229, 229, 229);
            roundedRectangleWithOutline1.CornerColor = Color.White;
            roundedRectangleWithOutline1.ForeColor = Color.FromArgb(161, 148, 148);
            roundedRectangleWithOutline1.Location = new Point(433, 228);
            roundedRectangleWithOutline1.Name = "roundedRectangleWithOutline1";
            roundedRectangleWithOutline1.OutlineColor = Color.Black;
            roundedRectangleWithOutline1.OutlineWidth = 1;
            roundedRectangleWithOutline1.Rounding = 15;
            roundedRectangleWithOutline1.Size = new Size(81, 30);
            roundedRectangleWithOutline1.TabIndex = 59;
            roundedRectangleWithOutline1.Text = "roundedRectangleWithOutline1";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = Properties.Resources.Main_Icon;
            pictureBox1.Location = new Point(450, 86);
            pictureBox1.MaximumSize = new Size(70, 70);
            pictureBox1.MinimumSize = new Size(70, 70);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 58;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            label1.Location = new Point(365, 159);
            label1.Name = "label1";
            label1.Size = new Size(239, 48);
            label1.TabIndex = 57;
            label1.Text = "          Заполните\nосновную информацию";
            // 
            // Previous_Button
            // 
            Previous_Button.BackColor = Color.White;
            Previous_Button.CornerColor = Color.White;
            Previous_Button.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Bold);
            Previous_Button.ForeColor = Color.FromArgb(242, 85, 26);
            Previous_Button.Location = new Point(346, 421);
            Previous_Button.Name = "Previous_Button";
            Previous_Button.Rounding = 20;
            Previous_Button.Size = new Size(75, 25);
            Previous_Button.TabIndex = 56;
            Previous_Button.Text = "Назад";
            Previous_Button.Click += Previous_Button_Click;
            // 
            // Next_Button
            // 
            Next_Button.BackColor = Color.FromArgb(242, 85, 26);
            Next_Button.CornerColor = Color.White;
            Next_Button.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Bold);
            Next_Button.ForeColor = Color.White;
            Next_Button.Location = new Point(546, 421);
            Next_Button.Name = "Next_Button";
            Next_Button.Rounding = 20;
            Next_Button.Size = new Size(75, 25);
            Next_Button.TabIndex = 55;
            Next_Button.Text = "Далее";
            Next_Button.Click += Next_Button_Click;
            // 
            // CityTextBox
            // 
            CityTextBox.BackColor = Color.FromArgb(229, 229, 229);
            CityTextBox.BorderStyle = BorderStyle.None;
            CityTextBox.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            CityTextBox.ForeColor = Color.Black;
            CityTextBox.Location = new Point(372, 279);
            CityTextBox.Name = "CityTextBox";
            CityTextBox.Size = new Size(220, 16);
            CityTextBox.TabIndex = 52;
            // 
            // roundedRectangleWithOutline3
            // 
            roundedRectangleWithOutline3.BackColor = Color.FromArgb(229, 229, 229);
            roundedRectangleWithOutline3.CornerColor = Color.White;
            roundedRectangleWithOutline3.ForeColor = Color.FromArgb(161, 148, 148);
            roundedRectangleWithOutline3.Location = new Point(365, 272);
            roundedRectangleWithOutline3.Name = "roundedRectangleWithOutline3";
            roundedRectangleWithOutline3.OutlineColor = Color.Black;
            roundedRectangleWithOutline3.OutlineWidth = 1;
            roundedRectangleWithOutline3.Rounding = 15;
            roundedRectangleWithOutline3.Size = new Size(235, 30);
            roundedRectangleWithOutline3.TabIndex = 51;
            roundedRectangleWithOutline3.Text = "roundedRectangleWithOutline3";
            // 
            // SurnameTextBox
            // 
            SurnameTextBox.BackColor = Color.FromArgb(229, 229, 229);
            SurnameTextBox.BorderStyle = BorderStyle.None;
            SurnameTextBox.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            SurnameTextBox.ForeColor = Color.Black;
            SurnameTextBox.Location = new Point(346, 235);
            SurnameTextBox.Name = "SurnameTextBox";
            SurnameTextBox.Size = new Size(66, 16);
            SurnameTextBox.TabIndex = 50;
            // 
            // roundedRectangleWithOutline2
            // 
            roundedRectangleWithOutline2.BackColor = Color.FromArgb(229, 229, 229);
            roundedRectangleWithOutline2.CornerColor = Color.White;
            roundedRectangleWithOutline2.ForeColor = Color.FromArgb(161, 148, 148);
            roundedRectangleWithOutline2.Location = new Point(339, 228);
            roundedRectangleWithOutline2.Name = "roundedRectangleWithOutline2";
            roundedRectangleWithOutline2.OutlineColor = Color.Black;
            roundedRectangleWithOutline2.OutlineWidth = 1;
            roundedRectangleWithOutline2.Rounding = 15;
            roundedRectangleWithOutline2.Size = new Size(81, 30);
            roundedRectangleWithOutline2.TabIndex = 49;
            roundedRectangleWithOutline2.Text = "roundedRectangleWithOutline2";
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
            roundedRectangle1.TabIndex = 48;
            roundedRectangle1.Text = "roundedRectangle1";
            // 
            // DateLabel
            // 
            DateLabel.AutoSize = true;
            DateLabel.BackColor = Color.White;
            DateLabel.Font = new Font("Segoe UI", 5F, FontStyle.Bold);
            DateLabel.Location = new Point(372, 305);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new Size(76, 12);
            DateLabel.TabIndex = 68;
            DateLabel.Text = "Дату рождения";
            // 
            // BirthDatePicker
            // 
            BirthDatePicker.CalendarMonthBackground = Color.FromArgb(161, 148, 148);
            BirthDatePicker.CalendarTitleBackColor = Color.FromArgb(161, 148, 148);
            BirthDatePicker.Location = new Point(339, 320);
            BirthDatePicker.Name = "BirthDatePicker";
            BirthDatePicker.Size = new Size(282, 27);
            BirthDatePicker.TabIndex = 69;
            // 
            // EmployerRegister0_Page
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
            Controls.Add(CityTextBox);
            Controls.Add(roundedRectangleWithOutline3);
            Controls.Add(SurnameTextBox);
            Controls.Add(roundedRectangleWithOutline2);
            Controls.Add(roundedRectangle1);
            Name = "EmployerRegister0_Page";
            Size = new Size(960, 540);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private OutlinedRoundedButton Btn_SexFemale;
        private OutlinedRoundedButton Btn_SexMale;
        private Label label3;
        private Label label2;
        private TextBox LastnameTextBox;
        private RoundedRectangleWithOutline roundedRectangleWithOutline6;
        private TextBox NameTextBox;
        private RoundedRectangleWithOutline roundedRectangleWithOutline1;
        private PictureBox pictureBox1;
        private Label label1;
        private SimpleRoundedButton Previous_Button;
        private SimpleRoundedButton Next_Button;
        private TextBox CityTextBox;
        private RoundedRectangleWithOutline roundedRectangleWithOutline3;
        private TextBox SurnameTextBox;
        private RoundedRectangleWithOutline roundedRectangleWithOutline2;
        private RoundedRectangle roundedRectangle1;
        private Label DateLabel;
        private DateTimePicker BirthDatePicker;
    }
}
