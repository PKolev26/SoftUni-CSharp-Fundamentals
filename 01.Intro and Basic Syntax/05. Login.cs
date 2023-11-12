namespace SoftUni_CSharp_Fundamentals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string pass = "";

            int count = 0;

            for (int i = name.Length - 1; i >= 0; i--)
            {
                pass += name[i];
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input != pass)
                {
                    count++;

                    if (count == 4)
                    {
                        Console.WriteLine($"User {name} blocked!");
                        break;
                    }

                    Console.WriteLine("Incorrect password. Try again.");
                }

                else
                {
                    Console.WriteLine($"User {name} logged in.");
                    break;
                }
            }
        }
    }
}