using MarsRover.Interfaces;

namespace MarsRover.Commands
{
    public class Right : ICommand
    {
        public void Execute(IRover rover)
        {
            rover.MoveRight();
        }
    }
}
