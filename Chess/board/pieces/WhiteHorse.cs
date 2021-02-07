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
    }
}
