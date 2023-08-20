using System;

class CountOccurence
{
    static void Main()
    {
        Console.WriteLine("***Program To Count The Occurance Of Character***\n");
        Console.Write("Enter a Word: ");
        string input = Console.ReadLine();

        Console.Write("\nEnter a character: ");
        char OccuranceChar = Convert.ToChar(Console.ReadLine());    

        int count = 0;
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == OccuranceChar)
            {
                count++;
            }
        }

        Console.WriteLine($"The character {OccuranceChar} In The Word, occurs {count} times.");
    }
}