namespace SoftUni_CSharp_Fundamentals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] num = Console.ReadLine().Select(x => x.ToString()).ToArray();
            Stack<string> stack = new Stack<string>(num);
            int sum = 0;
            while (stack.Count != 0)
            {
                sum += int.Parse(stack.First());
                stack.Pop();
            }
            Console.WriteLine(sum);
        }
    }
}