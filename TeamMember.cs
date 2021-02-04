
using System;
using System.Collections.Generic;
using System.Text;

namespace TheHeist
{
    class TeamMember
    {
        public string Name { get; set; }
        public int SkillLevel { get; private set; }
        public double CourageFactor { get; private set; }
        public TeamMember(string name, int skillLevel, double courageFactor)
        {
            Name = name;
            SkillLevel = skillLevel;
            CourageFactor = courageFactor;
        }

        public void ShowTeamMemberInfo()
        {
            Console.WriteLine($"Your first heist team member is  {Name}. They have a skill level of {SkillLevel} and they have a courage factor of {CourageFactor}");
        }
    }
}