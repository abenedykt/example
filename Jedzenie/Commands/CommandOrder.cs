using Food.Abstract;

namespace Food.Commands
{
    internal class CommandOrder : ICommand
    {
        private readonly IOrderer _order;
        private readonly IBasket _basket;

        public CommandOrder(IOrderer order, IBasket basket)
        {
            _order = order;
            _basket = basket;
        }

        public void Execute()
        {
            _order.Order(_basket);
        }
    }
}