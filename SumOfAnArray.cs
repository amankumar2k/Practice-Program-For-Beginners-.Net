using System;
namespace SumOfAnArray;
class SumOfAnArray
{
    static void Main(string[] args)
    {
        Console.WriteLine("***Program To Sum an Array using loop***\n");
        int[] a = { 92, 2, 34, 20, 87, 48, 71, 8 };
        int i;int SumOfAnArray=0;
        for(i=0;i<a.Length;i++)
        {
            SumOfAnArray = SumOfAnArray + a[i];
        }
        Console.WriteLine("The Sum Of th Given Array is :" + SumOfAnArray);
    }
    
}