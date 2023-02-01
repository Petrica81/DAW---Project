namespace Ziare.Models.DTOs.ZiarDTOs
{
    public class ZiarResultsDTO
    {
        public Guid Id { get; set; }
        public string Titlu { get; set; }
        public string Editura { get; set; }
        public string Domeniu { get; set; }
        public int Pret { get; set; }

        public ZiarResultsDTO(Ziar ziar)
        {
            Id = ziar.Id;
            Titlu = ziar.Titlu;
            Editura = ziar.Editura;
            Domeniu = ziar.Domeniu;
            Pret = ziar.Pret;
        }
    }
}
