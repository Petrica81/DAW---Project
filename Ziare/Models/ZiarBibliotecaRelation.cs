namespace Ziare.Models
{
    public class ZiarBibliotecaRelation
    {
        public Guid ZiarId { get; set; }
        public Ziar Ziar { get; set; }
        public Guid BibliotecaId { get; set; }
        public Biblioteca Biblioteca { get; set; }
    }
}
