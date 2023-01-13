using Ziare.Models.Base;

namespace Ziare.Models
{
    public class Biblioteca : BaseEntity
    {
        public string Denumire { get; set; }
        public ICollection<ZiarBibliotecaRelation> ZiarBibliotecaRelations { get; set; }
        public Client Client { get; set; }
    }
}
