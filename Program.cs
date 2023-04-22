using System;
using System.Collections.Generic;

namespace SnakeGame
{
    class Program
    {
        static int N = 10;
        static int M = 10;
        static int speed = 1;
        static int score = 0;

        static string SKIN = "*";
        static string BRICK = "#";
        static string SPACE = " ";
       
        static string[,] board = new string[N, M];
        static Snake snake = new Snake();
        static Food food = new Food();
        

        private static void calcWall()
        {
            for (int i = 0; i < N; i++) 
            {
                for (int j = 0; j < M; j++)
                {
                    if (i == 0 || i == N - 1 || j == 0 ||j == M-1)
                    {
                        board[i, j] = BRICK;
                    }
                }
            }
        }

        private static void calcSnake()
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                   int row = snake.Head.Row;
                   int column = snake.Head.Column; 
                    if (i ==row && j == column)
                    {
                        board[i, j] = SKIN;
                    }
                }
            }
        }

        private static void calcFood()
        {

        }

        private static void resetBoard()
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    board[i, j] = SPACE;
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
                    if(value.Equals(BRICK))
                        {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write(value);
                        Console.ResetColor();
                    }
                    else
                    {

                    }
                    Console.Write(value);
                }

                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Console.Clear();
            resetBoard();
            calcWall();
            calcSnake();
            printBoard();
        }
    }
}
