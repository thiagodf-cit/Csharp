using System;
using System.Linq;

namespace LinqNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 2, 3, 4, 5 };

            var result = numbers
                .Where(n => n % 2 == 0)
                .Select(n => n * 10);

            foreach (int n in result) 
            {
                Console.WriteLine(n);
            }
        }
    }
}
