using System;
using System.Windows.Forms;

namespace Symulator_Intel_8086
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Forms());
        }
    }
}
