using Microsoft.EntityFrameworkCore;
using Ziare.Data;
using Ziare.Models;
using Ziare.Repositories.GenericRepository;

namespace Ziare.Repositories.ClientiRepository
{
    public class ClientiRepository : GenericRepository<Client>, IClientiRepository
    {
        private readonly DbSet<Biblioteca> _biblioteci;
        private readonly DbSet<Ziar> _ziare;
        private readonly DbSet<ZiarBibliotecaRelation> _zbrelations;
        public ClientiRepository(ZiarContext context) : base(context) { }

        public async Task<Client> FindByEmailAsync(string email)
        {
            return await _table.FirstOrDefaultAsync(x => x.Email == email);
        }
        public async Task<Client> GetByEmailCuBibliotecaAsync(string email)
        {
            return await _table.Include(c => c.Biblioteca)
                                .ThenInclude(b => b!.ZiarBibliotecaRelations)
                                .FirstOrDefaultAsync(c => c.Email == email);
        }
        //aceasta metoda linq face join pe 4 tabele(nu asa speram initial) ca sa afle valoarea totala a unui utilizator
        //valoare totala = banii utilizatorului + pretul ziarelor detinute in biblioteca acestuia
        public int GetValoareCont(Guid id)
        {
            //pretul ziarelor adunat
            int valziare = (from t in _table.AsNoTracking()
                              join b in _biblioteci on t.BibliotecaId equals b.Id
                              join r in _zbrelations on b.Id equals r.BibliotecaId
                              join z in _ziare on r.ZiarId equals z.Id
                              where t.Id == id
                              select z.Pret).Sum();
            //am adaugat banii din portofel separat deoarece in cea anterioara s-ar fi multiplicat cu cate ziare am
            int portofel = (from t in _table.AsNoTracking()
                            where t.Id == id
                              select t.Bani).Sum();//folosesc .Sum() chiar daca am doar un element pentru a-mi intoarce int :))
            
            return  (valziare + portofel);
        }
        public Client FindById(Guid id)
        {
            return  _table.FirstOrDefault(x => x.Id == id);
        }
    }
}
