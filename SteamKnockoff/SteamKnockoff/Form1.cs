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
using System.Diagnostics;

namespace SteamKnockoff
{
    public partial class Form1 : Form
    {
        Library ILibrary = new Library();
        BindingSource bs = new BindingSource();
        public Form1()
        {
            InitializeComponent();
            ILibrary.XmlLaden(ILibrary.DefaultXmlPath);
            ILibrary.SpielHinzufügen("League of legends", "23.06.2017", "NA", @"D:\Games\Riot Games\League of Legends\lol.launcher.exe", "MOBA", "RIOT", 0);
            bs.DataSource = ILibrary.SpieleListe;
            // Bindet die Spielelist als Quelle and die listBox1
            listBox1.DataSource = bs;
            listBox1.DisplayMember = "Titel";
            ILibrary.SpieleListe.Sort((x, y) => x.Titel.CompareTo(y.Titel));
            if (listBox1.Items.Count > 0)
            {
                listBox1.SelectedIndex = 0;
            }
            bs.ResetBindings(false);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TitelBox.Clear();
            DatumBox.Clear();
            LetztesSpielDatumBox.Clear();
            InstallationspfadBox.Clear();
            KategorieBox.Clear();
            PublisherBox.Clear();
            USKBox.Clear();
            if (listBox1.SelectedIndex >= 0)
            {
                OKButton.Hide();
                StartButton.Show();
                ErstellError.Hide();
                TitelBox.Text = ILibrary.SpieleListe[listBox1.SelectedIndex].Titel;
                DatumBox.Text = ILibrary.SpieleListe[listBox1.SelectedIndex].Datum;
                LetztesSpielDatumBox.Text = ILibrary.SpieleListe[listBox1.SelectedIndex].LetztesSpielDatum;
                InstallationspfadBox.Text = ILibrary.SpieleListe[listBox1.SelectedIndex].InstallationsPfad;
                KategorieBox.Text = ILibrary.SpieleListe[listBox1.SelectedIndex].Kategorie;
                PublisherBox.Text = ILibrary.SpieleListe[listBox1.SelectedIndex].Publisher;
                USKBox.Text = Convert.ToString(ILibrary.SpieleListe[listBox1.SelectedIndex].USK);
            }
        }

        private void EntfernenButton_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1 && listBox1.SelectedIndex <= listBox1.Items.Count -1)
            {
                ILibrary.SpielLöschen(listBox1.SelectedIndex);
            }
            bs.ResetBindings(false);
            ILibrary.XmlSpeichern(ILibrary.DefaultXmlPath);
        }

        private void HinzufügenButton_Click(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = -1;
            OKButton.Show();
            TitelBox.Clear();
            DatumBox.Clear();
            LetztesSpielDatumBox.Clear();
            InstallationspfadBox.Clear();
            KategorieBox.Clear();
            PublisherBox.Clear();
            USKBox.Clear();
            StartButton.Hide();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            try
            {
                ILibrary.SpielHinzufügen(TitelBox.Text, DatumBox.Text, LetztesSpielDatumBox.Text, InstallationspfadBox.Text, KategorieBox.Text, PublisherBox.Text, Convert.ToInt32(USKBox.Text));
                bs.ResetBindings(false);
                ILibrary.XmlSpeichern(ILibrary.DefaultXmlPath);
            }
            catch (FormatException)
            {
                ErstellError.Show();
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = InstallationspfadBox.Text;
            Process.Start(start);
        }
    }
}
