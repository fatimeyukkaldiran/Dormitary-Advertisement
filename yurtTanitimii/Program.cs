using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yurtTanitimii
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            Yurt yt = new Devlet(new Kiz());
            yt.cinsiyetSecim();
            Console.WriteLine();
            Yurt yt2 = new Ozel(new Erkek());
            yt2.cinsiyetSecim();
            Console.ReadLine();
        
        }
    }
}
