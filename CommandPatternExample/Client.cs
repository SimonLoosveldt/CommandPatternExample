using System;

namespace CommandPatternExample
{
    /// <summary>
    /// Client code
    /// </summary>
    public class Client // Example code implemented and adapted from Vaskaran Sarcar's book 'Design Patterns in C#' page 315 - 335
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Command Pattern Demonstration***\n");
            /* Client holds both the Invoker and Command Objects */
            RemoteControl invoker = new();
            Game gameName = new("Golf");
            // Command to start the game
            GameStartCommand gameStartCommand = new(gameName);
            // Command to stop the game
            GameStopCommand gameStopCommand = new(gameName);
            // Command to pauze the game
            GamePauzeCommand gamePauzeCommand = new(gameName);
            Console.WriteLine("**Starting the game and performing undo immediately.**");

            invoker.SetCommand(gameStartCommand);
            invoker.ExecuteCommand();
            // Performing undo operation
            Console.WriteLine("\nUndoing the previous command now.");
            invoker.UndoCommand();
            Console.WriteLine("\n**Starting the game again.Then stopping it and undoing the stop operation.**");

            invoker.SetCommand(gameStartCommand);
            invoker.ExecuteCommand();
            // Stop command to finish the game
            invoker.SetCommand(gameStopCommand);
            invoker.ExecuteCommand();
            // Performing undo operation
            Console.WriteLine("\nUndoing the previous command now.");
            invoker.UndoCommand();

            // Starting a new game
            invoker.SetCommand(gameStartCommand);
            invoker.ExecuteCommand();
            // Pauzing the running game
            invoker.SetCommand(gamePauzeCommand);
            invoker.ExecuteCommand();
            // Performing undo operation --> Continue
            invoker.UndoCommand();
            // Stopping the running game
            invoker.SetCommand(gameStopCommand);
            invoker.ExecuteCommand();

            Console.ReadKey();
        }
    }
}
