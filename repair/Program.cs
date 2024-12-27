using System;
using System.Windows.Forms;

namespace repair
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm()); // Запускаем форму авторизации
        }
    }
}



