using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Models
{
    internal class Rectangle : Shape2D
    {
        public Rectangle(int height, int width) : base(height, width, "Prostokąt")
        {
        }

        public override float GetArea()
        {
            return Height * Width;
        }


    }
}
