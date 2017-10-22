using Food.Abstract;

namespace Food.Kantyna
{
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