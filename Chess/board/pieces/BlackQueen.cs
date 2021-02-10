using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.board.pieces
{
    class BlackQueen : BlackPiece
    {
        public override void print()
        {
            Console.Write(" \u265B ");
        }

        public override void movePiece(Board board, BoardSquare source, BoardSquare target)
        {
            if (board.isDiagonalWayBlocked(source, target)) throw new MovementError();
            if (board.isVerticalWayBlocked(source, target) || board.isHorizontalWayBlocked(source, target)) throw new MovementError();
            if (!target.getPiece().isBlack() && target.rowNumber() == source.rowNumber()) return;
            if (!target.getPiece().isBlack() && target.columnNumber() == source.columnNumber()) return;
            if (!target.getPiece().isBlack() && source.rowNumber() - target.rowNumber() == source.columnNumber() - target.columnNumber()) return;
            if (!target.getPiece().isBlack() && source.rowNumber() - target.rowNumber() == target.columnNumber() - source.columnNumber()) return;
            throw new MovementError();
        }
    }
}
