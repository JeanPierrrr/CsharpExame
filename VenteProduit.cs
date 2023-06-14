using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace GestionPharmacie
{
    public class VenteProduit
    {
        private readonly List<Produit> produits;
        private object Produits;

        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal MontantTotal { get; set; }
        public Client Client { get; set; }

        public VenteProduit()
        {
            produits = new List<Produit>();
        }

        public void AjouterProduit(Produit produit)
        {
            //Produits.Add(produit);
            MontantTotal += produit.Prix;
        }
    }
}







