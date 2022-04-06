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



    }
}