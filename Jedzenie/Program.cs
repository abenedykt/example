using System;
using System.Collections.Generic;
using Food.Abstract;
using Food.Commands;

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

            var executor = new CommandExecutor();
            executor.Execute(new CommandAddMenuItem(basket, menu.GetItem(0)));
            executor.Execute(new CommandAddMenuItem(basket, menu.GetItem(2)));
            executor.Execute(new CommandEmptyBasket(basket));
            executor.Execute(new CommandAddMenuItem(basket, menu.GetItem(0)));
            executor.Execute(new CommandAddMenuItem(basket, menu.GetItem(2)));


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
}
