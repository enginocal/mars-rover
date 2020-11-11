using MarsRover.Commands;
using MarsRover.Factory;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MarsRover.Tests
{
    public class CommandFactoryTest
    {
        [Fact]
        public void GetCommand_CommandLetter_R_ReturnRightCommand()
        {
            var commandFactory = new CommandFactory();
            var command = commandFactory.GetCommand('R');
            Assert.Equal(typeof(Right), command.GetType());
        }

        [Fact]
        public void GetCommand_CommandLetter_L_ReturnLeftCommand()
        {
            var commandFactory = new CommandFactory();
            var command = commandFactory.GetCommand('L');
            Assert.Equal(typeof(Left), command.GetType());
        }

        [Fact]
        public void GetCommand_CommandLetter_M_ReturnMoveCommand()
        {
            var commandFactory = new CommandFactory();
            var command = commandFactory.GetCommand('M');
            Assert.Equal(typeof(Move), command.GetType());
        }

        [Fact]
        public void GetCommand_InvalidCommandLetter_A_ExceptionThrown()
        {
            var commandFactory = new CommandFactory();
            Assert.Throws<ArgumentException>(() => commandFactory.GetCommand('E'));
        }
    }
}
