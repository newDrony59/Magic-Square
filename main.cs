/*

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

*/

using System;

public class Program 
{
	public static bool IsMagicSquare(int[][] arr)
	{
		int x,y, hori1 = 0,hori2 = 0,hori3 = 0;
		int verti1 = 0,verti2 = 0,verti3 = 0;
		int diago1 = 0, diago2 = 0;
		bool horisum = true, vertisum = true, diagosum = true;
		//horizontal check
			for(x = 0 ; x < arr.Length; x++)
			{
				for(y = 0 ; y< arr.Length; y++)
				{
					if(x==0)
					{hori1 += arr[x][y];}
					else if(x==1)
					{hori2 += arr[x][y];}
					else
					{hori3 += arr[x][y];}
				}			
			}
			if(hori1 != hori2 && hori2 != hori3){horisum =false;}
			//verticalcheck
			for(y = 0 ; y < arr.Length; y++)
			{
				for(x = 0 ; x < arr.Length; x++)
				{
					if(y == 0)
					{verti1 += arr[x][y];}
					else if(y == 1)
					{verti2 += arr[x][y];}
					else
					{verti3 += arr[x][y];}
				}			
			}
			if(verti1 != verti2 && verti2 != verti3){vertisum =false;}
			
			//diagonal check
			y=0;
			for(x = 0 ; x < arr.Length; x++)
			{
				diago1 += arr[x][y];
				y++;
			}
			x = 0;
			for(y = (arr.Length)-1 ; y >=0 ; y--)
			{
				diago2 += arr[x][y];
				x++;
			}
			if(diago1 != diago2){diagosum = false;}
		return (horisum == true && vertisum == true && diagosum == true)?true:false;
	}
}
