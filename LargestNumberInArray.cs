using System;
namespace LargestNumberInArray;
class LargestNumberInArray
{
   static void Main(string[] args)
    {
        Console.WriteLine("Program to Find The Largest Number In Array\n");
        int[] Numbers = { 1, 20, 16, 40, 31, 38 };
        int temp = Numbers[0];
        int i;

        for (i = 1; i < Numbers.Length; i++)
        {
            if ( Numbers[i]>temp)
            {
                temp = Numbers[i];
                

            }
        }
        Console.Write("The Largest Number In An Array Is \n"+temp);
    }
        
}