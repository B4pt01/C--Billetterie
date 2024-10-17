namespace TpBilletterie.Classes
{
    public class Lieu : Adresse
    {
        public int Capacite { get; set; }

        public Lieu(string rue, string ville, int capacite) : base(rue, ville)
        {
            Capacite = capacite;
        }

        public override string ToString()
        {
            return $"{base.ToString()} (Capacite: {Capacite})";
        }
    }
}
