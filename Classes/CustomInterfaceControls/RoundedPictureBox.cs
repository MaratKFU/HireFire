using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace HireFire;
public class RoundedPictureBox : PictureBox
{
    private int _cornerRadius = 20;
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public int CornerRadius
    {
        get => _cornerRadius;
        set
        {
            _cornerRadius = value;
            Invalidate();
        }
    }

    public RoundedPictureBox()
    {

        this.DoubleBuffered = true;
        this.SizeMode = PictureBoxSizeMode.Zoom;
        this.BackColor = Color.Transparent;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        // Не вызываем base.OnPaint()!
        if (CornerRadius == 0 || Image == null)
        {
            base.OnPaint(e);
            return;
        }

        using (var path = CreateRoundPath())
        using (var clipRegion = new Region(path))
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;

            // Устанавливаем область отсечения
            e.Graphics.SetClip(clipRegion, CombineMode.Replace);

            // Рисуем изображение
            DrawImage(e.Graphics);

            // Опционально: рисуем границу
            DrawBorder(e.Graphics, path);
        }
    }

    private GraphicsPath CreateRoundPath()
    {
        var path = new GraphicsPath();
        int diameter = CornerRadius * 2;
        var rect = ClientRectangle;

        // Корректируем радиус, если он слишком большой
        if (diameter > rect.Width) diameter = rect.Width;
        if (diameter > rect.Height) diameter = rect.Height;

        path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
        path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
        path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
        path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
        path.CloseFigure();

        return path;
    }

    private void DrawImage(Graphics g)
    {
        Rectangle destRect;
        Rectangle srcRect = new Rectangle(0, 0, Image.Width, Image.Height);

        switch (SizeMode)
        {
            case PictureBoxSizeMode.Zoom:
                float ratio = Math.Min(
                    (float)Width / Image.Width,
                    (float)Height / Image.Height
                );
                int newWidth = (int)(Image.Width * ratio);
                int newHeight = (int)(Image.Height * ratio);
                destRect = new Rectangle(
                    (Width - newWidth) / 2,
                    (Height - newHeight) / 2,
                    newWidth,
                    newHeight
                );
                break;

            default:
                destRect = ClientRectangle;
                break;
        }

        g.DrawImage(Image, destRect, srcRect, GraphicsUnit.Pixel);
    }

    private void DrawBorder(Graphics g, GraphicsPath path)
    {
        if (BorderStyle == BorderStyle.None) return;

        using (var pen = new Pen(BorderColor, BorderWidth))
        {
            g.DrawPath(pen, path);
        }
    }

    protected override void OnResize(EventArgs e)
    {
        base.OnResize(e);
        Invalidate();
    }

    // Добавляем кастомные свойства для границы
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public Color BorderColor { get; set; } = Color.White;
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public float BorderWidth { get; set; } = 0;
}