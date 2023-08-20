using System;
class AverageArrayNumber
{
    static void Main(string[] args)
    {
        Console.WriteLine("***Program to find the Average In an Array***\n");
        int[] a = {10,2,3,5,7,1};
        int i,by=a.Length; 
        double Average;
        int Sum = 0;
        for (i = 0; i < a.Length; i++)
        {
            Sum = Sum + a[i];
        }
        Average = Sum / by;
        Console.WriteLine("The Average Of Numbers In An Array Is :"+Average);
        
    }
}
