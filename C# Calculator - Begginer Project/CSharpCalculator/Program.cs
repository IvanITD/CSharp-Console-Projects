// variables for later user
double firstNumber = 0;
double secondNumber = 0;
double result = 0.0;
string operation = "";
bool isValidStartKey;
bool isValidOperator;
bool isValidEndKey;
bool exitingProgram;
bool isValidFirstNumber;
bool isValidSecondNumber;

// Greeting the user
Console.WriteLine("\nHello, User!");
Console.WriteLine("\nWelcome to my first calculator!");
Console.WriteLine("\nPress ENTER to continue.");

//Checking whether the user pressed the ENTER key
isValidStartKey = false;

while (!isValidStartKey)
{
    // Pressing Enter to continue
    ConsoleKeyInfo keyStartButton = Console.ReadKey(intercept: true);

    // Check if the user pressed the ENTER key
    if (keyStartButton.Key == ConsoleKey.Enter)
    {
        // The user correctly pressed the ENTER key
        isValidStartKey = true;
    }
    else if (keyStartButton.Key == ConsoleKey.Spacebar)
    {
        // The user correctly pressed the SPACEBAR key
        Console.WriteLine("That works too! XD XD");
        isValidStartKey = true;
    }
    else
    {
        // The user did not press the ENTER key
        Console.WriteLine("Invalid key. Please press ENTER to continue.");
        Console.Write("\n");
    }

}

exitingProgram = false;
// Repeating the program until the user wants to exit
while (!exitingProgram)
{
    // Asking the user to enter the first number
    Console.WriteLine("\nPlease enter the first number: ");

    // Check whether the user entered only a number
    isValidFirstNumber = false;
    while(!isValidFirstNumber)
    {
        string number1 = Console.ReadLine();

        if (double.TryParse(number1, out firstNumber))
        {
            isValidFirstNumber = true; // Valid input, exit the loop
        }
        else
        {
            // Inform the user that the input is invalid
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }

    // Asking the user to enter the second number
    Console.WriteLine("\nPlease enter the second number: ");

    // Check whether the user entered only a number
    isValidSecondNumber = false;
    while (!isValidSecondNumber)
    {
        string number2 = Console.ReadLine();

        if (double.TryParse(number2, out secondNumber))
        {
            isValidSecondNumber = true; // Valid input, exit the loop
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }


    // Asking the user to choose what type of operation they want to perform
    Console.WriteLine("What type of operation would you like to perform?");
    Console.WriteLine("Please enter the number of the operation you would like to perform:");
    Console.WriteLine("*    Press 1 for addition ==>> (+)"); // Addition
    Console.WriteLine("*    Press 2 for substraction ==>> (-)"); // Substraction
    Console.WriteLine("*    Press 3 for multiplication ==>> (*)"); // Multiplication
    Console.WriteLine("*    Press 4 for division ==>> (/)"); // Division
    Console.WriteLine("*    Press 5 for modulo ==>> (%)"); // Modulo

    isValidOperator = false;

    while (!isValidOperator)
    {
        // Creating the variable for the user input
        ConsoleKeyInfo keyOperator = Console.ReadKey(intercept: true);

        if (keyOperator.Key == ConsoleKey.D1 || keyOperator.Key == ConsoleKey.Add || keyOperator.KeyChar == '+')
        {
            operation = "+";
            result = firstNumber + secondNumber;
            isValidOperator = true;
        }
        else if (keyOperator.Key == ConsoleKey.D2 || keyOperator.Key == ConsoleKey.Subtract || keyOperator.KeyChar == '-')
        {
            operation = "-";
            result = firstNumber - secondNumber;
            isValidOperator = true;
        }
        else if (keyOperator.Key == ConsoleKey.D3 || keyOperator.Key == ConsoleKey.Multiply || keyOperator.KeyChar == '*')
        {
            operation = "*";
            result = firstNumber * secondNumber;
            isValidOperator = true;
        }
        else if (keyOperator.Key == ConsoleKey.D4 || keyOperator.Key == ConsoleKey.Divide || keyOperator.KeyChar == '/')
        {
            if (secondNumber == 0)
            {
                Console.WriteLine("Division by zero is not allowed. Please enter a valid second number.");
                isValidOperator = false;
            }
            else
            {
                operation = "/";
                result = firstNumber / secondNumber;
                isValidOperator = true;
            }

        }
        else if (keyOperator.Key == ConsoleKey.D5 || keyOperator.KeyChar == '%')
        {

            if (secondNumber == 0)
            {
                Console.WriteLine("Modulo by zero is not allowed. Please enter a valid second number.");
                isValidOperator = false;
            }
            else
            {
                operation = "%";
                result = firstNumber % secondNumber;
                isValidOperator = true;
            }
        }
        else
        {
            // If the user input is not valid, ask the user to enter a valid operator
            Console.WriteLine("Invalid operator. Please enter a valid operator.");
            isValidOperator = false;
        }

        //isValidOperator = false;
    }

    // Printing the result to the user
    Console.Write("\nCALULATING....");
    Console.Write($" {firstNumber} {operation} {secondNumber} = {result}");
    Console.WriteLine("\n");
    // Telling the user to press ENTER to perform another operation ESC to exit the program
    Console.WriteLine("If you would like to perform another operation, please press ENTER.");
    Console.WriteLine("Or");
    Console.WriteLine("If you would like to exit the program, please press ESC.");


    // Creating a while loop to check if the user pressed either the ENTER or ESC key
    isValidEndKey = false;
    while (!isValidEndKey)
    {
        // Waiting for the user to press a key
        ConsoleKeyInfo keyEndButton = Console.ReadKey(intercept: true); // The 'true' prevents the key from being displayed.

        // Check if the user pressed the ESC key
        if (keyEndButton.Key == ConsoleKey.Enter)
        {
            // Clearing the console
            Console.Clear(); // This command clears the console.

            // The user correctly pressed the ENTER key
            isValidEndKey = true;
        }
        else if (keyEndButton.Key == ConsoleKey.Spacebar)
        {
            // Clearing the console
            Console.Clear(); // This command clears the console.
            Console.WriteLine("That SPACEBAR seems to always work! XD XD");

            // The user correctly pressed the SPACEBAR key, end made a joke out of it!!! XD XD
            isValidEndKey = true;
        }
        else if (keyEndButton.Key == ConsoleKey.Escape)
        {
            // Clearing the console
            Console.Clear();

            // Exiting the program
            Console.WriteLine("\nExiting the program...");
            Console.WriteLine("\nThank you for using my calculator! Have a great day!\n");
            isValidEndKey = true;
            exitingProgram = true;
        }
        else
        {
            // Informing the user that they pressed an invalid key
            Console.WriteLine("Invalid key. Please press either the ENTER or ESC key.");
        }
    }
}