using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternExample
{
    /// <summary>
    /// Receiver Class
    /// </summary>
    public class Game
    {
        string gameName;
        public Game(string name)
        {
            this.gameName = name;
        }
        public void Start()
        {
            Console.WriteLine($"{gameName} is on.");
        }
        public void DisplayScore()
        {
            Console.WriteLine("The score is changing time to time.");
        }
        public void Finish()
        {
            Console.WriteLine($"---The game of {gameName} is over.---");
        }
        public void Pauze()
        {
            Console.WriteLine($"The game of {gameName} is pauzed.");
        }
        public void Continue()
        {
            Console.WriteLine($"The game of {gameName} is continued.");
        }
    }
}
