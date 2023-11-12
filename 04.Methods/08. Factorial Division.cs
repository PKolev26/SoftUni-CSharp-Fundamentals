using System.Numerics;
using System.Diagnostics.CodeAnalysis;

namespace SoftUni_CSharp_Fundamentals
{
    internal class Program
    {
        private static decimal FactorialDivision(decimal a, decimal b)
        {
            decimal factA = 1;
            decimal factB = 1;
            for (decimal i = 2; i <= a; i++)
            {
                factA *= i;
            }
            for (decimal i = 2; i <= b; i++)
            {
                factB *= i;
            }
            return (decimal)(factA / factB);
        }
        static void Main(string[] args)
        {
            decimal a = int.Parse(Console.ReadLine());
            decimal b = int.Parse(Console.ReadLine());
            Console.WriteLine($"{FactorialDivision(a, b):f2}");

        }
    }
}