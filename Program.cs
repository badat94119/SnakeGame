using System;
using System.Collections.Generic;

namespace SnakeGame
{
    class Program
    {
        static int N = 23;
        static int M = 23;

        static string[,] board = new string[N, M];

        private static void calcWall()
        {
            for (int i = 0; i < N; i++) 
            {
                for (int j = 0; j < M; j++)
                {
                    if (i == 0 || i == N - 1 || j == 0 ||j==M)
                    {
                        board[i, j] = "#";
                    }
                }
            }
        }

        private static void resetBoard()
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    board[i, j] = "";
                }

                Console.WriteLine();
            }
        }

        private static void printBoard()
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++) 
                {
                    string value = board[i, j];
                    Console.Write(value);
                }

                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            resetBoard();
            calcWall();
            printBoard();
        }
    }
}
