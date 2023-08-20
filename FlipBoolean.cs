using System;
namespace flop;
class FlipBollean
{
    static void Main(string[] args)
    {
        bool a;
        bool IsRaining = true;
        bool NotRaining = false;
        Console.WriteLine("***BEFORE FLIP***\n");
        Console.Write("IsRaining is: " + IsRaining);
        Console.Write("\nNotRaining is:" + NotRaining);
        Console.Write("\n\n");
        a = IsRaining;
        IsRaining = NotRaining;
        NotRaining = a;
        Console.WriteLine("***AFTER FLIP***\n");
        Console.Write("IsRaining is: " +IsRaining );
        Console.Write("\nNotRaining is:" +NotRaining);


    }
}