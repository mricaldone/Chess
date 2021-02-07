using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.board.pieces
{
    class WhiteTower : WhitePiece
    {
        public override void print()
        {
            Console.Write(" \u2656 ");
        }

        public override void canMove(BoardSquare source, BoardSquare target)
        {
            if (!target.getPiece().isWhite() && target.rowNumber() == source.rowNumber()) return;
            if (!target.getPiece().isWhite() && target.columnNumber() == source.columnNumber()) return;
            throw new MovementError();
        }
    }
}
