using System.Numerics;
using System.Diagnostics.CodeAnalysis;

namespace SoftUni_CSharp_Fundamentals
{
    internal class Program
    {
        public class Students : IComparable<Students>
        {
            public string Name { get; set; }
            public string Surname { get; set; }
            public float Grade { get; set; }

            public Students(string name, string surname, float grade)
            {
                this.Name = name;
                this.Surname = surname;
                this.Grade = grade;
            }

            public override string ToString()
            {
                return $"{Name} {Surname}: {Grade:f2}";
            }
            public int CompareTo(Students other)
            {
                return other.Grade.CompareTo(this.Grade);
            }
        }
        static void Main(string[] args)
        {
            SortedSet<Students> students = new SortedSet<Students>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine().Split();
                Students obj = new Students(info[0], info[1], float.Parse(info[2]));
                students.Add(obj);
            }
            foreach (Students student in students)
            {
                Console.WriteLine(student.ToString());
            }
        }
    }
}
