using System.Drawing.Drawing2D;


namespace HireFire.Classes.CustomInterfaceControls
{
    static class Drawer
    {
        public static GraphicsPath RoundedRectangle(Rectangle rect, int RoundSize)
        {
            GraphicsPath gp = new GraphicsPath();

            gp.AddRoundedRectangle(rect, new Size(RoundSize, RoundSize));

            return gp;
        }
    }
}