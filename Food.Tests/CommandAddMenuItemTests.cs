﻿using Food.Abstract;
using Food.Commands;
using NSubstitute;
using Xunit;

namespace Food.Tests
{
    public class CommandAddMenuItemTests
    {
        [Fact]
        public void Command_should_add_menu_item_to_the_basket()
        {
            //arrange
            var basket = Substitute.For<IBasket>();
            var menuItem = Substitute.For<IMenuItem>();
            var command = new CommandAddMenuItem(basket, menuItem);

            //act
            command.Execute();

            //assert
            basket.Received(1).Add(menuItem);
        }

        [Fact]
        public void Command_should_add_menu_item_to_the_basket_v2()
        {
            var basket = Substitute.For<IBasket>();
            var menuItem = Substitute.For<IMenuItem>();

            menuItem.Name.Returns("test pizza");
            menuItem.Number.Returns(500);

            var command = new CommandAddMenuItem(basket, menuItem);

            command.Execute();

            basket.Received(1)
                .Add(Arg.Is<IMenuItem>(a=>a.Name == "test pizza" && a.Number == 500));

        }

        [Fact]
        public void Command_should_add_menu_item_to_the_basket_BAD_EXAMPLE()
        {//arrrange
            var basket = Substitute.For<IBasket>();
            var menuItem = Substitute.For<IMenuItem>();

            menuItem.Name.Returns("test pizza");
            menuItem.Number.Returns(500);

            var command = new CommandAddMenuItem(basket, menuItem);
            //act
            command.Execute();

            //asser
            basket.Received().Add(Arg.Any<IMenuItem>());

        }

        [Theory,
         InlineData(1, 1, 2),
         InlineData(1, 2, 3),
         InlineData(2, 1, 3)]
        public void Sum(int a , int b ,int expected)
        {
            Assert.Equal(expected, a + b);
        }
    }


}
