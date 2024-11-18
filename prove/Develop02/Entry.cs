using System.Security.Cryptography.X509Certificates;

public class Entry
{
  public string _date;
  public string _promptText;
  public string _entryText;
  public string _income;

  // public void setDate(string date){
  //   _date = date;
  // }

  // public void setPromptText(string promptText){
  //   _promptText = promptText;

  // }
  //   public void setEntryText(string entryText){
  //   _entryText = entryText;

  // }



  // public string Tofile(){
  //   //  DateTime dateTimeNow = DateTime.Now;
  //   // _date = dateTimeNow.ToShortDateString();
    
  //   return $"{_date}~~{_promptText}~~{_entryText}";

  // }

  public void Display(){
     Console.WriteLine($"{_date}:~~{_promptText}:~~{_entryText}:~~You Income:{_income}");
  }

}