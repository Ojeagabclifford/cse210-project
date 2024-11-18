
using System.Collections.Generic;
using System.IO;
public class Journal{
   
    public List<Entry> _entries = new List<Entry>();
    


    public void AddEntry(Entry newEntry)
    {

        _entries.Add(newEntry);    
    }
     public void DisplayAll(){
      if (_entries.Count > 0){



      
        foreach (Entry entry in _entries){
           
          entry.Display();
        }
        
        }
        else{
          Console.WriteLine("no entry to display");

        }
        


    }



    

    public void SaveToFile(string filename ){
      
      

        using (StreamWriter output = new StreamWriter(filename)){
        //      
         
        foreach(Entry entry in _entries){
          output.WriteLine($"{entry._date}~~{entry._promptText}~~{entry._entryText}~~You Income:{entry._income}");
        
        

        }
        

        }
    }
     public void LoadFromFile(string filename){
    if (File.Exists(filename)){

    
    using (StreamReader reader = new StreamReader(filename))
    {
      string line;
      while((line =reader.ReadLine())!=null){
         string[] part = line.Split("~~");
          if(part.Length == 4){


        
          Entry entry = new Entry();
          entry._date= part[0];
          entry._promptText = part[1];
          entry._entryText =part[2];
          _entries.Add(entry);

      }

    }
    }Console.WriteLine("file hads been loaded");
    }

    
    }
    }
     