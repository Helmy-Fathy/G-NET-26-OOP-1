using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_26_OOP_1
{
    public struct SeatLocation
    {
        public char Row { get; }
        public int Number { get; }

        public SeatLocation(char row, int number)
        {
            Row = row;
            Number = number;
        }

        public override string ToString() 
        {
            return $"{Row}{Number}"; 
        }
    }
}
