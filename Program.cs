// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using TpBilletterie.Classes;
using TpBilletterie.Exceptions;

class Program
{
    static List<Client> clients = new List<Client>();
    static List<Evenement> evenements = new List<Evenement>();

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("1. Creer un client");
            Console.WriteLine("2. Creer un evenement");
            Console.WriteLine("3. Reserver un billet");
            Console.WriteLine("4. Afficher la liste des billets pour un evenement");
            Console.WriteLine("5. Afficher les evenements");
            Console.WriteLine("6. Quitter");

            string choix = Console.ReadLine();

            try
            {
                switch (choix)
                {
                    case "1":
                        CreerClient();
                        break;
                    case "2":
                        CreerEvenement();
                        break;
                    case "3":
                        ReserverBillet();
                        break;
                    case "4":
                        AfficherBilletsPourEvenement();
                        break;
                    case "5":
                        AfficherEvenements();
                        break;
                    case "6":
                        return;
                    default:
                        Console.WriteLine("Choix invalide.");
                        break;
                }
            }
            catch (NotFoundException ex)
            {
                Console.WriteLine($"Erreur: {ex.Message}");
            }
        }
    }

    static void CreerClient()
    {
        Console.WriteLine("Nom du client :");
        string nom = Console.ReadLine();
        Console.WriteLine("Prenom du client :");
        string prenom = Console.ReadLine();
        Console.WriteLine("Rue :");
        string rue = Console.ReadLine();
        Console.WriteLine("Ville :");
        string ville = Console.ReadLine();
        Console.WriteLine("age :");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine("Numero de telephone :");
        string numeroTelephone = Console.ReadLine();

        Adresse adresse = new Adresse(rue, ville);
        Client client = new Client(nom, prenom, adresse, age, numeroTelephone);
        clients.Add(client);

        Console.WriteLine($"Client {prenom} {nom} cree avec succes !");
    }

    static void CreerEvenement()
    {
        Console.WriteLine("Nom de l'evenement :");
        string nom = Console.ReadLine();
        Console.WriteLine("Rue du lieu :");
        string rue = Console.ReadLine();
        Console.WriteLine("Ville du lieu :");
        string ville = Console.ReadLine();
        Console.WriteLine("Capacite :");
        int capacite = int.Parse(Console.ReadLine());
        Console.WriteLine("Date (YYYY-MM-DD) :");
        DateTime date = DateTime.Parse(Console.ReadLine());

        Lieu lieu = new Lieu(rue, ville, capacite);
        Evenement evenement = new Evenement(nom, lieu, date, capacite);
        evenements.Add(evenement);

        Console.WriteLine($"evenement {nom} cree avec succes !");
    }

    static void ReserverBillet()
    {
        Console.WriteLine("Nom de l'evenement :");
        string nomEvenement = Console.ReadLine();
        Evenement evenement = evenements.Find(e => e.Nom == nomEvenement);
        if (evenement == null)
            throw new NotFoundException("evenement non trouve.");

        if (evenement.PlacesDisponibles() <= 0)
        {
            Console.WriteLine("Plus de places disponibles.");
            return;
        }

        Console.WriteLine("Nom du client :");
        string nomClient = Console.ReadLine();
        Client client = clients.Find(c => c.Nom == nomClient);
        if (client == null)
            throw new NotFoundException("Client non trouve.");

        Console.WriteLine("Type de place (standard, gold, vip) :");
        string typeDePlace = Console.ReadLine();

        Billet billet = new Billet(evenement.Billets.Count + 1, client, evenement, typeDePlace);
        client.Billets.Add(billet);
        evenement.Billets.Add(billet);

        Console.WriteLine($"Billet reserve avec succes pour {client.Prenom} {client.Nom} a l'evenement {evenement.Nom}.");
    }

    static void AfficherBilletsPourEvenement()
    {
        Console.WriteLine("Nom de l'evenement :");
        string nomEvenement = Console.ReadLine();
        Evenement evenement = evenements.Find(e => e.Nom == nomEvenement);
        if (evenement == null)
            throw new NotFoundException("evenement non trouve.");

        Console.WriteLine($"Billets pour l'evenement {evenement.Nom} :");
        foreach (var billet in evenement.Billets)
        {
            Console.WriteLine(billet);
        }
    }
    public static void AfficherEvenements()
    {
        if (evenements.Count == 0)
            throw new NotFoundException("Aucun evenement disponible.");

        Console.WriteLine($"Liste des evenements : ");
        foreach (var evenement in evenements)
        {
            Console.WriteLine(evenement.ToString()); 
        }
    }


}

