using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.board.pieces
{
    public abstract class Piece
    {
        public abstract void print();
        public abstract void moveBlackPieceTo(BoardSquare target);
        public abstract void moveWhitePieceTo(BoardSquare target);
        public abstract void replaceWithBlackPiece(Piece new_piece);
        public abstract void replaceWithWhitePiece(Piece new_piece);
    }
}
