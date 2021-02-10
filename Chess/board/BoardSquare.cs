using System;
using System.Collections.Generic;
using System.Text;
using Chess.board.pieces;

namespace Chess.board
{
    public class BoardSquare
    {
        private Piece piece;
        private uint row;
        private uint column;
        private Board board;

        public BoardSquare(Board board, uint row, uint column)
        {
            this.piece = new NullPiece();
            this.row = row;
            this.column = column;
            this.board = board;
        }

        public int rowNumber()
        {
            return (int) this.row;
        }

        public int columnNumber()
        {
            return (int) this.column;
        }

        public void setBlackPiece(Piece piece)
        {
            this.piece.replaceWithBlackPiece(piece);
            this.piece = piece;
        }

        public void setWhitePiece(Piece piece)
        {
            this.piece.replaceWithWhitePiece(piece);
            this.piece = piece;
        }

        public void set(Piece piece)
        {
            this.piece = piece;
        }

        public void print()
        {
            ConsoleColor color = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Black;
            this.piece.print();
            Console.ForegroundColor = color;
        }

        public void moveBlackPieceTo(BoardSquare target)
        {
            if (this == target) throw new MovementError();
            this.piece.moveBlackPiece(this.board, this, target);
            this.piece = new NullPiece();
        }

        public void moveWhitePieceTo(BoardSquare target)
        {
            if (this == target) throw new MovementError();
            this.piece.moveWhitePiece(this.board, this, target);
            this.piece = new NullPiece();
        }

        public Piece getPiece()
        {
            return this.piece;
        }

    }
}
