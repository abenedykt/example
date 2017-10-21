using System.Collections.Generic;
using Food.Abstract;
using Food.Default;

namespace Food.Ludovisko
{
    internal class LudoviskoMenu : IMenu
    {
        public List<IMenuItem> Items => new List<IMenuItem>
        {
            new LudoviskoMenuItem(1, "Fit"),
            new LudoviskoMenuItem(2, "Vege"),
            new LudoviskoMenuItem(3, "Standard")
        };

        public IMenuItem GetItem(int number)
        {
            if (number > 0 && number < Items.Count)
                return Items[number];

            return new EmptyMenuItem();
        }
    }
}