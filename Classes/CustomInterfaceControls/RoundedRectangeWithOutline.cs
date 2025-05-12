using System.ComponentModel;
using System.Drawing.Drawing2D;


namespace HireFire.Classes.CustomInterfaceControls;
public class RoundedRectangleWithOutline : RoundedRectangle
{
    protected int outlineWidth = 3;
    [Description("Толщина контура")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public int OutlineWidth
    {
        get => outlineWidth;
        set { outlineWidth = value; Refresh(); }
    }

    protected Color outlineColor = Color.FromArgb(229, 229, 229);
    [Description("Цвет контура")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public Color OutlineColor
    {
        get => outlineColor;
        set { outlineColor = value; Refresh(); }
    }

    public RoundedRectangleWithOutline()
    {
        SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint, true);
        DoubleBuffered = true;
        Size = new Size(100, 30);
        BackColor = Color.FromArgb(242, 85, 26);
        ForeColor = Color.White;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        rect = new Rectangle(outlineWidth, outlineWidth, Width - 2 * outlineWidth - 1, Height - 2 * outlineWidth - 1);
        rectPath = Drawer.RoundedRectangle(rect, rounding);

        graph = e.Graphics;
        graph.SmoothingMode = SmoothingMode.HighQuality;
        graph.Clear(cornerColor);

        graph.DrawPath(new Pen(BackColor), rectPath);
        graph.FillPath(new SolidBrush(BackColor), rectPath);
        graph.DrawPath(new Pen(outlineColor, outlineWidth), rectPath);

        graph.SetClip(rectPath);
    }
}