using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.board.pieces
{
    class WhiteHorse : WhitePiece
    {
        public override void print()
        {
            Console.Write(" \u2658 ");
        }

        public override void movePiece(Board board, BoardSquare source, BoardSquare target)
        {
            if (!target.getPiece().isWhite() && source.rowNumber() + 1 == target.rowNumber() && source.columnNumber() + 2 == target.columnNumber()) return;
            if (!target.getPiece().isWhite() && source.rowNumber() + 1 == target.rowNumber() && source.columnNumber() - 2 == target.columnNumber()) return;
            if (!target.getPiece().isWhite() && source.rowNumber() + 2 == target.rowNumber() && source.columnNumber() + 1 == target.columnNumber()) return;
            if (!target.getPiece().isWhite() && source.rowNumber() + 2 == target.rowNumber() && source.columnNumber() - 1 == target.columnNumber()) return;
            if (!target.getPiece().isWhite() && source.rowNumber() - 1 == target.rowNumber() && source.columnNumber() + 2 == target.columnNumber()) return;
            if (!target.getPiece().isWhite() && source.rowNumber() - 1 == target.rowNumber() && source.columnNumber() - 2 == target.columnNumber()) return;
            if (!target.getPiece().isWhite() && source.rowNumber() - 2 == target.rowNumber() && source.columnNumber() + 1 == target.columnNumber()) return;
            if (!target.getPiece().isWhite() && source.rowNumber() - 2 == target.rowNumber() && source.columnNumber() - 1 == target.columnNumber()) return;
            throw new MovementError();
        }
    }
}
