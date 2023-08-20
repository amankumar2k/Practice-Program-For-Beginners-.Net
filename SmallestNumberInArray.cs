using System;
namespace SmallestNumberInArray;
class SmallestNumberInArray
{
   static void Main(string[] args)
    {
        Console.WriteLine("***Program to Find The Smallest Number In Array***\n");
        int[] Numbers = { 100, 20, 16, 40, 31, 38 };
        int temp = Numbers[0];
        int i;

        for (i = 1; i < Numbers.Length; i++)
        {
            if ( Numbers[i]>temp)
            {
                break;

            }
            else
            {
                temp = Numbers[i];
            }

        }
        Console.Write("The Smallest Number In An Array Is \n"+temp);
    }
        
}