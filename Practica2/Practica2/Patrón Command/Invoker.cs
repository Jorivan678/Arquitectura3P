using System;
using System.Collections.Generic;
using System.Text;

namespace Practica2.Patrón_Command
{
    public class Invoker
    {
        Command command;

        public void SetCommand(Command command)
        {
            this.command = command;
        }

        public void ExecuteCommand()
        {
            command.Execute();
        }
    }
}
