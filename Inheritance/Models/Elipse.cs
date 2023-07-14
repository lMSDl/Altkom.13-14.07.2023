using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Models
{
    internal class Elipse : Shape2D
    {
        public Elipse(int height, int width) : base(height, width, "Elipsa")
        {
        }

        public override float GetArea()
        {
            return (float)Math.PI * Width * Height;
        }

    }
}
