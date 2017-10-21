using System.Collections.Generic;

namespace Food.Abstract
{
    internal abstract class AbstractFactory
    {
        public abstract IMenu GetMenu();

        public IBasket CreateBasket()
        {
            return new Basket();
        }

        public abstract IBasketVerifier GetVerifier();

    }

    internal interface IBasketVerifier
    {
        bool Verify(IBasket basket);
    }

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
    }

    internal interface IBasket
    {
        void Add(IMenuItem item);
        // Remove
        // Edit
        IList<IMenuItem> Items { get; }
    }
}