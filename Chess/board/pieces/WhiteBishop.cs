using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.board.pieces
{
    class WhiteBishop : Bishop
    {
        public override void print()
        {
            ConsoleColor current_color = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("\u2657");
            Console.ForegroundColor = current_color;
        }
    }
}
