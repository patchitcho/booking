using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ForceT.Shared.Models
{
    public class Zone
    {
        [Key]
        public int zoneId { get; set; }
        [Required(ErrorMessage ="Vous devez saisir la zone")]
        public string zone { get; set; }
        [Required(ErrorMessage = "Vous devez saisir la ville")]
        public string ville { get; set; }
        
        [Display(Name ="Code postale")]
        [Range(typeof(int), "1000", "48999", ErrorMessage = "Vous devez saisir une valeur entre 1000 et 48999")]
        public int codepostal { get; set; }
    }
}
