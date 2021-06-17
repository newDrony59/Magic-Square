# Magic-Square

Problem: 

In recreational mathematics, a square array of numbers, usually positive integers, is called a magic square if the sums of the numbers in each row, each column, and both main diagonals are the same.

Create a function that takes a square 2D array as an argument and returns a Boolean (if it is: true, if it isn't: false).
Examples

IsMagicSquare(new int[][] {
  { 2, 7, 6 },
  { 9, 5, 1 },
  { 4, 3, 8 }
}) run -> true

IsMagicSquare(new int[][] {
  { 16, 3, 2, 13 },
  { 5, 10, 11, 8 },
  { 9, 6, 7, 12 },
  { 4, 15, 14, 1 }
}) run -> true

IsMagicSquare(new int[][] {
  { 1, 14, 14, 4 },
  { 11, 7, 6, 9 },
  { 8, 11, 10, 5 },
  { 13, 2, 3, 15 }
}) run -> false
