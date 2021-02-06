using System;
using System.Collections.Generic;
using System.Text;
using Chess.board.pieces;

namespace Chess.board
{
    class Square
    {
        private Piece piece;

        public Square(){
            this.piece = new NullPiece();
        }

        public void set(Piece piece)
        {
            this.piece = piece;
        }

        public void print()
        {
            this.piece.print();
        }
    }
}
