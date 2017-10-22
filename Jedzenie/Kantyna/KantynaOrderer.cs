using System;
using Food.Abstract;

namespace Food.Kantyna
{
    internal class KantynaOrderer : IOrderer
    {
        public void Order(IBasket basket)
        {
            Console.WriteLine("Zamowienie do kantyny zosto zlozone");
            foreach (var item in basket.Items)
            {
                Console.WriteLine(item);
            }
        }
    }
}