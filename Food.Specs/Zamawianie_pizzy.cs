using System;
using Microsoft.SqlServer.Server;
using Xunit;

namespace Food.Specs
{
    public class Zamawianie_pizzy
    {
        private readonly World _;

        public Zamawianie_pizzy()
        {
            _ = new World();
        }

        [Fact]
        public void TestName()
        {
            _.Dodaj_kawalki_pizzy(2);
            _.Dodaj_kawalki_pizzy(2);
            _.Dodaj_kawalki_pizzy(4);
            _.Zamow_pizze();
            _.Zamowienie_zostalo_zlozone();
        }
    }
}