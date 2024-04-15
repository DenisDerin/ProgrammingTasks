using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingTasks
{
    internal class MathMethods
    {
        public static int CalculateFactorial(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            else return n * CalculateFactorial(n - 1);
        }

        public static void PrintFactorialResult()
        {
            Console.WriteLine(CalculateFactorial(10));
        }
    }
}
