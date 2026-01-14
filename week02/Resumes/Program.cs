using System;


class Program

{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");


        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Fun Pimps";
        job1._startYear = 2020;
        job1._endYear = 2025;

        // job1.Display();

        // Console.WriteLine(job1._jobTitle);
        // Console.WriteLine(job1._company);
        // Console.WriteLine(job1._startYear);
        // Console.WriteLine(job1._endYear);

        Job job2 = new Job();
        job2._jobTitle = "Software Developer";
        job2._company = "Nintendo";
        job2._startYear = 1995;
        job2._endYear = 2020;

        // job2.Display();

        // Console.WriteLine(job2._jobTitle);
        // Console.WriteLine(job2._company);
        // Console.WriteLine(job2._startYear);
        // Console.WriteLine(job2._endYear);

        // create resume and persons name

        Resume myResume = new Resume();
        myResume._name = "James Bond";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        // Console.WriteLine(myResume._jobs[0]._jobTitle);

        myResume.Display();


    }

}
