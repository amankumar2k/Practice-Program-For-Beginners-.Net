using System;

class GradePercentage
{
    static void Main(string[] args)
    {
        Console.WriteLine("***Program To Calculate The Grade Based On Percentage***\n");
        Console.WriteLine("Enter the Percentage To Know The Grade");
        double  Percentage = Convert.ToInt32(Console.ReadLine());
        switch (Percentage)
        {
            case >= 90:
                Console.WriteLine("Your Grade Is : A+ ");
                break;

            case >= 80:
                Console.WriteLine("Your Grade Is : A ");
                break;

            case >= 70:
                Console.WriteLine("Your Grade Is : B+ ");
                break;

            case >= 60:
                Console.WriteLine("Your Grade Is : B ");
                break;

            case >= 50: 
                Console.WriteLine("Your Grade Is : C+ ");
                break;

            case >= 40:
                Console.WriteLine("Your Grade Is : C");
                break;

            case <35:
                Console.WriteLine("Your Percentage Is Very Low So u Belongs To F grade");
                break;

            default:
                Console.WriteLine("Error, Invalid percentage");
                break;
        }
    }
}
