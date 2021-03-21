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
    public interface ICommand
    {
        // To execute a command
        void Execute();
        // To undo last command execution
        void Undo();
    }
}
