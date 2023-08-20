using System;
class Factorial
{
    static void Main(string[] args)
    {
        Console.WriteLine("***PROGRAM TO FIND THE FACTORIAL\n");
        Console.WriteLine("Enter The Number: ");
        int n=Convert.ToInt32(Console.ReadLine());
        int factorial = 1;
        for (int i = 1; i <=n; i++)
        {
            if (n == 1)
            {
                break;
            }
            factorial = factorial * i;
        }
        Console.WriteLine("Factorial Of A number Is :"+factorial);
        

    }
}