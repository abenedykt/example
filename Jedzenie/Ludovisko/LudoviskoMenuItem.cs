using Food.Abstract;

namespace Food.Ludovisko
{
    internal class LudoviskoMenuItem : IMenuItem
    {
        private readonly double _price;

        public LudoviskoMenuItem(int number, string name, double price)
        {
            _price = price;
            Number = number;
            Name = name;
        }

        public int Number { get; }
        public string Name { get; }

        public override string ToString()
        {
            return $"{Number} {Name}";
        }

        public double Price()
        {
            return _price;
        }
    }
}