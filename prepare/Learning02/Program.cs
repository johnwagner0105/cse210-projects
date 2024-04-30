using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "NTT Data";
        job1._jobTitle = "Java programmer";
        job1._startYear = 2024;
        job1._endYear = 2025;

        Job job2 = new Job();
        job2._company = "Synopsys";
        job2._jobTitle = "Junior Programmer";
        job2._startYear = 2024;
        job2._endYear = 2025;

        Resume myResume = new Resume();
        myResume._name = "John";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume.Display();
    }
}