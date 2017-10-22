using System;
using System.Collections.Generic;
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

        public override IOrderer GetOrderer()
        {
            return new LudoviskoOrdererAdapter();
        }
    }

    internal class LudoviskoOrdererAdapter : IOrderer
    {
        public void Order(IBasket basket)
        {
            var api = new LudviskoApiClient("ECC19FA0-98F1-4FCA-BAAE-CB26AE6CA0A5","A40EC63E-EA93-4582-89C1-D4D81BD070BD");
            var order = Convert(basket);
            api.SendOrder(order);
        }

        private List<Tuple<string, int>> Convert(IBasket basket)
        {
            throw new NotSupportedException();
            return default(List<Tuple<string, int>>);
        }
    }

    internal class LudviskoApiClient
    {
        public LudviskoApiClient(string clientId, string clientSecret)
        {
            
        }

        public bool SendOrder(List<Tuple<string, int>>  order)
        {
            return true;
        }
    }
}