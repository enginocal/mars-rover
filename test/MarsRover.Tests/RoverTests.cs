using MarsRover.Extensions;
using MarsRover.Factory;
using MarsRover.Models;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MarsRover.Tests
{
    public class RoverTests
    {

        [Fact]
        public void SetPosition_ValidPositionLetter_GetPosition()
        {
            var plateau = new Plateu(5, 5);
            var mockCommandFactory = new Mock<ICommandFactory>();
            var roverPosition = new RoverPosition(new SetPosition { PositionLetter = "1 1 N" });

            var rover = new Rover(plateau, roverPosition, mockCommandFactory.Object);
            var position = $"{rover.Coordinate.XCoordinate} {rover.Coordinate.YCoordinate} {rover.Direction.ToDescription()}";

            Assert.Equal("1 1 N", position);
        }

        [Theory]
        [InlineData("")]
        [InlineData("denemetest")]
        [InlineData("engin")]
        public void RunCommandList_InvalidCommandLetters_ExceptionThrown(string commandLetters)
        {
            var plateau = new Plateu(5, 5);
            var mockCommandFactory = new Mock<ICommandFactory>();
            var roverPosition = new Mock<IRoverPosition>();
            var rover = new Rover(plateau, roverPosition.Object, mockCommandFactory.Object);

            Assert.Throws<Exception>(
                () => rover.Run(new RunCommand { CommandLetters = commandLetters }));
        }

    }
}
