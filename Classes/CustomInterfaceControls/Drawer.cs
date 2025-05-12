using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.IO;

namespace HireFire.Classes.CustomInterfaceControls
{
    static class Drawer
    {
        public static GraphicsPath RoundedRectangle(Rectangle rect, int RoundSize)
        {
            GraphicsPath gp = new GraphicsPath();
/*          gp.AddArc(rect.X, rect.Y, RoundSize, RoundSize, 180, 90);
            gp.AddArc(rect.X + rect.Width - RoundSize, rect.Y, RoundSize, RoundSize, 270, 90);
            gp.AddArc(rect.X + rect.Width - RoundSize, rect.Y + rect.Height - RoundSize, RoundSize, RoundSize, 0, 90);
            gp.AddArc(rect.X, rect.Y + rect.Height - RoundSize, RoundSize, RoundSize, 90, 90);
            gp.AddArc(rect.X, rect.Y, RoundSize, RoundSize, 180, 90);

            gp.AddArc(0, 0, RoundSize, RoundSize, 180, 90); // Верхний левый угол
            gp.AddArc(rect.Width - RoundSize, 0, RoundSize, RoundSize, 270, 90); // Верхний правый угол
            gp.AddArc(rect.Width - RoundSize, rect.Height - RoundSize, RoundSize, RoundSize, 0, 90); // Нижний правый угол
            gp.AddArc(0, rect.Height - RoundSize, RoundSize, RoundSize, 90, 90); // Нижний левый угол
            gp.CloseFigure();

            // Верхний левый угол
            gp.AddArc(rect.X, rect.Y, roundSize, roundSize, 180, 90);
            // Верхняя линия
            gp.AddLine(rect.X + roundSize, rect.Y, rect.X + rect.Width - roundSize, rect.Y);
            // Верхний правый угол
            gp.AddArc(rect.X + rect.Width - roundSize, rect.Y, roundSize, roundSize, 270, 90);
            // Правая линия
            gp.AddLine(rect.X + rect.Width, rect.Y + roundSize, rect.X + rect.Width, rect.Y + rect.Height - roundSize);
            // Нижний правый угол
            gp.AddArc(rect.X + rect.Width - roundSize, rect.Y + rect.Height - roundSize, roundSize, roundSize, 0, 90);
            // Нижняя линия
            gp.AddLine(rect.X + rect.Width - roundSize, rect.Y + rect.Height, rect.X + roundSize, rect.Y + rect.Height);
            // Нижний левый угол
            gp.AddArc(rect.X, rect.Y + rect.Height - roundSize, roundSize, roundSize, 90, 90);
            // Левая линия
            gp.AddLine(rect.X, rect.Y + rect.Height - roundSize, rect.X, rect.Y + roundSize);
*/
            //Лол, оказывается был готовый метод...
            gp.AddRoundedRectangle(rect, new Size(RoundSize, RoundSize));

            return gp;
        }
    }
}