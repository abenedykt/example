using System.Collections.Generic;
using Food.Abstract;

namespace Food
{
    internal class Basket : IBasket
    {
        private readonly IList<IMenuItem> _items;

        public Basket()
        {
            _items = new List<IMenuItem>();
        }

        public void Add(IMenuItem item)
        {
            _items.Add(item);
        }

        public IList<IMenuItem> Items => _items;
        public void Clear()
        {
            Items.Clear();
        }
    }
}