using Food.Abstract;

namespace Food.Kantyna
{
    internal class NaGrubym : Decorator
    {
        public override double Price()
        {
            return Component.Price() + 5;
        }
    }
}