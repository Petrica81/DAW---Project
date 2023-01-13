using Ziare.Models.Base;

namespace Ziare.Models
{
    public class Editor : BaseEntity
    {
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Editura { get; set; }
        public string Email { get; set; }
        public int Varsta { get; set; }
        public ICollection<ZiarEditorRelation> ZiarEditorRelations { get; set; }
    }
}
