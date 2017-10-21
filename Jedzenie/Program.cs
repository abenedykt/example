using System;
using System.Collections.Generic;

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

    internal class FlighweightFactory
    {
        public AbstractFactory CreateFactory(string place)
        {
            switch (place)
            {
                case "kantyna":
                    return new KantynaFactory();
                //case "ludovisko":
                //    return new LudoviskoFactory();
                //case "novege":
                //    return new NoVegeFactory();
            }
            return new NullableFactory();
        }
    }

    internal class NullableFactory : AbstractFactory
    {
        public override IMenu GetMenu()
        {
            return new EmptyMenu();
        }
    }

    internal class EmptyMenu : IMenu
    {
        public List<IMenuItem> Items => new List<IMenuItem>();
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

    internal class KantynaFactory : AbstractFactory
    {
        public override IMenu GetMenu()
        {
            return new KantynaExampleMenu();
        }

        private class KantynaExampleMenu : IMenu
        {
            public List<IMenuItem> Items => new List<IMenuItem>
            {
                new KanynaMenuItem(1, "Salami"),
                new KanynaMenuItem(2, "Hawajska"),
                new KanynaMenuItem(3, "4 sery"),
            };


        }

    }

    public class KanynaMenuItem : IMenuItem
    {
        public KanynaMenuItem(int number, string name)
        {
            Number = number;
            Name = name;
        }

        public int Number { get; }
        public string Name { get; }

        public override string ToString()
        {
            return $"{Number}) {Name}";
        }
    }


    internal abstract class AbstractFactory
    {
        public abstract  IMenu GetMenu();
    }

    internal interface IMenu
    {
        List<IMenuItem> Items { get; }
    }

    internal interface IMenuItem
    {
        int Number { get; }
        string Name{ get; }
    }
}
