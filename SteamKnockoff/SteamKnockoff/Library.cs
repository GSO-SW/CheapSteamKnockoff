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

namespace SteamKnockoff
{
    public class Library
    {
        public List<Spiel> SpieleListe = new List<Spiel>();

        public string XmlPath = @"..\..\XmlSave.xml";

        public void SpielHinzufügen(string Titel, string Datum, string LetztesSpielDatum, string Installationspfad, string Kategorie, string Publisher, int USK)
        {
            //Es wird überprüft ob eines der Attribute null ist
            if (Titel == null || Datum == null || LetztesSpielDatum == null || Installationspfad == null || Kategorie == null || Publisher == null || USK != 0 && USK != 6 && USK != 12 && USK != 16 && USK != 18)
            {
                throw new NullReferenceException("Eines der übergebenen Parameter an Libary.SpielHinzufügen() hat eine Exception vom Typ NullReferenceException ausgelöst.");
            }
            //Es wird überprüft ob der Installationspfad Existiert#
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
        /// 
        /// </summary>
        /// <returns>Gibt true zurück wenn das Speichern erfolgreich war und ansonsten false.</returns>
        public bool XmlSpeichern()
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

        public void XmlLaden()
        {
            if (!File.Exists(XmlPath))
            {
                throw new FileNotFoundException("Savefile was not found. Creating new document");
                File.Create(XmlPath);
            }
        }
    }
}
