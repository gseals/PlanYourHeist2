using System;
using System.Security.Cryptography.X509Certificates;

namespace PlanYourHeist2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan your heist!");
            Console.ReadLine();
            Console.WriteLine("Enter your first tea member's name.");
            var burglarName = Console.ReadLine();

            Console.WriteLine($"{burglarName}. Good choice. Now, what is {burglarName}'s skill level? This number cannot be negative. Otherwise, this value will be randomly assigned.");
            var skill = Console.ReadLine();
            var numSkill = Int32.Parse(skill);

            Console.WriteLine($"Next, what is {burglarName}'s courage factor? This number must be between 0.0 and 2.0. Otherwise, it will be randomly assigned.");
            var courage = Console.ReadLine();
            var numCourage = Convert.ToDouble(courage);

            var wholeMember = new TeamMember(burglarName, numSkill, numCourage);

            Console.WriteLine($"Your team member, {burglarName}, has a skill level of {numSkill} {wholeMember.SkillLevel} and a courage factor of {numCourage} {wholeMember.CourageFactor}");
            Console.ReadLine();
        }
    }
}
