# A Game of FizzBuzz

Based off of a combination of a game of life and fizz buzz, the rules are as follows: 
 - There are 2 counters, one for the Game Of Life and one for FizzBuzz 
 - For every increment of the Game Of Life Counter (or "frame"), the standard Game Of Life Rules apply (which are): 
   + Any live cell with fewer than two live neighbours dies, as if by underpopulation.
   + Any live cell with two or three live neighbours lives on to the next generation.
   + Any live cell with more than three live neighbours dies, as if by overpopulation.
   + Any dead cell with exactly three live neighbours becomes a live cell, as if by reproduction.
 - Simultaneously, for every 10 increments (or frames) of the game of life, the FizzBuzz counter is incremented
 - For every increment of the Game Of Life Counter (or "frame"), the standard FizzBuzz rules also apply (which are): 
   + For every Multiple of 3 write Fizz 
   + For every Multiple of 5 write Buzz 
   + For every Multiple of 3 and 5 write FizzBuzz
   + Otherwise write the FizzBuzz counters current number
 - In addition : 
   + Every time "Fizz" is written, a glider is created travelling right from x: 2, y: 12
   + Every time "Buzz" is written, a glider is created travelling right from x: 11, y: 2
   + Every time "FizzBuzz" is written, a glider is created travelling left from x: 4, y: 36

# CHALLENGE 1
You've had sprint planning, and this sprint there is 1 story, 1 bug, and 1 tech debt item. 

 - Story: Whenever the application writes Fizz, Buzz, or FizzBuzz, a new glider is introduced, but only on the first frame when it is written. 
 - The code for the Gliders has already been written. 
  + For Fizz, Introduce LeftGliderOne
  + For Buzz, Introduce LeftGliderTwo
  + For FizzBuzz, Introduce RightGliderOne

 - Bug: 
  + The grid was supposed to have a width of 60 and a height of 30, but after starting the application, the grid runs with a width of 30 and a height of 60

- Tech Debt: Theres no unit tests, let's write some! 
(this is nearly impossible, so don't waste much time on it, but do try to think about how you would even start this)