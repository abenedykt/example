using Food.Abstract;

namespace Food.Kantyna
{
    public class KantynaMenuItem : IMenuItem
    {
        private readonly double _price;

        public KantynaMenuItem(int number, string name, double price)
        {
            _price = price;
            Number = number;
            Name = name;
        }

        public virtual int Number { get; }
        public virtual string Name { get; }

        public virtual double Price()
        {
            return _price;
        }

        public override string ToString()
        {
            return $"{Number}) {Name}";
        }
    }
}