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
            Random rand = new Random();
            int maxValue = rand.Next(101);
            int result = 0;

            for (int i = 1; i <= maxValue; i++)
            {
                if(i % 3 == 0 || i % 5 == 0)
                {
                    result += i;
                }
            }

            Console.WriteLine("Результат: " + result);
            Console.ReadKey();
        }
    }
}
