using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternExample
{
    /// <summary>
    /// The command interface
    /// </summary>
    public interface ICommand // Example code implemented and adapted from Vaskaran Sarcar's book 'Design Patterns in C#' page 315 - 335
    {
        // To execute a command
        void Execute();
        // To undo last command execution
        void Undo();
    }
}
