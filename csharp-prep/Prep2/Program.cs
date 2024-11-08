using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        // Asking user for their grade latter and printing it out
        Console.Write("What is your grade percent? ");
        // colect the grade percent
        string userGradeletter = Console.ReadLine();
        // convert it to int
        int UserPercent = int.Parse(userGradeletter);
        // create a emtpy varable to collect letter graade 
        string leTter = "";
         // create a emtpy varable to collect sign grade graade
        string leTtersiGn = "";
        // get the last digit of the user percentage
        int remder = UserPercent % 10;
        
        // write conditional statement to dettermine if the user have + sign or -
        if(remder >=7){
          leTtersiGn = "+";

        }
        else if (remder < 3)
        {
           leTtersiGn = "-";
        }
        else if (remder == 0){
           leTtersiGn = "";
        }

        if (UserPercent >=97 || UserPercent <60){
           leTtersiGn = "";

        }

        // write conditional statement to dettermine if the user pass
       if (UserPercent >= 90) 
        {
            leTter = "A";
            
        }
       else if (UserPercent >= 80) 
        {
            leTter = "B";
            
        }

       else if (UserPercent >= 70) 
        {
          leTter = "C";
            
        }

      else if (UserPercent >= 60) 
        {
          leTter = "D";
            
        }

    else{
       leTter = "F";
    }
    // sending user a message to thank them

    Console.WriteLine($"{leTter}{leTtersiGn}");
    
     if (UserPercent >= 70) 
        {
            Console.WriteLine("Congratulation! You pass.");

        }
            
      
       
      else{
                Console.WriteLine("You fail try again next semeter");
            }
        

    }
}