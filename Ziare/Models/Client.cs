using Ziare.Models.Base;

namespace Ziare.Models
{
    public class Client : BaseEntity
    {
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Email { get; set; }
        public int Varsta { get; set; }
        public int Bani { get; set; }
        public Biblioteca? Biblioteca { get; set; }
        public Guid? BibliotecaId { get; set; }
    }
}
