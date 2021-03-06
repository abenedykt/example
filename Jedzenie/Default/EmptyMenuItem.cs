using Food.Abstract;

namespace Food.Default
{
    internal class EmptyMenuItem : IMenuItem
    {
        public int Number { get; }
        public string Name { get; }
        public double Price()
        {
            return 0;
        }
    }
}