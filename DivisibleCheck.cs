using System;
namespace DivisibleCheck;
class DivisibleCheck
{
    static void Main(string[] args)
    {
        Console.WriteLine("***PROGRAM TO CHECK A NUMBER IS DIVISIBLE BY ANOTHER NUMBER\n");
        int Num_1, Num_2;
        Console.WriteLine("Enter the Number");
        Num_1 =Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Number which You Will be dividing With");
        Num_2 =Convert.ToInt32(Console.ReadLine());
        if (Num_1 % Num_2 == 0)
        {
            Console.WriteLine($"The Number {Num_1} Is Divisible by  {Num_2}");
        }       
        else 
        {
            Console.WriteLine($"The Number {Num_1} Is Not Divisible by  {Num_2}");
        }

    }
}
