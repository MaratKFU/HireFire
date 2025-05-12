using HireFire.Classes.CustomInterfaceControls;

namespace HireFire
{
    partial class JobSeekerRegister1_Page
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
            Previous_Button = new RoundedButton1();
            Next_Button = new RoundedButton1();
            RepeatPasswordTextBox = new TextBox();
            roundedRectangleWithOutline5 = new RoundedRectangleWithOutline();
            PasswordTextBox = new TextBox();
            roundedRectangleWithOutline4 = new RoundedRectangleWithOutline();
            LoginTextBox = new TextBox();
            roundedRectangleWithOutline3 = new RoundedRectangleWithOutline();
            MailTextBox = new TextBox();
            roundedRectangleWithOutline2 = new RoundedRectangleWithOutline();
            roundedRectangle1 = new RoundedRectangle();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            label1.Location = new Point(392, 159);
            label1.Name = "label1";
            label1.Size = new Size(184, 48);
            label1.TabIndex = 25;
            label1.Text = "Регистрация для \n     соискателя";
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
            Previous_Button.TabIndex = 24;
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
            Next_Button.TabIndex = 23;
            Next_Button.Text = "Далее";
            Next_Button.Click += Next_Button_Click;
            // 
            // RepeatPasswordTextBox
            // 
            RepeatPasswordTextBox.BackColor = Color.FromArgb(229, 229, 229);
            RepeatPasswordTextBox.BorderStyle = BorderStyle.None;
            RepeatPasswordTextBox.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            RepeatPasswordTextBox.Location = new Point(371, 368);
            RepeatPasswordTextBox.Name = "RepeatPasswordTextBox";
            RepeatPasswordTextBox.Size = new Size(220, 16);
            RepeatPasswordTextBox.TabIndex = 22;
            // 
            // roundedRectangleWithOutline5
            // 
            roundedRectangleWithOutline5.BackColor = Color.FromArgb(229, 229, 229);
            roundedRectangleWithOutline5.CornerColor = Color.White;
            roundedRectangleWithOutline5.ForeColor = Color.FromArgb(161, 148, 148);
            roundedRectangleWithOutline5.Location = new Point(364, 361);
            roundedRectangleWithOutline5.Name = "roundedRectangleWithOutline5";
            roundedRectangleWithOutline5.OutlineColor = Color.Black;
            roundedRectangleWithOutline5.OutlineWidth = 1;
            roundedRectangleWithOutline5.Rounding = 15;
            roundedRectangleWithOutline5.Size = new Size(235, 30);
            roundedRectangleWithOutline5.TabIndex = 21;
            roundedRectangleWithOutline5.Text = "roundedRectangleWithOutline5";
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.BackColor = Color.FromArgb(229, 229, 229);
            PasswordTextBox.BorderStyle = BorderStyle.None;
            PasswordTextBox.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            PasswordTextBox.Location = new Point(371, 324);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(220, 16);
            PasswordTextBox.TabIndex = 20;
            // 
            // roundedRectangleWithOutline4
            // 
            roundedRectangleWithOutline4.BackColor = Color.FromArgb(229, 229, 229);
            roundedRectangleWithOutline4.CornerColor = Color.White;
            roundedRectangleWithOutline4.ForeColor = Color.FromArgb(161, 148, 148);
            roundedRectangleWithOutline4.Location = new Point(364, 317);
            roundedRectangleWithOutline4.Name = "roundedRectangleWithOutline4";
            roundedRectangleWithOutline4.OutlineColor = Color.Black;
            roundedRectangleWithOutline4.OutlineWidth = 1;
            roundedRectangleWithOutline4.Rounding = 15;
            roundedRectangleWithOutline4.Size = new Size(235, 30);
            roundedRectangleWithOutline4.TabIndex = 19;
            roundedRectangleWithOutline4.Text = "roundedRectangleWithOutline4";
            // 
            // LoginTextBox
            // 
            LoginTextBox.BackColor = Color.FromArgb(229, 229, 229);
            LoginTextBox.BorderStyle = BorderStyle.None;
            LoginTextBox.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            LoginTextBox.Location = new Point(371, 279);
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.Size = new Size(220, 16);
            LoginTextBox.TabIndex = 18;
            // 
            // roundedRectangleWithOutline3
            // 
            roundedRectangleWithOutline3.BackColor = Color.FromArgb(229, 229, 229);
            roundedRectangleWithOutline3.CornerColor = Color.White;
            roundedRectangleWithOutline3.ForeColor = Color.FromArgb(161, 148, 148);
            roundedRectangleWithOutline3.Location = new Point(364, 272);
            roundedRectangleWithOutline3.Name = "roundedRectangleWithOutline3";
            roundedRectangleWithOutline3.OutlineColor = Color.Black;
            roundedRectangleWithOutline3.OutlineWidth = 1;
            roundedRectangleWithOutline3.Rounding = 15;
            roundedRectangleWithOutline3.Size = new Size(235, 30);
            roundedRectangleWithOutline3.TabIndex = 17;
            roundedRectangleWithOutline3.Text = "roundedRectangleWithOutline3";
            // 
            // MailTextBox
            // 
            MailTextBox.BackColor = Color.FromArgb(229, 229, 229);
            MailTextBox.BorderStyle = BorderStyle.None;
            MailTextBox.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            MailTextBox.Location = new Point(371, 235);
            MailTextBox.Name = "MailTextBox";
            MailTextBox.Size = new Size(220, 16);
            MailTextBox.TabIndex = 16;
            // 
            // roundedRectangleWithOutline2
            // 
            roundedRectangleWithOutline2.BackColor = Color.FromArgb(229, 229, 229);
            roundedRectangleWithOutline2.CornerColor = Color.White;
            roundedRectangleWithOutline2.ForeColor = Color.FromArgb(161, 148, 148);
            roundedRectangleWithOutline2.Location = new Point(364, 228);
            roundedRectangleWithOutline2.Name = "roundedRectangleWithOutline2";
            roundedRectangleWithOutline2.OutlineColor = Color.Black;
            roundedRectangleWithOutline2.OutlineWidth = 1;
            roundedRectangleWithOutline2.Rounding = 15;
            roundedRectangleWithOutline2.Size = new Size(235, 30);
            roundedRectangleWithOutline2.TabIndex = 15;
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
            roundedRectangle1.TabIndex = 14;
            roundedRectangle1.Text = "roundedRectangle1";
            // 
            // JobSeekerRegister1_Page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(229, 229, 229);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(Previous_Button);
            Controls.Add(Next_Button);
            Controls.Add(RepeatPasswordTextBox);
            Controls.Add(roundedRectangleWithOutline5);
            Controls.Add(PasswordTextBox);
            Controls.Add(roundedRectangleWithOutline4);
            Controls.Add(LoginTextBox);
            Controls.Add(roundedRectangleWithOutline3);
            Controls.Add(MailTextBox);
            Controls.Add(roundedRectangleWithOutline2);
            Controls.Add(roundedRectangle1);
            Name = "JobSeekerRegister1_Page";
            Size = new Size(960, 540);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private RoundedButton1 Previous_Button;
        private RoundedButton1 Next_Button;
        private TextBox RepeatPasswordTextBox;
        private RoundedRectangleWithOutline roundedRectangleWithOutline5;
        private TextBox PasswordTextBox;
        private RoundedRectangleWithOutline roundedRectangleWithOutline4;
        private TextBox LoginTextBox;
        private RoundedRectangleWithOutline roundedRectangleWithOutline3;
        private TextBox MailTextBox;
        private RoundedRectangleWithOutline roundedRectangleWithOutline2;
        private RoundedRectangle roundedRectangle1;
    }
}
