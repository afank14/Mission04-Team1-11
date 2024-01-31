// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// hey I'm writing this comment -Eliza
using System.Runtime.CompilerServices;
using System.Threading;
using Mission04___Team1_11;

TikTakBoard tk = new TikTakBoard();
// make an array that stores player's Choices; if they choose a spot then it will store either an X or O
char[] PlayerArray = {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
// start with Player equaling 1
int Player = 1;
int choice;
int start = 0;
string result = "";
// give the players their symbols 
Console.WriteLine("PLayer1:X and Player2:O");
do
{
    // show them who's turn it is
    if (Player % 2 == 0)
    {
        Console.WriteLine("Player 2's turn!");
    }
    else
    {
        Console.WriteLine("Player 1's turn!");
    }
    // print the Board for the player
    tk.printBoard(PlayerArray);
    // read line to see what the user wants to do int.parse initializing
    Console.WriteLine("Where do you want to put your mark?");
    // gather the users choice
    choice = int.Parse(Console.ReadLine());
    // if else statement to check the place in the array
    if (PlayerArray[choice] != 'X' && PlayerArray[choice] != 'O') ;
    {
        if (Player % 2 == 0)
        {
            PlayerArray[choice] = 'O';
            Player++;
        }
        else
        {
            PlayerArray[choice] = 'X';
            Player++;
        }
    }
    result = tk.checkWinner(PlayerArray);

    if (result != "")
    {
        start = 1;
    }

} while (start == 0);
// print who the winner is and end the game
if (result == "X")
{
    Console.WriteLine("Player 1 is the winner!");
}
else if (result == "O")
{
    Console.WriteLine("Player 2 is the winner!");
}
else
{
    Console.WriteLine("It's a tie! Play again to see who can win!");
}

// Added this because it was closing as soon as the game ended immediately
Thread.Sleep(5000);