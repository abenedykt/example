using Food.Abstract;

namespace Food.Ludovisko
{
    internal class LudoviskoFactory : AbstractFactory
    {
        public override IMenu GetMenu()
        {
            return new LudoviskoMenu();
        }

        public override IBasketVerifier GetVerifier()
        {
            return new LudoviskoBasketVeryfier();
        }
    }
}