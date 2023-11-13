using System.Numerics;
using System.Diagnostics.CodeAnalysis;

namespace SoftUni_CSharp_Fundamentals
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<int> list = new List<int>(Console.ReadLine().Split(' ').Select(int.Parse));
            string[] command = Console.ReadLine().Split(' ');
            while (command[0] != "end")
            {
                if (command[0] == "Delete")
                {
                    int element = int.Parse(command[1]);
                    list.RemoveAll(e => e == element);
                }
                else if (command[0] == "Insert")
                {
                    list.Insert(int.Parse(command[2]), int.Parse(command[1]));
                }
                command = Console.ReadLine().Split(' ');
            }
            Console.WriteLine(string.Join(" ", list));
        }
    }
}