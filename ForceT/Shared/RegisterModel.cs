using System.ComponentModel.DataAnnotations;

namespace ForceT.Shared
{
    public class RegisterModel
    {
        [Required(ErrorMessage ="Vous devez saisir le nom d'utilisateur")]
        public string UserName { get; set; }

        [Required(ErrorMessage ="Vous devez saisir le mot de passe")]
        [StringLength(100, ErrorMessage = "Le {0} doit au minimum {2} et au maximum {1} charactere longue.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Le mot de passe et la confirmation ne se ressemble pas.")]
        public string ConfirmPassword { get; set; }
        //[Required(ErrorMessage ="Vous devez choisir des roles")]
        public RoleModel Roles { get; set; }
    }
}
