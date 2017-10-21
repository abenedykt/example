using Food.Abstract;

namespace Food.Ludovisko
{
    internal class LudoviskoBasketVeryfier : IBasketVerifier
    {
        public bool Verify(IBasket basket)
        {
            // items.SUm() >= x
            return true;
        }
    }
}