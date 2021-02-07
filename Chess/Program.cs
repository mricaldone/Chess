using System;
using System.Collections.Generic;
using System.Text;
using Chess.board.pieces;
using Chess.board;
using System.Threading;

namespace Chess
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Board board = new Board();
            BlackPieces blacks = new BlackPieces(board);
            WhitePieces whites = new WhitePieces(board);
            Turns turns = new Turns();
            turns.add(whites);
            turns.add(blacks);
            String last_move = "";
            while (true)
            {
                Console.Clear();
                board.print();
                Console.WriteLine();
                Console.WriteLine(last_move);
                Pieces pieces = turns.getCurrent();
                try
                {
                    Console.Write(pieces + "> ");
                    String move = Console.ReadLine();
                    Movement movement = new Movement(move);
                    pieces.move(movement);
                    //board.move(movement);
                    turns.next();
                    last_move = pieces + "> " + move;
                }
                catch (MovementError)
                {
                    ClearLastConsoleLine();
                    Console.WriteLine(pieces + "> Invalid movement!");
                    Thread.Sleep(1000);
                }
            }
        }

        public static void ClearLastConsoleLine()
        {
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, currentLineCursor - 1);
        }

    }
}
