using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ForceT.Shared.Models
{
    public class Typeproduit
    {
        [Key]
        public int TypeproduitId { get; set; }
        public string Libellé { get; set; }
    }
}
