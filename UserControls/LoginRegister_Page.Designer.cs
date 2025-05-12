using HireFire.Classes.CustomInterfaceControls;

namespace HireFire
{
    partial class LoginRegister_Page
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
            Stand = new RoundedRectangle();
            EnterLabel = new Label();
            Logo = new PictureBox();
            Btn_Enter = new RoundedButton1();
            Btn_employee = new RoundedButton2();
            Btn_employer = new RoundedButton2();
            Btn_register = new RoundedButton1();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            SuspendLayout();
            // 
            // Stand
            // 
            Stand.BackColor = Color.White;
            Stand.CornerColor = Color.FromArgb(229, 229, 229);
            Stand.ForeColor = Color.White;
            Stand.Location = new Point(316, 80);
            Stand.Margin = new Padding(5);
            Stand.Name = "Stand";
            Stand.Rounding = 60;
            Stand.Size = new Size(327, 380);
            Stand.TabIndex = 0;
            Stand.Text = "roundedRectangle1";
            // 
            // EnterLabel
            // 
            EnterLabel.AutoSize = true;
            EnterLabel.BackColor = Color.White;
            EnterLabel.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold);
            EnterLabel.Location = new Point(450, 152);
            EnterLabel.Margin = new Padding(5, 0, 5, 0);
            EnterLabel.Name = "EnterLabel";
            EnterLabel.Size = new Size(67, 26);
            EnterLabel.TabIndex = 1;
            EnterLabel.Text = "Вход";
            // 
            // Logo
            // 
            Logo.BackColor = Color.White;
            Logo.Image = Properties.Resources.Main_Icon;
            Logo.Location = new Point(448, 86);
            Logo.Margin = new Padding(5);
            Logo.Name = "Logo";
            Logo.Size = new Size(70, 70);
            Logo.SizeMode = PictureBoxSizeMode.StretchImage;
            Logo.TabIndex = 2;
            Logo.TabStop = false;
            // 
            // Btn_Enter
            // 
            Btn_Enter.BackColor = Color.FromArgb(242, 85, 26);
            Btn_Enter.CornerColor = Color.White;
            Btn_Enter.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            Btn_Enter.ForeColor = Color.White;
            Btn_Enter.Location = new Point(360, 335);
            Btn_Enter.Margin = new Padding(5);
            Btn_Enter.Name = "Btn_Enter";
            Btn_Enter.Rounding = 20;
            Btn_Enter.Size = new Size(244, 40);
            Btn_Enter.TabIndex = 3;
            Btn_Enter.Text = "Войти";
            Btn_Enter.Click += Btn_Enter_Click;
            // 
            // Btn_employee
            // 
            Btn_employee.BackColor = Color.FromArgb(255, 255, 255);
            Btn_employee.CornerColor = Color.White;
            Btn_employee.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            Btn_employee.ForeColor = Color.FromArgb(73, 73, 73);
            Btn_employee.Location = new Point(360, 185);
            Btn_employee.Margin = new Padding(5);
            Btn_employee.MousePressed = true;
            Btn_employee.Name = "Btn_employee";
            Btn_employee.OutlineColor = Color.FromArgb(242, 85, 26);
            Btn_employee.OutlineColorActive = Color.FromArgb(242, 85, 26);
            Btn_employee.OutlineColorPassive = Color.FromArgb(229, 229, 229);
            Btn_employee.OutlineWidth = 2;
            Btn_employee.Rounding = 40;
            Btn_employee.Size = new Size(244, 63);
            Btn_employee.TabIndex = 4;
            Btn_employee.Text = "Я ищу работу";
            Btn_employee.X = 20F;
            Btn_employee.Y = 20F;
            Btn_employee.MouseDown += Btn_employee_Press;
            // 
            // Btn_employer
            // 
            Btn_employer.BackColor = Color.FromArgb(255, 255, 255);
            Btn_employer.CornerColor = Color.White;
            Btn_employer.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            Btn_employer.ForeColor = Color.FromArgb(73, 73, 73);
            Btn_employer.Location = new Point(360, 258);
            Btn_employer.Margin = new Padding(5);
            Btn_employer.Name = "Btn_employer";
            Btn_employer.OutlineColor = Color.FromArgb(229, 229, 229);
            Btn_employer.OutlineColorActive = Color.FromArgb(242, 85, 26);
            Btn_employer.OutlineColorPassive = Color.FromArgb(229, 229, 229);
            Btn_employer.OutlineWidth = 2;
            Btn_employer.Rounding = 40;
            Btn_employer.Size = new Size(244, 63);
            Btn_employer.TabIndex = 5;
            Btn_employer.Text = "Я ищу сотрудников";
            Btn_employer.X = 20F;
            Btn_employer.Y = 20F;
            Btn_employer.MouseDown += Btn_employer_Press;
            // 
            // Btn_register
            // 
            Btn_register.BackColor = Color.FromArgb(255, 234, 226);
            Btn_register.CornerColor = Color.White;
            Btn_register.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            Btn_register.ForeColor = Color.FromArgb(242, 85, 26);
            Btn_register.Location = new Point(360, 385);
            Btn_register.Margin = new Padding(5);
            Btn_register.Name = "Btn_register";
            Btn_register.Rounding = 20;
            Btn_register.Size = new Size(244, 40);
            Btn_register.TabIndex = 6;
            Btn_register.Text = "Зарегистрироваться";
            Btn_register.Click += Btn_register_Click;
            // 
            // LoginRegister_Page
            // 
            AutoScaleDimensions = new SizeF(16F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(229, 229, 229);
            Controls.Add(Btn_register);
            Controls.Add(Btn_employer);
            Controls.Add(Btn_employee);
            Controls.Add(Btn_Enter);
            Controls.Add(Logo);
            Controls.Add(EnterLabel);
            Controls.Add(Stand);
            Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold);
            Margin = new Padding(5);
            Name = "LoginRegister_Page";
            Size = new Size(960, 540);
            Load += LoginRegiser_Page_Load;
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RoundedRectangle Stand;
        private Label EnterLabel;
        private PictureBox Logo;
        private RoundedButton1 Btn_Enter;
        private RoundedButton2 Btn_employee;
        private RoundedButton2 Btn_employer;
        private RoundedButton1 Btn_register;
    }
}
