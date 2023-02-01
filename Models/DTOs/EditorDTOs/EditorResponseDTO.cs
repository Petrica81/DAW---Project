using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ziare.Models;

namespace Ziare.Models.DTOs.EditorDTOs
{
    public class EditorResponseDTO
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Editura { get; set; }
    }
}
