using System;
namespace addition;
public class AddTwoNumbers
{
    static void Main(string[] args)
    {
        int Num_1, Num_2, sum;
        Console.WriteLine("**Program To Calculate Addition Of Two Numbers*** \n ");
        Console.WriteLine("Enter The First Number");
        Num_1=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter The Second Number");
        Num_2 = Convert.ToInt32(Console.ReadLine());
        sum=Num_1+Num_2;
        Console.WriteLine("*************************************");
        Console.WriteLine("The Sum Of Two Numbers Is :" + sum);
        
    }
}