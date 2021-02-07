using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.board.pieces
{
    class BlackHorse : BlackPiece
    {
        public override void print()
        {
            Console.Write(" \u265E ");
        }
    }
}
