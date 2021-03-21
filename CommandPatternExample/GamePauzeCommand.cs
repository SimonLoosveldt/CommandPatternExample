using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternExample
{
    /// <summary>
    /// GamePauzeCommand
    /// </summary>
    public class GamePauzeCommand : ICommand // Example code implemented and adapted from Vaskaran Sarcar's book 'Design Patterns in C#' page 315 - 335
    {
        private Game game;
        public GamePauzeCommand(Game game)
        {
            this.game = game;
        }

        public void Execute()
        {
            game.Pauze();
        }
        public void Undo()
        {
            game.Continue();
        }
    }
}
