using System;
using System.Windows.Forms;

namespace V6_SQL_Tool
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
#if DEBUG
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
#endif
        }
    }
}
