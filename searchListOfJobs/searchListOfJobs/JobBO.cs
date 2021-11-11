using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace searchListOfJobs
{
    class JobBO

    {


        public List<job> findJobBySal(List<job> jobList, Double salary)
        {
            List<job> results = new List<job>();
            foreach(var item in jobList)
            {
                if(item.Salary>= salary)
                {
                    results.Add(item);
                }
            }
            return results;

        }

        public List<job> findJobByLoc(List<job> jobList, string location)
        {
            List<job> results = new List<job>();
            foreach (var item in jobList)
            {
                if (item.Location == location)
                {
                    results.Add(item);
                }
            }
            return results;
        }


    }
}
