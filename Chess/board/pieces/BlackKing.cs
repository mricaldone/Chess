using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.board.pieces
{
    class BlackKing : BlackPiece
    {
        public override void print()
        {
            Console.Write(" \u265A ");
        }

        public override void canMove(BoardSquare source, BoardSquare target)
        {
            if (!target.getPiece().isBlack() && source.rowNumber() + 0 == target.rowNumber() && source.columnNumber() + 1 == target.columnNumber()) return;
            if (!target.getPiece().isBlack() && source.rowNumber() + 0 == target.rowNumber() && source.columnNumber() - 1 == target.columnNumber()) return;
            if (!target.getPiece().isBlack() && source.rowNumber() + 1 == target.rowNumber() && source.columnNumber() + 0 == target.columnNumber()) return;
            if (!target.getPiece().isBlack() && source.rowNumber() + 1 == target.rowNumber() && source.columnNumber() + 1 == target.columnNumber()) return;
            if (!target.getPiece().isBlack() && source.rowNumber() + 1 == target.rowNumber() && source.columnNumber() - 1 == target.columnNumber()) return;
            if (!target.getPiece().isBlack() && source.rowNumber() - 1 == target.rowNumber() && source.columnNumber() + 0 == target.columnNumber()) return;
            if (!target.getPiece().isBlack() && source.rowNumber() - 1 == target.rowNumber() && source.columnNumber() + 1 == target.columnNumber()) return;
            if (!target.getPiece().isBlack() && source.rowNumber() - 1 == target.rowNumber() && source.columnNumber() - 1 == target.columnNumber()) return;
            throw new MovementError();
        }
    }
}
