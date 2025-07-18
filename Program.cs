using PracticeFilesAndDB.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImportExpornInDB
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var connectForm = new AuthDb();
            if (connectForm.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new DataBaseFile());
            }
        }
    }
}
