namespace SoftUni_CSharp_Fundamentals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = num; i > 0; i = i / 10)
            {
                int digit = i % 10;
                int factorial = 1;
                for (int j = 1; j <= digit; j++)
                {
                    factorial = factorial * j;
                }
                sum = sum + factorial;
            }
            if (sum == num) Console.WriteLine("yes");
            else Console.WriteLine("no");
        }
    }
}