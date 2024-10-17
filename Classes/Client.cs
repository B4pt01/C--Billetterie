using System.Collections.Generic;

namespace TpBilletterie.Classes
{
    public class Client
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public Adresse AdresseClient { get; set; }
        public int Age { get; set; }
        public string NumeroTelephone { get; set; }
        public List<Billet> Billets { get; set; }

        public Client(string nom, string prenom, Adresse adresse, int age, string numeroTelephone)
        {
            Nom = nom;
            Prenom = prenom;
            AdresseClient = adresse;
            Age = age;
            NumeroTelephone = numeroTelephone;
            Billets = new List<Billet>();
        }

        public override string ToString()
        {
            return $"{Prenom} {Nom}, {Age} ans, Telephone: {NumeroTelephone}, Adresse: {AdresseClient}";
        }
    }
}
