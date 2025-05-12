namespace HireFire.Classes.CustomInterfaceControls;
public class RoundedTextBox_new : RoundedButton2
{
    private TextBox _textBox;
    bool mouseLeft = true;
    public TextBox InnerTextBox => _textBox;

    public RoundedTextBox_new()
    {
        _textBox = new TextBox();
        _textBox.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Bold);
        _textBox.Location = new Point(Location.X + Rounding / 2, Location.Y + Rounding / 2);
    }

    protected override void OnMouseDown(MouseEventArgs e) 
    {
        base.OnMouseDown(e);

        if (mouseLeft)
        {
            Controls.Remove(_textBox);
        }
        else
        {
            Controls.Add(_textBox);
        }

        Invalidate();
    }
    protected override void OnMouseLeave(EventArgs e)
    {
        base.OnMouseLeave(e);
        mouseLeft = true;
        Invalidate();
    }
    protected override void OnMouseEnter(EventArgs e)
    {
        base.OnMouseEnter(e);
        mouseLeft = false;
        Invalidate();
    }
    
}
