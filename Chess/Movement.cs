using System;
using System.Collections.Generic;
using System.Text;

namespace Chess
{
    public class Movement
    {
        public Coordinate source;
        public Coordinate target;

        public Movement(String movement)
        {
            //if (movement.Length != 4) throw new MovementError();
            try
            {
                this.source = new Coordinate(movement.Substring(0, 2));
                this.target = new Coordinate(movement.Substring(2, 2));
            }
            catch (CoordinateError)
            {
                throw new MovementError();
            }
            catch (ArgumentOutOfRangeException)
            {
                throw new MovementError();
            }
        }
    }
}
