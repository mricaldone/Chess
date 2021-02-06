using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.board.pieces
{
    class BlackQueen : Queen
    {
        public override void print()
        {
            ConsoleColor current_color = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("\u265B");
            Console.ForegroundColor = current_color;
        }
    }
}
