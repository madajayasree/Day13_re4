using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortListOfJobs
{
    class job : IComparable
    {
        string role;
        string skillSet;
        string employeementType;
        string location;
        int minExperience;
        double sal;

        public job()
        {
        }

        public job(string role, string skillSet, string employeementType, string location, int minExperience, double sal)
        {
            Role = role;
            SkillSet = skillSet;
            EmployeementType = employeementType;
            Location = location;
            MinExperience = minExperience;
            Sal = sal;
        }

        public string Role { get => role; set => role = value; }
        public string SkillSet { get => skillSet; set => skillSet = value; }
        public string EmployeementType { get => employeementType; set => employeementType = value; }
        public string Location { get => location; set => location = value; }
        public int MinExperience { get => minExperience; set => minExperience = value; }
        public double Sal { get => sal; set => sal = value; }

        public override string ToString()
        {
            return String.Format("{0}  {1}  {2}  {3}  {4}  {5}  ", Role, skillSet, EmployeementType, location, MinExperience, sal);
        }

        public override bool Equals(object obj)
        {
            job j = (job)obj;
            return this.MinExperience.Equals(j.MinExperience) ;

        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static job createJob(string details)
        {
            string[] s = details.Split(',');
            job jb = new job(s[0], s[1], s[2], s[3], int.Parse(s[4]), double.Parse(s[5]));
            return jb;


        }

        public int CompareTo(object obj)
        {
            job j = (job)obj;
            return this.MinExperience.CompareTo(j.MinExperience);


        }
    }
}
