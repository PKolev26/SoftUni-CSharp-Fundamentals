using System.Numerics;
using System.Diagnostics.CodeAnalysis;

namespace SoftUni_CSharp_Fundamentals
{
    internal class Program
    {
        public static bool TopNumber(int n)
        {
            int sum = 0;
            bool odd = false;
            while (n > 0)
            {
                int digit = n % 10;
                sum += digit;
                if (digit % 2 == 1)
                {
                    odd = true;
                }
                n /= 10;
            }
            return sum % 8 == 0 && odd;
        }
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (TopNumber(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}