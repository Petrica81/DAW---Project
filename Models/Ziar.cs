using Ziare.Models.Base;

namespace Ziare.Models
{
    public class Ziar : BaseEntity
    {
        public string Titlu { get; set; } = default!;
        public string Editura { get; set; } = default!;
        public string Domeniu { get; set; } = default!;
        public int Pret { get; set; } = default!;
        public List<Articol> Articole { get; set; } = new List<Articol>();
        public List<ZiarBibliotecaRelation> ZiarBibliotecaRelations { get; set; } = new List<ZiarBibliotecaRelation>();
    }
}
