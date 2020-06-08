using Xunit;

namespace Lab0
{
    public class XUnit
    {
        [Fact]
        public void Add()
        {
            var target = new Calculation();

            var actual = target.Add(1, 3);

            Assert.Equal(4, actual);
        }
    }
}