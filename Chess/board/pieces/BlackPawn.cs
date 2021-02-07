using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.board.pieces
{
    class BlackPawn : BlackPiece
    {
        public override void print()
        {
            Console.Write(" \u265F");
        }

        public override void canMove(BoardSquare source, BoardSquare target)
        {
            if (target.getPiece().isNull() && source.rowNumber() + 1 == target.rowNumber() && source.columnNumber() == target.columnNumber()) return;
            if (target.getPiece().isNull() && source.rowNumber() == 1 && target.rowNumber() == 3 && source.columnNumber() == target.columnNumber()) return;
            if (target.getPiece().isWhite() && source.columnNumber() + 1 == target.columnNumber() && source.rowNumber() + 1 == target.rowNumber()) return;
            if (target.getPiece().isWhite() && source.columnNumber() - 1 == target.columnNumber() && source.rowNumber() + 1 == target.rowNumber()) return;
            //FALTA PEON AL PASO
            throw new MovementError();
        }
    }
}
