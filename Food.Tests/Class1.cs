using Food.Abstract;
using Food.Commands;
using NSubstitute;
using Xunit;

namespace Food.Tests
{
    public class CommandEmptyBasketTests
    {
        [Fact]
        public void Command_should_execute_clear_on_basket()
        {
            var basket = Substitute.For<IBasket>();
            var command = new CommandEmptyBasket(basket);

            command.Execute();

            basket.Received(1).Clear();
        }
    }

    public class CommandAddMenuItemTests
    {
        [Fact]
        public void TestName()
        {
            //var command = 
        }
    }


}
