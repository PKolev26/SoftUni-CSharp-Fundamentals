namespace SoftUni_CSharp_Fundamentals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<string> stack = new Stack<string>();
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                stack.Push(Console.ReadLine());
            }
            foreach (var str in stack)
            {
                foreach (var ch in str)
                {
                    sum += (int)ch;
                }
            }
            Console.WriteLine("The sum equals: " + sum);
        }
    }
}