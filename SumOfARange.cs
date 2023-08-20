using System;
namespace SumOfARange;
class SumOfARange
{
    static void Main(string[] args)
    {
        Console.WriteLine("***PROGRAM TO CALCULATE THE SUM OF NUMBERS FROM 1 TO 100\n");
        int sum_of_Range = 0;
        int i;
        for (i=0; i <= 100; i++)
        {
            sum_of_Range = sum_of_Range+i;
        }
        Console.WriteLine(sum_of_Range);
        
    }
}