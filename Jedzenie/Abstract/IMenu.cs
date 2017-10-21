using System.Collections.Generic;

namespace Food.Abstract
{
    internal interface IMenu
    {
        List<IMenuItem> Items { get; }
        IMenuItem GetItem(int number);
    }
}