using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SteamKnockoff
{
    public class Library
    {
        public List<Spiel> SpieleListe = new List<Spiel>();

        public void SpielHinzufügen(string Titel, string Datum, string LetztesSpielDatum, string Installationspfad, string Kategorie, string Publisher, int USK)
        {
            if (Titel == null || Datum == null || LetztesSpielDatum == null || Installationspfad == null || Kategorie == null || Publisher == null || USK != 0 && USK != 6 && USK != 12 && USK != 16 && USK != 18)
            {
                throw new NullReferenceException("Eines der übergebenen Parameter an Libary.SpielHinzufügen() hat eine Exception vom Typ NullReferenceException ausgelöst.");
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

        public static void SpielSpeichern(Spiel ISpiel)
        {
            if (ISpiel == null)
            {
                throw new NullReferenceException();
            }
        }

        public void XmlSpeichern()
        {

        }
    }
}
