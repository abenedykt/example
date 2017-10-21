using Food.Abstract;

namespace Food.Kantyna
{
    public class KantynaMenuItem : IMenuItem
    {
        public KantynaMenuItem(int number, string name)
        {
            Number = number;
            Name = name;
        }

        public int Number { get; }
        public string Name { get; }

        public override string ToString()
        {
            return $"{Number}) {Name}";
        }
    }
}