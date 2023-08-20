using System;
class PrimeNumber
{
     static bool PrimeCheck(int number)
    {
        for (int i = 2; i < number; i++)
            if (number % i == 0)
                return false;
        return true;
    }
    public static void Main()
    {
        Console.WriteLine("***PROGRAM TO CHECK A NUMBER IS PRIME OR NOT***");
        Console.Write("Enter a number : ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (PrimeCheck(number))
        {
            Console.WriteLine(number + " Is a prime number");
        }
        else
        {
            Console.WriteLine(number + " Is not a prime number");
        }
        
    }
}