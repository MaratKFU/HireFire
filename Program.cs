using Microsoft.Extensions.DependencyInjection;
using HireFire.Classes.DataBase;

namespace HireFire
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new MainWindow());
            
        }
    }
}