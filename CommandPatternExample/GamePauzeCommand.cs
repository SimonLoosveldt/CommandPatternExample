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
    public class GamePauzeCommand : ICommand
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
