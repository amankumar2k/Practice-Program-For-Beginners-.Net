using System;
class SecondLargestNumber
{
    static void Main(string[] args)
    {
        Console.WriteLine("***Program To Find The Second Largest Number In an Array***\n");
        int[] a = { 1, 2, 3, 4, 5,6 };
        int temp;
        for (int i = 0; i < a.Length; i++)
        {
            for (int j = i + 1; j < a.Length; j++)
            {
                if (a[i] < a[j])
                {
                    temp = a[i];
                    a[i] = a[j];
                    a[j] = temp;
                }
            }

            
        }
        Console.WriteLine("Second Largest Element in an array element is:" + a[1]);
        

    }
}