using MarsRover.Exceptions;
using MarsRover.Factory;
using MarsRover.Interfaces;
using MarsRover.Models;
using System.Collections.Generic;

namespace MarsRover
{
    public class Rover : IRover
    {
        public Coordinate Coordinate { get; private set; }
        public Directions Direction { get; private set; }

        private Dictionary<Directions, Directions> leftCommandNextPosition = new Dictionary<Directions, Directions>();
        private Dictionary<Directions, Directions> rightCommandNextPosition = new Dictionary<Directions, Directions>();
        private Dictionary<Directions, Coordinate> moveForwardNextPosition = new Dictionary<Directions, Coordinate>();
        private ICommandFactory _commandFactory;
        private IRoverPosition _position;

        //private Dictionary<char, Func<TResult>> moveCommand = new Dictionary<char, Func<TResult>>();
        private readonly Plateu _plateu;
        

        public Rover(Plateu plateu, IRoverPosition position, ICommandFactory commandFactory)
        {
            _plateu = plateu;
            _commandFactory = commandFactory;
            _position = position;
            Direction = Directions.N;
            PrepareMoveForwardNextPositionsTable();
            PrepareLeftNextPositionsTable();
            PrepareRightNextPositionsTable();
            SetCurrentPosition();
        }

        private void SetCurrentPosition()
        {
            Coordinate = _position.Coordinate;
            Direction = _position.Direction;
        }

        private void PrepareMoveForwardNextPositionsTable()
        {
            moveForwardNextPosition.Add(Directions.N, new Coordinate(0, 1));
            moveForwardNextPosition.Add(Directions.E, new Coordinate(1, 0));
            moveForwardNextPosition.Add(Directions.W, new Coordinate(-1, 0));
            moveForwardNextPosition.Add(Directions.S, new Coordinate(0, -1));
        }

        private void PrepareLeftNextPositionsTable()
        {
            leftCommandNextPosition.Add(Directions.N, Directions.W);
            leftCommandNextPosition.Add(Directions.E, Directions.N);
            leftCommandNextPosition.Add(Directions.W, Directions.S);
            leftCommandNextPosition.Add(Directions.S, Directions.E);
        }

        private void PrepareRightNextPositionsTable()
        {
            rightCommandNextPosition.Add(Directions.N, Directions.E);
            rightCommandNextPosition.Add(Directions.E, Directions.S);
            rightCommandNextPosition.Add(Directions.W, Directions.N);
            rightCommandNextPosition.Add(Directions.S, Directions.W);
        }

        public void MoveLeft()
        {
            Direction = leftCommandNextPosition[Direction];
        }

        public void MoveRight()
        {
            Direction = rightCommandNextPosition[Direction];
        }

        public void MoveForward()
        {
            var position = moveForwardNextPosition[Direction];
            Coordinate.XCoordinate += position.XCoordinate;
            Coordinate.YCoordinate += position.YCoordinate;

            var isCorrectMove = _plateu.Contains(Coordinate);
            if (!isCorrectMove)
            {
                throw new PlateauSizeNotValidException(Coordinate.XCoordinate, Coordinate.YCoordinate);
            }
        }

        public void Run(RunCommand runCommand)
        {
            foreach (var commandLetter in runCommand.CommandLetters)
            {
                var command = _commandFactory.GetCommand(commandLetter);
                command.Execute(this);
            }
        }
    }
}
