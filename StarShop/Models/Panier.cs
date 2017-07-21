using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace StarShop.Models
{
    [Table("Panier")]
    public class Panier
    {
        [Key]
        public int idPanier { get; set; }

        public int idUser { get; set; }
        public int nbrProduit { get; set; }
        public int somme { get; set; }
        public List<Produit> listProduits { get; set; }
    }
}