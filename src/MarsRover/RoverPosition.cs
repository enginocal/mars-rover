using MarsRover.Enums;
using MarsRover.Models;

namespace MarsRover
{
    public class RoverPosition : IRoverPosition
    {
        static readonly EnumOperation enumOperation = new EnumOperation();
        public Coordinate Coordinate { get; set; }
        public Directions Direction { get; set; }
        public RoverPosition(SetPosition position)
        {
            var arr = position.PositionLetter.Split(' ');
            Coordinate = new Coordinate { XCoordinate = int.Parse(arr[0]), YCoordinate = int.Parse(arr[1]) };
            Direction = enumOperation.GetEnumFromDescription<Directions>(arr[2]);
        }

        public void CurrentPosition(SetPosition position)
        {
            var arr = position.PositionLetter.Split(' ');
            Coordinate = new Coordinate { XCoordinate = int.Parse(arr[0]), YCoordinate = int.Parse(arr[1]) };
            Direction = enumOperation.GetEnumFromDescription<Directions>(arr[2]);
        }
    }
}
