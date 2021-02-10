using System;
using System.Collections.Generic;
using System.Text;
using Chess.board;
using Chess.board.pieces;
using System.Threading;

namespace Chess.tests
{
    class TestManager
    {
        private Board board;

        public TestManager()
        {
            try
            {
                this.board = new Board();
                this.testQueensMovement();
                Console.WriteLine("All tests OK!");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                this.board.print();
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.ReadKey();
            }
        }

        private void moveBlackPiece(String movement)
        {
            Console.WriteLine("Movement: " + movement);
            this.board.moveBlackPiece(new Movement(movement));
            Console.Clear();
            Console.WriteLine("Movement: " + movement);
            this.board.print();
            Thread.Sleep(200);
        }

        private void moveBlackPieceAndBack(String movement)
        {
            this.moveBlackPiece(movement);
            this.moveBlackPiece(movement.Substring(2,2) + movement.Substring(0,2));
        }

        private void testInvalidBlackMovement(String movement)
        {
            try
            {
                this.moveBlackPiece(movement);
                Console.WriteLine("This must throws MovementError but nothing happens");
                throw new Exception();
            }
            catch (MovementError)
            {
                Console.WriteLine("MovementError expected ok!");
                return;
            }
        }

        private void testQueensMovement()
        {
            this.board.initialize();
            this.board.set(new BlackQueen(), 4, 4);
            //VALID SHORT
            this.moveBlackPieceAndBack("e4e5");
            this.moveBlackPieceAndBack("e4f5");
            this.moveBlackPieceAndBack("e4f4");
            this.moveBlackPieceAndBack("e4f3");
            this.moveBlackPieceAndBack("e4e3");
            this.moveBlackPieceAndBack("e4d3");
            this.moveBlackPieceAndBack("e4d4");
            this.moveBlackPieceAndBack("e4d5");
            //VALID LONG
            this.moveBlackPieceAndBack("e4e8");
            this.moveBlackPieceAndBack("e4h7");
            this.moveBlackPieceAndBack("e4h4");
            this.moveBlackPieceAndBack("e4h1");
            this.moveBlackPieceAndBack("e4e1");
            this.moveBlackPieceAndBack("e4b1");
            this.moveBlackPieceAndBack("e4a4");
            this.moveBlackPieceAndBack("e4a8");
            //INVALID
            this.testInvalidBlackMovement("e4e4");
            this.testInvalidBlackMovement("e4e0");
            this.testInvalidBlackMovement("e4e9");
            this.testInvalidBlackMovement("e4i4");
            this.testInvalidBlackMovement("e4g3");
            this.board.set(new WhitePawn(), 4, 6);
            this.testInvalidBlackMovement("e4h4");
            this.moveBlackPieceAndBack("e4f4");
        }

    }
}
