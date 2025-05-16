using HireFire.Classes.Entities;
using HireFire.Classes.CustomInterfaceControls;
using HireFire.Classes.DataBase;


namespace HireFire.UserControls
{
    public partial class JobSeekerDialogs_Page : UserControl
    {
        DataService dataService = new DataService();
        JobSeeker jobSeeker;
        Employer currEmployer;
        List<MyDialog> dialogs = [];
        public JobSeekerDialogs_Page(JobSeeker _jobSeeker)
        {
            DoubleBuffered = true;

            InitializeComponent();

            jobSeeker = _jobSeeker;

            LoadDialogs();

            DialogsList.DataSource = dialogs;
            DialogsList.SelectedIndex = 0;
            currEmployer = dataService.GetEmployer(((MyDialog)DialogsList.SelectedItem).EmployerId);

            ChatPanel.GetType().GetMethod("SetStyle", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).Invoke(ChatPanel, new object[] { ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true });
            ChatPanel.AutoScrollPosition = new Point(0, ChatPanel.VerticalScroll.Maximum);
            TextToSend.AddPlaceholder("Напишите текст...");
        }
        private void LoadDialogs()
        {
            foreach (int i in jobSeeker.DialogsIds)
            {
                dialogs.Add(dataService.GetDialog(i));
            }
        }
        private void SearchButton_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            var search_page_control = new SearchVacancies_Page(jobSeeker);
            search_page_control.Dock = DockStyle.Fill;
            Controls.Add(search_page_control);
        }
        private void ProfileButton_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            var profile_page_control = new Resumes_Page(jobSeeker);
            profile_page_control.Dock = DockStyle.Fill;
            Controls.Add(profile_page_control);
        }
        private void SendButton_Click(object sender, EventArgs e)
        {
            if (TextToSend.ForeColor == Color.Black && TextToSend.Text.Length != 0)
            {
                string finalText = TextToSend.Text;
                var messageControl = new RoundedMessage(
                    $"Вы: {TextToSend.Text}",
                    isOutgoing: true,
                    containerSize: ChatPanel.ClientSize,
                    time: DateTime.UtcNow,
                    alignment: HorizontalAlignment.Center
                );
                ChatPanel.Controls.Add(messageControl);

                var userMessage = new UserMessage();
                userMessage.MessageText = finalText;
                userMessage.Sender = "J";
                userMessage.DispatchTime = DateTime.UtcNow;

                int messageId = dataService.SaveMessage(userMessage);

                var selectedDialog = (MyDialog)DialogsList.SelectedItem;
                if (selectedDialog != null)
                {
                    selectedDialog.MessagesIds.Add(messageId);
                    dataService.SaveDialog(selectedDialog);
                }
                TextToSend.Text = "";
                ChatPanel.ScrollControlIntoView(messageControl);
            }
        }
        private void LoadValues()
        {
            var image = Image.FromStream(new MemoryStream(currEmployer.PhotoData));
            EmployerAvatar.Image = new Bitmap(image);
            FullNameLabel.Text = $"{currEmployer.Surname} {currEmployer.Name} {currEmployer.Lastname}";
            foreach (int i in ((MyDialog)DialogsList.SelectedItem).MessagesIds)
            {
                UserMessage currMessage = dataService.GetMessage(i);
                bool IOGMessage;
                string messageText = currMessage.MessageText;
                if (currMessage.Sender == "E")
                {
                    IOGMessage = false;
                    messageText = $"{currEmployer.Name}: " + messageText;
                }    
                else
                {
                    IOGMessage = true;
                    messageText = $"Вы: " + messageText;
                }

                var messageControl = new RoundedMessage(
                    messageText,
                    isOutgoing: IOGMessage,
                    containerSize: ChatPanel.ClientSize,
                    time: currMessage.DispatchTime,
                    alignment: HorizontalAlignment.Center
                );

                ChatPanel.Controls.Add(messageControl);

                if (i == ((MyDialog)DialogsList.SelectedItem).MessagesIds.Count - 1)
                {
                    ChatPanel.ScrollControlIntoView(messageControl);
                }
            }
        }
        private void DialogsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Employer replaceEmployer = dataService.GetEmployer(((MyDialog)DialogsList.SelectedItem).EmployerId);
            if (currEmployer != replaceEmployer)
            {
                currEmployer = replaceEmployer;
                LoadValues();
            }
        }

    }
}

