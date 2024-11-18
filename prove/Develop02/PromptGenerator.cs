
using System.Collections.Generic;
public class PromtGenerator
{
public List<string> _prompts= [
"Who was the most interesting person I interacted with today? ",
"What was the best part of my day? ",
"How did I see the hand of the Lord in my life today? ",
"What was the strongest emotion I felt today? ",
"If I had one thing I could do over today, what would it be?"
];
 

 





   
public string GetRamdomPrompt(){
    Random randomGenerator = new Random();
    
        int randomPromt = randomGenerator.Next(_prompts.Count);
        string nextPropt = _prompts[randomPromt];
        return nextPropt;

    
   
    
        
        

    }
        
    
   



}

