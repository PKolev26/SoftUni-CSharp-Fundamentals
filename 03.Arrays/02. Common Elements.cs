using System.Numerics;

namespace SoftUni_CSharp_Fundamentals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input1 = Console.ReadLine().Split();
            string[] input2 = Console.ReadLine().Split();
            Stack<string> stack1 = new Stack<string>(input1);
            Stack<string> stack2 = new Stack<string>(input2);
            Stack<string> match = new Stack<string>();
            foreach (var item in stack2)
            {
                if (stack1.Contains(item))
                {
                    match.Push(item);
                }
            }
            Console.WriteLine(string.Join(" ", match));
        }
    }
}