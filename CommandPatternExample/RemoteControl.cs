using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternExample
{
    /// <summary>
    /// Invoker class
    /// </summary>
    public class RemoteControl // Example code implemented and adapted from Vaskaran Sarcar's book 'Design Patterns in C#' page 315 - 335
    {
        ICommand commandToBePerformed, lastCommandPerformed;
        public void SetCommand(ICommand command)
        {
            this.commandToBePerformed = command;
        }
        public void ExecuteCommand()
        {
            commandToBePerformed.Execute();
            lastCommandPerformed = commandToBePerformed;
        }
        public void UndoCommand()
        {
            // Undo the last command executed
            lastCommandPerformed.Undo();
        }
    }
}
