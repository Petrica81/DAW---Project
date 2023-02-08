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
        public string Email { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Editura { get; set; }

        public EditorResponseDTO(Editor editor)
        {
            Email = editor.Email;
            Nume = editor.Nume;
            Prenume = editor.Prenume;
            Editura = editor.Editura;
        }
    }
}
