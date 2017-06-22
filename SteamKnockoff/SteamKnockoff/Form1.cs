using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteamKnockoff
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Library ILibrary = new Library();
            ILibrary.SpielHinzufügen("Dead Island", "19.06.2017 10:30", "NA", @"C:\Games\Dead Island Definitive Edition\DeadIslandGame.exe", "Horror, RPG", "THQ", 6);
            ILibrary.SpieleListe.Clear();
        }
    }
}
