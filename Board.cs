using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoard
{

    internal class Board
    {
        private Figure[,] board;
        private readonly Dictionary<char, int> letters = new Dictionary<char, int>
        {
            {'a', 0 },
            {'b', 1 },
            {'c', 2 },
            {'d', 3 },
            {'e', 4 },
            {'f', 5 },
            {'g', 6 },
            {'h', 7 }
        };
        
        public Board()
        {
            board = new Figure[8, 8];
            for(int i = 0; i < 8; i++)
            {
                for(int j = 0; j < 8; j++)
                {
                    board[i, j] = new Figure(FigureType.None);
                }
            }
        }

        public void AddFigure(Figure figure, char x, int y)
        {
            int index = letters[x];
            board[Math.Abs(y - 8), index] = figure;
        }

        public void Print()
        {
            for (int row = 0; row < board.GetLength(0); row++)
            {
                for (int col = 0; col < board.GetLength(1); col++)
                {

                    if ((row + col) % 2 == 0)
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        if (board[row, col].type == FigureType.King)
                        {
                            Console.ForegroundColor = (ConsoleColor)board[row, col].color;

                            Console.Write('♔');
                        }
                        else if (board[row, col].type == FigureType.Queen)
                        {
                            Console.ForegroundColor = (ConsoleColor)board[row, col].color;
                            Console.Write('♕');
                        }
                        else if (board[row, col].type == FigureType.Rook)
                        {
                            Console.ForegroundColor = (ConsoleColor)board[row, col].color;
                            Console.Write('♖');
                        }
                        else if (board[row, col].type == FigureType.Bishop)
                        {
                            Console.ForegroundColor = (ConsoleColor)board[row, col].color;
                            Console.Write('♗');
                        }
                        else if (board[row, col].type == FigureType.Knight)
                        {
                            Console.ForegroundColor = (ConsoleColor)board[row, col].color;
                            Console.Write('♘');
                        }
                        else if (board[row, col].type == FigureType.Pawn)
                        {
                            Console.ForegroundColor = (ConsoleColor)board[row, col].color;
                            Console.Write('♙');
                        }
                        else
                        {
                            Console.Write(' ');
                        }
                        
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        if (board[row, col].type == FigureType.King)
                        {
                            Console.ForegroundColor = (ConsoleColor)board[row, col].color;

                            Console.Write('♔');
                        }
                        else if (board[row, col].type == FigureType.Queen)
                        {
                            Console.ForegroundColor = (ConsoleColor)board[row, col].color;
                            Console.Write('♕');
                        }
                        else if (board[row, col].type == FigureType.Rook)
                        {
                            Console.ForegroundColor = (ConsoleColor)board[row, col].color;
                            Console.Write('♖');
                        }
                        else if (board[row, col].type == FigureType.Bishop)
                        {
                            Console.ForegroundColor = (ConsoleColor)board[row, col].color;
                            Console.Write('♗');
                        }
                        else if (board[row, col].type == FigureType.Knight)
                        {
                            Console.ForegroundColor = (ConsoleColor)board[row, col].color;
                            Console.Write('♘');
                        }
                        else if (board[row, col].type == FigureType.Pawn)
                        {
                            Console.ForegroundColor = (ConsoleColor)board[row, col].color;
                            Console.Write('♙');
                        }
                        else
                        {
                            Console.Write(' '); 
                        }
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
