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
                new KantynaMenuItem(1, "Salami"),
                new KantynaMenuItem(2, "Hawajska"),
                new KantynaMenuItem(3, "4 sery")
            };

            public IMenuItem GetItem(int number)
            {
                if (number >= 0 && number < Items.Count)
                    return Items[number];

                return new EmptyMenuItem();
            }
        }
    }

    internal class MixedVeryfier : IBasketVerifier
    {
        public bool Verify(IBasket basket)
        {
            var pizza = new PizzaVerifier();
            var food = new FoodVeryfier();

            return pizza.Verify(basket) && food.Verify(basket);
        }
    }

    internal class PizzaVerifier : IBasketVerifier
    {
        public bool Verify(IBasket basket)
        {
            // var slices = basket.Items.Sum();

            //var groups = slices.GroupBy(s => s.Name)
            //    .Sum(g => g.Count)
            //    .Where(s => s % 8 == 0 || s % 4 == 0);
            //return groups.Any();

            return true;
        }
    }

    internal class FoodVeryfier : IBasketVerifier
    {
        public bool Verify(IBasket basket)
        {
            return true;
        }
    }
}