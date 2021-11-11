using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortListOfJobs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of jobs:");
            int count;
            count = Convert.ToInt32(Console.ReadLine());

            job[] job_obj = new job[count];
            for(int i=0; i < count;i++)
            {
                Console.WriteLine("Enter {0} job details separated by kamas in the format of role, skillSet,  employeementType,  location,  minExperience,  sal", i + 1);
                string jobDetails = Console.ReadLine();
                job jb = job.createJob(jobDetails);
                job_obj[i] = jb;
             
            }

            Console.WriteLine("Enter type of sort: 1: Sort by minExperience, 2: sort by salary");
            int sortBy = Convert.ToInt32(Console.ReadLine());
            switch(sortBy)
            {
                case 1:
                    Array.Sort(job_obj);
                    break;

                case 2:
                    salaryComparator sort_By_Sal = new salaryComparator();
                    Array.Sort(job_obj, sort_By_Sal);
                    break;
                        
            }
                             
                          

            foreach (var item in job_obj)
            {
                Console.WriteLine(item);
            }
        }

        

    }
}
