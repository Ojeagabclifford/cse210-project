using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");
        // user fisrt name
        Console.Write("What is your first name? ");
        string fname = Console.ReadLine();
        // user last name
        Console.Write("What is your last name? ");
        string lname = Console.ReadLine();
        // print out the name to terminal
        Console.WriteLine($"Your names is {fname}, {lname} {fname}.");

        
    }
}