using System;  
namespace Resumes{
class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._companyName = "N tech";
        job1._startYear = 2025;
        job1._applicationYear = 2024;

        Job job2=new Job();
        job2._jobTitle = "Data specialist";
        job2._companyName = "family search";
        job2._startYear= 2024;
        job2._applicationYear=2024;

        Resume myResume = new Resume();
        myResume._name = "Emmanuel Nasir";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        
        myResume.Display();
    }
}
}