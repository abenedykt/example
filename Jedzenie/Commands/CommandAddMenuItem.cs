using Food.Abstract;

namespace Food.Commands
{
    internal class CommandAddMenuItem : ICommand
    {
        private readonly IBasket _basket;
        private readonly IMenuItem _menuItem;

        public CommandAddMenuItem(IBasket basket, IMenuItem menuItem)
        {
            _basket = basket;
            _menuItem = menuItem;
        }

        public void Execute()
        {
            _basket.Add(_menuItem);
        }
    }

    internal class CommndSaveOrder : ICommand
    {
        public CommndSaveOrder(IRepository repository)
        {
            
        }
        public void Execute()
        {
            
        }
    }
}