using System;
using System.Collections.Generic;
using Food.Abstract;

namespace Food
{
    static class Program
    {
        static void Main()
        {
            Console.WriteLine("Gdzie jemy?");
            var place = Console.ReadLine();
            var f = new FlighweightFactory();
            var factory = f.CreateFactory(place);

            var menu = factory.GetMenu();
            ShowMenu(menu.Items);

            var basket = factory.CreateBasket();

            basket.Add(menu.GetItem(0));
            basket.Add(menu.GetItem(2));

            var veryfier = factory.GetVerifier();
            if (veryfier.Verify(basket))
            {
                Console.WriteLine("można zamówić :)");

                factory.GetOrderer().Order(basket);
            }
            else
            {
                Console.WriteLine("popraw zamówienie");
            }

        }

        private static void ShowMenu(IEnumerable<IMenuItem> items)
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }
    }

    //internal class NoVegeFactory : AbstractFactory
    //{
    //    public override IMenu GetMenu()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
}
