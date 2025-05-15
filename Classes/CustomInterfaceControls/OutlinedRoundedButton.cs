using System.ComponentModel;
namespace HireFire.Classes.CustomInterfaceControls;
public struct Coordinates(float X, float Y)
{
    public float X;
    public float Y;
    public override string ToString()
    {
        return $"{X};{Y}";
    }
}

public class OutlinedRoundedButton: RoundedRectangleWithOutline
{
    protected Coordinates textOffset = new Coordinates(20, 20);
    [Description("Отступ текста (X)")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public float X
    {
        get => textOffset.X;
        set { textOffset.X = value; Refresh(); }
    }
    [Description("Отступ текста (Y)")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public float Y
    {
        get => textOffset.Y;
        set { textOffset.Y = value; Refresh(); }
    }

    private Color outlineColorActive = Color.FromArgb(242, 81, 28);
    [Description("Цвет контура кнопки в неактивном состоянии")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public Color OutlineColorActive
    {
        get => outlineColorActive;
        set { outlineColorActive = value; Refresh(); }
    }

    private Color outlineColorPassive = Color.FromArgb(229, 229, 229);
    [Description("Цвет контура кнопки в неактивном состоянии")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public Color OutlineColorPassive
    {
        get => outlineColorPassive;
        set { outlineColorPassive = value; Refresh(); }
    }

    private bool mousePressed = false;
    [DefaultValue(false)]
    [Description("Вкл/Выкл выбор кнопки по умолчанию")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public bool MousePressed
    {
        get => mousePressed;
        set {mousePressed = value; Refresh();}
    }

    public OutlinedRoundedButton()
    {
        BackColor = Color.FromArgb(255, 255, 255);
        ForeColor = Color.White;
        textOffset.X = 20;
        textOffset.Y = 20;
    }
    protected override void OnPaint(PaintEventArgs e)
    {
        if (mousePressed)
            outlineColor = outlineColorActive;
        else
            outlineColor = outlineColorPassive;

        base.OnPaint(e);
        
        graph.DrawString(Text, Font, new SolidBrush(ForeColor), rect.X + textOffset.X, rect.Y + textOffset.Y);

        graph.SetClip(rectPath);

    }
    protected override void OnMouseDown(MouseEventArgs e) {base.OnMouseDown(e); mousePressed = true; Invalidate();}
    public void AnotherBtnClicked() {mousePressed = false; Invalidate();}
}
