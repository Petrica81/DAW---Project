using System.Text.Json.Serialization;
using Ziare.Models.Base;
using Ziare.Models.Enums;

namespace Ziare.Models
{
    public class Client : BaseEntity
    {
        public string Nume { get; set; } = default!;
        public string Prenume { get; set; } = default!;
        public string Email { get; set; } = default!;
        public int Varsta { get; set; } = default!;
        public int Bani { get; set; } = default!;
        public Biblioteca? Biblioteca { get; set; } = new Biblioteca();
        public Guid? BibliotecaId { get; set; } = Guid.NewGuid();

        [JsonIgnore]
        public string PasswordHash { get; set; } = default!;
        public Roles Role { get; set; } = default!;
    }
}
