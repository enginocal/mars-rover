using MarsRover.Factory;
using MarsRover.Models;
using System;
using System.Linq;

namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {

            var maxPoints = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
            var x = maxPoints[0];
            var y = maxPoints[1];
            Plateu plateu = new Plateu(x, y);
            var startPositions = Console.ReadLine().Trim();
            ICommandFactory commandFactory = new CommandFactory();
            IRoverPosition roverPosition = new RoverPosition(new SetPosition() { PositionLetter = startPositions });
            Rover roverVehicle = new Rover(plateu, roverPosition, commandFactory);

            var moves = Console.ReadLine().ToUpper();

            try
            {
                roverVehicle.Run(new RunCommand() { CommandLetters = moves });

                Console.WriteLine($"{roverVehicle.Coordinate.XCoordinate} {roverVehicle.Coordinate.YCoordinate} {roverVehicle.Direction.ToString()}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
