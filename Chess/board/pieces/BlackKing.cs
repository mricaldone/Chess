using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.board.pieces
{
    class BlackKing : King
    {
        public override void print()
        {
            ConsoleColor current_color = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("\u265A");
            Console.ForegroundColor = current_color;
        }
    }
}
