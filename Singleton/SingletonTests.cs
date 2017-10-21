using Xunit;

namespace Singleton
{
    public class SingletonTests
    {
        [Fact]
        public void Singleton_has_only_one_instance()
        {
            var obj1 = Singleton.Instance;
            var obj2 = Singleton.Instance;

            Assert.Equal(obj1.GetHashCode(), obj2.GetHashCode());
        }
    }
}
