using System;
using System.Collections.Generic;
using System.Text;
using Chess.board.pieces;

namespace Chess.board
{
    public class Board
    {
        private BoardSquare[,] squares;

        public Board()
        {
            this.initialize();
        }

        public void initialize()
        {
            this.squares = new BoardSquare[8,8];
            for (uint i = 0; i < 8; i++)
            {
                for (uint j = 0; j < 8; j++)
                {
                    this.squares[i, j] = new BoardSquare(this, i, j);
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

        public bool isHorizontalWayBlocked(BoardSquare source, BoardSquare target)
        {
            int start = Math.Min(source.columnNumber(), target.columnNumber());
            int end = Math.Max(source.columnNumber(), target.columnNumber());
            for (int i = 1; i < end - start; i++) if (!this.squares[source.rowNumber(), start + i].getPiece().isNull()) return true;
            return false;
        }

        public bool isVerticalWayBlocked(BoardSquare source, BoardSquare target)
        {
            int start = Math.Min(source.rowNumber(), target.rowNumber());
            int end = Math.Max(source.rowNumber(), target.rowNumber());
            for (int i = 1; i < end - start; i++) if (!this.squares[start + i, source.columnNumber()].getPiece().isNull()) return true;
            return false;
        }

        public bool isDiagonalWayBlocked(BoardSquare source, BoardSquare target)
        {
            int rstart = Math.Min(source.rowNumber(), target.rowNumber());
            int rend = Math.Max(source.rowNumber(), target.rowNumber());
            int cstart = Math.Min(source.columnNumber(), target.columnNumber());
            int cend = Math.Max(source.columnNumber(), target.columnNumber());
            if (rend - rstart != cend - cstart) return false;
            for (int i = 1; i < rend - rstart; i++) if (!this.squares[rstart + i, cstart + i].getPiece().isNull()) return true;
            return false;
        }

    }
}
