using System.ComponentModel.DataAnnotations;

namespace Proxima.Shared.Models
{
    public class StockInterne
    {
        [Key]
        public int StockId { get; set; }
        public Produit produit { get; set; }
        public int Quantite { get; set; }
    }
}
