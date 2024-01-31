using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Mission04___Team1_11
{
    internal class TikTakBoard
    {
        string result = "";

        public void printBoard(char[] PlayerArray) // method that prints the board based on the information passed to it
        {
            Console.WriteLine(" {0} | {1} | {2} ", PlayerArray[1], PlayerArray[2], PlayerArray[3]);
            Console.WriteLine("---|---|---");
            Console.WriteLine(" {0} | {1} | {2} ", PlayerArray[4], PlayerArray[5], PlayerArray[6]);
            Console.WriteLine("---|---|---");
            Console.WriteLine(" {0} | {1} | {2} ", PlayerArray[7], PlayerArray[8], PlayerArray[9]);
        }

        public string checkWinner(char[] PlayerArray) // method that receives the game board array as input and returns if there is a winner and who it was
        {
            int[,] winCombinations = new int[,]
            {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9},
                {1, 4, 7},
                {2, 5, 8},
                {3, 6, 9},
                {1, 5, 9},
                {3, 5, 7}
            };

            for (int i = 0; i < 8; i++)
            {
                int a = winCombinations[i, 0], b = winCombinations[i, 1], c = winCombinations[i, 2];
                if (PlayerArray[a] == PlayerArray[b] && PlayerArray[b] == PlayerArray[c])
                {
                    Console.WriteLine(PlayerArray[a].ToString());
                    result = PlayerArray[a].ToString();
                }
            };

            if (PlayerArray.Skip(1).All(c => c == 'X' || c == 'O'))
            {
                result = "Tie";
            }

            return result; // No winner yet
        }
    }
}

