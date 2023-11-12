namespace SoftUni_CSharp_Fundamentals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string biggestModel = "";
            double biggestVolume = 0;
            for (int i = 0; i < n; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                double volume = Math.PI * radius * radius * height;
                if (volume > biggestVolume)
                {
                    biggestModel = model;
                    biggestVolume = volume;
                }
            }
            Console.WriteLine(biggestModel);
        }
    }
}