using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");
        DisplayWelcome();
        string userName = PromptUserName();
       int UserNumber =  PromptUserNumber();

       int sqrNumber = SquareNumber(UserNumber);
       DisplayResult(userName,sqrNumber);
    }
    static void DisplayWelcome(){
        Console.WriteLine("Welcome to the Program!");

    }
    static string PromptUserName(){
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        
        return name;
    }

    static int PromptUserNumber(){
         Console.Write("Please enter your favorite number: ");
         string Number = Console.ReadLine();
         int FavNumber = int.Parse(Number);
         return FavNumber;
    }
    static int SquareNumber( int numbers){
       int squr = numbers* numbers;
       return squr;

    }
    static void DisplayResult(string name, int sqr){
        Console.WriteLine($"{name},the square of your number is {sqr}");
    }
}