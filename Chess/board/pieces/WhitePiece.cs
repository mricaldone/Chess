﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.board.pieces
{
    public abstract class WhitePiece : Piece
    {
        public override void moveBlackPieceTo(BoardSquare target)
        {
            throw new MovementError();
        }

        public override void moveWhitePieceTo(BoardSquare target)
        {
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
    }
}