using System;
class ReverseSting
{
    static void Main(string[] args)
    {
        string Word = "Esyasoft", reverse = "";
        Console.WriteLine("Before Reversing, The String is: " + Word);
        int a=Word.Length-1;
        do
        {
            reverse = reverse + Word[a];
            a--;
        }
        while (a >= 0);
        
        Console.WriteLine("\nAfter Reversing, The string is: "+ reverse);
        
    }
}

