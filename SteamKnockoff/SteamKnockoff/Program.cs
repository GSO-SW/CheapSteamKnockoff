using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteamKnockoff
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
            //Die Spielliste wird gespeichert falls die Form geschlossen wird
            Library ILibrary = new Library();
            ILibrary.XmlSpeichern(ILibrary.DefaultXmlPath);
        }
    }
}
