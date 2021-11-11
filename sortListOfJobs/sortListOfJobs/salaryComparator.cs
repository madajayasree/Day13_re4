using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortListOfJobs
{
    class salaryComparator : IComparer<job>
    {
        

            public int Compare(job x, job y)
            {
                return x.Sal.CompareTo(y.Sal);
            }
        
    }
}
