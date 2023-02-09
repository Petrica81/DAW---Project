using Ziare.Models.Base;

namespace Ziare.Models
{
    public class Ziar : BaseEntity
    {
        public string Titlu { get; set; } = "";
        public string Editura { get; set; } = "";
        public string Domeniu { get; set; } = "";
        public int Pret { get; set; } = 0;
        public List<Articol> Articole { get; set; } = new List<Articol>();
        public List<ZiarBibliotecaRelation> ZiarBibliotecaRelations { get; set; } = new List<ZiarBibliotecaRelation>();
    }
}
