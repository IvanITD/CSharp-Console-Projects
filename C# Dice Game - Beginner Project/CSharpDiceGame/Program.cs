// Variables for later user
int userPoints = 0;
int computerPoints = 0;

// Welcome the user to the rolling dice game
  Console.WriteLine("\nHello User!");
  
  // Adding delay so that the user can read the welcome message
  System.Threading.Thread.Sleep(2000);
  Console.ForegroundColor = ConsoleColor.Cyan;
  Console.WriteLine("WELCOME TO MY ROLLING DICE GAME");
  System.Threading.Thread.Sleep(2000);

// Include the a while loop in order to continue rolling the dice until the user decides to stop
bool ProgramIsRunning = false;
while (!ProgramIsRunning)
{
  for (int i = 0; i < 10; i++)
  {
    // Inform the user to roll the dice
  Console.WriteLine();
  Console.ResetColor();
  Console.WriteLine("Press any key to roll the dice...");

  // Wait for the user to press a key
  Console.ReadKey(intercept: true);

  // Generate a random number between 1 and 7
    Random randomNumber = new Random();
    int userNumber = randomNumber.Next(1, 7);
    // Informing the user of the random number they rolled
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($"You rolled a {userNumber}");
    Console.WriteLine();
    //Make the dice rolling a little more realistic by adding a delay
    Console.Write("Rolling");
    Console.Write(".");
    System.Threading.Thread.Sleep(500);
    Console.Write(".");
    System.Threading.Thread.Sleep(500);
    Console.Write(".");
    System.Threading.Thread.Sleep(500);
    Console.WriteLine();

    int computerNumber = randomNumber.Next(1, 7);
    // Informing the user of the random number the computer AI rolled
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine($"\nThe AI Computer rolled a {computerNumber}");
    Console.WriteLine();

    // Create a if statement to determine who won the game
  if (userNumber > computerPoints)
  {
    userPoints++;
  }
  else if (computerNumber > userPoints)
  {
    computerPoints++;
  }

  }
  // Reset the color of the text back to normal!
  Console.ResetColor();
  // Changing the color to pink to inform the user of the current score
  Console.ForegroundColor = ConsoleColor.Magenta;
  // Inform the user of the current score
  Console.WriteLine($"Your Points: {userPoints}");
  // Restoring the color for the dots
  Console.ResetColor();
  System.Threading.Thread.Sleep(500);
  Console.Write(".");
  System.Threading.Thread.Sleep(500);
  Console.Write(".");
  System.Threading.Thread.Sleep(500);
  Console.Write(".");


  // Set the color to red to inform the user of the computer AI's current score
  Console.ForegroundColor = ConsoleColor.Red;
  // Inform the user of the computer AI's current score
  Console.WriteLine();
  Console.WriteLine($"The AI Computer's Points: {computerPoints}");
  // Restoring the color for the dots
  Console.ResetColor();
  System.Threading.Thread.Sleep(500);
  Console.Write(".");
  System.Threading.Thread.Sleep(500);
  Console.Write(".");
  System.Threading.Thread.Sleep(500);
  Console.Write(".");

  // Reset the color of the text back to normal!
  Console.ResetColor();
  // Prompt the user to press the enter the key to continue playing or exit the program
  Console.WriteLine("Press ENTER to continue playing or press ESC to exit the program");
  Console.WriteLine();

  if (Console.ReadKey(intercept: true).Key == ConsoleKey.Enter)
  {
    // Inform the user that the game is continuing!
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write("Continuing Game");
    System.Threading.Thread.Sleep(500);
    Console.Write(".");
    System.Threading.Thread.Sleep(500);
    Console.Write(".");
    System.Threading.Thread.Sleep(500);
    Console.Write(".");
    Console.WriteLine();
  }
  else if (Console.ReadKey(intercept: true ).Key == ConsoleKey.Escape)
  {
    // Inform the user that the program is exiting!
    Console.ForegroundColor = ConsoleColor.DarkGray;
    Console.Write("Game Closing");
    System.Threading.Thread.Sleep(500);
    Console.Write(".");
    System.Threading.Thread.Sleep(500);
    Console.Write(".");
    System.Threading.Thread.Sleep(500);
    Console.Write(".");
    Console.WriteLine();
    
    ProgramIsRunning = true; 
  }

}