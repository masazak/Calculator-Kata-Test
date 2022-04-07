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
            char[] delimiterChars = { '\n', ',', ';', '/' };
            string[] num = numbers.Split(delimiterChars, System.StringSplitOptions.RemoveEmptyEntries);
            int sum = 0;
            for (int i = 0; i < num.Length; i++)
            {
                sum += Convert.ToInt32(num[i]);
            }


            return sum;
        }
        
        

        }
}
