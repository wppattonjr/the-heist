using System;
using System.Collections.Generic;

namespace TheHeist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist!");
            Console.WriteLine("What is the difficulty level of the bank that you wish to rob?");

            var difficulty = int.Parse(Console.ReadLine());

            var theTeam = new List<TeamMember> { };

            bool leftEmpty = true;

            while (leftEmpty)
            {
                Console.WriteLine("Enter a team member name");
                var teamMemberName = Console.ReadLine();

                if (String.IsNullOrEmpty(teamMemberName))
                {
                    leftEmpty = false;
                    break;
                }

                Console.WriteLine("Enter team member skill level 0-100");
                var teamMemberSkill = Console.ReadLine();
                if (String.IsNullOrEmpty(teamMemberSkill))
                {
                    leftEmpty = false;
                    break;
                }
                var convertToInt = int.Parse(teamMemberSkill);

                Console.WriteLine("Enter team member courage level 0-2.0");
                var teamMemberCourage = Console.ReadLine();
                if (String.IsNullOrEmpty(teamMemberCourage))
                {
                    leftEmpty = false;
                    break;
                }
                var memberCourage = double.Parse(teamMemberCourage);

                var teamMember = new TeamMember(teamMemberName, convertToInt, memberCourage);
                theTeam.Add(teamMember);
            }
            Console.WriteLine($"There are {theTeam.Count} members on your team.");

            Console.WriteLine("How many times do you wish to run the scenario?");
            var numberOfScenarios = Console.ReadLine();
            var counter = 0;
            var success = 0;
            var fail = 0;
            while (int.Parse(numberOfScenarios) > counter)
            {
                var teamSkillLevel = 0;
                var random = new Random();
                int luck = random.Next(-10, 10);
                difficulty += luck;

                foreach (var member in theTeam)
                {
                    teamSkillLevel += member.SkillLevel;
                }

                Console.WriteLine($"The combined skill level of the team is {teamSkillLevel}");
                Console.WriteLine($"The difficulty level of the bank is {difficulty}");

                if (teamSkillLevel >= difficulty)
                {
                    Console.WriteLine("$$$$$");
                    success++;
                }
                else
                {
                    Console.WriteLine("You are still broke and a failure");
                    fail++;
                }
                counter++;
            }
            Console.WriteLine($"The bank has been robbed {success} times and you have gone to prison {fail} times.");
        }
    }
}