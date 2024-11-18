using System;

using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        // To exceed requirements i add a new varriable called income to track down the income of the user in each day  and i added conditional statement that will also display no if the user did not earn income.

Console.WriteLine("Hello Develop02 World!");

DateTime dateTimeNow = DateTime.Now;
string dateTime = dateTimeNow.ToShortDateString();



int userEntrys = 0;
// string promts = "";
// string userResposne = "";
 

 Journal journal = new Journal();
 
PromtGenerator promtGenerator = new PromtGenerator();
// promts = promtGenerator.GetRamdomPrompt();
//  Entry entry = new Entry();
//  entry. = dateTime;
string income = "";




while (userEntrys != 5)
{
    Console.WriteLine("Please select one of the following");
    Console.WriteLine("1.Do you want to Write in your journal?");
    Console.WriteLine("2.Do you want to Display Your Journal");
    Console.WriteLine("3.Do you want to Load Your Journal");
    Console.WriteLine("4.Do you want to Save Your Journal");
    Console.WriteLine("5.Do you want to quit");
    Console.Write("What will you like to do today? ");
    string userEntry = Console.ReadLine();
    userEntrys = int.Parse(userEntry);

    if (userEntrys == 1)
    {

        // PromtGenerator promtGenerator = new PromtGenerator();
        string promts = promtGenerator.GetRamdomPrompt();
        
        Console.WriteLine(promts);
    
        string userResposne = Console.ReadLine();
        Console.Write("Do youR earn any income today?");
         income = Console.ReadLine();

          // To exceed requirements i add a new varriable called income to track down the income of the user in each day  and i added conditional statement that will also display no if the user did not earn income.
        
        if (income.ToLower() =="yes"){
            Console.WriteLine("How much is the income?");
            income = Console.ReadLine();
        
        }
        else if (income.ToUpper() == "no"){
            income = null;
        }
        else{
            Console.WriteLine("please you enter the wrong answer");
        }
        // entry._promptText= promts;
        // entry._entryText = userResposne;
        Entry entry = new Entry();
        entry._date= dateTime;
        entry._promptText =promts;
        entry._entryText =userResposne;
        entry._income = income;
        journal.AddEntry(new Entry{_date = dateTime, _promptText =promts, _entryText= userResposne , _income = income});
 
    }


    else if (userEntrys == 2)
    {
        journal.DisplayAll();
    }

    else if (userEntrys == 3){
        
        Console.WriteLine("what will your call filename:");
        string filename = Console.ReadLine();
        journal.LoadFromFile(filename);
    }

    else if (userEntrys == 4){
        Console.WriteLine("Which file do you want to Save:");
        string filename = Console.ReadLine();
        journal.SaveToFile(filename);
    }
    else if (userEntrys == 5){
        userEntrys = 5;
    }

    else{
        Console.WriteLine("invild options");
    }
      

    

    
 
}}}
