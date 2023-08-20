using System;

class VowelString
{
    static void Main()
    {
        Console.Write("***Program To Count The Number Of Vowels*** ");
        string input = "esyasoft";

        int count = 0;
        for (int i = 0; i < input.Length; i++)
        {
            
            if (input[i] == 'a' || input[i] == 'e' || input[i] == 'i' || input[i] == 'o' || input[i] == 'u')
            {
                count++;
            }
        }

        Console.WriteLine("\n Number of vowels are: " + count);
    }
}
