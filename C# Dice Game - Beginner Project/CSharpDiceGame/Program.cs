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

  // Generate a randome number between 1 and 7
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
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"\nThe AI Computer rolled a {computerNumber}");
    Console.WriteLine();

  }
  // Reset the color of the text back to normal!
  Console.ResetColor();
  // Prompt the user to press the enter the key to continue playing or exit the program
  Console.WriteLine("Press ENTER to continue playing or press ESC to exit the program");
  Console.WriteLine();

  if (Console.ReadKey(intercept: true).Key == ConsoleKey.Enter)
  {
    // Inform the user that the game is continuing!
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("Continuing Game");
    System.Threading.Thread.Sleep(500);
    Console.Write(".");
    System.Threading.Thread.Sleep(500);
    Console.Write(".");
    System.Threading.Thread.Sleep(500);
    Console.Write(".");
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

    ProgramIsRunning = true; 
  }

}