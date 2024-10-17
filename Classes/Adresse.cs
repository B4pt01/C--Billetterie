namespace TpBilletterie.Classes
{
    public class Adresse
    {
        public string Rue { get; set; }
        public string Ville { get; set; }

        public Adresse(string rue, string ville)
        {
            Rue = rue;
            Ville = ville;
        }

        public override string ToString()
        {
            return $"{Rue}, {Ville}";
        }
    }
}
