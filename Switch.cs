// switch functions
public class Switch
{
   public static void Main()
   {
      // set the condition with int i
    int i = 1;
    switch (i)
    {
      case 1:
          // first case
        Console.WriteLine("One");
          // breqk
        break;
      case 2:
        Console.WriteLine("Two");
          // print the second line
        Console.WriteLine("Two");
          // break
        break;
          // final before break
      default:
        Console.WriteLine("Other");
          // break
        break;
      }
   }
}// end of program 
