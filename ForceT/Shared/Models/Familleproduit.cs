using System.ComponentModel.DataAnnotations;

namespace ForceT.Shared.Models
{
    public class Familleproduit
    {
        [Key]
        public int FamilleproduitId { get; set; }
        public string Libellé { get; set; }
    }
}
