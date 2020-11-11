using MarsRover.Interfaces;

namespace MarsRover.Commands
{
    public class Left : ICommand
    {
        public void Execute(IRover rover)
        {
            rover.MoveLeft();
        }
    }
}
