namespace Ziare.Models
{
    public class ZiarBibliotecaRelation
    {
        public Guid ZiarId { get; set; }
        public Ziar Ziar { get; set; } = default!; 
        public Guid BibliotecaId { get; set; }
        public Biblioteca Biblioteca { get; set; } = default!;
    }
}
