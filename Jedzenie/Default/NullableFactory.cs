using Food.Abstract;

namespace Food.Default
{
    internal class NullableFactory : AbstractFactory
    {
        public override IMenu GetMenu()
        {
            return new EmptyMenu();
        }

        public override IBasketVerifier GetVerifier()
        {
            return new EmptyVeryfier();
        }
    }
}