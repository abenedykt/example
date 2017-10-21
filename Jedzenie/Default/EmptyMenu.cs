using System.Collections.Generic;
using Food.Abstract;

namespace Food.Default
{
    internal class EmptyMenu : IMenu
    {
        public List<IMenuItem> Items => new List<IMenuItem>();
    }
}