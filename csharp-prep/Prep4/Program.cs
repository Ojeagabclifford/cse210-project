using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // creating a list where users can add numbers data type
        List<int> numbers = new List<int>();
        
        int userNumbers = -1;
        string cs = "";
        Console.WriteLine("Enter a list of Numbers (press 0 if you are done)");
         
        
        do
        {
             do{
                Console.Write("Enter a number: ");

                string userResposne = Console.ReadLine();
                userNumbers = int.Parse(userResposne);

                if  (userNumbers != 0){
                numbers.Add(userNumbers);
                }} while(userNumbers!=0);
            cs=Con();
            } while (cs == "yes");
         
          
        
         int sum = 0;
         int max = numbers[0];

        foreach(int number in numbers){

            sum +=number;
            if (number> max){
                max = number;
            }
            

        }

        
        float avarage = ((float)sum)/ numbers.Count;
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The avarage is: {avarage}");
        Console.WriteLine($"The max number  is: {max}");



        

        
    }

    static string Con(){
        Console.Write("do you want to continue?");
       string con =   Console.ReadLine();
     return con;
    }
}