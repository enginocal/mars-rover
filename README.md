# mars-rover

# <h2><b>Problem Definition</b>

A squad of robotic rovers are to be landed by NASA on a plateau on Mars. This plateau, which is curiously rectangular, must be navigated by the rovers so that their on board cameras can get a complete view of the surrounding terrain to send back to Earth. 

A rover's position and location is represented by a combination of x and y co-ordinates and a letter representing one of the four cardinal compass points. The plateau is divided up into a grid to simplify navigation. An example position might be 0, 0, N, which means the rover is in the bottom left corner and facing North. 

In order to control a rover, NASA sends a simple string of letters. The possible letters are 'L', 'R' and 'M'. 'L' and 'R' makes the rover spin 90 degrees left or right respectively, without moving from its current spot. 'M' means move forward one grid point, and maintain the same heading.

Assume that the square directly North from (x, y) is (x, y+1).

<b>Input: </b>

The first line of input is the upper-right coordinates of the plateau, the lower-left coordinates are assumed to be 0,0. 
The rest of the input is information pertaining to the rovers that have been deployed. Each rover has two lines of input. The first line gives the rover's position, and the second line is a series of instructions telling the rover how to explore the plateau. 
 
The position is made up of two integers and a letter separated by spaces, corresponding to the x and y co-ordinates and the rover's orientation. 
Each rover will be finished sequentially, which means that the second rover won't start to move until the first one has finished moving. 

<b>Output:</b> <br>
The output for each rover should be its final co-ordinates and heading. 

<b>Input and Output </b>
Test Input: 
5 5 1 2 N <br>
LMLMLMLMM <br>
3 3 E <br>
MMRMMRMRRM <br>

# <h2> Explanation

It is a classical mars rover problem case. It assumed that rover only move on  the way, turn left or turn right.

# <h2>Problem Solving Approach
 
The project only contains console input progress. We would improve with adding different streaming sources.
I was trying to implement command factory pattern.

For turn left and right command, i use table design to next position.

For example, if the current command <b>"L"</b> and the current position are like below, next position would be dictionary value.
leftCommandNextPosition.Add(Directions.N, Directions.W);<br>
leftCommandNextPosition.Add(Directions.E, Directions.N);<br>
leftCommandNextPosition.Add(Directions.W, Directions.S);<br>
leftCommandNextPosition.Add(Directions.S, Directions.E);<br>
