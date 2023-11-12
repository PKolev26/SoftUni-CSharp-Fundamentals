namespace SoftUni_CSharp_Fundamentals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstnum = int.Parse(Console.ReadLine());
            int secondnum = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = firstnum; i <= secondnum; i++)
            {
                Console.Write(i + " ");
                sum += i;
            }
            Console.WriteLine("\nSum: " + sum);
        }
    }
}