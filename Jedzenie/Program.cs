using System;
using System.Collections.Generic;
using Food.Abstract;

namespace Food
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gdzie jemy?");
            var place = Console.ReadLine();
            var f = new FlighweightFactory();
            var factory = f.CreateFactory(place);

            var menu = factory.GetMenu();
            ShowMenu(menu.Items);



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

    //internal class LudoviskoFactory : AbstractFactory
    //{
    //    public override IMenu GetMenu()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
}
