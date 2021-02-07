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
    }
}
