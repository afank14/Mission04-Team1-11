﻿// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// hey I'm writing this comment -Eliza
using System.Runtime.CompilerServices;

TikTakBoard tk = new TikTakBoard();
char[] PlayerArray = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
int Player = 1;
int choice;
int start = 0;
Console.WriteLine("PLayer1:X and Player2:O");
if (Player % 2 == 0)
{
    Console.WriteLine("Player 2's turn!");
}
else
{
    Console.WriteLine("Player 1's turn!");
}
tk.PrintBoard();
// read line to see what the user wants to do int.parse initializing
Console.WriteLine("Where do you want to put your mark?");
choice = int.Parse(Console.ReadLine());
// if else statement to check the place in the array
if (PlayerArray[choice] != 'X' && PlayerArray[choice] != 'O') ;
{
    if (Player % 2 == 0)
    {
        PlayerArray[choice] = 'O';
    }
    else
    {
        PlayerArray[choice] = 'X';
    }
}
tk.CheckWinner(PlayerArray);
// check the position in the array make sure they didn't just put O and X