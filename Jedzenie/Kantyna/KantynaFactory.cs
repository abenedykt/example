using System.Collections.Generic;
using Food.Abstract;
using Food.Default;

namespace Food.Kantyna
{
    internal class KantynaFactory : AbstractFactory
    {
        public override IMenu GetMenu()
        {
            return new KantynaExampleMenu();
        }

        public override IBasketVerifier GetVerifier()
        {
            return new MixedVeryfier();
        }

        public override IOrderer GetOrderer()
        {
            return new KantynaOrderer();
        }

        private class KantynaExampleMenu : IMenu
        {
            public List<IMenuItem> Items => new List<IMenuItem>
            {
                new KantynaMenuItem(1, "Salami", 20),
                new KantynaMenuItem(2, "Hawajska", 25),
                new KantynaMenuItem(3, "4 sery", 30)
            };

            public IMenuItem GetItem(int number)
            {
                if (number >= 0 && number < Items.Count)
                    return Items[number];

                return new EmptyMenuItem();
            }
        }
    }

    
}