using Food.Kantyna;

namespace Food.Abstract
{
    abstract class Decorator : KantynaMenuItem
    {
        internal KantynaMenuItem Component;

        protected Decorator() : base(0,string.Empty,0)
        {
        }

        public void SetComponent(KantynaMenuItem menuItem)
        {
            Component = menuItem;
        }

        public abstract double Price();

        public override string Name => Component.Name;
        public override int Number => Component.Number;
    }
}