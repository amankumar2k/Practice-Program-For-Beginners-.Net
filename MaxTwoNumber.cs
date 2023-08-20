using System;
namespace MaxTwoNumber;
class MaxTwoNumber
{
    static void Main(string[] args)
    {
        Console.WriteLine("***PROGRAM TO FIND THE MAXIMUM OF TWO NUMBERS***\n");
        int n1,n2;
        n1 = 10; n2 = 20;
        if (n1 > n2)
        {
            Console.Write(" The Maximum Number Among Two Number Is: "+n1);
        }
        else
        {
            Console.WriteLine(" The Maximum Number Is " + n2);
        }

    }
}