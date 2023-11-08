using System;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Youth Counselor";
        job1._company = "FSY";
        job1._startYear = 2023;
        job1._endYear = 2023;

        Job job2 = new Job();
        job2._jobTitle = "Sandwich Artist";
        job2._company = "Subway";
        job2._startYear = 2022;
        job2._endYear = 2022;


        Resume myResume = new Resume();
        myResume._name = "Tanner Winward";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}