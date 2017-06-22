using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SteamKnockoff
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Library ILibrary = new Library();
            ILibrary.SpieleListe.Clear();
            File.Create(ILibrary.DefaultXmlPath).Close();
            ILibrary.SpielHinzufügen("League of Legends", "19.06.2017 10:30", "NA", @"D:\Games\Riot Games\League of Legends\lol.launcher.exe", "Horror, RPG", "THQ", 6);
            ILibrary.XmlLaden(ILibrary.DefaultXmlPath);
            listBox1.DataSource = ILibrary.SpieleListe;
            listBox1.DisplayMember = "Titel";
        }
    }
}
