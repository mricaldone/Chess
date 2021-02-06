using System;
using System.Collections.Generic;
using System.Text;
using Chess.board.pieces;
using Chess.board;

namespace Chess
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Board board = new Board();
            Boolean play_white = true;
            while (true)
            {
                Console.Clear();
                board.print();
                Console.WriteLine();
                if(play_white) Console.Write("WHITE> ");
                else Console.Write("BLACK> ");
                Console.Read();
                play_white = !play_white;
            }
        }
    }
}
