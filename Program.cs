namespace Calculator;

internal class Program
{
    static void Main(string[] args)
    {
        double num1 = 0;
        double num2 = 0;
        double result = 0;
        // 'num1' and 'num2' store the converted input values, 'result' is self explanatory
        // they are 0 in case user won't input anything
        // could have made it a null instead but that would be extra effort and this works well enough

        double tryDouble1;
        double tryDouble2;
        // doubles for TryParse

        Console.WriteLine("Nika's Shitty Ass Fuckin' Calculator(tm)");

        Console.Write("Input first value: ");
        string? tempNum1 = Console.ReadLine();
        // string will be what the user inputs, it will be constant during the if statement

        if (!string.IsNullOrEmpty(tempNum1))
        // will execute if 'tempNum1' *isn't* null or empty ('!' in front makes reverses the boolean from false to true and vice versa)
        {
            if (double.TryParse(tempNum1, out tryDouble1))
            // tries the output of 'tempNum1' and outputs it into 'tryDouble1'
            {
                num1 = tryDouble1;
                // if TryParse succeeds, 'num1' will inherit the value of 'tryDouble1"
            }
            else
            {
                // otherwise throw a fit and keep asking the user to input the value until it's right
                Console.WriteLine("Error: Not a Number");
                Console.Write("Input first value: ");

                while (!double.TryParse(Console.ReadLine(), out tryDouble1))
                // while the TryParse is failing, keep prompting (here's the '!' again)
                {
                    Console.WriteLine("Error: Not a Number");
                    Console.Write("Input first value: ");
                }

                num1 = tryDouble1;
                // and when the user finally gets it right, 'num1' inherits the value of 'tryDouble1'
            }

        }

        // this repeats again with the second value

        Console.Write("Input second value: ");
        string? tempNum2 = Console.ReadLine();

        if (!string.IsNullOrEmpty(tempNum2))
        {
            if (double.TryParse(tempNum2, out tryDouble2))
            {
                num2 = tryDouble2;
            }
            else
            {
                Console.WriteLine("Error: Not a Number");
                Console.Write("Input second value: ");
                while (!double.TryParse(Console.ReadLine(), out tryDouble2))
                {
                    Console.WriteLine("Error: Not a Number");
                    Console.Write("Input second value: ");
                }
                num2 = tryDouble2;
            }

        }

        Console.WriteLine("What do you want to do with these values?");
        Console.WriteLine("\t+ Addition");
        Console.WriteLine("\t- Subtraction");
        Console.WriteLine("\t* Multiplication");
        Console.WriteLine("\t/ Division");

        string? option = Console.ReadLine();
    
        bool isCorrect = false;

        //while (option != "+" || option != "-" || option != "*" || option != "/")
        do
        {
            switch (option)
            {
                case "+":
                    isCorrect = true;
                    result = num1 + num2;
                    Console.WriteLine($"Your magic number: {num1} + {num2} = " + result);
                    break;

                case "-":
                    isCorrect = true;
                    result = num1 - num2;
                    Console.WriteLine($"Your magic number: {num1} - {num2} = " + result);
                    break;

                case "*":
                    isCorrect = true;
                    result = num1 * num2;
                    Console.WriteLine($"Your magic number: {num1} * {num2} = " + result);
                    break;

                case "/":
                    isCorrect = true;
                    result = num1 / num2;
                    if (result == double.PositiveInfinity)
                    {
                        Console.WriteLine($"Error: Devide by zero exception -> {num1} / {num2}");
                    }
                    else
                    {
                        Console.WriteLine($"Your magic number: {num1} / {num2} = " + result);
                    }
                    break;
                
                default:
                    return;
            }

        } while (!isCorrect);

        Console.ReadKey();
    }
   
}


