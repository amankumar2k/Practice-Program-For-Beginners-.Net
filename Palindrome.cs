using System;
class Palindrome
{
    static void Main(string[] args)
    {
        Console.WriteLine("Program To Check The string is palindrome or Not\n");
        Console.WriteLine("Enter The String");
        string word = Console.ReadLine();
        string reverse = "";
        int length = word.Length - 1;
        while(length >= 0)
        {
            reverse = reverse + word[length];
            length--;
        }
        
        if(word==reverse)
        {
            Console.WriteLine("The String Is Palindrome");

        }
        else
        {
            Console.WriteLine("The String Is Not A Palindrome");
        }

    }
}