using System;

namespace CalculatorKata
{
    public class Program
    {
        static void Main(string[] args)
        {
        }
        public int add(String numbers)
        {
            if (string.IsNullOrWhiteSpace(numbers))
                return 0;
            string[] num = numbers.Split(',');
            int sum = 0;
            if (num.Length == 2)
                sum = Convert.ToInt32(num[0]) + Convert.ToInt32(num[1]);
            else
                if (num.Length == 1)
                sum = Convert.ToInt32(num[0]);


            return sum;
        }
    }
}
