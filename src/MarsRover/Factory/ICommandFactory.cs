using MarsRover.Interfaces;

namespace MarsRover.Factory
{
    public interface ICommandFactory
    {
        ICommand GetCommand(char letter);
    }
}