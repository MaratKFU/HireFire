/*public static class ControlExtensions
{
    /// <summary>
    /// Обрабатывает клики мыши вне указанного контрола.
    /// </summary>
    /// <param name="control">Контрол, для которого отслеживаются клики снаружи.</param>
    /// <param name="onClickOutside">Действие при клике вне контрола.</param>
    public static void HandleClickOutside(this Control control, Action onClickOutside)
    {
        if (control.Parent == null)
            throw new InvalidOperationException("Контрол должен быть добавлен в родительский контейнер (например, Form).");

        // Подписываемся на клик по родительской форме/контейнеру
        control.Parent.Click += (sender, e) =>
        {
            Point clickPos = control.Parent.PointToClient(Control.MousePosition);

            if (!control.Bounds.Contains(clickPos))
            {
                onClickOutside.Invoke();
            }
        };
    }
}*/