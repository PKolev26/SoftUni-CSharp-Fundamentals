using System.Numerics;
using System.Diagnostics.CodeAnalysis;

namespace SoftUni_CSharp_Fundamentals
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<int> train = new List<int>(Console.ReadLine().Split(' ').Select(int.Parse));
            int capacity = int.Parse(Console.ReadLine());
            string[] command = Console.ReadLine().Split(' ');
            while (command[0] != "end")
            {
                if (command[0] == "Add")
                {
                    train.Add(int.Parse(command[1]));
                }
                else
                {
                    int passengers = int.Parse(command[0]);
                    for (int i = 0; i < train.Count; i++)
                    {
                        int availableSeats = capacity - train[i];
                        if (availableSeats >= passengers)
                        {
                            train[i] += passengers;
                            break;
                        }
                    }
                }
                command = Console.ReadLine().Split(' ');
            }
            Console.WriteLine(string.Join(" ", train));
        }
    }
}