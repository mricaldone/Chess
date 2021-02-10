using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.board.pieces
{
    public abstract class Piece
    {
        public abstract void print();
        public abstract void moveBlackPiece(Board board, BoardSquare source, BoardSquare target);
        public abstract void moveWhitePiece(Board board, BoardSquare source, BoardSquare target);
        public abstract void replaceWithBlackPiece(Piece new_piece);
        public abstract void replaceWithWhitePiece(Piece new_piece);
        public abstract void movePiece(Board board, BoardSquare source, BoardSquare target);
        public abstract bool isWhite();
        public abstract bool isBlack();
        public abstract bool isNull();
    }
}
