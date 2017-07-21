using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace StarShop.Models
{
    [Table("Produit")]
    public class Produit
    {
        [Key]
        public int idProduit { get; set; }

        public string nomProduit { get; set; }
        public int minerai { get; set; }
        public int vespene { get; set; }
        public string description { get; set; }
        public string picture { get; set; }
    }
}