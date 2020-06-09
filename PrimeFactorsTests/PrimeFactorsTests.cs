using Xunit;
using PrimeFactors;

namespace PrimeFactorsTests
{
    public class PrimeFactorsFinderTest
    {
        [Fact]
        public void TestWith4()
        {
            var expected = "2 2";

            var result = PrimeFactorsFinder.Instance.GetFrom(4);;

            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestWith7()
        {
            var expected = "7";

            var result = PrimeFactorsFinder.Instance.GetFrom(7); ;

            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestWith30()
        {
            var expected = "5 3 2";

            var result = PrimeFactorsFinder.Instance.GetFrom(30);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestWith40()
        {
            var expected = "5 2 2 2";

            var result = PrimeFactorsFinder.Instance.GetFrom(40);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestWith50()
        {
            var expected = "5 5 2";

            var result = PrimeFactorsFinder.Instance.GetFrom(50);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestWith62()
        {
            var expected = "31 2";

            var result = PrimeFactorsFinder.Instance.GetFrom(62);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestWith125()
        {
            var expected = "5 5 5";

            var result = PrimeFactorsFinder.Instance.GetFrom(125);

            Assert.Equal(expected, result);
        }
    }
}
