namespace Ziare.Models.DTOs.ZiarDTOs
{
    public class ZiarResultsDTO
    {
        public string Titlu { get; set; } = "";
        public string Editura { get; set; } = "";
        public string Domeniu { get; set; } = "";
        public int Pret { get; set; } = 0;

        public ZiarResultsDTO(Ziar ziar)
        {
            Titlu = ziar.Titlu;
            Editura = ziar.Editura;
            Domeniu = ziar.Domeniu;
            Pret = ziar.Pret;
        }
    }
}
