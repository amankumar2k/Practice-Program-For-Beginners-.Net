using System;
namespace calculate;
class Calculator
{
    static void Main(string[] args)
    {
        int Num_1, Num_2;
        Console.WriteLine("*** Calculator Program *** \n");
        Console.WriteLine(" Available Options : \n 1: ADDITION \n 2: SUBTRACTION \n 3: Multiplication \n 4: DIVISION \n");
        Console.WriteLine("SELECT AN OPTION FROM THE ABOVE \n");
        int Option = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter The First Number: ");
        Num_1=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Second Number: ");
        Num_2=Convert.ToInt32(Console.ReadLine());
        switch (Option)
        {
            case 1:
                 int Addition = Num_1 + Num_2;
                 Console.WriteLine(" The Addition Of Two Numbers Is: " + Addition);
                 break;
            case 2:
                 int Subtraction = Num_1 - Num_2;
                  Console.WriteLine(" The Subtraction Of Two Numbers Is: " + Subtraction);
                  break;
            case 3:
                 int Multiplication = Num_1 * Num_2;
                 Console.WriteLine(" The Multiplication Of Two Numbers Is: " + Multiplication);
                 break;
            case 4:
                 int Division = Num_1 / Num_2;
                 Console.WriteLine(" The Division Of Two Numbers Is: " + Division);
                 break;
            default:
                    Console.WriteLine("You Entered An Invalid Option So Operation Cannot Be Performed");
                    break;


        }
        
    }
}

