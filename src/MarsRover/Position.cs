//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Text;

//namespace MarsRover
//{
//    public class Position : IPosition
//    {
//        public int XCoordinatePoint { get; set; }
//        public int YCoordinatePoint { get; set; }

//        private Dictionary<Directions, Directions> leftCommandNextPosition = new Dictionary<Directions, Directions>();
//        private Dictionary<Directions, Directions> rightCommandNextPosition = new Dictionary<Directions, Directions>();
//        private Dictionary<Directions, Coordinate> moveForwardNextPosition = new Dictionary<Directions, Coordinate>();


//        public Directions Direction { get; set; }

//        public Position()
//        {
//            XCoordinatePoint = 0;
//            YCoordinatePoint = 0;
//            Direction = Directions.N;
//            PrepareMoveForwardNextPosition();
//            PrepareLeftNextPositions();
//            PrepareRightNextPositions();

//        }

//        private void PrepareMoveForwardNextPosition()
//        {
//            moveForwardNextPosition.Add(Directions.N, new Coordinate(0, 1));
//            moveForwardNextPosition.Add(Directions.E, new Coordinate(1, 0));
//            moveForwardNextPosition.Add(Directions.W, new Coordinate(-1, 0));
//            moveForwardNextPosition.Add(Directions.S, new Coordinate(0, -1));
//        }

//        private void PrepareLeftNextPositions()
//        {
//            leftCommandNextPosition.Add(Directions.N, Directions.W);
//            leftCommandNextPosition.Add(Directions.E, Directions.N);
//            leftCommandNextPosition.Add(Directions.W, Directions.S);
//            leftCommandNextPosition.Add(Directions.S, Directions.E);
//        }

//        private void PrepareRightNextPositions()
//        {
//            rightCommandNextPosition.Add(Directions.N, Directions.E);
//            rightCommandNextPosition.Add(Directions.E, Directions.S);
//            rightCommandNextPosition.Add(Directions.W, Directions.N);
//            rightCommandNextPosition.Add(Directions.S, Directions.W);
//        }



//        private void MoveLeft()
//        {
//            Direction = leftCommandNextPosition[Direction];
//        }

//        private void MoveRight()
//        {
//            Direction = rightCommandNextPosition[Direction];
//        }

//        private void MoveForward()
//        {
//            var position = moveForwardNextPosition[Direction];
//            XCoordinatePoint += position.XCoordinate;
//            YCoordinatePoint += position.YCoordinate;
//        }

//        public void Move(int x, int y, string moves)
//        {
//            foreach (var move in moves)
//            {
//                switch (move)
//                {
//                    case 'M':
//                        MoveForward();
//                        break;
//                    case 'L':
//                        MoveLeft();
//                        break;
//                    case 'R':
//                        MoveRight();
//                        break;
//                    default:
//                        Console.WriteLine($"Invalid Character {move}");
//                        break;
//                }

//                if (XCoordinatePoint < 0 || XCoordinatePoint > x || YCoordinatePoint < 0 || YCoordinatePoint > y)
//                {
//                    throw new Exception($"Something is wrong ({x} , {y})");
//                }
//            }
//        }

//    }

//    public interface IPosition
//    {

//    }
//}
