using System;
class OddNumberSum
{
    static void Main(string[] args)
    {
        Console.WriteLine("***PROGRAM TO CALCULATE THE SUM OF ODD NUMBERS FROM 1 to 100***\n");
        int i = 1;
        int sum = 0;
        while (i <= 100)
        {

            if (i % 2 != 0)
            {
                sum = sum + i;
            }
            i++;
        }
        Console.WriteLine("The sum of Odd numbers from 1 to 100 is : " + sum);

    }
}