using System.Text.Json.Serialization;
using Ziare.Models.Base;
using Ziare.Models.Enums;

namespace Ziare.Models
{
    public class Editor : BaseEntity
    {
        public string Nume { get; set; } = default!;
        public string Prenume { get; set; } = default!;
        public string Editura { get; set; } = default!;
        public string Email { get; set; } = default!;
        public int Varsta { get; set; } = default!;
    }
}
