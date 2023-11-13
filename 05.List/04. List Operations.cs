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
            while (command[0] != "End")
            {
                if (command[0] == "Add")
                {
                    list.Add(int.Parse(command[1]));
                }
                else if (command[0] == "Insert")
                {
                    if (int.Parse(command[2]) < 0 || int.Parse(command[2]) > list.Count)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        list.Insert(int.Parse(command[2]), int.Parse(command[1]));
                    }
                }
                else if (command[0] == "Remove")
                {
                    if (int.Parse(command[1]) < 0 || int.Parse(command[1]) >= list.Count)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        list.RemoveAt(int.Parse(command[1]));
                    }
                }
                else if (command[0] == "Shift" && command[1] == "left")
                {
                    int count = int.Parse(command[2]);
                    for (int i = 0; i < count % list.Count; i++)
                    {
                        int first = list[0];
                        list.RemoveAt(0);
                        list.Add(first);
                    }
                }
                else if (command[0] == "Shift" && command[1] == "right")
                {
                    int count = int.Parse(command[2]);
                    for (int i = 0; i < count % list.Count; i++)
                    {
                        int last = list.Last();
                        list.RemoveAt(list.Count - 1);
                        list.Insert(0, last);
                    }
                }

                command = Console.ReadLine().Split(' ');
            }
            Console.WriteLine(string.Join(" ", list));
        }
    }
}