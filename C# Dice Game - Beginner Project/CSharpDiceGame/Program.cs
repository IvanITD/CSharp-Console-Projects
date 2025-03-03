// Variables for later user
int userPoints = 0;
int computerPoints = 0;

// Welcome the user to the rolling dice game
  Console.WriteLine("\nHello User!");
  
  // Adding delay so that the user can read the welcome message
  System.Threading.Thread.Sleep(1500);
  Console.ForegroundColor = ConsoleColor.Cyan;
  Console.WriteLine("WELCOME TO MY ROLLING DICE GAME");
  System.Threading.Thread.Sleep(1500);

// Include the a while loop in order to continue rolling the dice until the user decides to stop
bool ProgramIsRunning = false;
while (!ProgramIsRunning)
{
  for (int i = 0; i < 10; i++)
  {
    // Small delay to make the rolling take a bit more time
    System.Threading.Thread.Sleep(1000);
    // Inform the user to roll the dice
    Console.WriteLine();
    Console.ResetColor();
    Console.WriteLine("Press any key to roll the dice...");

    // Wait for the user to press a key
    Console.ReadKey(intercept: true);

    // Inform the user that the dice is rolling
    Console.Write("\nRolling");
    loadingDots(500, 1, 3);

    // Generate a random number between 1 and 7
    Random randomNumber = new Random();
    int userNumber = randomNumber.Next(1, 7);

    // Informing the user of the random number they rolled
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write($"  You rolled a {userNumber}");
    Console.WriteLine();
    
    // Creating a small delay to make the rolling take a bit more time
    System.Threading.Thread.Sleep(1500);

    // Rolling
    Console.Write("AI Rolling");
    loadingDots(500, 1, 3);

    // Generate a random number between 1 and 7
    int computerNumber = randomNumber.Next(1, 7);
    
    // Informing the user of the random number the computer AI rolled
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write($"  The AI {computerNumber}");
    Console.WriteLine();

    // Create a if statement to determine who won the game
  if (userNumber > computerNumber)
  {
    userPoints++;
  }
  else if (computerNumber > userNumber)
  {
    computerPoints++;
  }

  }
  // Reset the color of the text back to normal!
  Console.ResetColor();
  // Changing the color to pink to inform the user of the current score
  Console.ForegroundColor = ConsoleColor.Magenta;
  // Inform the user of the current score
  Console.WriteLine($"Your Points: {userPoints} ||");
  // Restoring the color for the dots
  Console.ResetColor();


  // Set the color to red to inform the user of the computer AI's current score
  Console.ForegroundColor = ConsoleColor.Red;
  // Inform the user of the computer AI's current score
  Console.WriteLine();
  Console.Write($"      The AI Computer's Points: {computerPoints}");
  // Restoring the color for the dots
  Console.ResetColor();
  loadingDots(500, 1, 3);
  Console.WriteLine();

  // Check whether the user or the enemy AI has won the game
  if (userPoints > computerPoints)
  {
    // Inform the user that they have won the game
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("YOU WON!\nCongratulations!");
  }
  else if (computerPoints > userPoints)
  {
    // Inform the user that the computer AI has won the game
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("YOU LOOSE!\nThe AI Computer has won the game!");
  }
  else if (userPoints == computerPoints)
  {
    // Inform the user that the game is a draw
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("DRAW!\nIt's a draw!");
  }

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
    loadingDots(500, 1, 3);
  }
  else if (Console.ReadKey(intercept: true ).Key == ConsoleKey.Escape)
  {
    // Inform the user that the program is exiting!
    Console.ForegroundColor = ConsoleColor.DarkGray;
    Console.Write("Game Closing");
    loadingDots(500, 1, 3);
    
    ProgramIsRunning = true; 
  }

}

// Methods
static void loadingDots(int delay, int cycles, int dots)
{
    for (int i = 0; i < cycles; i++)
    {
        for (int j = 1; j <= dots; j++)
        {
            Console.Write('.');
            System.Threading.Thread.Sleep(delay);
        }
        if (i < cycles - 1)
        {
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', dots));
            Console.SetCursorPosition(0, Console.CursorTop);
        }
    }
}