using System.Collections;
using System.Collections.Generic;
using System.Runtime.Remoting.Contexts;
using Food.Abstract;

namespace Food.Commands
{
    internal interface IRepository
    {
        void Create(IBasket basket);
        void Update(IBasket basket);
        void Read(int basketId);
        void ReadAll();
        void Delete(int basketId);
    }

    class Repository : IRepository
    {
        public void Create(IBasket basket)
        {
           
        }

        public void Update(IBasket basket)
        {
            throw new System.NotImplementedException();
        }

        public void Read(int basketId)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<DbBasket> ReadAll()
        {
            using (var db = new Context())
            {
                return db.Baskets().ToList();
            }
        }

        public void Delete(int basketId)
        {
            throw new System.NotImplementedException();
        }
    }
}