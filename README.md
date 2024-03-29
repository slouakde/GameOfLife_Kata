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
   
There are 4 branches to look at :
 Challenge-1 : Code is written poorly and some challenges are raised
 Challenge-1-Solved : An example of the above being solved 
 Challenge-2 : Code is written with more separation and layering, same challenges are raised
 Challenge-2-Solved : An example of the above being solved 
