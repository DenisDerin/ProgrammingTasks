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

        static int FindMax(int[] numbers)
        {
            int maxNumber = 0;
            foreach (int number in numbers)
            {
                if (number > maxNumber) { maxNumber = number; }
            }
            return maxNumber;
        }

        static int FindMin(int[] numbers)
        {
            int minNumber = int.MaxValue;
            foreach (int number in numbers)
            {
                if (number < minNumber) { minNumber = number; }
            }
            return minNumber;
        }

        public static void PrintMinMax()
        {
            int[] numbers = { 63, 17, 49, 92, 4, 30, 87, 53, 18, 76 };
            int maxNumber = FindMax(numbers);
            int minNumber = FindMin(numbers);

            Console.WriteLine($"Max number: {maxNumber}");
            Console.WriteLine($"Min number: {minNumber}");
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
