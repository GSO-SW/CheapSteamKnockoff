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
            ILibrary.XmlLaden(ILibrary.DefaultXmlPath);
            ILibrary.SpieleListe.Clear();
        }
    }
}
