using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace searchListOfJobs
{
    class job
    {
        string role;
        string skillSet;
        string emolyementType;
        string location;
        int minExp;
        double salary;

        public job()
        {
        }

        public job(string role, string skillSet, string emolyementType, string location, int minExp, double salary)
        {
            this.Role = role;
            this.SkillSet = skillSet;
            this.emolyementType = emolyementType;
            this.Location = location;
            this.MinExp = minExp;
            this.Salary = salary;
        }

        public string Role { get => role; set => role = value; }
        public string SkillSet { get => skillSet; set => skillSet = value; }
        public string EmolyementType { get => emolyementType; set => emolyementType = value; }
        public string Location { get => location; set => location = value; }
        public int MinExp { get => minExp; set => minExp = value; }
        public double Salary { get => salary; set => salary = value; }

        public override string ToString()
        {
            return String.Format("{0,15} {1,15} {2,15} {3,15} {4,15} {5,15}", Role, SkillSet, EmolyementType, Location, MinExp, Salary );
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
