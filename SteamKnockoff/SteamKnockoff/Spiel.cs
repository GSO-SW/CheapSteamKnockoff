namespace SteamKnockoff
{
    public class Spiel
    {
        public Spiel()
        {
        }

        public string Titel { get; set; }
        public string Datum { get; set; }
        public string LetztesSpielDatum { get; set; }
        public string InstallationsPfad { get; set; }
        public string Kategorie { get; set; }
        public string Publisher { get; set; }
        public int USK { get; set; }
    }
}