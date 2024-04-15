using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingTasks
{
    internal class MathMethods
    {
        static int[] CalculateDigitCounts(int number)
        {
            if (number.ToString().Length != 4)
            {
                Console.WriteLine("Error: Please enter a four-digit number.");
                return null;
            }

            int units = number % 10;
            int tens = (number / 10) % 10;
            int hundreds = (number / 100) % 10;
            int thousands = number / 1000;

            return new int[] { units, tens, hundreds, thousands };
        }

        public static int CalculateFactorial(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            else return n * CalculateFactorial(n - 1);
        }

        public static void PrintDigitCounts()
        {
            int number = 2024;
            int[] counts = CalculateDigitCounts(number);

            if (counts != null)
            {
                Console.WriteLine($"For the number {number}:");
                Console.WriteLine($"Units: {counts[0]}");
                Console.WriteLine($"Tens: {counts[1]}");
                Console.WriteLine($"Hundreds: {counts[2]}");
                Console.WriteLine($"Thousands: {counts[3]}");
            }
            else
            {
                Console.WriteLine("Error occurred while processing the number.");
            }
        }

        public static void PrintFactorialResult()
        {
            Console.WriteLine(CalculateFactorial(10));
        }
    }
}
