namespace Food.Specs
{
    public class World
    {
        public World()
        {
            // startup servera w pamieci
        }

        public void Dodaj_kawalki_pizzy(int p0)
        {
            // send api request [post] /api/pizza/2
        }

        public void Zamow_pizze()
        {
            // send api request [post] /api/order;
        }

        public void Zamowienie_zostalo_zlozone()
        {
            // send api request [get] /api/order/2345/status;
        }
    }
}
