using System;
using System.Collections.Generic;
using System.Text;
using Chess.board.pieces;

namespace Chess.board
{
    public class Board
    {
        private BoardSquare[,] squares = new BoardSquare[8,8];

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
                    this.squares[i, j] = new BoardSquare();
                }
            }
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
                    this.squares[i, j].print();
                }
                Console.BackgroundColor = current_color;
                Console.Write(String.Format(" {0} ", 8 - i));
                Console.WriteLine();
            }
            Console.BackgroundColor = current_color;
            Console.WriteLine("    a  b  c  d  e  f  g  h ");
        }
        
        public void moveWhitePiece(Movement movement)
        {
            try
            {
                BoardSquare target = this.squares[movement.target.row, movement.target.column];
                BoardSquare source = this.squares[movement.source.row, movement.source.column];
                source.moveWhitePieceTo(target);
            }
            catch (IndexOutOfRangeException)
            {
                throw new MovementError();
            }
        }

        public void moveBlackPiece(Movement movement)
        {
            try
            {
                BoardSquare target = this.squares[movement.target.row, movement.target.column];
                BoardSquare source = this.squares[movement.source.row, movement.source.column];
                source.moveBlackPieceTo(target);
            }
            catch (IndexOutOfRangeException)
            {
                throw new MovementError();
            }
        }
        
        public void set(Piece piece, uint i, uint j)
        {
            this.squares[i, j].set(piece);
        }

    }
}
