using System.Collections.Generic;

public class Resume{

    public string _name = "";
    public List<Job>_jobS = new List<Job>();
        

    
    public void DisplayResume(){
      

        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Jobs:");
        
        foreach (Job job in _jobS)
        {
            // This calls the Display method on each job
            job.Display();
        }
    }


}