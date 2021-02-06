using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.board.pieces
{
    class NullPiece : Piece
    {
        public void print()
        {
            Console.Write(" ");
        }
    }
}
