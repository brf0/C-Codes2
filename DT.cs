
namespace Calculator;

internal class DT
{
    public string DecisionTree()
    {
        //Console.BackgroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("Choose a number between 0 and 20");
        Console.WriteLine();
        Console.WriteLine("Is your number less than or equal to 10?");
        string qa = "";
        bool IsContinue = true;

        Keyboard key = new Keyboard();

        do
        {
           
            qa += Keyboard.GetYesOrNo().ToString().ToLower();

            switch (qa)
            {
                case "y":
                    Console.WriteLine("Is your number less than or equal to 5?");
                    break;
                case "yy":
                    Console.WriteLine("Is your number less than or equal to 2?");
                    break;
                case "yyy":
                    Console.WriteLine("Is your number less than or equal to 1?");
                    break;
                case "yyyy":
                    Console.WriteLine("Is your number = 1?");
                    break;
                case "yyyyy":
                    Console.WriteLine("your number = 1");
                    IsContinue = false;
                    break;
                case "yyyyn":
                    Console.WriteLine("your number = 0");
                    IsContinue = false;
                    break;
                case "yyyn":
                    Console.WriteLine("your number = 2");
                    IsContinue = false;
                    break;
                case "yyn":
                    Console.WriteLine("Is your number less than or equal to 4?");
                    break;
                case "yynn":
                    Console.WriteLine("your number = 5");
                    IsContinue = false;
                    break;
                case "yyny":
                    Console.WriteLine("Is your number less than or equal to 3?");
                    break;
                case "yynyy":
                    Console.WriteLine("your number = 3");
                    IsContinue = false;
                    break;
                case "yynyn":
                    Console.WriteLine("your number = 4");
                    IsContinue = false;
                    break;
                case "yn":
                    Console.WriteLine("Is your number less than or equal to 7?");
                    break;
                case "yny":
                    Console.WriteLine("Is your number = 6?");
                    break;
                case "ynyy":
                    Console.WriteLine("your number = 6");
                    IsContinue = false;
                    break;
                case "ynyn":
                    Console.WriteLine("your number = 7");
                    IsContinue = false;
                    break;
                case "ynn":
                    Console.WriteLine("Is your number less than or equal to 9?");
                    break;
                case "ynny":
                    Console.WriteLine("Is your number = 8?");
                    break;
                case "ynnyy":
                    Console.WriteLine("your number = 8");
                    IsContinue = false;
                    break;
                case "ynnyn":
                    Console.WriteLine("your number = 9");
                    IsContinue = false;
                    break;
                case "ynnn":
                    Console.WriteLine("your number = 10");
                    IsContinue = false;
                    break;
                case "n":
                    Console.WriteLine("Is your number less than or equal to 15?");
                    break;
                case "ny":
                    Console.WriteLine("Is your number less than or equal to 13?");
                    break;
                case "nyy":
                    Console.WriteLine("Is your number less than or equal to 12?");
                    break;
                case "nyyy":
                    Console.WriteLine("Is your number = 11?");
                    break;
                case "nyyyy":
                    Console.WriteLine("your number = 11");
                    IsContinue = false;
                    break;
                case "nyyyn":
                    Console.WriteLine("your number = 12");
                    IsContinue = false;
                    break;
                case "nyyn":
                    Console.WriteLine("your number = 13");
                    IsContinue = false;
                    break;
                case "nyn":
                    Console.WriteLine("Is your number = 14?");
                    break;
                case "nynn":
                    Console.WriteLine("your number = 15");
                    IsContinue = false;
                    break;
                case "nyny":
                    Console.WriteLine("your number = 14");
                    IsContinue = false;
                    break;
                case "nn":
                    Console.WriteLine("Is your number less than or equal to 18?");
                    break;
                case "nny":
                    Console.WriteLine("Is your number less than or equal to 17?");
                    break;
                case "nnyn":
                    Console.WriteLine("your number = 18");
                    IsContinue = false;
                    break;
                case "nnyy":
                    Console.WriteLine("Is your number = 17?");
                    break;
                case "nnyyy":
                    Console.WriteLine("your number = 17");
                    IsContinue = false;
                    break;
                case "nnyyn":
                    Console.WriteLine("your number = 16");
                    IsContinue = false;
                    break;
                case "nnn":
                    Console.WriteLine("Is your number = 19?");
                    break;
                case "nnny":
                    Console.WriteLine("your number = 19");
                    IsContinue = false;
                    break;
                case "nnnn":
                    Console.WriteLine("your number = 20");
                    IsContinue = false;
                    break;
                default:
                    throw new Exception();
            }

        } while (IsContinue);
        Console.WriteLine();
        Console.WriteLine("The End!");
        return qa;

    }
}

