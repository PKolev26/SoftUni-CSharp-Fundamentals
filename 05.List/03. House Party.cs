using System.Numerics;
using System.Diagnostics.CodeAnalysis;

namespace SoftUni_CSharp_Fundamentals
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<string> list = new List<string>();
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string[] command = Console.ReadLine().Split(' ');
                if (command[2] == "going!")
                {
                    if (list.Contains(command[0]))
                    {
                        Console.WriteLine(command[0] + " is already in the list!");
                    }
                    else
                    {
                        list.Add(command[0]);
                    }
                }
                if (command[2] == "not")
                {
                    if (list.Contains(command[0]))
                    {
                        list.Remove(command[0]);
                    }
                    else
                    {
                        Console.WriteLine(command[0] + " is not in the list!");
                    }
                }
            }
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}