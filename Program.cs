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
            /*DataBase BAZA = new DataBase("Server=localhost;Port=5432;Database=HireFire; User Id = postgres; Password=277353;");
            BAZA.SqlConnectionReader();*/
            Application.Run(new MainWindow());
            
        }
    }
}