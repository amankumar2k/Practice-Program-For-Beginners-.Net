using System;

class FactorialNumber
{
    public static void Main(string[] args)
    {
        Console.WriteLine("***PROGRAM TO FIND THE FACTORIAL OF A NUMBER***\n");
        Console.Write("Enter The number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        long fact = GetFactorial(number);
        Console.WriteLine("The factorial of a number is: " + fact);
    }

    static long GetFactorial(int number)
    {
        if (number == 0)
        {
            return 1;
        }

        int factorial = 1;
        for (int i = 1; i <= number; i++)
        {
            factorial *= i;
        }

        return factorial;
    }
}
