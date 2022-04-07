using Xunit;
using CalculatorKata;

namespace CalculatorKataTest
{
    public class CalculatorKataTestShould
    {

        [Theory]
        [InlineData("", 0)]
        [InlineData("1", 1)]
        [InlineData("1,2", 3)]
        public void SumOfNumbersHaveAtMostTwonumber(string num, int expectedResult)
        {
            var obj = new Program();

            int result = obj.add(num);

            Assert.Equal(expectedResult, result);

        }

        [Fact]
        public void SumOfUnknownAmountOfNumbers()
        {
            var obj = new Program();

            int result = obj.add("1,2,3,4,5,6,7,8");

            int expectedResult = 36;

            Assert.Equal(expectedResult, result);

        }

        [Fact]
        public void SumNumbersWithNewLines()
        {
            var obj = new Program();

            int result = obj.add("1\n2,3");

            int expectedResult = 6;

            Assert.Equal(expectedResult, result);

        }






    }
}