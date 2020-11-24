using System.ComponentModel.DataAnnotations;

namespace ForceT.Shared.Models
{
    public class Produit
    {
        [Key]
        public int ProduitId { get; set; }
        public string CodeArticle { get; set; }
        public string Designation { get; set; }
        public double Prix { get; set; }
        public int TypeproduitId { get; set; }
        public int FamilleproduitId { get; set; }
    }
}
