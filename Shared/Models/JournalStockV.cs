using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Proxima.Shared.Models
{
    public class JournalStockV
    {
        [Key]
        public int JournalStockVId { get; set; }
        public int ProduitId { get; set; }
        public DateTime Date { get; set; }
        public int Qte { get; set; }
        public string Motif { get; set; }
    }
}
