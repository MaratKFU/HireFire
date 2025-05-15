using HireFire.Classes.CustomInterfaceControls;

namespace HireFire
{
    partial class Login_Page
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
            Back_Button = new SimpleRoundedButton();
            Enter_Button = new SimpleRoundedButton();
            PasswordTextBox = new TextBox();
            LoginTextBox = new TextBox();
            roundedRectangleWithOutline4 = new RoundedRectangleWithOutline();
            roundedRectangle1 = new RoundedRectangle();
            roundedRectangleWithOutline5 = new RoundedRectangleWithOutline();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = Properties.Resources.Main_Icon;
            pictureBox1.Location = new Point(449, 142);
            pictureBox1.MaximumSize = new Size(70, 70);
            pictureBox1.MinimumSize = new Size(70, 70);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            label1.Location = new Point(452, 221);
            label1.Name = "label1";
            label1.Size = new Size(59, 24);
            label1.TabIndex = 25;
            label1.Text = "Вход";
            // 
            // Back_Button
            // 
            Back_Button.BackColor = Color.White;
            Back_Button.CornerColor = Color.White;
            Back_Button.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Bold);
            Back_Button.ForeColor = Color.FromArgb(242, 85, 26);
            Back_Button.Location = new Point(355, 168);
            Back_Button.Name = "Back_Button";
            Back_Button.Rounding = 20;
            Back_Button.Size = new Size(75, 25);
            Back_Button.TabIndex = 24;
            Back_Button.Text = "Назад";
            Back_Button.Click += BackButton_Click;
            // 
            // Enter_Button
            // 
            Enter_Button.BackColor = Color.FromArgb(242, 85, 26);
            Enter_Button.CornerColor = Color.White;
            Enter_Button.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Bold);
            Enter_Button.ForeColor = Color.White;
            Enter_Button.Location = new Point(442, 358);
            Enter_Button.Name = "Enter_Button";
            Enter_Button.Rounding = 20;
            Enter_Button.Size = new Size(75, 25);
            Enter_Button.TabIndex = 23;
            Enter_Button.Text = "Войти";
            Enter_Button.Click += EnterButton_Click;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.AccessibleDescription = "фывыффвыфв";
            PasswordTextBox.AccessibleRole = AccessibleRole.None;
            PasswordTextBox.BackColor = Color.FromArgb(229, 229, 229);
            PasswordTextBox.BorderStyle = BorderStyle.None;
            PasswordTextBox.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            PasswordTextBox.Location = new Point(370, 306);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(220, 16);
            PasswordTextBox.TabIndex = 22;
            // 
            // LoginTextBox
            // 
            LoginTextBox.BackColor = Color.FromArgb(229, 229, 229);
            LoginTextBox.BorderStyle = BorderStyle.None;
            LoginTextBox.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            LoginTextBox.Location = new Point(369, 261);
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.Size = new Size(220, 16);
            LoginTextBox.TabIndex = 20;
            // 
            // roundedRectangleWithOutline4
            // 
            roundedRectangleWithOutline4.BackColor = Color.FromArgb(229, 229, 229);
            roundedRectangleWithOutline4.CornerColor = Color.White;
            roundedRectangleWithOutline4.ForeColor = Color.FromArgb(161, 148, 148);
            roundedRectangleWithOutline4.Location = new Point(362, 254);
            roundedRectangleWithOutline4.Name = "roundedRectangleWithOutline4";
            roundedRectangleWithOutline4.OutlineColor = Color.Black;
            roundedRectangleWithOutline4.OutlineWidth = 1;
            roundedRectangleWithOutline4.Rounding = 15;
            roundedRectangleWithOutline4.Size = new Size(235, 30);
            roundedRectangleWithOutline4.TabIndex = 19;
            roundedRectangleWithOutline4.Text = "roundedRectangleWithOutline4";
            // 
            // roundedRectangle1
            // 
            roundedRectangle1.BackColor = Color.White;
            roundedRectangle1.CornerColor = Color.FromArgb(229, 229, 229);
            roundedRectangle1.ForeColor = Color.White;
            roundedRectangle1.Location = new Point(317, 142);
            roundedRectangle1.Name = "roundedRectangle1";
            roundedRectangle1.Rounding = 100;
            roundedRectangle1.Size = new Size(327, 256);
            roundedRectangle1.TabIndex = 14;
            roundedRectangle1.Text = "roundedRectangle1";
            // 
            // roundedRectangleWithOutline5
            // 
            roundedRectangleWithOutline5.BackColor = Color.FromArgb(229, 229, 229);
            roundedRectangleWithOutline5.CornerColor = Color.White;
            roundedRectangleWithOutline5.ForeColor = Color.FromArgb(161, 148, 148);
            roundedRectangleWithOutline5.Location = new Point(363, 299);
            roundedRectangleWithOutline5.Name = "roundedRectangleWithOutline5";
            roundedRectangleWithOutline5.OutlineColor = Color.Black;
            roundedRectangleWithOutline5.OutlineWidth = 1;
            roundedRectangleWithOutline5.Rounding = 15;
            roundedRectangleWithOutline5.Size = new Size(235, 30);
            roundedRectangleWithOutline5.TabIndex = 21;
            roundedRectangleWithOutline5.Text = "roundedRectangleWithOutline5";
            // 
            // Login_Page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(229, 229, 229);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(Back_Button);
            Controls.Add(Enter_Button);
            Controls.Add(PasswordTextBox);
            Controls.Add(roundedRectangleWithOutline5);
            Controls.Add(LoginTextBox);
            Controls.Add(roundedRectangleWithOutline4);
            Controls.Add(roundedRectangle1);
            Name = "Login_Page";
            Size = new Size(960, 540);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private SimpleRoundedButton Back_Button;
        private SimpleRoundedButton Enter_Button;
        private TextBox PasswordTextBox;
        private TextBox LoginTextBox;
        private RoundedRectangleWithOutline roundedRectangleWithOutline4;
        private RoundedRectangle roundedRectangle1;
        private RoundedRectangleWithOutline roundedRectangleWithOutline5;
    }
}
