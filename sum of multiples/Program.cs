using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_of_multiples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int limitValue = 100;
            int maxValue = random.Next(limitValue + 1);
            int firstNumberComparison = 3;
            int secondNumberComparison = 5;
            int result = 0;

            for (int i = 1; i <= maxValue; i++)
            {
                if(i % firstNumberComparison == 0 || i % secondNumberComparison == 0)
                {
                    result += i;
                }
            }

            Console.WriteLine("Результат: " + result);
            Console.ReadKey();
        }
    }
}
