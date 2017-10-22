using Food.Abstract;

namespace Food.Commands
{
    internal class CommandEmptyBasket : ICommand
    {
        private readonly IBasket _basket;

        public CommandEmptyBasket(IBasket basket)
        {
            _basket = basket;
        }

        public void Execute()
        {
            _basket.Clear();
        }
    }
}