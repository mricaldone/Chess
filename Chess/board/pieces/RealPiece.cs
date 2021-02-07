using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.board.pieces
{
    public abstract class RealPiece : Piece
    {
        public override bool isNull()
        {
            return false;
        }
    }
}
