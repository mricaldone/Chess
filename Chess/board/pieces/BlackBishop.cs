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

        private bool canMove(Board board, BoardSquare source, BoardSquare target)
        {
            if (board.isDiagonalWayBlocked(source, target)) return false;
            if (!target.getPiece().isBlack() && source.rowNumber() - target.rowNumber() == source.columnNumber() - target.columnNumber()) return true;
            if (!target.getPiece().isBlack() && source.rowNumber() - target.rowNumber() == target.columnNumber() - source.columnNumber()) return true;
            return false;
        }

        public override void movePiece(Board board, BoardSquare source, BoardSquare target)
        {
            if (!this.canMove(board, source, target)) throw new MovementError();
        }

    }
}
