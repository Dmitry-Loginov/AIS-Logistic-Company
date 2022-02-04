using System;
using System.Windows.Forms;

namespace АИС
{
    static class Program
    {

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            CP.GetContext();
            AuthWindow authWindow = new AuthWindow();
            CP.AuthWindow = authWindow;
            Application.Run(CP.AuthWindow);
     
           




        }
    }
}
