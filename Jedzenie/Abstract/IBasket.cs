using System.Collections.Generic;

namespace Food.Abstract
{
    internal interface IBasket
    {
        void Add(IMenuItem item);
        // Remove
        // Edit
        IList<IMenuItem> Items { get; }
        void Clear();
    }
}