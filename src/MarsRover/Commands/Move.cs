using MarsRover.Interfaces;

namespace MarsRover.Commands
{
    public class Move : ICommand
    {
        public void Execute(IRover rover)
        {
            rover.MoveForward();
        }
    }
}
