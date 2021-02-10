using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.board.pieces
{
    class WhiteQueen : WhitePiece
    {
        public override void print()
        {
            Console.Write(" \u2655 ");
        }

        public override void movePiece(Board board, BoardSquare source, BoardSquare target)
        {
            if (board.isDiagonalWayBlocked(source, target)) throw new MovementError();
            if (board.isVerticalWayBlocked(source, target) || board.isHorizontalWayBlocked(source, target)) throw new MovementError();
            if (!target.getPiece().isWhite() && target.rowNumber() == source.rowNumber()) return;
            if (!target.getPiece().isWhite() && target.columnNumber() == source.columnNumber()) return; 
            if (!target.getPiece().isWhite() && source.rowNumber() - target.rowNumber() == source.columnNumber() - target.columnNumber()) return;
            if (!target.getPiece().isWhite() && source.rowNumber() - target.rowNumber() == target.columnNumber() - source.columnNumber()) return;
            throw new MovementError();
        }
    }
}
