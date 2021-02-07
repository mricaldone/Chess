using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.board.pieces
{
    class BlackTower : BlackPiece
    {
        public override void print()
        {
            Console.Write(" \u265C ");
        }
    }
}
