// See https://aka.ms/new-console-template for more information
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
// if else statement to check the place in the array