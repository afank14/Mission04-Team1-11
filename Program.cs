// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;
using System.Threading;
using Mission04___Team1_11;

TikTakBoard tk = new TikTakBoard();
// make an array that stores player's Choices; if they choose a spot then it will store either an X or O
char[] PlayerArray = {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
// initialize player 1 so that we can automatically iterate trhough two players
// initalize a start variable that will change if game finishes
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
    // Validate user input
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out choice) && choice >= 1 && choice <= 9 && PlayerArray[choice] != 'X' && PlayerArray[choice] != 'O')
        {
            break;
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number between 1 and 9, and a position that is not marked.");
        }
    }

    // if else statement to check if the place in the array is full or not

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

    Console.WriteLine("");
    result = tk.checkWinner(PlayerArray);


    if (result != "")
    {
        start = 1;
    }

    } while (start == 0); 

    tk.printBoard(PlayerArray);// print who the winner is and end the game
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