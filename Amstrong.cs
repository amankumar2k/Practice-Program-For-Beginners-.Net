class Amstrong
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter The Number");
            int Number = Convert.ToInt32(Console.ReadLine());
            bool FunctionValue = IsAmstrong(Number);
            if (FunctionValue)
            {
                Console.WriteLine("The Number Is Amstrong");
            }
            else
            {
                Console.WriteLine("Not An Amstrong");
            }
        }
        catch (Exception ex)
        {
            
            Console.WriteLine(ex.Message);
        }
        
    }

    public static bool IsAmstrong(int Number)
    {
        try
        {
            int Num = Number;
            int sum = 0;
            int amst = 0;

            while (Num > 0)
            {
                //throw new Exception("Error Ocured In Amstrong Method");
                amst = Num % 10;
                sum = sum + amst * amst * amst;
                Num = Num / 10;
            }

            if (Number == sum)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Amstrong Function Error: {ex.Message}");
            return false;
        }
    }

 }