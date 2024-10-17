using System;
using System.Collections.Generic;

namespace TpBilletterie.Classes
{
    public class Evenement
    {
        public string Nom { get; set; }
        public Lieu LieuEvenement { get; set; }
        public DateTime Date { get; set; }
        public int NombreDePlaces { get; set; }
        public List<Billet> Billets { get; set; }

        public Evenement(string nom, Lieu lieu, DateTime date, int nombreDePlaces)
        {
            Nom = nom;
            LieuEvenement = lieu;
            Date = date;
            NombreDePlaces = nombreDePlaces;
            Billets = new List<Billet>();

        }

        public int PlacesDisponibles()
        {
            return NombreDePlaces - Billets.Count;
        }

        public override string ToString()
        {
            return $"{Nom} a {LieuEvenement}, le {Date.ToShortDateString()}, Places disponibles : {PlacesDisponibles()}";
        }
    }
}
