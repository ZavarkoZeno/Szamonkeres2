using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szamonkeres2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int positiveSum = 0;
            int negativeSum = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Adja meg a {i + 1} számot: ");
                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    if (number > 0)
                    {
                        positiveSum += number;
                    }
                    else if (number < 0)
                    {
                        negativeSum += number;
                    }
                }
                else
                {
                    Console.WriteLine("Érvényes egész számot adjon meg");
                    i--;
                }
            }
            Console.WriteLine($"A pozitív számok összege: {positiveSum}");
            Console.WriteLine($"A negatív számok összege: {negativeSum}");
        }
    }
}
