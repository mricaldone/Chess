using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.board.pieces
{
    public abstract class WhitePiece : RealPiece
    {
        public override void moveBlackPiece(Board board, BoardSquare source, BoardSquare target)
        {
            throw new MovementError();
        }

        public override void moveWhitePiece(Board board, BoardSquare source, BoardSquare target)
        {
            this.movePiece(board, source, target);
            target.setWhitePiece(this);
        }

        public override void replaceWithBlackPiece(Piece new_piece)
        {
            //throw new MovementError();
        }

        public override void replaceWithWhitePiece(Piece new_piece)
        {
            throw new MovementError();
        }

        public override bool isWhite()
        {
            return true;
        }

        public override bool isBlack()
        {
            return false;
        }
    }
}
