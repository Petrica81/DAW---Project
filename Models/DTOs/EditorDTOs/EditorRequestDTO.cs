using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ziare.Models.DTOs.EditorDTOs
{
    public class EditorRequestDTO
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        [Required]
        public string Editura { get; set; }
    }
}
