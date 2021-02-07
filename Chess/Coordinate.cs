using System;
using System.Collections.Generic;
using System.Text;

namespace Chess
{
    public class Coordinate
    {
        private class TransFormError : Exception { };

        public uint column;
        public uint row;

        public Coordinate(string code)
        {
            //if (code.Length != 2) throw new CoordinateError();
            code = code.ToLower();
            try
            {
                this.column = this.columnTransform(code.ToCharArray()[0]);
                this.row = this.rowTransform(code.ToCharArray()[1]);
            }
            catch (TransFormError)
            {
                try
                {
                    this.column = this.columnTransform(code.ToCharArray()[1]);
                    this.row = this.rowTransform(code.ToCharArray()[0]);
                }
                catch (TransFormError)
                {
                    throw new CoordinateError();
                }
            }
        }

        private uint columnTransform(Char letter){
            int op = letter - 97;
            if (op < 0) throw new TransFormError();
            return (uint) op;
        }

        private uint rowTransform(Char number){
            int op = 7 - (number - 49);
            if (op < 0) throw new TransFormError();
            return (uint)op;
        }

    }
}
