using System;
namespace GestionPharmacie;

class Program
{
    static Pharmacie pharmacie;
    private static Client client;

    static void Main(string[] args)
    {
        pharmacie = new Pharmacie();

        bool quitter = false;

        while (!quitter)
        {
            AfficherMenu();
            Console.WriteLine("Veuillez saisir votre choix : ");
            string choix = Console.ReadLine();

            switch (choix)
            {
                case "1":
                    AjouterProduit();
                    break;
                case "2":
                    AfficherStock();
                    break;
                case "3":
                    AjouterVente();
                    break;
                case "4":
                    AfficherVentesClient();
                    break;
                case "5":
                    AjouterClient();
                    break;
                case "6":
                    AjouterEmploye();
                    break;
                case "7":
                    quitter = true;
                    break;
                default:
                    Console.WriteLine("Choix invalide. Veuillez réessayer.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void AfficherMenu()
    {
        Console.WriteLine("---------- Gestion de Pharmacie ----------");
        Console.WriteLine("1. Ajouter un produit");
        Console.WriteLine("2. Afficher le stock");
        Console.WriteLine("3. Ajouter une vente");
        Console.WriteLine("4. Afficher les ventes d'un client");
        Console.WriteLine("5. Ajouter un client");
        Console.WriteLine("6. Ajouter un employé");
        Console.WriteLine("7. Quitter");
        Console.WriteLine("-------------------------------------------");
    }

    static void AjouterProduit()
    {
        Console.WriteLine("Ajouter un produit");
        Console.WriteLine("Saisissez les informations du produit :");

        Console.Write("Nom : ");
        string nom = Console.ReadLine();

        Console.Write("Prix : ");
        decimal prix = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Quantité disponible : ");
        int quantite = Convert.ToInt32(Console.ReadLine());

        Console.Write("Date d'expiration (YYYY-MM-DD) : ");
        DateTime dateExpiration = Convert.ToDateTime(Console.ReadLine());

        Produit produit = new Produit
        {
            Nom = nom,
            Prix = prix,
            QuantiteDisponible = quantite,
            DateExpiration = dateExpiration
        };

        pharmacie.AjouterProduit(produit);
        Console.WriteLine("Produit ajouté avec succès !");
    }

    static void AfficherStock()
    {
        Console.WriteLine("Afficher le stock");

        var stock = pharmacie.AfficherStock();

        Console.WriteLine("----- Stock -----");
        foreach (var produit in stock)
        {
            Console.WriteLine($"ID: {produit.Id}, Nom: {produit.Nom}, Prix: {produit.Prix}, Quantité Disponible: {produit.QuantiteDisponible}, Date d'expiration: {produit.DateExpiration.ToShortDateString()}");
        }
        Console.WriteLine("-----------------");
    }

    static void AjouterVente()
    {
        Console.WriteLine("Ajouter une vente");
        Console.WriteLine("Saisissez les informations de la vente :");

        Console.Write("ID du client : ");
        int clientId = Convert.ToInt32(Console.ReadLine());

        Console.Write("Date de la vente (YYYY-MM-DD) : ");
        DateTime dateVente = Convert.ToDateTime(Console.ReadLine());

        Console.Write("Montant total : ");
        decimal montantTotal = Convert.ToDecimal(Console.ReadLine());



        VenteProduit vente = new VenteProduit
        {
            Date = dateVente,
            MontantTotal = montantTotal,
            Client = client
        };

        pharmacie.AjouterVente(vente);
        Console.WriteLine("Vente ajoutée avec succès !");
    }

    static void AfficherVentesClient()
    {
        Console.WriteLine("Afficher les ventes d'un client");
        Console.Write("ID du client : ");
        int clientId = Convert.ToInt32(Console.ReadLine());

        

        var ventesClient = pharmacie.AfficherVentesClient(client);

        Console.WriteLine($"----- Ventes du client {client.Nom} -----");
        foreach (var vente in ventesClient)
        {
            Console.WriteLine($"ID: {vente.Id}, Date: {vente.Date.ToShortDateString()}, Montant Total: {vente.MontantTotal}");
        }
        Console.WriteLine("-----------------------------------------");
    }

    static void AjouterClient()
    {
        Console.WriteLine("Ajouter un client");
        Console.WriteLine("Saisissez les informations du client :");

        Console.Write("Nom : ");
        string nom = Console.ReadLine();

        Console.Write("Adresse : ");
        string adresse = Console.ReadLine();

        Console.Write("Numéro de téléphone : ");
        string numeroTelephone = Console.ReadLine();

        Client client = new Client
        {
            Nom = nom,
            Adresse = adresse,
            NumeroTelephone = numeroTelephone
        };

        pharmacie.AjouterClient(client);
        Console.WriteLine("Client ajouté avec succès !");
    }

    static void AjouterEmploye()
    {
        Console.WriteLine("Ajouter un employé");
        Console.WriteLine("Saisissez les informations de l'employé :");

        Console.Write("Nom : ");
        string nom = Console.ReadLine();

        Console.Write("Poste : ");
        string poste = Console.ReadLine();

        Console.Write("Salaire : ");
        decimal salaire = Convert.ToDecimal(Console.ReadLine());

        Employe employe = new Employe
        {
            Nom = nom,
            Poste = poste,
            Salaire = salaire
        };

        pharmacie.AjouterEmploye(employe);
        Console.WriteLine("Employé ajouté avec succès !");
    }
 }

