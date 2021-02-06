using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.board.pieces
{
    class WhiteTower : Tower
    {
        public override void print()
        {
            ConsoleColor current_color = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("\u2656");
            Console.ForegroundColor = current_color;
        }
    }
}
