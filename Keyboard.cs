
using System.Formats.Asn1;

namespace Calculator;

internal class Keyboard : DT
{
    public static char GetYesOrNo()
    {

        char key;
        do
        {
            key = Console.ReadKey(true).KeyChar;
        } while (key != 'y' && key != 'n' && key != 'Y' && key != 'N');

        return key;
    }
    
    public static char GetHomeControl() 
    {
        char key;
        do
        {
            key = Console.ReadKey(true).KeyChar;
        } while (key != 'a' && key != 'b' && key != 'c' && key != 'A' && key != 'B' && key != 'C');
        return key;
    }
    
    public static uint GetValidNumber()
    {
        string input = string.Empty;
        
        while (true) 
        {
            var key = Console.ReadKey(true);
            if (char.IsAsciiDigit(key.KeyChar))
            {
                Console.Write(key.KeyChar);
                input += key.KeyChar;
            }
            else if (key.Key == ConsoleKey.Enter)
            {
                    Console.WriteLine();
                    if (!string.IsNullOrEmpty(input))
                    {
                        return uint.Parse(input);
                    }
            }
        }       
    }
}

