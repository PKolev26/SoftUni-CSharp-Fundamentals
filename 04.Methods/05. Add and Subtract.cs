using System.Numerics;
using System.Diagnostics.CodeAnalysis;

namespace SoftUni_CSharp_Fundamentals
{
    internal class Program
    {
        static int Sum(int num1, int num2)
        {
            return num1 + num2;

        }
        static int Sub(int num1, int num2)
        {
            return num1 - num2;

        }
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine(Sub(Sum(num1, num2), num3));
        }
    }
}