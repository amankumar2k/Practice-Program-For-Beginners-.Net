using System;
class EvenNumberSum
{
    static void Main(string[] args)
    {
        Console.WriteLine("***PROGRAM TO CALCULATE THE SUM OF EVEN NUMBERS FROM 1 to 100***\n");
        int i = 1;
        int sum = 0;
        while (i <= 100)
        {

            if (i % 2 == 0)
            {
                sum = sum + i;
            }
            i++;
        }
        Console.WriteLine("The sum of even numbers from 1 to 100 is : " + sum);

    }
}