using System;
using System.Collections.Generic;
using System.Text;
using Chess.board.pieces;

namespace Chess.board
{
    public class WhitePieces : Pieces
    {
        private Board board;
        private List<Piece> pieces;

        public WhitePieces(Board board)
        {
            this.board = board;
            this.initialize();
        }

        private void initialize()
        {
            this.pieces = new List<Piece>();
            this.add(new WhiteTower(), 7, 0);
            this.add(new WhiteHorse(), 7, 1);
            this.add(new WhiteBishop(), 7, 2);
            this.add(new WhiteQueen(), 7, 3);
            this.add(new WhiteKing(), 7, 4);
            this.add(new WhiteBishop(), 7, 5);
            this.add(new WhiteHorse(), 7, 6);
            this.add(new WhiteTower(), 7, 7);

            for (uint j = 0; j < 8; j++) this.add(new WhitePawn(), 6, j);
        }

        public void add(Piece piece, uint i, uint j)
        {
            this.pieces.Add(piece);
            this.board.set(piece, i, j);
        }

        public void move(Movement movement)
        {
            this.board.moveWhitePiece(movement);
        }

        public override String ToString()
        {
            return "WHITE";
        }

    }
}
