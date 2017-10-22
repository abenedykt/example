using System;
using Food.Abstract;

namespace Food.Default
{
    internal class Orderer : IOrderer
    {
        private Orderer()
        {
        }

        public static IOrderer Empty()
        {
            return new Orderer();
        }

        public void Order(IBasket basket)
        {
            Console.WriteLine("empty order - nothing has been done");
        }
    }
}