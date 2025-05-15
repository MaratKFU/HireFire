namespace HireFire.UserControls
{
    partial class JobSeekerDialogs_Page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JobSeekerDialogs_Page));
            roundedPictureBox5 = new RoundedPictureBox();
            roundedPictureBox2 = new RoundedPictureBox();
            roundedPictureBox4 = new RoundedPictureBox();
            roundedPictureBox3 = new RoundedPictureBox();
            roundedRectangle2 = new HireFire.Classes.CustomInterfaceControls.RoundedRectangle();
            roundedRectangle4 = new HireFire.Classes.CustomInterfaceControls.RoundedRectangle();
            roundedRectangle5 = new HireFire.Classes.CustomInterfaceControls.RoundedRectangle();
            SendButton = new HireFire.Classes.CustomInterfaceControls.SimpleRoundedButton();
            DialogsList = new ListBox();
            EmployerAvatar = new RoundedPictureBox();
            roundedRectangleWithOutline1 = new HireFire.Classes.CustomInterfaceControls.RoundedRectangleWithOutline();
            FullNameLabel = new Label();
            TextToSend = new TextBox();
            roundedRectangleWithOutline2 = new HireFire.Classes.CustomInterfaceControls.RoundedRectangleWithOutline();
            ChatPanel = new FlowLayoutPanel();
            roundedRectangle1 = new HireFire.Classes.CustomInterfaceControls.RoundedRectangle();
            ((System.ComponentModel.ISupportInitialize)roundedPictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roundedPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roundedPictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roundedPictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EmployerAvatar).BeginInit();
            roundedRectangleWithOutline1.SuspendLayout();
            SuspendLayout();
            // 
            // roundedPictureBox5
            // 
            roundedPictureBox5.BackColor = Color.FromArgb(0, 0, 0, 0);
            roundedPictureBox5.BorderColor = Color.FromArgb(0, 0, 0, 0);
            roundedPictureBox5.BorderWidth = 200F;
            roundedPictureBox5.CornerRadius = 100;
            roundedPictureBox5.Image = Properties.Resources.Main_Icon;
            roundedPictureBox5.Location = new Point(0, -2);
            roundedPictureBox5.Name = "roundedPictureBox5";
            roundedPictureBox5.Size = new Size(80, 80);
            roundedPictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            roundedPictureBox5.TabIndex = 99;
            roundedPictureBox5.TabStop = false;
            // 
            // roundedPictureBox2
            // 
            roundedPictureBox2.BackColor = Color.White;
            roundedPictureBox2.BorderColor = Color.FromArgb(0, 0, 0, 0);
            roundedPictureBox2.BorderWidth = 200F;
            roundedPictureBox2.CornerRadius = 100;
            roundedPictureBox2.Image = Properties.Resources.Search_Icon_Passive;
            roundedPictureBox2.Location = new Point(14, 157);
            roundedPictureBox2.Name = "roundedPictureBox2";
            roundedPictureBox2.Size = new Size(50, 50);
            roundedPictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            roundedPictureBox2.TabIndex = 98;
            roundedPictureBox2.TabStop = false;
            roundedPictureBox2.Click += SearchButton_Click;
            // 
            // roundedPictureBox4
            // 
            roundedPictureBox4.BackColor = Color.FromArgb(161, 148, 148);
            roundedPictureBox4.BorderColor = Color.FromArgb(0, 0, 0, 0);
            roundedPictureBox4.BorderWidth = 200F;
            roundedPictureBox4.CornerRadius = 100;
            roundedPictureBox4.Image = Properties.Resources.Messages_Icon_Passive;
            roundedPictureBox4.Location = new Point(14, 257);
            roundedPictureBox4.Name = "roundedPictureBox4";
            roundedPictureBox4.Size = new Size(50, 50);
            roundedPictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            roundedPictureBox4.TabIndex = 95;
            roundedPictureBox4.TabStop = false;
            // 
            // roundedPictureBox3
            // 
            roundedPictureBox3.BackColor = Color.White;
            roundedPictureBox3.BorderColor = Color.FromArgb(0, 0, 0, 0);
            roundedPictureBox3.BorderWidth = 200F;
            roundedPictureBox3.CornerRadius = 100;
            roundedPictureBox3.Image = Properties.Resources.Profile_Icon_Passive;
            roundedPictureBox3.Location = new Point(14, 357);
            roundedPictureBox3.Name = "roundedPictureBox3";
            roundedPictureBox3.Size = new Size(50, 50);
            roundedPictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            roundedPictureBox3.TabIndex = 94;
            roundedPictureBox3.TabStop = false;
            roundedPictureBox3.Click += ProfileButton_Click;
            // 
            // roundedRectangle2
            // 
            roundedRectangle2.BackColor = Color.White;
            roundedRectangle2.CornerColor = Color.FromArgb(229, 229, 229);
            roundedRectangle2.ForeColor = Color.White;
            roundedRectangle2.Location = new Point(-20, 148);
            roundedRectangle2.Name = "roundedRectangle2";
            roundedRectangle2.Rounding = 50;
            roundedRectangle2.Size = new Size(100, 67);
            roundedRectangle2.TabIndex = 93;
            roundedRectangle2.Text = "roundedRectangle2";
            roundedRectangle2.Click += SearchButton_Click;
            // 
            // roundedRectangle4
            // 
            roundedRectangle4.BackColor = Color.FromArgb(161, 148, 148);
            roundedRectangle4.CornerColor = Color.FromArgb(229, 229, 229);
            roundedRectangle4.ForeColor = Color.White;
            roundedRectangle4.Location = new Point(-20, 248);
            roundedRectangle4.Name = "roundedRectangle4";
            roundedRectangle4.Rounding = 50;
            roundedRectangle4.Size = new Size(100, 67);
            roundedRectangle4.TabIndex = 96;
            roundedRectangle4.Text = "roundedRectangle4";
            // 
            // roundedRectangle5
            // 
            roundedRectangle5.BackColor = Color.White;
            roundedRectangle5.CornerColor = Color.FromArgb(229, 229, 229);
            roundedRectangle5.ForeColor = Color.White;
            roundedRectangle5.Location = new Point(-20, 348);
            roundedRectangle5.Name = "roundedRectangle5";
            roundedRectangle5.Rounding = 50;
            roundedRectangle5.Size = new Size(100, 67);
            roundedRectangle5.TabIndex = 97;
            roundedRectangle5.Text = "roundedRectangle5";
            roundedRectangle5.Click += ProfileButton_Click;
            // 
            // SendButton
            // 
            SendButton.BackColor = Color.FromArgb(242, 85, 26);
            SendButton.CornerColor = Color.FromArgb(229, 229, 229);
            SendButton.Font = new Font("Segoe UI", 7F);
            SendButton.ForeColor = Color.White;
            SendButton.Location = new Point(601, 454);
            SendButton.Name = "SendButton";
            SendButton.Rounding = 30;
            SendButton.Size = new Size(125, 38);
            SendButton.TabIndex = 107;
            SendButton.Text = "Отправить";
            SendButton.Click += SendButton_Click;
            // 
            // DialogsList
            // 
            DialogsList.BorderStyle = BorderStyle.None;
            DialogsList.DisplayMember = "EmployerInit";
            DialogsList.Font = new Font("Segoe UI", 7F);
            DialogsList.FormattingEnabled = true;
            DialogsList.Location = new Point(783, 111);
            DialogsList.Name = "DialogsList";
            DialogsList.Size = new Size(150, 270);
            DialogsList.TabIndex = 104;
            DialogsList.SelectedIndexChanged += DialogsList_SelectedIndexChanged;
            // 
            // EmployerAvatar
            // 
            EmployerAvatar.BackColor = Color.White;
            EmployerAvatar.BorderColor = Color.White;
            EmployerAvatar.BorderWidth = 200F;
            EmployerAvatar.CornerRadius = 100;
            EmployerAvatar.Image = (Image)resources.GetObject("EmployerAvatar.Image");
            EmployerAvatar.Location = new Point(168, 16);
            EmployerAvatar.Name = "EmployerAvatar";
            EmployerAvatar.Size = new Size(70, 70);
            EmployerAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            EmployerAvatar.TabIndex = 103;
            EmployerAvatar.TabStop = false;
            // 
            // roundedRectangleWithOutline1
            // 
            roundedRectangleWithOutline1.BackColor = Color.White;
            roundedRectangleWithOutline1.Controls.Add(FullNameLabel);
            roundedRectangleWithOutline1.CornerColor = Color.FromArgb(229, 229, 229);
            roundedRectangleWithOutline1.ForeColor = Color.White;
            roundedRectangleWithOutline1.Location = new Point(149, 1);
            roundedRectangleWithOutline1.Name = "roundedRectangleWithOutline1";
            roundedRectangleWithOutline1.OutlineColor = Color.FromArgb(243, 81, 28);
            roundedRectangleWithOutline1.OutlineWidth = 2;
            roundedRectangleWithOutline1.Rounding = 1;
            roundedRectangleWithOutline1.Size = new Size(600, 98);
            roundedRectangleWithOutline1.TabIndex = 102;
            roundedRectangleWithOutline1.Text = "roundedRectangleWithOutline1";
            // 
            // FullNameLabel
            // 
            FullNameLabel.AutoSize = true;
            FullNameLabel.Font = new Font("Montserrat", 15F);
            FullNameLabel.ForeColor = Color.Black;
            FullNameLabel.Location = new Point(95, 31);
            FullNameLabel.Name = "FullNameLabel";
            FullNameLabel.Size = new Size(87, 39);
            FullNameLabel.TabIndex = 0;
            FullNameLabel.Text = "label1";
            // 
            // TextToSend
            // 
            TextToSend.BackColor = Color.FromArgb(244, 241, 241);
            TextToSend.BorderStyle = BorderStyle.None;
            TextToSend.Font = new Font("Segoe UI", 15F);
            TextToSend.ForeColor = Color.Black;
            TextToSend.Location = new Point(176, 398);
            TextToSend.Name = "TextToSend";
            TextToSend.Size = new Size(550, 34);
            TextToSend.TabIndex = 101;
            // 
            // roundedRectangleWithOutline2
            // 
            roundedRectangleWithOutline2.BackColor = Color.White;
            roundedRectangleWithOutline2.CornerColor = Color.FromArgb(229, 229, 229);
            roundedRectangleWithOutline2.ForeColor = Color.White;
            roundedRectangleWithOutline2.Location = new Point(771, 70);
            roundedRectangleWithOutline2.Name = "roundedRectangleWithOutline2";
            roundedRectangleWithOutline2.OutlineColor = Color.FromArgb(243, 81, 28);
            roundedRectangleWithOutline2.OutlineWidth = 2;
            roundedRectangleWithOutline2.Rounding = 70;
            roundedRectangleWithOutline2.Size = new Size(174, 362);
            roundedRectangleWithOutline2.TabIndex = 105;
            roundedRectangleWithOutline2.Text = "roundedRectangleWithOutline2";
            // 
            // ChatPanel
            // 
            ChatPanel.AccessibleRole = AccessibleRole.ScrollBar;
            ChatPanel.AutoScroll = true;
            ChatPanel.BackColor = Color.White;
            ChatPanel.FlowDirection = FlowDirection.TopDown;
            ChatPanel.Location = new Point(149, 98);
            ChatPanel.Name = "ChatPanel";
            ChatPanel.Size = new Size(600, 293);
            ChatPanel.TabIndex = 106;
            ChatPanel.WrapContents = false;
            // 
            // roundedRectangle1
            // 
            roundedRectangle1.BackColor = Color.FromArgb(244, 241, 241);
            roundedRectangle1.CornerColor = Color.FromArgb(229, 229, 229);
            roundedRectangle1.ForeColor = Color.White;
            roundedRectangle1.Location = new Point(149, 298);
            roundedRectangle1.Name = "roundedRectangle1";
            roundedRectangle1.Rounding = 100;
            roundedRectangle1.Size = new Size(600, 150);
            roundedRectangle1.TabIndex = 100;
            roundedRectangle1.Text = "roundedRectangle1";
            // 
            // JobSeekerDialogs_Page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(229, 229, 229);
            Controls.Add(SendButton);
            Controls.Add(DialogsList);
            Controls.Add(EmployerAvatar);
            Controls.Add(roundedRectangleWithOutline1);
            Controls.Add(TextToSend);
            Controls.Add(roundedRectangleWithOutline2);
            Controls.Add(ChatPanel);
            Controls.Add(roundedRectangle1);
            Controls.Add(roundedPictureBox5);
            Controls.Add(roundedPictureBox2);
            Controls.Add(roundedPictureBox4);
            Controls.Add(roundedPictureBox3);
            Controls.Add(roundedRectangle2);
            Controls.Add(roundedRectangle4);
            Controls.Add(roundedRectangle5);
            Name = "JobSeekerDialogs_Page";
            Size = new Size(960, 540);
            ((System.ComponentModel.ISupportInitialize)roundedPictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)roundedPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)roundedPictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)roundedPictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)EmployerAvatar).EndInit();
            roundedRectangleWithOutline1.ResumeLayout(false);
            roundedRectangleWithOutline1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RoundedPictureBox roundedPictureBox5;
        private RoundedPictureBox roundedPictureBox2;
        private RoundedPictureBox roundedPictureBox4;
        private RoundedPictureBox roundedPictureBox3;
        private Classes.CustomInterfaceControls.RoundedRectangle roundedRectangle2;
        private Classes.CustomInterfaceControls.RoundedRectangle roundedRectangle4;
        private Classes.CustomInterfaceControls.RoundedRectangle roundedRectangle5;
        private Classes.CustomInterfaceControls.SimpleRoundedButton SendButton;
        private ListBox DialogsList;
        private RoundedPictureBox EmployerAvatar;
        private Classes.CustomInterfaceControls.RoundedRectangleWithOutline roundedRectangleWithOutline1;
        private Label FullNameLabel;
        private TextBox TextToSend;
        private Classes.CustomInterfaceControls.RoundedRectangleWithOutline roundedRectangleWithOutline2;
        private FlowLayoutPanel ChatPanel;
        private Classes.CustomInterfaceControls.RoundedRectangle roundedRectangle1;
    }
}
