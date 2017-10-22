using FluentAssertions;
using Xunit;

namespace LSP
{
    public class Class1
    {
        [Fact]
        public void Kwadrat_tests()
        {
            var kwadrat = new Kwadrat(5);

            kwadrat.Pole.Should().Be(25);
            kwadrat.Obwod.Should().Be(20);
        }

        [Fact]
        public void Prostokat_tests()
        {
            var prostokat = new Prostokat(2, 5);
            prostokat.Pole.Should().Be(10);
            prostokat.Obwod.Should().Be(14);
        }

        [Fact]
        public void TestName()
        {
            Kwadrat kwadrat = new Kwadrat(5);

            kwadrat.Pole.Should().Be(25);
            kwadrat.Obwod.Should().Be(20);

            Prostokat p = kwadrat;
            p.Pole.Should().Be(25);
            p.Obwod.Should().Be(20);
        }
        [Fact]
        public void TestName_v2()
        {
            Prostokat2 prostokat = new Prostokat2(2,5);

            prostokat.Pole.Should().Be(10);
            prostokat.Obwod.Should().Be(14);

            Kwadrat2 kwadrat = prostokat;
            kwadrat.Pole.Should().Be(2);
            kwadrat.Obwod.Should().Be(4);
        }
    }

    public class Prostokat
    {
        protected int _a;
        private readonly int _b;
        public int Pole => _a * _b;
        public int Obwod => 2 * (_a + _b);

        public Prostokat(int a, int b)
        {
            _a = a;
            _b = b;
        }
    }

    public class Kwadrat : Prostokat
    {
        public int Pole => _a * _a;
        public int Obwod => 4 * _a;

        public Kwadrat(int a) : base(a, a)
        {
            _a = a;
        }
    }

    public class Prostokat2 : Kwadrat2
    {
        private readonly int _b;
        public int Pole => _a * _b;
        public int Obwod => 2 * (_a + _b);

        public Prostokat2(int a, int b) : base(a)
        {
            _a = a;
            _b = b;
        }
    }

    public class Kwadrat2
    {
        internal int _a;
        public int Pole => _a * _a;
        public int Obwod => 4 * _a;

        public Kwadrat2(int a)
        {
            _a = a;
        }
    }
}
