using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternExample
{
    /// <summary>
    /// GameStartCommand
    /// </summary>
    public class GameStartCommand : ICommand
    {
        private Game game;
        public GameStartCommand(Game game)
        {
            this.game = game;
        }
        public void Execute()
        {
            game.Start();
            game.DisplayScore();
        }
        public void Undo()
        {
            Console.WriteLine("Undoing start command.");
            game.Finish();
        }
    }
}
