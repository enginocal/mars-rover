using MarsRover.Interfaces;

namespace MarsRover
{
    public class Plateu : IPlateu
    {
        public int XLength { get; set; }
        public int YLength { get; set; }

        private int xMin = 0;
        private int yMin = 0;

        public Plateu(int x, int y)
        {
            XLength = x;
            YLength = y;
        }
        public Plateu()
        {

        }

        public bool Contains(Coordinate coordinate)
        {
            bool valid = coordinate.XCoordinate >= xMin && coordinate.XCoordinate <= XLength
                                             && coordinate.YCoordinate >= yMin && coordinate.YCoordinate <= YLength;

            return valid;
        }
    }
}
