using System;
using System.Collections.Generic;
using System.Text;
using Chess.board.pieces;

namespace Chess.board
{
    class Board
    {
        private Square[,] squares = new Square[8,8];

        public Board()
        {
            this.initialize();
        }

        private void initialize()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    this.squares[i, j] = new Square();
                }
            }
            this.squares[7,0].set(new WhiteTower());
            this.squares[7,1].set(new WhiteHorse());
            this.squares[7,2].set(new WhiteBishop());
            this.squares[7,3].set(new WhiteQueen());
            this.squares[7,4].set(new WhiteKing());
            this.squares[7,5].set(new WhiteBishop());
            this.squares[7,6].set(new WhiteHorse());
            this.squares[7,7].set(new WhiteTower());
            for (int j = 0; j < 8; j++) this.squares[6, j].set(new WhitePawn());
            for (int j = 0; j < 8; j++) this.squares[1, j].set(new BlackPawn());
            this.squares[0,0].set(new BlackTower());
            this.squares[0,1].set(new BlackHorse());
            this.squares[0,2].set(new BlackBishop());
            this.squares[0,3].set(new BlackQueen());
            this.squares[0,4].set(new BlackKing());
            this.squares[0,5].set(new BlackBishop());
            this.squares[0,6].set(new BlackHorse());
            this.squares[0,7].set(new BlackTower());
        }

        public void print()
        {
            ConsoleColor current_color = Console.BackgroundColor;
            Console.WriteLine("    a  b  c  d  e  f  g  h ");
            for (int i = 0; i < 8; i++)
            {
                Console.BackgroundColor = current_color;
                Console.Write(String.Format(" {0} ", 8 - i));
                for (int j = 0; j < 8; j++)
                {
                    ConsoleColor bg_color = ConsoleColor.Gray;
                    if ((j + i) % 2 != 0)
                    {
                        bg_color = ConsoleColor.DarkGray;
                    }
                    Console.BackgroundColor = bg_color;
                    Console.Write(" ");
                    this.squares[i, j].print();
                    Console.Write(" ");
                }
                Console.BackgroundColor = current_color;
                Console.Write(String.Format(" {0} ", 8 - i));
                Console.WriteLine();
            }
            Console.BackgroundColor = current_color;
            Console.WriteLine("    a  b  c  d  e  f  g  h ");
        }

    }
}
