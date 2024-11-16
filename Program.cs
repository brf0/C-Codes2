using Calculator;

Console.WriteLine("Which program do you want?");
Console.WriteLine("A. Prime Number");
Console.WriteLine("B. Mirror Number");
Console.WriteLine("C. DT");
Console.WriteLine();
Console.Write("your choice: ");
char answer = Keyboard.GetHomeControl();

Console.Clear();

    switch (answer.ToString().ToUpper())
    {
        case "A":
            Console.Write("enter a number:");
            uint number = Keyboard.GetValidNumber();
            Codes codes = new Codes();

            if (number <= 1000)
            {
                codes.CheckPrime2(number);
            }
            else
            {
                codes.CheckPrime1(number);
            }
            break;

        case "B":
            Console.Write("enter a number:");
            uint Number = Keyboard.GetValidNumber();
            Codes code = new Codes();

            if (Number <= 1000)
            {
                code.CheckMirror1(Number);
            }
            else
            {
                code.CheckMirror2(Number);
            }
            break;

        case "C":
            DT yesorno = new DT();
            yesorno.DecisionTree();
            break;
        default:
            Console.WriteLine("error");
            break;
    }
