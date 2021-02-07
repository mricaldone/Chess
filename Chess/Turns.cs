using System;
using System.Collections.Generic;
using System.Text;

namespace Chess
{
    class Turns
    {
        private List<Pieces> pieces = new List<Pieces>();
        private int index = 0;

        public void add(Pieces pieces)
        {
            this.pieces.Add(pieces);
        }

        public Pieces getCurrent()
        {
            try
            {
                return this.pieces[this.index];
            }
            catch (ArgumentOutOfRangeException)
            {
                this.index = 0;
                return this.pieces[this.index];
            }
        }

        public void next()
        {
            this.index++;
        }
    }
}
