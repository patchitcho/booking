using System.ComponentModel.DataAnnotations;

namespace ForceT.Shared
{
    public class LoginModel
    {
        [Required(ErrorMessage ="Vous devez saisir votre nom d'utilisateur")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Vous devez saisir votre mot de passe")]
        public string Password { get; set; }
    }
}
