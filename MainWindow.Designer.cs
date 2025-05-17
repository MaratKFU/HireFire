using HireFire.Classes.CustomInterfaceControls;

namespace HireFire
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            Greetings01 = new Label();
            Greetings02 = new Label();
            Greetings11 = new Label();
            Greetings12 = new Label();
            Greetings22 = new Label();
            Greetings21 = new Label();
            Greetings32 = new Label();
            Greetings31 = new Label();
            pictureBox1 = new PictureBox();
            Acception1 = new SimpleRoundedButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Greetings01
            // 
            Greetings01.AutoSize = true;
            Greetings01.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold);
            Greetings01.Location = new Point(225, 37);
            Greetings01.Name = "Greetings01";
            Greetings01.Size = new Size(503, 39);
            Greetings01.TabIndex = 0;
            Greetings01.Text = "Добро пожаловать в HireFire";
            // 
            // Greetings02
            // 
            Greetings02.AutoSize = true;
            Greetings02.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold);
            Greetings02.ForeColor = Color.FromArgb(73, 73, 73);
            Greetings02.Location = new Point(244, 76);
            Greetings02.Name = "Greetings02";
            Greetings02.Size = new Size(466, 26);
            Greetings02.TabIndex = 1;
            Greetings02.Text = "Пожалуйста, соблюдайте наши правила:";
            // 
            // Greetings11
            // 
            Greetings11.AutoSize = true;
            Greetings11.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold);
            Greetings11.Location = new Point(83, 145);
            Greetings11.Name = "Greetings11";
            Greetings11.Size = new Size(197, 26);
            Greetings11.TabIndex = 2;
            Greetings11.Text = "· ✓ Будьте собой";
            // 
            // Greetings12
            // 
            Greetings12.AutoSize = true;
            Greetings12.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            Greetings12.ForeColor = Color.FromArgb(73, 73, 73);
            Greetings12.Location = new Point(121, 175);
            Greetings12.Name = "Greetings12";
            Greetings12.Size = new Size(674, 48);
            Greetings12.TabIndex = 3;
            Greetings12.Text = "Убедитесь, что ваше резюме и профиль отражают ваши реальные\nнавыки и опыт.";
            // 
            // Greetings22
            // 
            Greetings22.AutoSize = true;
            Greetings22.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            Greetings22.ForeColor = Color.FromArgb(73, 73, 73);
            Greetings22.Location = new Point(121, 253);
            Greetings22.Name = "Greetings22";
            Greetings22.Size = new Size(696, 48);
            Greetings22.TabIndex = 5;
            Greetings22.Text = "Не спешите делиться личной информацией. Общайтесь безопасно и\nпроверяйте работодателей.";
            // 
            // Greetings21
            // 
            Greetings21.AutoSize = true;
            Greetings21.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold);
            Greetings21.Location = new Point(83, 223);
            Greetings21.Name = "Greetings21";
            Greetings21.Size = new Size(254, 26);
            Greetings21.TabIndex = 4;
            Greetings21.Text = "· ✓ Будьте осторожны";
            // 
            // Greetings32
            // 
            Greetings32.AutoSize = true;
            Greetings32.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            Greetings32.ForeColor = Color.FromArgb(73, 73, 73);
            Greetings32.Location = new Point(121, 331);
            Greetings32.Name = "Greetings32";
            Greetings32.Size = new Size(670, 48);
            Greetings32.TabIndex = 7;
            Greetings32.Text = "Относитесь к другим так, как хотели бы, чтобы относились к вам.\nСтройте профессиональные отношения на взаимном уважении.";
            // 
            // Greetings31
            // 
            Greetings31.AutoSize = true;
            Greetings31.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold);
            Greetings31.Location = new Point(83, 301);
            Greetings31.Name = "Greetings31";
            Greetings31.Size = new Size(235, 26);
            Greetings31.TabIndex = 6;
            Greetings31.Text = "· ✓ Уважайте других";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Main_Icon;
            pictureBox1.Location = new Point(134, 19);
            pictureBox1.MaximumSize = new Size(1000, 1000);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(96, 83);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // Acception1
            // 
            Acception1.BackColor = Color.FromArgb(242, 85, 26);
            Acception1.CornerColor = Color.FromArgb(229, 229, 229);
            Acception1.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold);
            Acception1.ForeColor = Color.White;
            Acception1.Location = new Point(366, 407);
            Acception1.Name = "Acception1";
            Acception1.Rounding = 60;
            Acception1.Size = new Size(236, 63);
            Acception1.TabIndex = 8;
            Acception1.Text = "Я согласен";
            Acception1.Click += Acception1_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(229, 229, 229);
            ClientSize = new Size(942, 513);
            Controls.Add(pictureBox1);
            Controls.Add(Acception1);
            Controls.Add(Greetings32);
            Controls.Add(Greetings31);
            Controls.Add(Greetings22);
            Controls.Add(Greetings21);
            Controls.Add(Greetings12);
            Controls.Add(Greetings11);
            Controls.Add(Greetings02);
            Controls.Add(Greetings01);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(960, 560);
            MinimumSize = new Size(960, 560);
            Name = "MainWindow";
            Text = "HireFire";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Greetings01;
        private Label Greetings02;
        private Label Greetings11;
        private Label Greetings12;
        private Label Greetings22;
        private Label Greetings21;
        private Label Greetings32;
        private Label Greetings31;
        private PictureBox pictureBox1;
        private SimpleRoundedButton Acception1;
    }
}
