using System;
namespace Reminder;
class ReminderToNumber
{
    static void Main(string[] args)
    {
        Console.WriteLine("***Program To Find the Reminder of Two Number***\n");
        Console.WriteLine("Enter the 1st Number: ");
        int Val_1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the 2nd Number: ");
        int Val_2 = Convert.ToInt32(Console.ReadLine());
        int Reminder = Val_1 % Val_2;
        Console.Write("The Reminder is: " + Reminder);
        
    }
}
