using Ziare.Models.Base;

namespace Ziare.Models
{
    public class Biblioteca : BaseEntity
    {
        public string Denumire { get; set; } = default!;
        public List<ZiarBibliotecaRelation> ZiarBibliotecaRelations { get; set; } = new List<ZiarBibliotecaRelation>();
        public Client Client { get; set; } = new Client();
    }
}
