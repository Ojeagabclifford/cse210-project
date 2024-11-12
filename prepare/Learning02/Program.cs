using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        
        Job job1 = new Job();
        job1._company ="Microsoft";
        job1._jobTitle ="Software Engineer";
        job1._startYear =2020;
        job1._endYear=2024;

        Job job2 = new Job();
        job2._company ="Apple";
        job2._jobTitle ="Manager";
        job2._startYear =2025;
        job2._endYear=2029;


        

        Resume resume = new Resume();
        resume._name ="Ojeaga B Clifford";
        resume._jobS.Add(job1);
        resume._jobS.Add(job2);

       resume.DisplayResume();
       

    }
}