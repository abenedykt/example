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

        public abstract IOrderer GetOrderer();

    }
}