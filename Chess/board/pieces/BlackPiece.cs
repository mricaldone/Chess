using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.board.pieces
{
    public abstract class BlackPiece : Piece
    {
        public override void moveBlackPieceTo(BoardSquare target)
        {
            target.setBlackPiece(this);
        }

        public override void moveWhitePieceTo(BoardSquare target)
        {
            throw new MovementError();
        }

        public override void replaceWithBlackPiece(Piece new_piece)
        {
            throw new MovementError();
        }

        public override void replaceWithWhitePiece(Piece new_piece)
        {
            //throw new MovementError();
        }

    }
}
