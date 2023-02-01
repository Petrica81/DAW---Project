namespace Ziare.Models.DTOs.ClientDTOs
{
    public class ClientResponseDTO
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Token { get; set; }
        public ClientResponseDTO(Client client, string token)
        {
            Id = client.Id;
            Email = client.Email;
            Nume = client.Nume;
            Prenume = client.Prenume;
            Token = token;

        }
    }
}
