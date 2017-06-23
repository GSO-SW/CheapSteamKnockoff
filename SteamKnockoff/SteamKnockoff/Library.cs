using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Xml;
using System.IO;
using System.Xml.Serialization;
using System.Xml.Linq;
using System.Windows.Forms;

namespace SteamKnockoff
{
    public class Library
    {
        public List<Spiel> SpieleListe = new List<Spiel>();

        public string DefaultXmlPath = @"..\..\XmlSave.xml";

        /// <summary>
        /// Fügt ein Spiel mit dén angegebenen Parametern in die Spieleliste hinzu.
        /// </summary>
        /// <param name="Titel"></param>
        /// <param name="Datum"></param>
        /// <param name="LetztesSpielDatum"></param>
        /// <param name="Installationspfad"></param>
        /// <param name="Kategorie"></param>
        /// <param name="Publisher"></param>
        /// <param name="USK"></param>
        public void SpielHinzufügen(string Titel, string Datum, string LetztesSpielDatum, string Installationspfad, string Kategorie, string Publisher, int USK)
         {
            //Es wird überprüft ob eines der Attribute null ist
            if (Titel == null || Datum == null || LetztesSpielDatum == null || Installationspfad == null || Kategorie == null || Publisher == null || USK != 0 && USK != 6 && USK != 12 && USK != 16 && USK != 18)
            {
                throw new NullReferenceException("Eines der übergebenen Parameter an Libary.SpielHinzufügen() hat eine Exception vom Typ NullReferenceException ausgelöst.");
            }
            //Es wird überprüft ob der Installationspfad Existiert
            if (!File.Exists(Installationspfad))
            {
                throw new FileNotFoundException();
            }
            Spiel ISpiel = new Spiel();
            ISpiel.Titel = Titel;
            ISpiel.Datum = Datum;
            ISpiel.LetztesSpielDatum = LetztesSpielDatum;
            ISpiel.InstallationsPfad = Installationspfad;
            ISpiel.Kategorie = Kategorie;
            ISpiel.Publisher = Publisher;
            ISpiel.USK = USK;
            SpieleListe.Add(ISpiel);
        }

        /// <summary>
        /// Löscht das Spiel am angegebenen Index
        /// </summary>
        /// <param name="index"></param>
        public void SpielLöschen(int index)
        {
            if (index > SpieleListe.Count - 1)
            {
                throw new IndexOutOfRangeException();
            }
            SpieleListe.RemoveAt(index);
        }

        /// <summary>
        /// Speichert die SPiele aus der SpieleListe in Xml-Format in eine XmlDokument im angegebenen Pfad.
        /// </summary>
        /// <returns>Gibt true zurück wenn das Speichern erfolgreich war und ansonsten false.</returns>
        public bool XmlSpeichern(string XmlPath)
        {
            XmlDocument doc = new XmlDocument();
            XmlNode RootNode = doc.CreateElement("Spiele");
            doc.AppendChild(RootNode);
            for (int i = 0; i < SpieleListe.Count; i++)
            {
                RootNode.AppendChild(doc.CreateElement(SpieleListe[i].Titel.Replace(" ", "_")));
                RootNode.SelectSingleNode(SpieleListe[i].Titel.Replace(" ", "_")).Attributes.Append(doc.CreateAttribute("Datum")).InnerText = SpieleListe[i].Datum;
                RootNode.SelectSingleNode(SpieleListe[i].Titel.Replace(" ", "_")).Attributes.Append(doc.CreateAttribute("LetztesSpielDatum")).InnerText = SpieleListe[i].LetztesSpielDatum;
                RootNode.SelectSingleNode(SpieleListe[i].Titel.Replace(" ", "_")).Attributes.Append(doc.CreateAttribute("InstallationsPfad")).InnerText = SpieleListe[i].InstallationsPfad;
                RootNode.SelectSingleNode(SpieleListe[i].Titel.Replace(" ", "_")).Attributes.Append(doc.CreateAttribute("Kategorie")).InnerText = SpieleListe[i].Kategorie;
                RootNode.SelectSingleNode(SpieleListe[i].Titel.Replace(" ", "_")).Attributes.Append(doc.CreateAttribute("Publisher")).InnerText = SpieleListe[i].Publisher;
                RootNode.SelectSingleNode(SpieleListe[i].Titel.Replace(" ", "_")).Attributes.Append(doc.CreateAttribute("USK")).InnerText = SpieleListe[i].USK.ToString();
            }
            try
            {
                doc.Save(XmlPath);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        /// <summary>
        /// Läd die Spiele aus einem XmlDokument im angegebenen Pfad in die Spieleliste.
        /// </summary>
        /// <returns>Gibt true zurück wenn das laden der XmlAttribute in die Instanzen der Spiele erfolgreich war.
        /// Gibt false zurück wenn das laden der Attribute fehlgeschlagen ist.</returns>
        public bool XmlLaden(string XmlPath)
        {
            int i = 0;
            //Falls das Dokument nicht existiert wird es erstellt und ein XmlKnoten angefügt.
            if (!File.Exists(XmlPath))
            {
                XmlSpeichern(XmlPath);
            }
            XmlDocument doc = new XmlDocument();
            //Löst eine XmlException aus wenn die datei vorhanden ist, es aber keine Knoten gibt.
            try
            {
                doc.Load(XmlPath);
            }
            catch (XmlException)
            {
                XmlSpeichern(XmlPath);
                doc.Load(XmlPath);
            }
            //Root Knoten in ein XmlElement laden
            XmlElement RootNode = doc.DocumentElement;
            //Für jedes XML Element aus dem Root Knoten die Schleife ausführen
            try
            {
                SpieleListe.Clear();
                foreach (XmlNode Spiel in RootNode.ChildNodes)
                {
                    Spiel ISpiel = new Spiel();
                    ISpiel.Titel = Spiel.Name;
                    ISpiel.Datum = Spiel.Attributes["Datum"].InnerText;
                    ISpiel.LetztesSpielDatum = Spiel.Attributes["LetztesSpielDatum"].InnerText;
                    ISpiel.InstallationsPfad = Spiel.Attributes["InstallationsPfad"].InnerText;
                    ISpiel.Kategorie = Spiel.Attributes["Kategorie"].InnerText;
                    ISpiel.Publisher = Spiel.Attributes["Publisher"].InnerText;
                    ISpiel.USK = Convert.ToInt32(Spiel.Attributes["USK"].InnerText);
                    SpieleListe.Add(ISpiel);
                }
                SpieleListe.Sort((x, y) => x.Titel.CompareTo(y.Titel));
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Exception" + e.Message);
                return false;
            }
        }
    }
}
