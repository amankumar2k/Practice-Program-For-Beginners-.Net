using System;
namespace MinTwoNumber;
class MinTwoNumber
{
    static void Main(string[] args)
    {
        Console.WriteLine("***PROGRAM TO FIND THE MINIMUM OF TWO NUMBERS***\n");
        int n1,n2;
        n1 = 10; n2 = 20;
        if (n1 < n2)
        {
            Console.Write(" The Minimum Number Number Is: "+n1);
        }
        else
        {
            Console.WriteLine(" The Minimum Number Number Is " + n2);
        }

    }
}