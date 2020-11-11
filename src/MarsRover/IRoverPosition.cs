namespace MarsRover
{
    public interface IRoverPosition
    {
        Coordinate Coordinate { get; set; }
        Directions Direction { get; set; }
    }
}