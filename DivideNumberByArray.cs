using System;
class arrays
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter The Size Of Array");
        int size=Convert.ToInt32(Console.ReadLine());
        int[] arr= new int[size];
        int i = 0;
        for(i=0; i<size; i++)
        {
            arr[i]=Convert.ToInt32(Console.ReadLine());
        }
        double div = 0;

        try
        {
            for (i = 0; i < size+1; i++) //Index Error
            {
                try
                {
                    div = 8 / arr[i]; //Divide By zero Error
                    Console.WriteLine(div);
                }
                catch (Exception ex)   //Divide By zero Error Handling
                {
                    Console.WriteLine($" Error: Is {ex.Message}");
                }
            }
        }

        catch (Exception ex) //Index Error Handling
        {
            Console.WriteLine($" Error: Is {ex.Message}");
        }

    }


}

