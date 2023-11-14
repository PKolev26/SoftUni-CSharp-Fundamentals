using System.Numerics;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.Text.RegularExpressions;

namespace SoftUni_CSharp_Fundamentals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> map = new Dictionary<string, double>();
            string[] players = Console.ReadLine().Split(new String[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string player in players)
            {
                if (!map.ContainsKey(player))
                {
                    map[player] = 0;
                }
            }
            while (true)
            {
                string command = Console.ReadLine();
                string name = "";
                double distance = 0;
                if (command == "end of race")
                {
                    break;
                }
                else
                {
                    Regex regex = new Regex(@"[A-Za-z]");
                    MatchCollection matches = regex.Matches(command);
                    foreach (Match match in matches)
                    {
                        name += match.Value;
                    }
                    if (map.ContainsKey(name))
                    {
                        MatchCollection matchesdist = Regex.Matches(command, @"[0-9]");
                        foreach (Match item in matchesdist)
                        {
                            distance += double.Parse(item.Value);
                        }
                        map[name] += distance;
                    }
                }
            }
            var top = map.OrderByDescending(d => d.Value).Take(3).ToList();
            Console.WriteLine($"1st place: {top[0].Key}");
            Console.WriteLine($"2nd place: {top[1].Key}");
            Console.WriteLine($"3rd place: {top[2].Key}");
        }
    }
}
