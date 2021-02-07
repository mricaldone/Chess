using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.board.pieces
{
    class BlackHorse : BlackPiece
    {
        public override void print()
        {
            Console.Write(" \u265E ");
        }

        public override void canMove(BoardSquare source, BoardSquare target)
        {
            if (!target.getPiece().isBlack() && source.rowNumber() + 1 == target.rowNumber() && source.columnNumber() + 2 == target.columnNumber()) return;
            if (!target.getPiece().isBlack() && source.rowNumber() + 1 == target.rowNumber() && source.columnNumber() - 2 == target.columnNumber()) return;
            if (!target.getPiece().isBlack() && source.rowNumber() + 2 == target.rowNumber() && source.columnNumber() + 1 == target.columnNumber()) return;
            if (!target.getPiece().isBlack() && source.rowNumber() + 2 == target.rowNumber() && source.columnNumber() - 1 == target.columnNumber()) return;
            if (!target.getPiece().isBlack() && source.rowNumber() - 1 == target.rowNumber() && source.columnNumber() + 2 == target.columnNumber()) return;
            if (!target.getPiece().isBlack() && source.rowNumber() - 1 == target.rowNumber() && source.columnNumber() - 2 == target.columnNumber()) return;
            if (!target.getPiece().isBlack() && source.rowNumber() - 2 == target.rowNumber() && source.columnNumber() + 1 == target.columnNumber()) return;
            if (!target.getPiece().isBlack() && source.rowNumber() - 2 == target.rowNumber() && source.columnNumber() - 1 == target.columnNumber()) return;
            throw new MovementError();
        }
    }
}
