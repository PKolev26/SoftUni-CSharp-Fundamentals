using System.Numerics;
using System.Diagnostics.CodeAnalysis;

namespace SoftUni_CSharp_Fundamentals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var parking = new Dictionary<string, string>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string com, name, num;
                string[] input = Console.ReadLine().Split().ToArray();
                com = input[0];
                if (com == "register")
                {
                    name = input[1];
                    num = input[2];
                    if (parking.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {num}");
                    }
                    else if (!parking.ContainsKey(name))
                    {
                        parking.Add(name, num);
                        Console.WriteLine($"{name} registered {num} successfully");

                    }
                }
                else
                {
                    com = input[0];
                    name = input[1];
                    if (!parking.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: user {name} not found");
                    }
                    else
                    {

                        parking.Remove(name);
                        Console.WriteLine($"{name} unregistered successfully");
                    }
                }

            }
            foreach (var item in parking)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
