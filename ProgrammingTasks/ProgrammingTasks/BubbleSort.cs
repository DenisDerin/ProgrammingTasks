using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingTasks
{
    internal static class BubbleSort
    {
        public static int[] SortAscending(int[] numbers)
        {
            var arrayLength = numbers.Length;

            for (int passIndex = 0; passIndex < arrayLength; passIndex++)
            {
                for (int elementIndex = 0; elementIndex < arrayLength - 1; elementIndex++)
                {
                    if (numbers[elementIndex] < numbers[elementIndex + 1])
                    {
                        int temporaryNumber = numbers[elementIndex];
                        numbers[elementIndex] = numbers[elementIndex + 1];
                        numbers[elementIndex + 1] = temporaryNumber;
                    }
                }
            }
            return numbers;
        }
        public static int[] SortDescending(int[] numbers)
        {
            var arrayLength = numbers.Length;

            for (int passIndex = 0; passIndex < arrayLength; passIndex++)
            {
                for (int elementIndex = 0; elementIndex < arrayLength - 1; elementIndex++)
                {
                    if (numbers[elementIndex] > numbers[elementIndex + 1])
                    {
                        int temporaryNumber = numbers[elementIndex];
                        numbers[elementIndex] = numbers[elementIndex + 1];
                        numbers[elementIndex + 1] = temporaryNumber;
                    }
                }
            }
            return numbers;
        }

        public static void ExecuteSortDescending()
        {
            int[] inputNumbers = { 63, 17, 49, 92, 4, 30, 87, 53, 18, 76 };
            int[] sortedNumbers = BubbleSort.SortDescending(inputNumbers);

            foreach (var number in sortedNumbers)
            {
                Console.WriteLine(number);
            }
        }

        internal static void SortAscending()
        {
            int[] inputNumbers = { 63, 17, 49, 92, 4, 30, 87, 53, 18, 76 };
            int[] sortedNumbers = BubbleSort.SortAscending(inputNumbers);

            foreach (var number in sortedNumbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
