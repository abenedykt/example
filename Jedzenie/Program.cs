using System;
using System.Collections.Generic;
using Food.Abstract;
using Food.Commands;
using Food.Kantyna;

namespace Food
{
    static class Program
    {
        static void Main()
        {
            var factory = new Factory();
            var licence = factory.GetLicenceChain();

            licence.Validate("mylicence.txt");

            Console.WriteLine("Gdzie jemy?");
            var place = Console.ReadLine();
            var f = new FlighweightFactory();
            var abstractFactory = f.CreateFactory(place);

            var menu = abstractFactory.GetMenu();
            ShowMenu(menu.Items);

            var basket = abstractFactory.CreateBasket();

            var executor = new CommandExecutor();
            executor.Execute(new CommandAddMenuItem(basket, menu.GetItem(0)));
            executor.Execute(new CommandAddMenuItem(basket, menu.GetItem(2)));
            executor.Execute(new CommandEmptyBasket(basket));
            executor.Execute(new CommandAddMenuItem(basket, menu.GetItem(0)));
            executor.Execute(new CommandAddMenuItem(basket, menu.GetItem(2)));

            KantynaMenuItem pizza = menu.GetItem(2) as KantynaMenuItem;
            NaGrubym pizzaNaGrubym = new NaGrubym();
            
            pizzaNaGrubym.SetComponent(pizza);
            KantynaMenuItem naGrubym = pizzaNaGrubym;
            executor.Execute(new CommandAddMenuItem(basket, pizzaNaGrubym));
            
            var veryfier = abstractFactory.GetVerifier();
            
            
            //LSP


            if (veryfier.Verify(basket))
            {
                Console.WriteLine("można zamówić :)");

                executor.Execute(new CommandOrder(abstractFactory.GetOrderer(), basket));
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
