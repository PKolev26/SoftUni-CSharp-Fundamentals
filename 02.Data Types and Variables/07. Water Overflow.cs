namespace SoftUni_CSharp_Fundamentals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int waterTank = 0;
            for (int i = 0; i < n; i++)
            {
                int liter = int.Parse(Console.ReadLine());
                if (liter + waterTank <= 255)
                {
                    waterTank += liter;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }
        }
    }
}