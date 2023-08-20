using System;
namespace ReverseArray;
class ReverseArray
{
    static void Main(string[] args)
    {
        int[] a = { 1, 2, 3, 4, 5 };
        Console.WriteLine("Before Reversing The Array Elements are:");

        for (int i = 0; i < a.Length; i++)
        {
            Console.Write(a[i] + "\t");
        }

        Reverse(a);

        Console.WriteLine("\n\nAfter Reversing the array elements are:");
        for (int i = 0; i < a.Length; i++)
        {
            Console.Write(a[i] + "\t");
        }
               
    }
    static void Reverse(int[] a) 
    {
        int temp; int i = 0; int j = a.Length - 1;
        while (i < j)
        {
            temp = a[i];
            a[i] = a[j];
            a[j] = temp;
            i++;
            j--;
        }
    }
}