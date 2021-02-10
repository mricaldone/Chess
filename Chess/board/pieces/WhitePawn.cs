using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.board.pieces
{
    class WhitePawn : WhitePiece
    {
        public override void print()
        {
            Console.Write(" \u2659 ");
        }

        public override void movePiece(Board board, BoardSquare source, BoardSquare target)
        {
            if (board.isVerticalWayBlocked(source, target)) throw new MovementError();
            if (target.getPiece().isNull() && source.rowNumber() - 1 == target.rowNumber() && source.columnNumber() == target.columnNumber()) return;
            if (target.getPiece().isNull() && source.rowNumber() == 6 && target.rowNumber() == 4 && source.columnNumber() == target.columnNumber()) return;
            if (target.getPiece().isBlack() && source.columnNumber() + 1 == target.columnNumber() && source.rowNumber() - 1 == target.rowNumber()) return;
            if (target.getPiece().isBlack() && source.columnNumber() - 1 == target.columnNumber() && source.rowNumber() - 1 == target.rowNumber()) return;
            //FALTA PEON AL PASO
            throw new MovementError();
        }
    }
}
