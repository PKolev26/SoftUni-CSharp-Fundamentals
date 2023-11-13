using System.Numerics;
using System.Diagnostics.CodeAnalysis;

namespace SoftUni_CSharp_Fundamentals
{
    internal class Program
    {
        class Team
        {
            public string Name { get; set; }
            public string Creator { get; set; }
            public List<string> Members { get; set; }

            public Team(string name, string creator)
            {
                this.Name = name;
                this.Creator = creator;
                this.Members = new List<string>();
            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split('-');
                string user = input[0];
                string team = input[1];
                if (teams.Any(f => f.Name == team))
                {
                    Console.WriteLine($"Team {team} was already created!");
                    continue;
                }
                else if (teams.Any(f => f.Creator == user))
                {
                    Console.WriteLine($"{user} cannot create another team!");
                    continue;
                }
                Team t = new Team(team, user);
                teams.Add(t);
                Console.WriteLine($"Team {team} has been created by {user}!");
            }
            string command = Console.ReadLine();
            while (command != "end of assignment")
            {
                string[] input = command.Split(new String[] { "->" }, StringSplitOptions.None);
                string user = input[0];
                string teamName = input[1];
                if (!teams.Any(t => t.Name == teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                else if (teams.Any(t => t.Members.Contains(user)) || teams.Any(t => t.Creator == user))
                {
                    Console.WriteLine($"Member {user} cannot join team {teamName}!");
                }
                else
                {
                    Team team = teams.Find(t => t.Name == teamName);
                    team.Members.Add(user);
                }
                if (command == "end of assignment")
                {
                    break;
                }
                command = Console.ReadLine();
            }
            var disband = teams.Where(t => t.Members.Count == 0).OrderBy(t => t.Name).ToList();
            teams.RemoveAll(t => t.Members.Count == 0);
            teams = teams.OrderByDescending(t => t.Members.Count).ThenBy(t => t.Name).ToList();
            foreach (var team in teams)
            {
                Console.WriteLine($"{team.Name}");
                Console.WriteLine($"- {team.Creator}");

                foreach (var member in team.Members.OrderBy(m => m))
                {
                    Console.WriteLine($"-- {member}");
                }
            }
            Console.WriteLine("Teams to disband:");
            foreach (var team in disband)
            {
                Console.WriteLine(team.Name);
            }
        }
    }
}
