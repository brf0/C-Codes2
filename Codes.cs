
namespace Calculator;

internal class Codes
{
    
     public void CheckPrime1(uint number)
     {
         bool isPrime = true;
         if (number <= 1)
            isPrime = false;
         else
         {
             for (uint i = 2; i <= Math.Sqrt(number); i++)
             {
                 if (number % i == 0)
                 {
                        isPrime = false;
                        break;
                 }
             }
         }

         if (isPrime)
            Console.WriteLine($"{number} is a Prime number.");
         else
            Console.WriteLine($"{number} is not a Prime number.");
     }

    
    public void CheckPrime2(uint number)
    {

        if (IsPrime(number))
            Console.WriteLine($"{number} is a Prime Number");
        else
            Console.WriteLine($"{number} is not a Prime Number");
    }

    static bool IsPrime(uint number)
    {
        if (number <= 1)
            return false;

        for (uint i = 2; i <= number / 2; i++)
        {
            if (number % i == 0)
                return false;
        }

        return true;
    }

    
    public void CheckMirror1(uint Number)
    {

        string original = Number.ToString();
        string reversed = new string(original.Reverse().ToArray());

        if (original == reversed)
            Console.WriteLine($"{Number} is a Mirror Number.");
        else
            Console.WriteLine($"{Number} is not a Mirror Number.");
    }

    
    public void CheckMirror2(uint Number)
    {
        uint reverse = 0, temp = Number;

        while (temp > 0)
        {
            uint remainder = temp % 10;
            reverse = reverse * 10 + remainder;
            temp /= 10;
        }

        if (Number == reverse)
            Console.WriteLine($"{Number} is a Mirror number.");
        else
            Console.WriteLine($"{Number} is not a Mirror number.");
    }
}

