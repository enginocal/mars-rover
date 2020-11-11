using MarsRover.Commands;
using MarsRover.Interfaces;
using System.Collections;

namespace MarsRover.Factory
{
    public class CommandFactory : ICommandFactory
    {
        private readonly Hashtable commandTable;

        public CommandFactory()
        {
            commandTable = new Hashtable();
            PrepareCommandTable();
        }

        private void PrepareCommandTable()
        {
            commandTable.Add('L', new Left());
            commandTable.Add('R', new Right());
            commandTable.Add('M', new Move());
        }

        public ICommand GetCommand(char letter)
        {
            var command = (ICommand)commandTable[letter];
            return command;
        }
    }
}
