using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace searchListOfJobs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of jobs:");
            int jobCount;
            jobCount = Convert.ToInt32(Console.ReadLine());
            
            List<job> obj_job = new List<job>();
            for(int i = 0; i< jobCount; i++)
            {
                string job = Console.ReadLine();
                string[] job_details = job.Split(',');
                job objjob = new job(job_details[0], job_details[1], job_details[2], job_details[3], int.Parse(job_details[4]), double.Parse(job_details[5]));
                obj_job.Add(objjob);
            }


            /*foreach (var item in obj_job)
            {
                Console.WriteLine(item);

            }*/

            Console.WriteLine("Enter a search type \n 1: By salary 2: By Location");
            int choice = int.Parse(Console.ReadLine());
            
           JobBO jbo = new JobBO();
            List<job> jobSearch = new List<job>();

            switch (choice)
            {
                case 1:

                    Console.WriteLine("Sorting by salary");
                    Console.WriteLine("enter salary");
                    jobSearch = jbo.findJobBySal(obj_job, Convert.ToDouble(Console.ReadLine()));
                 
                    break;

                case 2:
                   Console.WriteLine("Sorting by Location");
                     Console.WriteLine("enter Locaion");
                    jobSearch = jbo.findJobByLoc(obj_job, Console.ReadLine());
                    break;

                 default:
                    Console.WriteLine("Invalid choice");
                    break;
            }

            

                foreach (var item in jobSearch)
                {
                    Console.WriteLine(item);
                }
            }




        }
    }

