using Ziare.Models.Base;

namespace Ziare.Models
{
    public class Ziar : BaseEntity
    {
        public string Titlu { get; set; }

        public string Editura { get; set; }
        public string Domeniu { get; set; }
        public int Pret { get; set; }
    }
}
