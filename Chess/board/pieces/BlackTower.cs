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

        public override void movePiece(Board board, BoardSquare source, BoardSquare target)
        {
            if (board.isVerticalWayBlocked(source, target) || board.isHorizontalWayBlocked(source, target)) throw new MovementError();
            if (!target.getPiece().isBlack() && target.rowNumber() == source.rowNumber()) return;
            if (!target.getPiece().isBlack() && target.columnNumber() == source.columnNumber()) return;
            throw new MovementError();
        }
    }
}
