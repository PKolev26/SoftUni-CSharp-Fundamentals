using System.Numerics;

namespace SoftUni_CSharp_Fundamentals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<int> stack = new Queue<int>();
            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                stack.Enqueue(input);
            }
            Console.WriteLine(string.Join(" ", stack));
            Console.WriteLine(stack.Sum());
        }
    }
}