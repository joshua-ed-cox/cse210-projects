using System;

class Program
{
    static void Main(string[] args)
    {
        // Create instances of the Job class
        Job job1 = new Job("Software Engineer", "Amazon", 2019, 2022);
        Job job2 = new Job("Manager", "Microsoft", 2022, 2023);

        //Create an instance of the Resume class
        Resume resume1 = new Resume();
        resume1._joblist.Add(job1);
        resume1._joblist.Add(job2);


        // Call the Display method on the resume instances
        resume1.Display();
    }
}