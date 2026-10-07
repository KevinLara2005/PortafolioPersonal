using System.ComponentModel.DataAnnotations;

namespace PortafolioPersonal.Models
{
    public class ContactoViewModel
    {
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El email es obligatorio")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "El asunto es obligatorio")]
        public string Asunto { get; set; }

        [Required(ErrorMessage = "El mensaje es obligatorio")]
        public string Mensaje { get; set; }
    }
}