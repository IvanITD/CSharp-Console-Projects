// variables for later user
double result = 0.0;
string operation = "";
bool isValidKey;
bool isValidOperator;
bool isValidNumber;
int firstNumber = 0;
int secondNumber = 0;

// Greeting the user
Console.WriteLine("\nHello, User!");
Console.WriteLine("Welcome to my first calculator!");
Console.WriteLine("Press ENTER to continue.");

//Checking whether the user pressed the ENTER key
isValidKey = false;

while (!isValidKey)
{
    // Pressing Enter to continue
    ConsoleKeyInfo keyInfo = Console.ReadKey(intercept: true);

    // Check if the user pressed the ENTER key
    if (keyInfo.Key == ConsoleKey.Enter)
    {
        // The user correctly pressed the ENTER key
        isValidKey = true;
    }
    else if (keyInfo.Key == ConsoleKey.Spacebar)
    {
        // The user correctly pressed the SPACEBAR key
        isValidKey = true;
    }
    else
    {
        // The user did not press the ENTER key
        Console.WriteLine("Invalid key. Please press ENTER to continue.");
    }

}

// Checking to see if the user didn't enter 0  while using % or / operator
isValidNumber = false;

// Creating a while loop to check if the user operator input is valid
isValidOperator = false;
while (!isValidNumber && isValidOperator || isValidOperator || isValidNumber)
{
    // Asking the user to enter the first number
    Console.WriteLine("In order to proceed, please enter the first number: ");

    // Creating the first variable and storing the user input
    firstNumber = int.Parse(Console.ReadLine());

    // Asking the user to enter the second number
    Console.WriteLine("Please enter the second number: ");

    // Creating the second variable and storing the user input
    secondNumber = int.Parse(Console.ReadLine());

    // Asking the user to choose what type of operation they want to perform
    Console.WriteLine("What type of operation would you like to perform?");
    Console.WriteLine("Please enter the number of the operation you would like to perform:");

    // Printing the options to the user
    Console.WriteLine("*    Press 1 for addition ==>> (+)"); // Addition
    Console.WriteLine("*    Press 2 for substraction ==>> (-)"); // Substraction
    Console.WriteLine("*    Press 3 for multiplication ==>> (*)"); // Multiplication
    Console.WriteLine("*    Press 4 for division ==>> (/)"); // Division
    Console.WriteLine("*    Press 5 for modulo ==>> (%)"); // Modulo



    // Creating the variable for the user input
    ConsoleKeyInfo keyOperator = Console.ReadKey(intercept: true);

    if (keyOperator.Key == ConsoleKey.D1 || keyOperator.Key == ConsoleKey.Add || keyOperator.KeyChar == '+')
    {
        operation = "+";
        // Performing the addition operation
        result = firstNumber + secondNumber;

        // Setting the isValidOperator flag to true for addition
        isValidOperator = true;
    }
    else if (keyOperator.Key == ConsoleKey.D2 || keyOperator.Key == ConsoleKey.Subtract || keyOperator.KeyChar == '-')
    {
        operation = "-";
        // Performing the substraction operation
        result = firstNumber - secondNumber;

        // Setting the isValidOperator flag to true for substraction
        isValidOperator = true;
    }
    else if (keyOperator.Key == ConsoleKey.D3 || keyOperator.Key == ConsoleKey.Multiply || keyOperator.KeyChar == '*')
    {
        operation = "*";
        // Performing the multiplication operation
        result = firstNumber * secondNumber;

        // Setting the isValidOperator flag to true for multiplication
        isValidOperator = true;
    }
    else if (keyOperator.Key == ConsoleKey.D4 || keyOperator.Key == ConsoleKey.Divide || keyOperator.KeyChar == '/')
    {
        operation = "/";
        // Performing the division operation
        result = firstNumber / secondNumber;

        // Setting the isValidOperator flag to true for division
        isValidOperator = true;
    }
    else if (keyOperator.Key == ConsoleKey.D5 || keyOperator.KeyChar == '%')
    {
        operation = "%";
        // Performing the modulo operation
        result = firstNumber % secondNumber;

        // Setting the isValidOperator flag to true for modulo
        isValidOperator = true;
    }
    else
    {
        // If the user input is not valid, ask the user to enter a valid operator
        Console.WriteLine("Invalid operator. Please enter a valid operator.");
    }

    // Checking if the user entered 0 while using % or / operator
    if (firstNumber == 0 || secondNumber == 0 || firstNumber == 0 && secondNumber == 0)
    {
        // Checking if the user entered 0 while using % or / operator
        while (operation == "%" || operation == "/")
        {
            // Inform the user that they cannot use 0 while using % or / operator
            Console.WriteLine("Error: Cannot divide by zero!");
        }
    }


}

// Printing the result to the user
Console.WriteLine($"{firstNumber} {operation} {secondNumber} = {result}");
Console.WriteLine();
// Telling the user to press ENTER to perform another operation ESC to exit the program
Console.WriteLine("If you would like to perform another operation, please press ENTER.");
Console.WriteLine("Or");
Console.WriteLine("If you would like to exit the program, please press ESC.");

// Creating a while loop to check if the user pressed either the ENTER or ESC key
isValidKey = false;
while (!isValidKey)
{
    // Waiting for the user to press a key
    ConsoleKeyInfo keyOperator = Console.ReadKey(intercept: true); // The 'true' prevents the key from being displayed.

    // Check if the user pressed the ESC key
    if (keyOperator.Key == ConsoleKey.Escape)
    {
        // Clearing the console
        Console.Clear();

        // Exiting the program
        Console.WriteLine("\nExiting the program...");

        // The user correctly pressed the ESC key
        isValidKey = true;
    }
    else if (keyOperator.Key == ConsoleKey.Enter)
    {
        // Clearing the console
        Console.Clear(); // This command clears the console.

        // The user correctly pressed the ENTER key
        isValidKey = true;
    }
    else if (keyOperator.Key == ConsoleKey.Spacebar)
    {
        // Clearing the console
        Console.Clear(); // This command clears the console.
        Console.WriteLine("That works too! XD XD");

        // The user correctly pressed the SPACEBAR key, end made a joke out of it!!! XD XD
        isValidKey = true;
    }
    else
    {
        // Informing the user that they pressed an invalid key
        Console.WriteLine("Invalid key. Please press either the ENTER or ESC key.");
    }

}