using Ziare.Models.Base;

namespace Ziare.Models
{
    public class Articol : BaseEntity
    {
        public string Titlu { get; set; }
        public string? Autor { get; set; }
        public string Text { get; set; }
    }
}
