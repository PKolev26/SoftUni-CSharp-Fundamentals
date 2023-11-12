using System.Numerics;

namespace SoftUni_CSharp_Fundamentals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ');
            Queue<string> queue = new Queue<string>();
            for (int i = 0; i < arr.Length; i++)
            {
                bool top = true;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (int.Parse(arr[j]) >= int.Parse(arr[i]))
                    {
                        top = false;
                        break;
                    }
                }
                if (top)
                {
                    queue.Enqueue(arr[i]);
                }
            }

            Console.WriteLine(string.Join(" ", queue));
        }
    }
}