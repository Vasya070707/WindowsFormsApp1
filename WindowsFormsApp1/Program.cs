using System;
using System;
using System.Windows.Forms;

namespace ТекстовыйРедактор
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            Console.WriteLine("RADMI DSA");
        }
    }
}