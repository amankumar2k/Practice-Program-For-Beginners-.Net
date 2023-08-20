using System;
namespace PostiveNegative;
class PostiveNegative
{
    static void Main(string[] args)
    {
        Console.WriteLine("PROGRAM TO FIND THE ENTERED NUMBER IS POSITIVE OR NEGATIVE\n");
        Console.WriteLine("Enter The NUMBER: ");
        decimal n=Convert.ToDecimal(Console.ReadLine());
        if (n>0)
        {
            Console.WriteLine("The Number is Positive");
        }
        else if (n<0) 
        {
            Console.WriteLine("The Number is Negative");

        }
        else 
        {
            Console.WriteLine("The Entered Number Is Zero");
        }
        
    }
}