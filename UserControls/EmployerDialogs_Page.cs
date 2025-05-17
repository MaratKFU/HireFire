using HireFire.Classes.Entities;
using HireFire.Classes.CustomInterfaceControls;
using HireFire.Classes.DataBase;



namespace HireFire.UserControls
{
    public partial class EmployerDialogs_Page : UserControl
    {
        DataService dataService = new DataService();
        Employer employer;
        JobSeeker currJobSeeker;
        List<MyDialog> dialogs = [];
        public EmployerDialogs_Page(Employer _employer)
        {
            DoubleBuffered = true;

            InitializeComponent();

            employer = _employer;

            LoadDialogs();

            DialogsList.DataSource = dialogs;
            DialogsList.SelectedIndex = 0;

            currJobSeeker = dataService.GetJobSeeker(((MyDialog)DialogsList.SelectedItem).JobSeekerId);

            ChatPanel.GetType().GetMethod("SetStyle", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).Invoke(ChatPanel, new object[] { ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true });
            ChatPanel.AutoScrollPosition = new Point(0, ChatPanel.VerticalScroll.Maximum);
            
            SetPlaceholderValues();
        }

        //Бизнес логика
        private void LoadDialogs()
        {
            foreach(int i in employer.DialogsIds)
            {
                dialogs.Add(dataService.GetDialog(i));
            }
        }
        private void LoadValues()
        {
            using var stream = new MemoryStream(currJobSeeker.PhotoData);
            JobSeekerAvatar.Image = new Bitmap(stream);

            FullNameLabel.Text = string.Join(" ", new[]
            {
        currJobSeeker.Surname,
        currJobSeeker.Name,
        currJobSeeker.Lastname
    }.Where(s => !string.IsNullOrEmpty(s)));

            var selectedDialog = (MyDialog)DialogsList.SelectedItem;
            var lastMessageId = selectedDialog.MessagesIds.LastOrDefault();

            ChatPanel.SuspendLayout();

            foreach (var messageId in selectedDialog.MessagesIds)
            {
                var message = dataService.GetMessage(messageId);
                var isOutgoing = message.Sender != "J";

                var prefix = isOutgoing ? "Вы: " : $"{currJobSeeker.Name}: ";
                var messageText = prefix + message.MessageText;

                var messageControl = new RoundedMessage(
                    messageText,
                    isOutgoing,
                    ChatPanel.ClientSize,
                    message.DispatchTime)
                {
                };

                ChatPanel.Controls.Add(messageControl);

                if (messageId == lastMessageId)
                {
                    ChatPanel.ScrollControlIntoView(messageControl);
                }
            }

            ChatPanel.ResumeLayout();
        }



        //Интерфейс
        private void SetPlaceholderValues()
        {
            TextToSend.AddPlaceholder("Напишите текст...");
        }
        private void SearchButton_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            var search_page_control = new SearchResumes_Page(employer);
            search_page_control.Dock = DockStyle.Fill;
            Controls.Add(search_page_control);
        }
        private void ProfileButton_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            var profile_page_control = new Vacancies_Page(employer);
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
                
                UserMessage userMessage = new();
                userMessage.MessageText = finalText;
                userMessage.Sender = "E";
                userMessage.DispatchTime = DateTime.UtcNow;

                int messageId = dataService.SaveMessage(userMessage);

                var selectedDialog = (MyDialog)DialogsList.SelectedItem;
                if (selectedDialog != null)
                {
                    selectedDialog.MessagesIds.Add(messageId);
                    dataService.SaveDialog(selectedDialog);
                }
                ChatPanel.ScrollControlIntoView(messageControl);
                TextToSend.Text = "";
            }
        }
        private void DialogsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            JobSeeker replaceJobSeeker = dataService.GetJobSeeker(((MyDialog)DialogsList.SelectedItem).JobSeekerId);
            if (currJobSeeker != replaceJobSeeker)
            {
                currJobSeeker = replaceJobSeeker;
            
                ChatPanel.Controls.Clear();
                LoadValues();
            }
        }
    }
}
