using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.board.pieces
{
    class BlackBishop : BlackPiece
    {
        public override void print()
        {
            Console.Write(" \u265D ");
        }

        public override void canMove(BoardSquare source, BoardSquare target)
        {
            if (!target.getPiece().isBlack() && source.rowNumber() - target.rowNumber() == source.columnNumber() - target.columnNumber()) return;
            if (!target.getPiece().isBlack() && source.rowNumber() - target.rowNumber() == target.columnNumber() - source.columnNumber()) return;
            throw new MovementError();
        }

    }
}
