using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "BYU-Idaho";
        job1._jobTitle = "Teacher";
        job1._startYear = 2002;
        job1._endYear = 2023;
        // job1.Display();

        Job job2 = new Job();
        job2._company = "BYU-Hawaii";
        job2._jobTitle = "Professor";
        job2._startYear = 2023;
        job2._endYear = 2023;
        // job2.Display();

        Resume resume1 = new Resume();
        resume1._name = "John Tanner";

        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.Display();
    }
}