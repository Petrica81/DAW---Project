namespace Ziare.Models.DTOs.ArticolDTOs
{
    public class ArticolResponseDTO
    {
        public Guid Id { get; set; }
        public string Titlu { get; set; }
        public string Autor { get; set; }
        public string Text { get; set; }

        public ArticolResponseDTO(Articol articol)
        {
            Id = articol.Id;
            Titlu = articol.Titlu;
            Autor = articol.Autor;
            Text = articol.Text;
        }
    }
}
