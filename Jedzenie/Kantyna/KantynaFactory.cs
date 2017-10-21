using System.Collections.Generic;
using Food.Abstract;

namespace Food.Kantyna
{
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
}