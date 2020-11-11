namespace MarsRover.Interfaces
{
    public interface ICommand
    {
        void Execute(IRover rover);
    }
}
