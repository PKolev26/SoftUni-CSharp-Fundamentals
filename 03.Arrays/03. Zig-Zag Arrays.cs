using System.Numerics;

namespace SoftUni_CSharp_Fundamentals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<int> red = new Queue<int>();
            Queue<int> blue = new Queue<int>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                if (i % 2 == 0)
                {
                    red.Enqueue(int.Parse(input[0]));
                    blue.Enqueue(int.Parse(input[1]));
                }
                else
                {
                    blue.Enqueue(int.Parse(input[0]));
                    red.Enqueue(int.Parse(input[1]));
                }

            }
            Console.WriteLine(string.Join(" ", red));
            Console.WriteLine(string.Join(" ", blue));
        }
    }
}