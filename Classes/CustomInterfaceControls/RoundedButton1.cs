namespace HireFire.Classes.CustomInterfaceControls;
class RoundedButton1: RoundedRectangle
{
    private StringFormat SF = new StringFormat();
    private bool MouseEntered = false;
    private bool MousePressed = false;
    
    public RoundedButton1()
    {
        SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint, true);
        DoubleBuffered = true;

        Size = new Size(100, 30);
        BackColor = Color.FromArgb(242, 85, 26);
        ForeColor = Color.White;
        
        SF.Alignment = StringAlignment.Center;
        SF.LineAlignment = StringAlignment.Center;

    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        
        if (MouseEntered)
        {
            graph.DrawRectangle(new Pen(Color.FromArgb(60, Color.White)), rect);
            graph.FillRectangle(new SolidBrush(Color.FromArgb(60, Color.White)), rect);
            graph.SetClip(rectPath);
        }

        if (MousePressed)
        {
            graph.DrawRectangle(new Pen(Color.FromArgb(40, Color.Black)), rect);
            graph.FillRectangle(new SolidBrush(Color.FromArgb(40, Color.Black)), rect);
            graph.SetClip(rectPath);
        }
        graph.DrawString(Text, Font, new SolidBrush(ForeColor), rect, SF);

        graph.SetClip(rectPath);
    }
    protected override void OnMouseEnter(EventArgs e)
    {
        base.OnMouseEnter(e);

        MouseEntered = true;

        Invalidate();
    }
    protected override void OnMouseLeave(EventArgs e)
    {
        base.OnMouseLeave(e);

        MouseEntered = false;

        Invalidate();
    }
    protected override void OnMouseDown(MouseEventArgs e)
    {
        base.OnMouseDown(e);

        MousePressed = true;

        Invalidate();
    }
    protected override void OnMouseUp(MouseEventArgs e)
    {
        base.OnMouseUp(e);

        MousePressed = false;

        Invalidate();
    }
}
