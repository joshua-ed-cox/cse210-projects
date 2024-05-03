public class Resume
{
    public string _name;
    public List<Job> _joblist = new List<Job>();

    //defualt constructor
    public Resume()
    {
        _name = "John Doe";
    }

    //parameter constructor
       public Resume(string name)
    {
        _name = name; // Initialize with custom name
    }


    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        foreach (Job job in _joblist)
        {
            job.Display();
        }
        
    }
}