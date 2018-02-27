class ForEach
{
  static void Main(string[] args)
  {            
    // create instance of array list
    ArrayList list = new ArrayList();
    list.Add("John Doe");
    list.Add("Jane Doe");
    list.Add("Someone Else");
            
    foreach(string name in list)
    {
      Console.WriteLine(name);
    }
    Console.ReadLine();
  }
  // end of the program
