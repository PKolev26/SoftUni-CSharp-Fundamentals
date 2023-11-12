using System.Numerics;

namespace SoftUni_CSharp_Fundamentals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static int Small(int num1, int num2, int num3)
            {
                return Math.Min(Math.Min(num1, num2), num3);
            }
            static void Main(string[] args)
            {
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());
                int num3 = int.Parse(Console.ReadLine());
                Console.WriteLine(Small(num1, num2, num3));
            }
        }
    }
}