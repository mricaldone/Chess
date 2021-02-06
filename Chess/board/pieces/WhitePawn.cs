using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.board.pieces
{
    class WhitePawn : Pawn
    {
        public override void print()
        {
            ConsoleColor current_color = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("\u2659");
            Console.ForegroundColor = current_color;
        }
    }
}
