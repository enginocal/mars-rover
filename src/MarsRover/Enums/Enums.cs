using System.ComponentModel;

namespace MarsRover
{
    public enum Directions
    {
        N = 1,
        E = 3,
        W = 4,
        S = 2
    }

    public enum Instructions
    {
        [Description("L")]
        Left = -1,
        [Description("R")]
        Right = 1,
        [Description("M")]
        Move = 0
    }
}
