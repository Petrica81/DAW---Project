namespace Ziare.Models.DTOs.ArticolDTOs
{
    public class ArticolResponseDTO
    {
        public string Titlu { get; set; } = "";
        public string? Autor { get; set; } = "";
        public string Text { get; set; } = "";

        public ArticolResponseDTO(Articol articol)
        {
            Titlu = articol.Titlu;
            Autor = articol.Autor;
            Text = articol.Text;
        }
    }
}
