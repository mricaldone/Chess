using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.board.pieces
{
    class BlackTower : BlackPiece
    {
        public override void print()
        {
            Console.Write(" \u265C ");
        }

        public override void canMove(BoardSquare source, BoardSquare target)
        {
            if (!target.getPiece().isBlack() && target.rowNumber() == source.rowNumber()) return;
            if (!target.getPiece().isBlack() && target.columnNumber() == source.columnNumber()) return;
            throw new MovementError();
        }
    }
}
