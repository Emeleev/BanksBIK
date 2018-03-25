using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SpkBIK
{
    public static class UpdateDelegate //обновление данных в таблице с документами
    {
        public delegate void MyEvent();
        public static MyEvent EventHandler;
    }

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
            Application.Run(new Form1());
        }
    }
}
