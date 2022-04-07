using System;
using System.Collections.Generic;
using System.Linq;

namespace CalculatorKata
{
    public class Program
    {
        static void Main(string[] args)
        {
            
        }
        public  int add(String numbers)
        {
            if (string.IsNullOrWhiteSpace(numbers))
                return 0;
            char[] delimiterChars = { '\n', ',', ';', '/' };
            string[] num = numbers.Split(delimiterChars, System.StringSplitOptions.RemoveEmptyEntries);
            int sum = 0;
            List<int> negativenum = new List<int>();
            for (int i = 0; i < num.Length; i++)
            {   if(Convert.ToInt32(num[i]) < 0)
                {
                    negativenum.Add(Convert.ToInt32(num[i]));
                    
                }
                if (Convert.ToInt32(num[i]) < 1000)
                { 
                    sum += Convert.ToInt32(num[i]); 
                }
            }

           if(negativenum.Any())
            {
                throw new ArgumentException(String.Format("negatives not allowed:{0}",
                           string.Join(", ", negativenum.Select(sns => sns))));

            }


            return sum;
        }
        
        

        }
}
