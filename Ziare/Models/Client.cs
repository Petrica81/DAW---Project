using Ziare.Models.Base;

namespace Ziare.Models
{
    public class Client : BaseEntity
    {
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Email { get; set; }
        public int Varsta { get; set; }
        public int Balance { get; set; }
    }
}
