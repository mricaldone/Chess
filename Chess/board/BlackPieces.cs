using System;
using System.Collections.Generic;
using System.Text;
using Chess.board.pieces;

namespace Chess.board
{
    public class BlackPieces : Pieces
    {
        private Board board;
        private List<Piece> pieces;

        public BlackPieces(Board board)
        {
            this.board = board;
            this.initialize();
        }

        public void initialize()
        {
            this.pieces = new List<Piece>();
            this.add(new BlackTower(), 0, 0);
            this.add(new BlackHorse(), 0, 1);
            this.add(new BlackBishop(), 0, 2);
            this.add(new BlackQueen(), 0, 3);
            this.add(new BlackKing(), 0, 4);
            this.add(new BlackBishop(), 0, 5);
            this.add(new BlackHorse(), 0, 6);
            this.add(new BlackTower(), 0, 7);
            for (uint j = 0; j < 8; j++) this.add(new BlackPawn(), 1, j);
        }

        public void add(Piece piece, uint i, uint j)
        {
            this.pieces.Add(piece);
            this.board.set(piece, i, j);
        }

        public void move(Movement movement)
        {
            this.board.moveBlackPiece(movement);
        }

        public override String ToString()
        {
            return "BLACK";
        }

    }
}
