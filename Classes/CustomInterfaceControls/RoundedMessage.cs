using System.ComponentModel;

namespace HireFire.Classes.CustomInterfaceControls;

public class RoundedMessage : RoundedRectangle
{
    // Текст сообщения и время
    private string messageText = "";
    private string time = DateTime.UtcNow.ToString("HH:mm");
    private bool leftOrientation = false;

    // Настройки шрифтов
    private Font messageFont = new Font("Montserrat", 9f);
    private Font timeFont = new Font("Montserrat", 7f, FontStyle.Italic);

    #region Properties

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public HorizontalAlignment MessageAlignment { get; set; }
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public Point CustomLocation { get; set; }
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public bool UseCustomPosition { get; set; }
    [Category("Appearance")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]

    public string MessageText
    {
        get => messageText;
        set { messageText = value; Refresh(); }
    }

    [Category("Appearance")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]

    public string Time
    {
        get => time;
        set { time = value; Refresh(); }
    }

    [Category("Layout")]
    [DefaultValue(false)]
    public bool LeftOrientation
    {
        get => leftOrientation;
        set { leftOrientation = value; Refresh(); }
    }

    [Category("Appearance")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public Font MessageFont
    {
        get => messageFont;
        set { messageFont = value; Refresh(); }
    }

    [Category("Appearance")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public Font TimeFont
    {
        get => timeFont;
        set { timeFont = value; Refresh(); }
    }
    #endregion

    public RoundedMessage(
        string text,
        bool isOutgoing,
        Size containerSize,
        DateTime time,
        HorizontalAlignment alignment = HorizontalAlignment.Left,
        Point? customPosition = null)
    {
        SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor |
                ControlStyles.UserPaint, true);
        DoubleBuffered = true;

        // Основные параметры
        MessageText = text;
        Time = time.ToShortTimeString();
        LeftOrientation = !isOutgoing;

        // Автоматические расчеты размеров и позиции
        CalculateSizeAndPosition(containerSize, isOutgoing);

        // Стилизация
        ApplyStyle(isOutgoing);
    }

    private void CalculateSizeAndPosition(Size containerSize, bool isOutgoing)
    {
        int maxWidth = (int)(containerSize.Width * 0.75);
        MaximumSize = new Size(maxWidth, 1000);

        new Padding(-containerSize.Width + maxWidth + 10, 5, 10, 5);
    }

    private void ApplyStyle(bool isOutgoing)
    {
        BackColor = isOutgoing ? Color.FromArgb(255,234,226): Color.FromArgb(229,229,229);
        ForeColor = Color.Black;
        CornerColor = Color.White;
        MessageFont = new Font("Segoe UI", 9f);
        TimeFont = new Font("Segoe UI", 7f, FontStyle.Italic);
        Rounding = 25;
        Padding = new Padding(10);
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        CalculateAutoSize(e.Graphics);
        base.OnPaint(e);

        StringFormat format = new StringFormat
        {
            Alignment = MessageAlignment switch
            {
                HorizontalAlignment.Left => StringAlignment.Near,
                HorizontalAlignment.Right => StringAlignment.Far,
                _ => StringAlignment.Near
            },
            LineAlignment = StringAlignment.Near
        };

        Rectangle textRect = new Rectangle(
            Padding.Left,
            Padding.Top,
            Width - Padding.Horizontal + 10,
            Height - Padding.Vertical
        );

        e.Graphics.DrawString(MessageText, MessageFont,
                            new SolidBrush(ForeColor),
                            textRect, format);

        DrawTime(e.Graphics);
    }
    private void CalculateAutoSize(Graphics g)
    {
        SizeF textSize = g.MeasureString(MessageText, MessageFont, MaximumSize.Width - Padding.Horizontal);
        SizeF timeSize = g.MeasureString(Time, TimeFont);

        int height = (int)(textSize.Height + timeSize.Height + Padding.Vertical + 15);

        Size = new Size(
            width: Math.Min((int)textSize.Width + Padding.Horizontal, MaximumSize.Width),
            height: Math.Min(height, MaximumSize.Height > 0 ? MaximumSize.Height : int.MaxValue)
        );
    }
    private void DrawTime(Graphics g)
    {
        
        SizeF timeSize = g.MeasureString(Time, TimeFont);
        PointF timeLocation = new PointF(Width - timeSize.Width - Padding.Right, Height - timeSize.Height - Padding.Bottom);

        g.DrawString(Time, TimeFont, new SolidBrush(ForeColor), timeLocation);
    }
}