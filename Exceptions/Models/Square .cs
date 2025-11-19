using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions.Models
{
    internal class Square: Figure
    {
        private int _side;
        public Square(int side)
        {
             Side = side;
        }
        public int Side
        {
            get {                 
                return _side;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Side length must be greater than zero.");
                }
                _side = value;
            }

        }

        public override void CalcArea()
        {
            Console.WriteLine($"Fiqurun sahesi:{Side * Side}");
        }
    }
}
