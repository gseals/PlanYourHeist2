using System;
using System.Collections.Generic;
using System.Text;

namespace PlanYourHeist2
{
    class TeamMember
    {
        private int _skillLevel;
        private double _courageFactor;

        public string Name { get; set; }

        public int SkillLevel
        {
            get
            {
                return _skillLevel;
            }
            set
            {
                if (value > 0)
                {
                    _skillLevel = value;
                }
                else
                {
                    Random rnd = new Random();
                    _skillLevel = rnd.Next(1000);
                }
            }
        }

        public double CourageFactor
        {
            get
            {
                return _courageFactor;
            }
            set
            {
                if (value >= 0.0 && value <= 2.0)
                {
                    _courageFactor = value;
                }
                else
                {
                    Random rnd2 = new Random();
                    _courageFactor = rnd2.NextDouble() * 2;
                }
            }

        }

        public TeamMember(string name, int skillLevel, double courageFactor)
        {
            Name = name;
            SkillLevel = skillLevel;
            CourageFactor = courageFactor;
        }


    }
}
