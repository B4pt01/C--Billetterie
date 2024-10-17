namespace TpBilletterie.Classes
{
    public class Billet
    {
        public int NumeroDePlace { get; set; }
        public Client ClientAssocie { get; set; }
        public Evenement EvenementAssocie { get; set; }
        public string TypeDePlace { get; set; }

        public Billet(int numeroDePlace, Client client, Evenement evenement, string typeDePlace)
        {
            NumeroDePlace = numeroDePlace;
            ClientAssocie = client;
            EvenementAssocie = evenement;
            TypeDePlace = typeDePlace;
        }

        public override string ToString()
        {
            return $"Billet n°{NumeroDePlace}, {TypeDePlace}, Client : {ClientAssocie.Prenom} {ClientAssocie.Nom}, Evenement : {EvenementAssocie.Nom}";
        }
    }
}
