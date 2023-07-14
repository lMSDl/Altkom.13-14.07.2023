using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Models
{
    public abstract class Shape2D : Shape1D
    {
        public int Height { get; }

        public Shape2D(int height, int width, string name) : base(width, name)
        {
            Height = height;
        }

        public override string ToString()
        {
            return base.ToString() + " i wysokości " + Height;
        }

        //metoda abstrakcyjna - ne posiada ciała i MUSI mieć implementację w klasach pochodnych
        //Jeśli klasa posiada metodę abstrakcyjną to sama musi być abstrakcyjna
        public abstract float GetArea();

    }
}
