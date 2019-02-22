Using System;
public class ForEach2
{
   public static void Main()
   {
      // variables new data strcut
      var names = new List<string>() { "John", "Tom", "Peter" };
      // iterate through the names 
      foreach (string name in names)
      {
       // print the string in the array list 
        Console.WriteLine(name);
      }
  } // end of the program 
   //mote info 
}
