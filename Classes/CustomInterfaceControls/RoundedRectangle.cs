using System.ComponentModel;
using System.Drawing.Drawing2D;


namespace HireFire.Classes.CustomInterfaceControls;
public class RoundedRectangle : Control
{
    protected Graphics graph;
    protected Rectangle rect;
    protected GraphicsPath rectPath;


    protected Color cornerColor = Color.FromArgb(229, 229, 229);
    [Description("Цвет заднего фона")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public Color CornerColor
    {
        get => cornerColor;
        set {cornerColor = value; Refresh();}
    }

    protected int rounding = 1;
    [DisplayName("Rounding")]
    [Description("Указывает радиус закругления объекта")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public int Rounding
    {
        get => rounding;
        set
        {
            if (value > 0)
                rounding = value;
            else
                rounding = 1;
            Refresh();
        }
    }

    public RoundedRectangle()
    {
        SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint, true);
        DoubleBuffered = true;
        Size = new Size(236, 63);
        BackColor = Color.FromArgb(242, 85, 26);
        ForeColor = Color.White;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        rect = new Rectangle(0, 0, Width - 1, Height - 1);
        rectPath = Drawer.RoundedRectangle(rect, rounding);

        graph = e.Graphics;
        graph.SmoothingMode = SmoothingMode.HighQuality;
        graph.Clear(cornerColor);

        graph.DrawPath(new Pen(BackColor), rectPath);
        graph.FillPath(new SolidBrush(BackColor), rectPath);
        
        graph.SetClip(rectPath);
    }
}