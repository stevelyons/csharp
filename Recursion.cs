// C# example of recursion
using System;
class Recursion
{
    // main function
    public static void Main()
{
    // intialize the integer variables number and result 
    int num, result;
    // create new pro object 
    pro pg = new pro();
    // prompt the user to enter a number
    Console.WriteLine("Enter the Number : ");
    // get result 
    num=int.Parse(Console.ReadLine());
        // Get the result 
    result =pg.sum(num);
        // print
    Console.WriteLine("Sum of Digits in {0} is {1}", num, // read line
// read in the last line
Console.ReadLine();
}
}
class pro
{
// define the function 
    public int sum(int num)
    {
        if (num != 0)
        {
            // iterate through shd gey rhe remainder
            return (num % 10 + sum(num / 10));
        }
// is number does equal zero 
        else
        {
            //whenndone tetuen 0
            return 0;
            //return if invalid
        }
    }// end of the program
}
