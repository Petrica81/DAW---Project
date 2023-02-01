using System.ComponentModel.DataAnnotations;

namespace Ziare.Models.DTOs.ClientDTOs
{
    public class ClientRequestDTO
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
    }
}
