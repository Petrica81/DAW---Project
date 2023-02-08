using Microsoft.EntityFrameworkCore;
using System.Net.WebSockets;
using Ziare.Data;
using Ziare.Models;

namespace Ziare.Helpers.Seeders
{
    public class ZiareSeeder
    {
        public ZiarContext _ziarContext;

        public ZiareSeeder(ZiarContext ziarContext)
        {
            _ziarContext = ziarContext;
        }

        public void SeedInitialZiare()
        {
            /*if (!_ziarContext.Ziare.Any())
            {*/
                var ziar1 = new Ziar
                {
                    Titlu = "Noutati despre vedete! 1",
                    Editura = "BigSpicy",
                    Domeniu = "Cancan",
                    Pret = 5
                };
                var ziar2 = new Ziar
                {
                    Titlu = "Noutati despre vedete! 2",
                    Editura = "BigSpicy",
                    Domeniu = "Cancan",
                    Pret = 5
                };
                var ziar3 = new Ziar
                {
                    Titlu = "Fotbalul romanesc!",
                    Editura = "BigSpicy",
                    Domeniu = "Sport",
                    Pret = 10
                };
                var ziar4 = new Ziar
                {
                    Titlu = "Noutati in Arges! 1",
                    Editura = "ArgesExpress",
                    Domeniu = "Stiri",
                    Pret = 0
                };
                var ziar5 = new Ziar
                {
                    Titlu = "Vedetele Argesene! 1",
                    Editura = "ArgesExpress",
                    Domeniu = "Cancan",
                    Pret = 5
                };

                _ziarContext.Ziare.Add(ziar1);
                _ziarContext.Ziare.Add(ziar2);
                _ziarContext.Ziare.Add(ziar3);
                _ziarContext.Ziare.Add(ziar4);
                _ziarContext.Ziare.Add(ziar5);

                _ziarContext.SaveChangesAsync();
            /*}*/
        }
    }
}
