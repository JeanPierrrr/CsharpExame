using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPharmacie
{
    public class Pharmacie
    {
            private List<Produit> stock;
            private List<VenteProduit> ventes;
            private List<Client> clients;
            private List<Employe> employes;

            public Pharmacie()
            {
                stock = new List<Produit>();
                ventes = new List<VenteProduit>();
                clients = new List<Client>();
                employes = new List<Employe>();
            }

            public void AjouterProduit(Produit produit)
            {
                stock.Add(produit);
            }

            public List<Produit> AfficherStock()
            {
                return stock;
            }

            public void AjouterVente(VenteProduit vente)
            {
                ventes.Add(vente);
            }

            public List<VenteProduit> AfficherVentesClient(Client client)
            {
                List<VenteProduit> ventesClient = new List<VenteProduit>();
                foreach (var vente in ventes)
                {
                    if (vente.Client == client)
                    {
                        ventesClient.Add(vente);
                    }
                }
                return ventesClient;
            }

            public Client ChercherClient(int clientId)
            {
                foreach (var client in clients)
                {
                    if (client.Id == clientId)
                    {
                        return client;
                    }
                }
                return null;
            }

            public void AjouterClient(Client client)
            {
                clients.Add(client);
            }

            public void AjouterEmploye(Employe employe)
            {
                employes.Add(employe);
            }
        }
    }
