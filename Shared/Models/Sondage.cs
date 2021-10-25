using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Proxima.Shared.Models
{
    public class Sondage
    {
        [Key]
        public int SondageId { get; set; }
        [Required(ErrorMessage ="Vous devez saisir le nom du sondage")]
        public string Libellé { get; set; }
        [Required(ErrorMessage = "Vous devez saisir la question")]
        public string Question { get; set; }
        [Required(ErrorMessage = "Vous devez specifier le type")]
        public string Type { get; set; }
        [Required(ErrorMessage = "Vous devez saisir le status")]
        public string Statut { get; set; }
        public bool Obligatoire { get; set; }

    }
}
