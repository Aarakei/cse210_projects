using System;

class Program
{
    static void Main(string[] args)
    {
        // Instantiate and initialize the first job
        Job job1 = new Job();
        job1._company = "Boston Dynamics";
        job1._jobTitle = "Embedded Systems Engineer";
        job1._startYear = 1997;
        job1._endYear = 2020;
        
        // Instantiate and initialize the second job
        Job job2 = new Job();
        job2._company = "House of Design";
        job2._jobTitle = "Integration Engineer";
        job2._startYear = 2020;
        job2._endYear = 2024;
        
        // Display both jobs
        job1.Display();
        job2.Display();
    }
}