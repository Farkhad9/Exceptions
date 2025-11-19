using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions.Models
{
    internal class Rectangular: Figure
    {
        private int _leight;
        private int _width;
        public int Width
        {
            get 
            {
                return _width;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Width length must be greater than zero.");
                }
                _width = value;
            }
        }
        public int Leight
        {
            get 
            {
            return _leight;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Leight length must be greater than zero.");
                }
                _leight = value;
            }
        }


        public Rectangular(int width,int length)
        {
            Width = width;
            Leight = length;
        }

        public override void CalcArea()
        {
            Console.WriteLine($"Fiqurun sahesi:{Width * Leight}");
        }
    }
}
