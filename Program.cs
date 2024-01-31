// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// hey I'm writing this comment -Eliza
using System.Runtime.CompilerServices;

string[] PlayerChoices = new string[9];
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

PrintBoard();