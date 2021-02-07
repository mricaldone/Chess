using System;
using System.Collections.Generic;
using System.Text;
using Chess.board.pieces;

namespace Chess.board
{
    public class BoardSquare
    {
        private Piece piece;

        public BoardSquare(){
            this.piece = new NullPiece();
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
            this.piece.moveBlackPieceTo(target);
            this.piece = new NullPiece();
        }

        public void moveWhitePieceTo(BoardSquare target)
        {
            if (this == target) throw new MovementError();
            this.piece.moveWhitePieceTo(target);
            this.piece = new NullPiece();
        }

    }
}
