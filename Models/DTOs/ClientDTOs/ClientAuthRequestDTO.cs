using System.ComponentModel.DataAnnotations;

namespace Ziare.Models.DTOs.ClientDTOs
{
    public class ClientAuthRequestDTO
    {
        [Required]
        public string Email { get; set; } = null!;
        [Required]
        public string Password { get; set; } = null!;
    }
}
