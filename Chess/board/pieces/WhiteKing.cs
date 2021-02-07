using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.board.pieces
{
    class WhiteKing : WhitePiece
    {
        public override void print()
        {
            Console.Write(" \u2654 ");
        }

        public override void canMove(BoardSquare source, BoardSquare target)
        {
            if (!target.getPiece().isWhite() && source.rowNumber() + 0 == target.rowNumber() && source.columnNumber() + 1 == target.columnNumber()) return;
            if (!target.getPiece().isWhite() && source.rowNumber() + 0 == target.rowNumber() && source.columnNumber() - 1 == target.columnNumber()) return;
            if (!target.getPiece().isWhite() && source.rowNumber() + 1 == target.rowNumber() && source.columnNumber() + 0 == target.columnNumber()) return;
            if (!target.getPiece().isWhite() && source.rowNumber() + 1 == target.rowNumber() && source.columnNumber() + 1 == target.columnNumber()) return;
            if (!target.getPiece().isWhite() && source.rowNumber() + 1 == target.rowNumber() && source.columnNumber() - 1 == target.columnNumber()) return;
            if (!target.getPiece().isWhite() && source.rowNumber() - 1 == target.rowNumber() && source.columnNumber() + 0 == target.columnNumber()) return;
            if (!target.getPiece().isWhite() && source.rowNumber() - 1 == target.rowNumber() && source.columnNumber() + 1 == target.columnNumber()) return;
            if (!target.getPiece().isWhite() && source.rowNumber() - 1 == target.rowNumber() && source.columnNumber() - 1 == target.columnNumber()) return;
            throw new MovementError();
        }
    }
}
