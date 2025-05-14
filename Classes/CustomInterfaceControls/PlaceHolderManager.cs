namespace HireFire.Classes.CustomInterfaceControls
{
    public static class PlaceholderManager
    {
        /*public static void AddPlaceholder(this TextBox tb, string placeholderText, bool IsPassword = false)
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

        }*/
        /*public static void AddPlaceholder(this ComboBox cb, string placeholderText)
        {
            cb.ForeColor = Color.FromArgb(161, 148, 148);

            cb.Text = placeholderText;

            cb.Enter += (s, e) =>
            {
                if (cb.Text == placeholderText && cb.ForeColor == Color.FromArgb(161, 148, 148))
                {
                    cb.Text = string.Empty;
                    cb.ForeColor = Color.Black;
                }
            };
            cb.Leave += (s, e) =>
            {
                if (cb.Text == "")
                {
                    cb.ForeColor = Color.FromArgb(161, 148, 148);
                    cb.Text = placeholderText;
                }
            };

        }*/
    }
}
