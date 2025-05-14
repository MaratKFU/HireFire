using System.Text;

public static class ControlExtensions
{
    public static void AddPlaceholder(this TextBox tb, string placeholderText, bool IsPassword = false)
    {
        tb.ForeColor = Color.FromArgb(161, 148, 148);

        tb.Text = placeholderText;

        tb.Enter += (s, e) =>
        {
            if (tb.Text == placeholderText && tb.ForeColor == Color.FromArgb(161, 148, 148))
            {
                tb.Text = string.Empty;
                tb.ForeColor = Color.Black;
                if (IsPassword)
                {
                    tb.PasswordChar = '•';
                }
            }
        };
        tb.Leave += (s, e) =>
        {
            if (tb.Text == "")
            {
                tb.ForeColor = Color.FromArgb(161, 148, 148);
                tb.Text = placeholderText;
                if (IsPassword)
                {
                    tb.PasswordChar = '\0';
                }
            }
        };
    }

    public static string WrapText(this string text, Font font, int maxWidth)
    {
        if (string.IsNullOrEmpty(text)) return text;

        var words = text.Split(' ');
        var result = new StringBuilder();
        var currentLine = new StringBuilder();

        using (var graphics = Graphics.FromHwnd(IntPtr.Zero))
        {
            foreach (var word in words)
            {
                var testLine = currentLine.Length > 0
                    ? currentLine + " " + word
                    : word;

                var size = graphics.MeasureString(testLine, font);

                if (size.Width > maxWidth)
                {
                    result.AppendLine(currentLine.ToString());
                    currentLine.Clear();
                    currentLine.Append(word);
                }
                else
                {
                    currentLine.Append(currentLine.Length > 0 ? " " + word : word);
                }
            }
            result.Append(currentLine);
        }
        return result.ToString();
    }
    public static void SetWrappedText(this Label label, string text)
    {
        var maxWidth = label.Width - 5;
        label.Text = text.WrapText(label.Font, maxWidth);
    }
}