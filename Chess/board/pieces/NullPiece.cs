using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.board.pieces
{
    class NullPiece : Piece
    {
        public override void print()
        {
            Console.Write("   ");
        }

        public override void moveWhitePiece(Board board, BoardSquare source, BoardSquare target)
        {
            throw new MovementError();
        }

        public override void moveBlackPiece(Board board, BoardSquare source, BoardSquare target)
        {
            throw new MovementError();
        }

        public override void replaceWithBlackPiece(Piece new_piece)
        {
            //throw new MovementError();
        }

        public override void replaceWithWhitePiece(Piece new_piece)
        {
            //throw new MovementError();
        }

        public override bool isNull()
        {
            return true;
        }

        public override bool isBlack()
        {
            return false;
        }

        public override bool isWhite()
        {
            return false;
        }

        public override void movePiece(Board board, BoardSquare source, BoardSquare target)
        {
            throw new MovementError();
        }

    }
}
