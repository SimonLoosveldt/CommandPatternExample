using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternExample
{
    /// <summary>
    /// GameStopCommand
    /// </summary>
    public class GameStopCommand : ICommand
    {
        private Game game;
        public GameStopCommand(Game game)
        {
            this.game = game;
        }
        public void Execute()
        {
            Console.WriteLine("Finishing the game.");
            game.Finish();
        }
        public void Undo()
        {
            Console.WriteLine("Undoing stop command.");
            game.Start();
            game.DisplayScore();
        }
    }
}
