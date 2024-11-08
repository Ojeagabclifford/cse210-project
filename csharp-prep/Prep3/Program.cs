using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        // Creating a program that help user gust the number
        // geting the user numer
        Random randomGenerator = new Random();
      
        // creating varables that i will use for my while loops
        
        string userGuses = "";
        int realNumbGuses =0;
        int count = 0;
        string gotIt ="";
        string doYes = "";

         // geting the user numer
       
        int userMagicNum = randomGenerator.Next(1, 100);
       
        // using do while loops to continue looping as long as the qustion is not get by the user
         
        while(realNumbGuses != userMagicNum || doYes =="yes")
            {
        
        
            Console.Write("What is your guess? ");
            userGuses = Console.ReadLine();
            realNumbGuses= int.Parse(userGuses);
            
                
                    if (realNumbGuses > userMagicNum)
                    {
                        Console.WriteLine("Higher");
                    }
                    else if (realNumbGuses < userMagicNum)
                    {
                        Console.WriteLine("Lower");
                    }
                    else{
                      gotIt = "You guessed it!";
                    }
            count++;
       }
        Console.WriteLine(gotIt);
        Console.WriteLine($"Your gusses count number is: {count}");
      
         

    }
}