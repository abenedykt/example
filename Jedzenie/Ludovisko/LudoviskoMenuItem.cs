using Food.Abstract;

namespace Food.Ludovisko
{
    internal class LudoviskoMenuItem : IMenuItem
    {
        public LudoviskoMenuItem(int number, string name)
        {
            Number = number;
            Name = name;
        }

        public int Number { get; }
        public string Name { get; }

        public override string ToString()
        {
            return $"{Number} {Name}";
        }
    }
}