using System;

class PositiveAverageNumber
{
    static void Main(string[] args)
    {
        Console.WriteLine("***Program to find the Average of positive number In an Array***\n");
        int[] a = { 10, -1, -5, -8, 2, 3, 5, 7, 1 };
        int i, positiveCount = 0;
        double average;
        int sum = 0;

        for (i = 0; i < a.Length; i++)
        {
            if (a[i] > 0)
            {
                sum =sum + a[i];
                positiveCount++;
            }
        }
        average = sum / positiveCount;
        Console.WriteLine("The Average of positive Numbers In The Array Is: " + average);
    }
}
