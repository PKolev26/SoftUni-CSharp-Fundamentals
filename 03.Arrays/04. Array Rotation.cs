using System.Numerics;

namespace SoftUni_CSharp_Fundamentals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>(Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse));
            int rotations = int.Parse(Console.ReadLine());
            for (int i = 0; i < rotations; i++)
            {
                int first = queue.Dequeue();
                queue.Enqueue(first);
            }
            Console.WriteLine(string.Join(" ", queue));
        }
    }
}