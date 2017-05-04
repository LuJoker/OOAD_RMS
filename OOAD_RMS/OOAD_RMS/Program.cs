using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OOAD_RMS
{
    static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Model model = new Model();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login(model));
        }
    }
}
