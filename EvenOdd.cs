using System;
namespace EvenOdd;
class EvenOdd
{
    static void Main(string[] args)
    {
        Console.WriteLine("***PROGRAM TO FIND THE NUMBER IS EVEN OR ODD***\n");
        Console.WriteLine("Enter the Number Which You Want To Check EVEN OR ODD\n");
        int number=Convert.ToInt32(Console.ReadLine());
        if(number%2==0)
        {
            Console.WriteLine("The Number Is EVEN");

        }
        else
        {
            Console.WriteLine("The Number Is ODD");
        }
    }
}