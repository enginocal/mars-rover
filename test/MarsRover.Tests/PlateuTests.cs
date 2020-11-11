using System;
using Xunit;

namespace MarsRover.Tests
{
    public class PlateuTests
    {
        [Theory]
        [InlineData("")]
        [InlineData("1")]
        [InlineData("11")]
        [InlineData("1 S")]
        [InlineData("W S")]
        public void Init_InvalidCoordinateLetter_ExceptionThrown(string upperCoordinateLetter)
        {
            Assert.Throws<Exception>(() => new Plateu(upperCoordinateLetter));
        }

        [Theory]
        [InlineData("1 1")]
        [InlineData("2 1")]
        [InlineData("2 3")]
        public void Init_ValidCoordinateLetter_ReturnPlateau(string upperCoordinateLetter)
        {
            var plateau = new Plateu(upperCoordinateLetter);
            Assert.Equal("0 0", $"{plateau.LowerLeftCoordinate.X} {plateau.LowerLeftCoordinate.Y}");
            Assert.Equal(upperCoordinateLetter, $"{plateau.UpperRightCoordinate.X} {plateau.UpperRightCoordinate.Y}");
        }
    }
}
