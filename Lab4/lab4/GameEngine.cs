using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class GameEngine
    {
        //private int MoveCount = 0;        // number of moves made in game
        public int[,] grid = new int[3, 3];        // Game Engine's interface of tic tac toe board
        // Zero is an empty square
        // 1 is an 'X' (player move)
        // 2 is an 'O' (CPU Move)

        public void StartNewGame()          // method to clear the board and start new game
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    grid[i, j] = 0;
                }
            }
        }

        public bool CheckPlayerMove(int i, int j)            // checks if a player move is valid, places X, returns true
        {
            if (grid[i, j] == 0)        // checks if the square is empty
            {
                grid[i, j] = 1;         // updates game engine grid with 1   
                return true;
            }
            else return false;
        }

        public void ComputerMove()
        {
            //1. Play a winning move
            if (grid[0, 0] == 2 && grid[0, 2] == 2 && grid[0, 1] == 0)
                grid[0, 1] = 2;
            else if (grid[1, 0] == 2 && grid[1, 2] == 2 && grid[1, 1] == 0)
                grid[1, 1] = 2;
            else if (grid[2, 0] == 2 && grid[2, 2] == 2 && grid[2, 1] == 0)
                grid[2, 1] = 2;
            else if (grid[0, 0] == 2 && grid[2, 0] == 2 && grid[1, 0] == 0)
                grid[1, 0] = 2;
            else if (grid[0, 1] == 2 && grid[2, 1] == 2 && grid[1, 1] == 0)
                grid[1, 1] = 2;
            else if (grid[0, 2] == 2 && grid[2, 2] == 2 && grid[1, 2] == 0)
                grid[1, 2] = 2;
            else if (grid[0, 0] == 2 && grid[2, 2] == 2 && grid[1, 1] == 0)
                grid[1, 1] = 2;
            else if (grid[0, 2] == 2 && grid[2, 0] == 2 && grid[1, 1] == 0)
                grid[1, 1] = 2;
            else if (grid[0, 0] == 2 && grid[1, 0] == 2 && grid[2, 0] == 0)
                grid[2, 0] = 2;
            else if (grid[0, 1] == 2 && grid[1, 1] == 2 && grid[2, 1] == 0)
                grid[2, 1] = 2;
            else if (grid[0, 2] == 2 && grid[1, 2] == 2 && grid[2, 2] == 0)
                grid[2, 2] = 2;
            else if (grid[0, 0] == 2 && grid[1, 1] == 2 && grid[2, 2] == 0)
                grid[2, 2] = 2;
            else if (grid[0, 2] == 2 && grid[1, 1] == 2 && grid[2, 0] == 0)
                grid[2, 0] = 2;
            else if (grid[1, 1] == 2 && grid[2, 2] == 2 && grid[0, 0] == 0)
                grid[0, 0] = 2;
            else if (grid[1, 0] == 2 && grid[2, 0] == 2 && grid[0, 0] == 0)
                grid[0, 0] = 2;
            else if (grid[1, 1] == 2 && grid[2, 1] == 2 && grid[0, 1] == 0)
                grid[0, 1] = 2;

            //block player winning move
            else if (grid[0, 0] == 1 && grid[0, 2] == 1 && grid[0, 1] == 0)
                grid[0, 1] = 2;
            else if (grid[1, 0] == 1 && grid[1, 2] == 1 && grid[1, 1] == 0)
                grid[1, 1] = 2;
            else if (grid[2, 0] == 1 && grid[2, 2] == 1 && grid[2, 1] == 0)
                grid[2, 1] = 2;
            else if (grid[0, 0] == 1 && grid[2, 0] == 1 && grid[1, 0] == 0)
                grid[1, 0] = 2;
            else if (grid[0, 1] == 1 && grid[2, 1] == 1 && grid[1, 1] == 0)
                grid[1, 1] = 2;
            else if (grid[0, 2] == 1 && grid[2, 2] == 1 && grid[1, 2] == 0)
                grid[1, 2] = 2;
            else if (grid[0, 0] == 1 && grid[2, 2] == 1 && grid[1, 1] == 0)
                grid[1, 1] = 2;
            else if (grid[0, 2] == 1 && grid[2, 0] == 1 && grid[1, 1] == 0)
                grid[1, 1] = 2;
            else if (grid[0, 0] == 1 && grid[1, 0] == 1 && grid[2, 0] == 0)
                grid[2, 0] = 2;
            else if (grid[0, 1] == 1 && grid[1, 1] == 1 && grid[2, 1] == 0)
                grid[2, 1] = 2;
            else if (grid[0, 2] == 1 && grid[1, 2] == 1 && grid[2, 2] == 0)
                grid[2, 2] = 2;
            else if (grid[0, 0] == 1 && grid[1, 1] == 1 && grid[2, 2] == 0)
                grid[2, 2] = 2;
            else if (grid[0, 2] == 1 && grid[1, 1] == 1 && grid[2, 0] == 0)
                grid[2, 0] = 2;
            else if (grid[1, 1] == 1 && grid[2, 2] == 1 && grid[0, 0] == 0)
                grid[0, 0] = 2;
            else if (grid[1, 0] == 1 && grid[2, 0] == 1 && grid[0, 0] == 0)
                grid[0, 0] = 2;
            else if (grid[1, 1] == 1 && grid[2, 1] == 1 && grid[0, 1] == 0)
                grid[0, 1] = 2;
            else if (grid[0, 2] == 1 && grid[1, 1] == 1 && grid[2, 0] == 0)
                grid[2, 0] = 2;


            else if (grid[1, 1] == 0)         // if computer makes first move, take middle square
                grid[1, 1] = 2;
            else if (grid[0, 0] == 0)    // checks if middle square is occupied, will take if not
                grid[0, 0] = 2;
            else if (grid[0, 0] != 0 && grid[2, 0] != 0)
                grid[1, 0] = 2;
            else if (grid[0, 2] != 0 && grid[2, 2] != 0)
                grid[1, 2] = 2;
            else if (grid[1, 0] != 0 && grid[1, 1] != 0)
                grid[1, 2] = 2;
            else if (grid[1, 0] != 0 && grid[1, 2] != 0)
                grid[1, 2] = 2;
            else if (grid[0, 2] == 0)
                grid[0, 2] = 2;
            else if (grid[2, 0] == 0)
                grid[2, 0] = 2;
            else if (grid[2, 2] == 0)
                grid[2, 2] = 2;
            else if (grid[0, 0] == 0)
                grid[0, 0] = 2;
            else if (grid[0, 1] == 0)
                grid[0, 1] = 2;
            else if (grid[1, 0] == 0)
                grid[1, 0] = 2;
            else if (grid[2, 1] == 0)
                grid[2, 1] = 2;
            else if (grid[1, 2] == 0)
                grid[1, 2] = 2;
        }

        public int CheckWin()             // checks for a winning move, clears board if so
        {
            if (grid[0, 0] == grid[0, 1] && grid[0, 1] == grid[0, 2])   // checks win in first row
                return grid[0, 0];

            else if (grid[1, 0] == grid[1, 1] && grid[1, 1] == grid[1, 2])  // second row
                return grid[1, 0];

            else if (grid[2, 0] == grid[2, 1] && grid[2, 1] == grid[2, 2])  // third row
                return grid[2, 0];

            else if (grid[0, 0] == grid[1, 0] && grid[1, 0] == grid[2, 0])  // first column
                return grid[0, 0];

            else if (grid[0, 1] == grid[1, 1] && grid[1, 1] == grid[2, 1])  // second column
                return grid[0, 1];

            else if (grid[0, 2] == grid[1, 2] && grid[1, 2] == grid[2, 2])  // third column
                return grid[0, 2];

            else if (grid[0, 0] == grid[1, 1] && grid[1, 1] == grid[2, 2])  // first diag
                return grid[0, 0];

            else if (grid[0, 2] == grid[1, 1] && grid[1, 1] == grid[2, 0])  // second diag
                return grid[0, 2];

            else return 0;      // if no win return 0
        }
    }
}
