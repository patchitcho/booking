using System;
using System.ComponentModel.DataAnnotations;

namespace ForceT.Shared.Models
{
    public class JournalStock
    {
        [Key]
        public int JournalStockId { get; set; }
        public Produit produit { get; set; }
        public DateTime Date { get; set; }
        public int Qte { get; set; }
        public string Motif { get; set; }
    }
}
