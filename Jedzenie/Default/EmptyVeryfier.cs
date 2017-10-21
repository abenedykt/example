using Food.Abstract;

namespace Food.Default
{
    internal class EmptyVeryfier : IBasketVerifier
    {
        public bool Verify(IBasket basket)
        {
            return false;
        }
    }
}