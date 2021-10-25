using System.ComponentModel.DataAnnotations;

namespace Proxima.Shared.Models
{
    public class Familleproduit
    {
        [Key]
        public int FamilleproduitId { get; set; }
        public string Libellé { get; set; }
    }
}
