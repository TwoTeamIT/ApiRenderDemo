using System.ComponentModel.DataAnnotations;

namespace ApiRenderDemo.Models
{
    public class UserModel
    {
        [Required(ErrorMessage = "Id is required")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Nome is required")]
        public string Nome { get; set; } = string.Empty;
        [Required(ErrorMessage = "Cognome is required")]
        public string Cognome { get; set; } = string.Empty;
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;
        [Required(ErrorMessage = "Abilitato is required")]
        public bool Abilitato { get; set; }
    }
}
